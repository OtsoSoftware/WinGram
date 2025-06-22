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

namespace WinGram
{
	public partial class MsgBox: Form
	{
		public MsgBox(string message, 
			string title = "WinGram", 
			MessageBoxButtons msgbuttons = MessageBoxButtons.OK,
			MessageBoxIcon msgicon = MessageBoxIcon.Information,
			bool inevitable = false,
			string buttOKtext = "OK",
			string buttYEStext = "Yes",
			string buttNOtext = "No")
		{
			InitializeComponent();
			this.WinStylize();

			labelMessage.Text = message;
			this.Text = title;
			buttOK.Text = buttOKtext;
			buttYes.Text = buttYEStext;
			buttNo.Text = buttNOtext;

			if (inevitable)
				ControlBox = false;
			
			if (msgbuttons == MessageBoxButtons.OK)
			{
				buttYes.Visible = false;
				buttNo.Visible = false;
			}
			else if (msgbuttons == MessageBoxButtons.YesNo)
			{
				buttOK.Visible = false;
			}
			else
			{

			}

			if (msgicon == MessageBoxIcon.Information)
			{
				picIcon.Image = Resources.information;
			}
			else if (msgicon == MessageBoxIcon.Question)
			{
                picIcon.Image = Resources.question;
            }
			else if (msgicon == MessageBoxIcon.Error)
			{
                picIcon.Image = Resources.asterisk;
            }
		}

		void buttOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
            Close();
        }

		void buttYes_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
            Close();
        }

		void buttNo_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			Close();
		}
	}
}
