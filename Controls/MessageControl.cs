using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TL;
using System.Threading;
using Microsoft.VisualBasic.Logging;

namespace WinGram
{
	public partial class MessageControl : UserControl
	{
		bool hideAvatar;
		Document document;
		DateTime sentDateTime;

		public MessageControl(object content, string senderName, DateTime sentDateTime, bool hideAvatar = false, Image avatar = null, bool backgroundAccent = false)
		{
			this.hideAvatar = hideAvatar;

			InitializeComponent();

			labelName.Text = senderName;
			labelDateTime.Text = sentDateTime.ToString(Types.dateTimeFormat);
			pictureAvatar.Image = avatar;
			
			if (hideAvatar)
				panelLefter.Visible = false;
				

			panelBackground.BackColor = backgroundAccent ? SystemColors.ControlDark : SystemColors.ControlLight;
			richMessage.BackColor = backgroundAccent ? SystemColors.ControlDark : SystemColors.ControlLight;

			if (content is Image image)
			{
				richMessage.Visible = false;
				pictureContent.Image = image;

				// control height to fit image:
				this.Height = panelUpper.Height + image.Height / 3;
			}
			else if (content is Document document)
			{
				buttDocumentGo.Text = "Download if not exist: " + document.Filename;
                this.document = document;
                panelDocument.Visible = true;
				this.Height = 180;
			}
			else if (content is string text)
			{
				pictureContent.Visible = false;
				richMessage.Text = text;

				// calculate required height for the text:
				using (Graphics g = richMessage.CreateGraphics())
				{
					SizeF textSize = g.MeasureString(text, richMessage.Font,
						richMessage.Width - SystemInformation.VerticalScrollBarWidth);

					// Total message height = upper panel + text height + margin
					this.Height = panelUpper.Height + (int)Math.Ceiling(textSize.Height) + 10;
				}
			}
		}


		public void UpdateRelativeTime()
		{
			TimeSpan span = DateTime.Now - sentDateTime;

			string text;

			if (span.TotalSeconds < 60)
			{
				int secs = (int)span.TotalSeconds;
				text = $"{secs} sec ago";
			}
			else if (span.TotalMinutes < 60)
			{
				int mins = (int)span.TotalMinutes;
				text = $"{mins} min ago";
			}
			else if (span.TotalHours < 23)
			{
				int hrs = (int)span.TotalHours;
				text = $"{hrs} hours ago";
			}
			else
			{
				// fallback to absolute date/time format
				text = sentDateTime.ToString(Types.dateTimeFormat);
			}

			// Don't trigger unnecessary redraws
			if (labelDateTime.Text != text)
				labelDateTime.Text = text;
		}


		/// <summary>
		/// Downloads and (or) opens the document.
		/// </summary>
		async void DocumentGo(object sender, EventArgs e)
        {
            await Cache.GrabFileAsync(document);
        }

        void pictureContent_Click(object sender, EventArgs e)
		{
			new PicViewForm(pictureContent.Image).ShowDialog();
		}

		/// <summary>
		/// Even if avatars are hidden, let's show them when the window very wide
		/// </summary>
		void MessageControl_Resize(object sender, EventArgs e)
		{
			if (hideAvatar)
				panelLefter.Visible = this.Width > 555;
		}

		void richMessage_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			// if does not always work, put the following before LinkCLicked event:
			// richMessage.Focus();
			string subj = e.LinkText;
			Process.Start("explorer.exe", subj); //don't ask me why we open links via the explorer.exe
		}
	}
}