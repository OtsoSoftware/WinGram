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

namespace WinGram
{
	public partial class MessageControl : UserControl
	{
		bool hideAvatar;


		public MessageControl(object content, string senderName, string sentDateTime, bool hideAvatar = false, Image avatar = null, bool backgroundAccent = false)
		{
			this.hideAvatar = hideAvatar;

			InitializeComponent();

			labelName.Text = senderName;
			labelDateTime.Text = sentDateTime;
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