using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;
using WinGram.Properties;
using WTelegram;
using static WinGram.Account;
using static WinGram.Types;

namespace WinGram
{
	/// <summary>
	/// The main window of the app. Still needed to work a lot on this abomination.
	/// </summary>
	public partial class ChatsListForm: Form
	{
		public ChatsListForm()
		{
			InitializeComponent();
		}


		void Freeze(sbyte temperature)
		{
			if (temperature <= 0)
			{
				tabControl1.Enabled = false;
			}
			else if (temperature > 0)
			{
				tabControl1.Enabled = true;
			}
		}

		void ChatsListForm_Load(object sender, EventArgs e)
		{
			LoadListOfDialogs();
		}

		// Load Channels (already similar to your existing one)
		async void LoadListOfChannels()
		{
			if (Account.client.User == null)
			{
				MessageBox.Show("Who the hell are you? Log in first!");
				Close();
			}

			Messages_Dialogs chats = await Account.client.Messages_GetAllDialogs();

			DataTable chatlist = new();
			chatlist.Columns.Add("id", typeof(long));
			chatlist.Columns.Add("image", typeof(Image));
			chatlist.Columns.Add("name", typeof(string));
			chatlist.Columns.Add("new_messages_count", typeof(int));
			chatlist.Columns.Add("inputpeer", typeof(InputPeer));
			chatlist.Columns.Add("chattype", typeof(ChatType));

			foreach (ChatBase chat in chats.chats.Values)
			{
				if (chat is Channel channel && channel.IsActive && channel.IsChannel) // only public channels
				{
					Image avatar = null;
					try
					{
						if (channel.Photo != null)
						{
							using (Stream suka = new MemoryStream())
							{
								await Account.client.DownloadProfilePhotoAsync(channel, suka, false, false);
								suka.Position = 0;
								using (var img = Image.FromStream(suka))
								{
									avatar = new Bitmap(img);
								}
							}
						}
					}
					catch { }

					chatlist.Rows.Add(channel.ID, avatar, channel.Title, -1, channel.ToInputPeer(), ChatType.Channel);
				}
			}

			dgvChannels.DataSource = chatlist;
			((DataGridViewImageColumn)dgvChannels.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
			dgvChannels.Columns["image"].Width = 42;
			dgvChannels.Columns["new_messages_count"].Width = 32;
			dgvChannels.Columns["id"].Visible = false;
			dgvChannels.Columns["inputpeer"].Visible = false;
			dgvChannels.Columns["chattype"].Visible = false;
			dgvChannels.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		// Load Private Dialogs (users only)
		async void LoadListOfDialogs()
		{
			if (Account.client.User == null)
			{
				MessageBox.Show("Who the hell are you? Log in first!");
				Close();
			}

			Messages_Dialogs chats = await Account.client.Messages_GetAllDialogs();

			DataTable chatlist = new();
			chatlist.Columns.Add("id", typeof(long));
			chatlist.Columns.Add("image", typeof(Image));
			chatlist.Columns.Add("name", typeof(string));
			chatlist.Columns.Add("new_messages_count", typeof(int));
			chatlist.Columns.Add("inputpeer", typeof(InputPeer));
			chatlist.Columns.Add("user", typeof(User));
			chatlist.Columns.Add("chattype", typeof(ChatType));

			foreach (User user in chats.users.Values)
			{
				if (user.IsActive && user.ID != Account.client.User.ID && !user.IsBot)
				{
					Image avatar = Resources.person;
					try
					{
						avatar = await Cache.GrabAvatarAsync(user);
					}
					catch { }

					string username = user.MainUsername;
					chatlist.Rows.Add(user.ID, avatar, username, -1, user.ToInputPeer(), user, ChatType.Dialog);
				}
			}

			dgvDialogs.DataSource = chatlist;
			((DataGridViewImageColumn)dgvDialogs.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
			dgvDialogs.Columns["image"].Width = 42;
			dgvDialogs.Columns["new_messages_count"].Width = 32;
			dgvDialogs.Columns["id"].Visible = false;
			dgvDialogs.Columns["inputpeer"].Visible = false;
			dgvDialogs.Columns["user"].Visible = false;
			dgvDialogs.Columns["chattype"].Visible = false;
			dgvDialogs.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		// Load Bots (only)
		async void LoadListOfBots()
		{
			if (Account.client.User == null)
			{
				MessageBox.Show("Who the hell are you? Log in first!");
				Close();
			}

			Messages_Dialogs chats = await Account.client.Messages_GetAllDialogs();

			DataTable chatlist = new();
			chatlist.Columns.Add("id", typeof(long));
			chatlist.Columns.Add("image", typeof(Image));
			chatlist.Columns.Add("name", typeof(string));
			chatlist.Columns.Add("new_messages_count", typeof(int));
			chatlist.Columns.Add("inputpeer", typeof(InputPeer));
			chatlist.Columns.Add("chattype", typeof(ChatType));

			foreach (User user in chats.users.Values)
			{
				if (user.IsActive && user.ID != Account.client.User.ID && user.IsBot)
				{
					Image avatar = null;
					try
					{
						if (user.photo != null)
						{
							using (Stream suka = new MemoryStream())
							{
								await Account.client.DownloadProfilePhotoAsync(user, suka, false, false);
								suka.Position = 0;
								using (var img = Image.FromStream(suka))
								{
									avatar = new Bitmap(img);
								}
							}
						}
					}
					catch { }

					string username = user.MainUsername;
					chatlist.Rows.Add(user.ID, avatar, username, -1, user.ToInputPeer(), ChatType.Bot);
				}
			}

			dgvBots.DataSource = chatlist;
			((DataGridViewImageColumn)dgvBots.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
			dgvBots.Columns["image"].Width = 42;
			dgvBots.Columns["new_messages_count"].Width = 32;
			dgvBots.Columns["id"].Visible = false;
			dgvBots.Columns["inputpeer"].Visible = false;
			dgvBots.Columns["chattype"].Visible = false;
			dgvBots.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		// Load Groups only (both basic group and supergroup/megagroup)
		async void LoadListOfGroups()
		{
			if (Account.client.User == null)
			{
				MessageBox.Show("Who the hell are you? Log in first!");
				Close();
			}

			Messages_Dialogs chats = await Account.client.Messages_GetAllDialogs();

			DataTable chatlist = new();
			chatlist.Columns.Add("id", typeof(long));
			chatlist.Columns.Add("image", typeof(Image));
			chatlist.Columns.Add("name", typeof(string));
			chatlist.Columns.Add("new_messages_count", typeof(int));
			chatlist.Columns.Add("inputpeer", typeof(InputPeer));
			chatlist.Columns.Add("chattype", typeof(ChatType));

			foreach (ChatBase chat in chats.chats.Values)
			{
				if (chat is Channel channel && channel.IsActive && channel.IsGroup) // supergroup
				{
					Image avatar = null;
					try
					{
						if (channel.Photo != null)
						{
							using (Stream suka = new MemoryStream())
							{
								await Account.client.DownloadProfilePhotoAsync(channel, suka, false, false);
								suka.Position = 0;
								using (var img = Image.FromStream(suka))
								{
									avatar = new Bitmap(img);
								}
							}
						}
					}
					catch { }

					chatlist.Rows.Add(channel.ID, avatar, channel.Title, channel.ToInputPeer(), -1);
				}
				else if (chat is Chat basicGroup && basicGroup.IsActive)
				{
					Image avatar = null;
					try
					{
						if (basicGroup.Photo != null)
						{
							using (Stream suka = new MemoryStream())
							{
								await Account.client.DownloadProfilePhotoAsync(basicGroup, suka, false, false);
								suka.Position = 0;
								using (var img = Image.FromStream(suka))
								{
									avatar = new Bitmap(img);
								}
							}
						}
					}
					catch { }

					chatlist.Rows.Add(basicGroup.ID, avatar, basicGroup.Title, -1, chat.ToInputPeer(), ChatType.Group);
				}
			}

			dgvGroups.DataSource = chatlist;
			((DataGridViewImageColumn)dgvGroups.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
			dgvGroups.Columns["image"].Width = 42;
			dgvGroups.Columns["new_messages_count"].Width = 32;
			dgvGroups.Columns["id"].Visible = false;
			dgvGroups.Columns["inputpeer"].Visible = false;
			dgvGroups.Columns["chattype"].Visible = false;
			dgvGroups.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}



		void ChatsListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Freeze(-10);

			if (tabControl1.SelectedTab == tabChannels && dgvChannels.DataSource == null)
			{
				LoadListOfChannels();
			}
			else if (tabControl1.SelectedTab == tabDialogs && dgvDialogs.DataSource == null)
			{
				LoadListOfDialogs();
			}
			else if (tabControl1.SelectedTab == tabGroups && dgvGroups.DataSource == null)
			{
				LoadListOfGroups();
			}
			else if (tabControl1.SelectedTab == tabBots && dgvBots.DataSource == null)
			{
				LoadListOfBots();
			}

			Freeze(+5);
		}

		void ChatRowOpen(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = sender as DataGridView;

			if (dgv == dgvBots)
			{

			}
			else if (dgv == dgvDialogs || dgv == dgvGroups)
			{
                DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];

                Image avatar = (row.Cells["image"].Value.GetType() == typeof(System.DBNull) ? Properties.Resources.person : (Image)row.Cells["image"].Value);
                InputPeer inputPeer = (InputPeer)row.Cells["inputpeer"].Value;
                User user = (User)(row.Cells["user"].Value ?? null);
                ChatType chatType = (ChatType)row.Cells["chattype"].Value;

                new ChatForm(inputPeer, chatType, user, avatar).Show();
            }
			else if (dgv == dgvChannels)
			{

			}
		}

		void quitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Account.client.Dispose();
			Application.Exit();
			Environment.Exit(0);
		}
	}
}
