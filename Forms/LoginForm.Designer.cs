
namespace WinGram
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonSendCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupCode = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBetween = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.groupApiHash = new System.Windows.Forms.GroupBox();
            this.textApiHash = new System.Windows.Forms.TextBox();
            this.groupApiId = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numApiId = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupCode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupApiHash.SuspendLayout();
            this.groupApiId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApiId)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogin.Location = new System.Drawing.Point(229, 23);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(153, 25);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Connect and Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.Location = new System.Drawing.Point(8, 23);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(161, 24);
            this.textBoxCode.TabIndex = 9;
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSendCode.Location = new System.Drawing.Point(201, 23);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(181, 25);
            this.buttonSendCode.TabIndex = 10;
            this.buttonSendCode.Text = "Verify";
            this.buttonSendCode.UseVisualStyleBackColor = true;
            this.buttonSendCode.Click += new System.EventHandler(this.buttonSendCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(390, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your phone number:";
            // 
            // groupCode
            // 
            this.groupCode.Controls.Add(this.buttonSendCode);
            this.groupCode.Controls.Add(this.textBoxCode);
            this.groupCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCode.Enabled = false;
            this.groupCode.Location = new System.Drawing.Point(14, 236);
            this.groupCode.Name = "groupCode";
            this.groupCode.Padding = new System.Windows.Forms.Padding(8);
            this.groupCode.Size = new System.Drawing.Size(390, 56);
            this.groupCode.TabIndex = 13;
            this.groupCode.TabStop = false;
            this.groupCode.Text = "Verification code:";
            this.groupCode.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupCode);
            this.panel1.Controls.Add(this.labelBetween);
            this.panel1.Controls.Add(this.groupApiHash);
            this.panel1.Controls.Add(this.groupApiId);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14);
            this.panel1.Size = new System.Drawing.Size(418, 367);
            this.panel1.TabIndex = 14;
            // 
            // labelBetween
            // 
            this.labelBetween.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBetween.Location = new System.Drawing.Point(14, 182);
            this.labelBetween.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.labelBetween.Name = "labelBetween";
            this.labelBetween.Size = new System.Drawing.Size(390, 54);
            this.labelBetween.TabIndex = 14;
            this.labelBetween.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBetween.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.label2.Size = new System.Drawing.Size(418, 117);
            this.label2.TabIndex = 15;
            this.label2.Text = "Please log in to chat, call and explore using WinGram, an unofficial Telegram Mes" +
    "senger client for Windows (R) operating system.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPhone.Location = new System.Drawing.Point(8, 23);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(221, 22);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.Text = "+";
            this.textBoxPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPhone_KeyUp);
            // 
            // groupApiHash
            // 
            this.groupApiHash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupApiHash.Controls.Add(this.textApiHash);
            this.groupApiHash.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupApiHash.Location = new System.Drawing.Point(14, 126);
            this.groupApiHash.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.groupApiHash.Name = "groupApiHash";
            this.groupApiHash.Padding = new System.Windows.Forms.Padding(8);
            this.groupApiHash.Size = new System.Drawing.Size(390, 56);
            this.groupApiHash.TabIndex = 15;
            this.groupApiHash.TabStop = false;
            this.groupApiHash.Text = "Your API HASH:";
            this.groupApiHash.Visible = false;
            // 
            // textApiHash
            // 
            this.textApiHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textApiHash.Location = new System.Drawing.Point(8, 23);
            this.textApiHash.MaxLength = 64;
            this.textApiHash.Name = "textApiHash";
            this.textApiHash.Size = new System.Drawing.Size(374, 22);
            this.textApiHash.TabIndex = 8;
            this.textApiHash.Text = "abcd1234ef5678abcd";
            // 
            // groupApiId
            // 
            this.groupApiId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupApiId.Controls.Add(this.numApiId);
            this.groupApiId.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupApiId.Location = new System.Drawing.Point(14, 70);
            this.groupApiId.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.groupApiId.Name = "groupApiId";
            this.groupApiId.Padding = new System.Windows.Forms.Padding(8);
            this.groupApiId.Size = new System.Drawing.Size(390, 56);
            this.groupApiId.TabIndex = 16;
            this.groupApiId.TabStop = false;
            this.groupApiId.Text = "Your API ID:";
            this.groupApiId.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinGram.Properties.Resources.wide_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(24);
            this.pictureBox1.Size = new System.Drawing.Size(418, 143);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // numApiId
            // 
            this.numApiId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numApiId.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numApiId.InterceptArrowKeys = false;
            this.numApiId.Location = new System.Drawing.Point(8, 23);
            this.numApiId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numApiId.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numApiId.Name = "numApiId";
            this.numApiId.Size = new System.Drawing.Size(374, 22);
            this.numApiId.TabIndex = 0;
            this.numApiId.Value = new decimal(new int[] {
            12345678,
            0,
            0,
            0});
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 565);
            this.Name = "LoginForm";
            this.Text = "WinGram - the unofficial Telegram Messenger for Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupCode.ResumeLayout(false);
            this.groupCode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupApiHash.ResumeLayout(false);
            this.groupApiHash.PerformLayout();
            this.groupApiId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApiId)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.Button buttonSendCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBetween;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.GroupBox groupApiHash;
        private System.Windows.Forms.TextBox textApiHash;
        private System.Windows.Forms.GroupBox groupApiId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numApiId;
    }
}

