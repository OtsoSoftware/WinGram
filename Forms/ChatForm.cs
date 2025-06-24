using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinGram.Properties;
using TL;
using WTelegram;
using static WinGram.Account;
using Message = TL.Message;
using static WinGram.Types;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WinGram
{
	/// <summary>
	/// This is a crucial yet bullshit class. 
	/// Will be probably expanded to support Groups, Bots and Channels, too.
	/// At the moment it is a piece of crap that loads messages in a random order and fucks the UI.
	/// </summary>
	public partial class ChatForm : Form
	{
		InputPeer inputPeer;
		ChatType chatType;
		Image avatar;
		private int lastMessageId = 0;
		private bool isLoading = false;
		private const int MESSAGES_PER_PAGE = 30;
		User user;
		private bool isInitialLoad = true;

		public ChatForm(InputPeer inputPeer, ChatType chatType, User user = null, Image avatar = null)
		{
			this.inputPeer = inputPeer;
			this.chatType = chatType;
			this.avatar = avatar ?? Resources.person;
			this.user = user;

			InitializeComponent();

			Account.OnUpdateReceived += ManageUpdates;

			pictureAvatar.Image = avatar;
			flowChat.VerticalScroll.Enabled = true;
		}

		Task ManageUpdates(Update update)
		{
			if (update is UpdateNewMessage)
			{
				Message message = (update as UpdateNewMessage).message as Message;

				if (message.Peer.ID != inputPeer.ID)
				{
					return Task.CompletedTask;
				}

				AddMessageToGrid(message);
				if (this.Focused)
				{
					client.ReadHistory(inputPeer, message.id);
				}
				else
				{
					Notifier.PlaySound();

					//wait for focus and only then mark new message as read:
					_ = Task.Run(async () =>
					{
						while (true)
						{
							if (!this.IsHandleCreated) return;

							bool isFocused = (bool)this.Invoke(() => this.ContainsFocus);
							if (isFocused)
							{
								client.ReadHistory(inputPeer, message.id);
								return;
							}
							await Task.Delay(60);
						}
					});
				}
			}
			else if (update is UpdatePhoneCall)
			{
				PhoneCall phoneCall = (update as UpdatePhoneCall).phone_call as PhoneCall;
			}

			return Task.CompletedTask;
		}

		async void FlowChatScroll(object sender, ScrollEventArgs e)
		{
			if (e.ScrollOrientation == ScrollOrientation.VerticalScroll && e.NewValue == 0 && !isLoading)
			{
				await LoadOlderMessages();
			}
		}

		async Task LoadOlderMessages()
		{
			if (isLoading) return;
			isLoading = true;

			try
			{
				// save current scroll position
				Control firstVisibleControl = flowChat.Controls.Count > 0 ? flowChat.Controls[0] : null;

				Messages_MessagesBase messages = await Account.client.Messages_GetHistory(inputPeer, lastMessageId);
				if (messages.Messages.Length > 0)
				{
					foreach (MessageBase msg in messages.Messages.Reverse())
					{
						if (msg is TL.Message message)
							AddMessageToGrid(message, true);
					}
					lastMessageId = messages.Messages[^1].ID;

					// restore scroll position after adding older messages
					if (firstVisibleControl != null)
					{
						flowChat.ScrollControlIntoView(firstVisibleControl);
					}
				}
			}
			finally
			{
				isLoading = false;
			}
		}

		async void AddMessageToGrid(Message message, bool insertAtTop = false, bool scrollToBottom = false)
		{
			if (message == null)
				return;

			//determine the message sender:
			long from_id;
			if (message.from_id != null)
				from_id = message.From.ID;
			else
				from_id = inputPeer.ID;

			//determine message content and its type:
			object content = "Undefined content";
			if (message.message.Length > 0)
			{
				content = message.message;
			}
			if (message.media != null)
			{
				MessageMedia mm = message.media;

				if (mm is MessageMediaPhoto { photo: Photo photo })
				{
					content = await Cache.GrabPhotoAsync(photo);
				}
				else if (mm is MessageMediaDocument { document: Document document })
				{
					content = document;
				}
			}
			
			MessageControl mess = new(
				content: content,
				senderName: from_id == client.UserId ? "Me" : user.MainUsername,
				sentDateTime: message.Date.ToString(Types.dateTimeFormat),
				hideAvatar: chatType == ChatType.Dialog ? true : false,
				avatar: from_id == client.UserId ? MyAvatar : avatar,
				backgroundAccent: from_id == client.UserId && chatType == ChatType.Dialog ? true : false)
				{
					Width = flowChat.ClientSize.Width - flowChat.Padding.Horizontal,
					Tag = message.ID
				};

			if (insertAtTop)
			{
				flowChat.Controls.Add(mess);
				flowChat.Controls.SetChildIndex(mess, 0);
			}
			else
			{
				flowChat.Controls.Add(mess);
				if (scrollToBottom || isInitialLoad)
				{
					flowChat.ScrollControlIntoView(mess);
				}
			}
		}

		async void RefreshChat()
		{
			if (isLoading) return;
			isLoading = true;

			try
			{
				flowChat.Controls.Clear();
				Messages_MessagesBase messages = await Account.client.Messages_GetHistory(inputPeer, 0, default, 0, MESSAGES_PER_PAGE);
				foreach (MessageBase msg in messages.Messages.Reverse())
				{
					AddMessageToGrid(msg as Message);
				}

				if (messages.Messages.Length > 0)
				{
					lastMessageId = messages.Messages[^1].ID;
				}
			}
			finally
			{
				isLoading = false;
				isInitialLoad = false;
				// ensure we scroll to bottom after initial load:
				if (flowChat.Controls.Count > 0)
				{
					flowChat.ScrollControlIntoView(flowChat.Controls[flowChat.Controls.Count - 1]);
				}
			}
		}

		/// <summary>
		/// In a dialog - gets info about buddy, in a group - also gets members list
		/// </summary>
		void RefreshPeerData()
		{
			try
			{
				if (chatType == ChatType.Dialog)
				{
					tabsFeatures.TabPages.Remove(tabMembers);
					labelDowner.Text = $"last seen {user.LastSeenAgo} ago";
					labelUpper.Text = $"{user.first_name} {user.last_name} [@{user.MainUsername}]";
				}
				else if (chatType == ChatType.Group)
				{
					tabsFeatures.TabPages.Remove(tabMembers);
					Messages_ChatFull chatInfo = Account.client.GetFullChat(inputPeer).Result;
					labelDowner.Text = $"{chatInfo.full_chat.ParticipantsCount} members";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "could not refresh peer data");
			}
		}

		void ChatForm_Load(object sender, EventArgs e)
		{
			RefreshPeerData();

			if (chatType == ChatType.Dialog)
			{
				tabsFeatures.TabPages.Remove(tabMembers);
			}
			else if (chatType == ChatType.Group)
			{
				tabsFeatures.TabPages.Remove(tabMembers);
			}

			RefreshChat();
			flowChat_Resize(flowChat, null);
		}

		void pictureAvatar_Click(object sender, EventArgs e)
		{
			//new ProfileForm().Show();
		}

		async void buttSend_Click(object sender, EventArgs e)
		{
			if (textMessage.Text.Length > 0)
			{
				string msg = Markdown.Escape(textMessage.Text);
				MessageEntity[] entities = Account.client.MarkdownToEntities(ref msg);
				Message sent_msg = await Account.client.SendMessageAsync(inputPeer, msg, entities: entities);
				AddMessageToGrid(sent_msg, false, true);
				textMessage.Text = "";
			}
		}

		void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Account.OnUpdateReceived -= ManageUpdates;
		}

		private void actionButton_Click(object sender, EventArgs e)
		{

		}

		void textMessage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && e.Modifiers != Keys.Shift)
				buttSend_Click(null, null);
		}

		void flowChat_Resize(object sender, EventArgs e)
		{
			foreach (Control c in flowChat.Controls)
			{
				int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
				int safePadding = flowChat.Padding.Left + flowChat.Padding.Right;
				int fudgeFactor = 0;
				c.Width = flowChat.ClientSize.Width - safePadding - scrollBarWidth - fudgeFactor;
			}
		}
	}
}