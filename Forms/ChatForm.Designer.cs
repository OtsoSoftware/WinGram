namespace WinGram
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDowner = new System.Windows.Forms.Label();
            this.labelUpper = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actionButton = new System.Windows.Forms.Button();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.tabsFeatures = new System.Windows.Forms.TabControl();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowChat = new System.Windows.Forms.FlowLayoutPanel();
            this.tabsMessenger = new System.Windows.Forms.TabControl();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttAttach = new System.Windows.Forms.Button();
            this.buttEmoji = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttSend = new System.Windows.Forms.Button();
            this.tabGifs = new System.Windows.Forms.TabPage();
            this.tabStickers = new System.Windows.Forms.TabPage();
            this.tabCall = new System.Windows.Forms.TabPage();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.contextMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forMeOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forBothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMessageForAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.tabsFeatures.SuspendLayout();
            this.tabChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabsMessenger.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(391, 87);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelDowner);
            this.panel3.Controls.Add(this.labelUpper);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(79, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(229, 73);
            this.panel3.TabIndex = 3;
            // 
            // labelDowner
            // 
            this.labelDowner.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDowner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDowner.Location = new System.Drawing.Point(6, 48);
            this.labelDowner.Name = "labelDowner";
            this.labelDowner.Size = new System.Drawing.Size(217, 25);
            this.labelDowner.TabIndex = 5;
            this.labelDowner.Text = "last seen or member count";
            this.labelDowner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUpper
            // 
            this.labelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpper.Location = new System.Drawing.Point(6, 6);
            this.labelUpper.Name = "labelUpper";
            this.labelUpper.Size = new System.Drawing.Size(217, 42);
            this.labelUpper.TabIndex = 4;
            this.labelUpper.Text = "Buddy or Group Name";
            this.labelUpper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.actionButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(308, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 73);
            this.panel2.TabIndex = 2;
            // 
            // actionButton
            // 
            this.actionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.actionButton.Location = new System.Drawing.Point(0, 0);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(74, 34);
            this.actionButton.TabIndex = 1;
            this.actionButton.Text = "Actions...";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureAvatar.Location = new System.Drawing.Point(5, 5);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(74, 73);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 1;
            this.pictureAvatar.TabStop = false;
            this.pictureAvatar.Click += new System.EventHandler(this.pictureAvatar_Click);
            // 
            // tabsFeatures
            // 
            this.tabsFeatures.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabsFeatures.Controls.Add(this.tabChat);
            this.tabsFeatures.Controls.Add(this.tabCall);
            this.tabsFeatures.Controls.Add(this.tabMembers);
            this.tabsFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsFeatures.Location = new System.Drawing.Point(0, 87);
            this.tabsFeatures.Name = "tabsFeatures";
            this.tabsFeatures.SelectedIndex = 0;
            this.tabsFeatures.Size = new System.Drawing.Size(391, 551);
            this.tabsFeatures.TabIndex = 1;
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.splitContainer1);
            this.tabChat.Location = new System.Drawing.Point(4, 28);
            this.tabChat.Name = "tabChat";
            this.tabChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabChat.Size = new System.Drawing.Size(383, 519);
            this.tabChat.TabIndex = 0;
            this.tabChat.Text = "Chat";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowChat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabsMessenger);
            this.splitContainer1.Size = new System.Drawing.Size(377, 513);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowChat
            // 
            this.flowChat.AutoScroll = true;
            this.flowChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChat.Location = new System.Drawing.Point(0, 0);
            this.flowChat.Margin = new System.Windows.Forms.Padding(0);
            this.flowChat.Name = "flowChat";
            this.flowChat.Size = new System.Drawing.Size(377, 411);
            this.flowChat.TabIndex = 0;
            this.flowChat.WrapContents = false;
            this.flowChat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowChatScroll);
            this.flowChat.Resize += new System.EventHandler(this.flowChat_Resize);
            // 
            // tabsMessenger
            // 
            this.tabsMessenger.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabsMessenger.Controls.Add(this.tabMessage);
            this.tabsMessenger.Controls.Add(this.tabGifs);
            this.tabsMessenger.Controls.Add(this.tabStickers);
            this.tabsMessenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsMessenger.Location = new System.Drawing.Point(0, 0);
            this.tabsMessenger.Multiline = true;
            this.tabsMessenger.Name = "tabsMessenger";
            this.tabsMessenger.SelectedIndex = 0;
            this.tabsMessenger.Size = new System.Drawing.Size(377, 98);
            this.tabsMessenger.TabIndex = 3;
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.textMessage);
            this.tabMessage.Controls.Add(this.panel5);
            this.tabMessage.Controls.Add(this.panel4);
            this.tabMessage.Location = new System.Drawing.Point(4, 4);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Size = new System.Drawing.Size(369, 65);
            this.tabMessage.TabIndex = 3;
            this.tabMessage.Text = "Message";
            this.tabMessage.UseVisualStyleBackColor = true;
            // 
            // textMessage
            // 
            this.textMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMessage.Location = new System.Drawing.Point(33, 0);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(285, 65);
            this.textMessage.TabIndex = 5;
            this.textMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMessage_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttAttach);
            this.panel5.Controls.Add(this.buttEmoji);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(33, 65);
            this.panel5.TabIndex = 9;
            // 
            // buttAttach
            // 
            this.buttAttach.BackgroundImage = global::WinGram.Properties.Resources.folder_hand;
            this.buttAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttAttach.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttAttach.Location = new System.Drawing.Point(0, 32);
            this.buttAttach.Name = "buttAttach";
            this.buttAttach.Size = new System.Drawing.Size(33, 33);
            this.buttAttach.TabIndex = 10;
            this.buttAttach.UseVisualStyleBackColor = true;
            // 
            // buttEmoji
            // 
            this.buttEmoji.BackgroundImage = global::WinGram.Properties.Resources.smileyface;
            this.buttEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttEmoji.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttEmoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttEmoji.Location = new System.Drawing.Point(0, 0);
            this.buttEmoji.Name = "buttEmoji";
            this.buttEmoji.Size = new System.Drawing.Size(33, 32);
            this.buttEmoji.TabIndex = 9;
            this.buttEmoji.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttSend);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(318, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(51, 65);
            this.panel4.TabIndex = 6;
            // 
            // buttSend
            // 
            this.buttSend.BackgroundImage = global::WinGram.Properties.Resources.send_message;
            this.buttSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttSend.Location = new System.Drawing.Point(0, 0);
            this.buttSend.Name = "buttSend";
            this.buttSend.Size = new System.Drawing.Size(51, 65);
            this.buttSend.TabIndex = 4;
            this.buttSend.UseVisualStyleBackColor = true;
            this.buttSend.Click += new System.EventHandler(this.buttSend_Click);
            // 
            // tabGifs
            // 
            this.tabGifs.Location = new System.Drawing.Point(4, 4);
            this.tabGifs.Name = "tabGifs";
            this.tabGifs.Padding = new System.Windows.Forms.Padding(3);
            this.tabGifs.Size = new System.Drawing.Size(369, 65);
            this.tabGifs.TabIndex = 0;
            this.tabGifs.Text = "GIFs";
            this.tabGifs.UseVisualStyleBackColor = true;
            // 
            // tabStickers
            // 
            this.tabStickers.Location = new System.Drawing.Point(4, 4);
            this.tabStickers.Name = "tabStickers";
            this.tabStickers.Padding = new System.Windows.Forms.Padding(3);
            this.tabStickers.Size = new System.Drawing.Size(369, 65);
            this.tabStickers.TabIndex = 1;
            this.tabStickers.Text = "Stickers";
            this.tabStickers.UseVisualStyleBackColor = true;
            // 
            // tabCall
            // 
            this.tabCall.Location = new System.Drawing.Point(4, 28);
            this.tabCall.Name = "tabCall";
            this.tabCall.Padding = new System.Windows.Forms.Padding(3);
            this.tabCall.Size = new System.Drawing.Size(383, 519);
            this.tabCall.TabIndex = 1;
            this.tabCall.Text = "Call";
            this.tabCall.UseVisualStyleBackColor = true;
            // 
            // tabMembers
            // 
            this.tabMembers.Location = new System.Drawing.Point(4, 28);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Size = new System.Drawing.Size(383, 519);
            this.tabMembers.TabIndex = 2;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // contextMessage
            // 
            this.contextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMessage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMessageToolStripMenuItem,
            this.deleteMessageForAllToolStripMenuItem});
            this.contextMessage.Name = "contextMessage";
            this.contextMessage.Size = new System.Drawing.Size(210, 48);
            // 
            // deleteMessageToolStripMenuItem
            // 
            this.deleteMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forMeOnlyToolStripMenuItem,
            this.forBothToolStripMenuItem});
            this.deleteMessageToolStripMenuItem.Name = "deleteMessageToolStripMenuItem";
            this.deleteMessageToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteMessageToolStripMenuItem.Text = "Delete message";
            // 
            // forMeOnlyToolStripMenuItem
            // 
            this.forMeOnlyToolStripMenuItem.Name = "forMeOnlyToolStripMenuItem";
            this.forMeOnlyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.forMeOnlyToolStripMenuItem.Text = "For me only";
            // 
            // forBothToolStripMenuItem
            // 
            this.forBothToolStripMenuItem.Name = "forBothToolStripMenuItem";
            this.forBothToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.forBothToolStripMenuItem.Text = "For both";
            // 
            // deleteMessageForAllToolStripMenuItem
            // 
            this.deleteMessageForAllToolStripMenuItem.Name = "deleteMessageForAllToolStripMenuItem";
            this.deleteMessageForAllToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteMessageForAllToolStripMenuItem.Text = "Delete message for all";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 638);
            this.Controls.Add(this.tabsFeatures);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.tabsFeatures.ResumeLayout(false);
            this.tabChat.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabsMessenger.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.tabMessage.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.contextMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDowner;
        private System.Windows.Forms.Label labelUpper;
        private System.Windows.Forms.TabControl tabsFeatures;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.TabPage tabCall;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabsMessenger;
        private System.Windows.Forms.TabPage tabMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TabPage tabGifs;
        private System.Windows.Forms.TabPage tabStickers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttSend;
        private System.Windows.Forms.ContextMenuStrip contextMessage;
        private System.Windows.Forms.ToolStripMenuItem deleteMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forMeOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forBothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMessageForAllToolStripMenuItem;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttAttach;
        private System.Windows.Forms.Button buttEmoji;
        private System.Windows.Forms.FlowLayoutPanel flowChat;
    }
}