using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;
using WinGram.Classes;

namespace WinGram
{
	public partial class LoginForm : Form
    {
        int apiID = 0;
        string apiHash = null;

        public LoginForm()
		{
			InitializeComponent();
			this.WinStylize();

			Stor.CreateCrucialDirectories();
			ObtainCrucialConfig();

            WTelegram.Helpers.Log = (l, s) => Debug.WriteLine(l, s);
		}

		void ObtainCrucialConfig()
		{
			if (Program.IsPublish)
			{
				apiID = 0000000;
				apiHash = "abcdef1234567890abddef";
				return;
			}

            IniFile conf = new(Stor.configPath);
			try { apiID = int.Parse(conf.Read("api_id")); } catch { }
			try { apiHash = conf.Read("api_hash"); } catch { }
			try { textBoxPhone.Text = conf.Read("phone_number"); } catch { }

			if (apiID == 0 || apiHash == null)
			{
				groupApiId.Visible = true;
				groupApiHash.Visible = true;

				new MsgBox("Your api_id and/or api_hash are absent. Please obtain ones and enter below.", msgicon: MessageBoxIcon.Error, inevitable: true).ShowDialog();
				Process.Start("explorer.exe", "https://my.telegram.org/apps");
			}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Account.client?.Dispose();
			
		}

		void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(((LinkLabel)sender).Tag as string);
		}

		async void buttonLogin_Click(object sender, EventArgs e)
		{
			if (textBoxPhone.Text.Length < 8)
			{
				new MsgBox("You failed to enter a proper phone number.").ShowDialog();
				textBoxPhone.Focus();
				return;
			}



            labelBetween.Visible = true;
			labelBetween.Text = $"Connecting to Telegram servers...";

			//if entering manually, use the entered values:
			if (groupApiId.Visible && groupApiHash.Visible)
			{
				apiID = (int)numApiId.Value;
				apiHash = textApiHash.Text;
			}

			Account.client = new WTelegram.Client(apiID, apiHash, Path.GetFullPath(Path.Combine(Stor.configFolder, "wingram.session")));
			
			await DoLogin(textBoxPhone.Text);
		}

		private async Task DoLogin(string loginInfo)
		{
			string what = await Account.client.Login(loginInfo);
			if (what != null)
			{
				groupCode.Visible = true;
				labelBetween.Text = $"A {what.Replace('_', ' ')} is required";
				groupCode.Enabled = true;
				groupCode.Text = "Enter your " + what.Replace('_', ' ') + ':';
				textBoxCode.Text = "";
				textBoxCode.Focus();
				return;
			}
			new MsgBox($"You are now logged in as {Account.client.User}").ShowDialog();

			this.Hide();

			IniFile conf = new(Stor.configPath);
			if (!Program.IsPublish)
			{
                conf.Write("api_id", apiID.ToString());
                conf.Write("api_hash", apiHash);
            }
            conf.Write("phone_number", textBoxPhone.Text);

			new ChatsListForm().Show();

			Account.StartUpdatesManager();
			Cache.Start_MediaHomelessMan();
		}

		async void buttonSendCode_Click(object sender, EventArgs e)
		{
			groupCode.Enabled = false;
			await DoLogin(textBoxCode.Text);
		}

		void MainForm_Load(object sender, EventArgs e)
		{

		}

        void textBoxPhone_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxPhone.Text))
				buttonLogin.PerformClick();
        }
    }
}
