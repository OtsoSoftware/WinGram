namespace WinGram
{
    partial class ChatsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatsListForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDialogs = new System.Windows.Forms.TabPage();
            this.dgvDialogs = new System.Windows.Forms.DataGridView();
            this.tabChannels = new System.Windows.Forms.TabPage();
            this.dgvChannels = new System.Windows.Forms.DataGridView();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.tabBots = new System.Windows.Forms.TabPage();
            this.dgvBots = new System.Windows.Forms.DataGridView();
            this.tabFavourites = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huynyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justForMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forBothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabDialogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialogs)).BeginInit();
            this.tabChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChannels)).BeginInit();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tabBots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBots)).BeginInit();
            this.tabFavourites.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabDialogs);
            this.tabControl1.Controls.Add(this.tabChannels);
            this.tabControl1.Controls.Add(this.tabGroups);
            this.tabControl1.Controls.Add(this.tabBots);
            this.tabControl1.Controls.Add(this.tabFavourites);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 559);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDialogs
            // 
            this.tabDialogs.Controls.Add(this.dgvDialogs);
            this.tabDialogs.Location = new System.Drawing.Point(29, 4);
            this.tabDialogs.Name = "tabDialogs";
            this.tabDialogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogs.Size = new System.Drawing.Size(409, 551);
            this.tabDialogs.TabIndex = 0;
            this.tabDialogs.Text = "  Dialogs";
            this.tabDialogs.UseVisualStyleBackColor = true;
            // 
            // dgvDialogs
            // 
            this.dgvDialogs.AllowUserToAddRows = false;
            this.dgvDialogs.AllowUserToDeleteRows = false;
            this.dgvDialogs.AllowUserToResizeColumns = false;
            this.dgvDialogs.AllowUserToResizeRows = false;
            this.dgvDialogs.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDialogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDialogs.ColumnHeadersVisible = false;
            this.dgvDialogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDialogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDialogs.Location = new System.Drawing.Point(3, 3);
            this.dgvDialogs.Name = "dgvDialogs";
            this.dgvDialogs.RowHeadersVisible = false;
            this.dgvDialogs.RowHeadersWidth = 51;
            this.dgvDialogs.RowTemplate.Height = 42;
            this.dgvDialogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDialogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDialogs.Size = new System.Drawing.Size(403, 545);
            this.dgvDialogs.TabIndex = 17;
            this.dgvDialogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChatRowOpen);
            // 
            // tabChannels
            // 
            this.tabChannels.Controls.Add(this.dgvChannels);
            this.tabChannels.Location = new System.Drawing.Point(29, 4);
            this.tabChannels.Name = "tabChannels";
            this.tabChannels.Padding = new System.Windows.Forms.Padding(3);
            this.tabChannels.Size = new System.Drawing.Size(409, 551);
            this.tabChannels.TabIndex = 1;
            this.tabChannels.Text = "  Channels";
            this.tabChannels.UseVisualStyleBackColor = true;
            // 
            // dgvChannels
            // 
            this.dgvChannels.AllowUserToAddRows = false;
            this.dgvChannels.AllowUserToDeleteRows = false;
            this.dgvChannels.AllowUserToResizeColumns = false;
            this.dgvChannels.AllowUserToResizeRows = false;
            this.dgvChannels.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvChannels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChannels.ColumnHeadersVisible = false;
            this.dgvChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChannels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChannels.Location = new System.Drawing.Point(3, 3);
            this.dgvChannels.Name = "dgvChannels";
            this.dgvChannels.RowHeadersVisible = false;
            this.dgvChannels.RowHeadersWidth = 51;
            this.dgvChannels.RowTemplate.Height = 42;
            this.dgvChannels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChannels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChannels.Size = new System.Drawing.Size(403, 545);
            this.dgvChannels.TabIndex = 18;
            this.dgvChannels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChatRowOpen);
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.dgvGroups);
            this.tabGroups.Location = new System.Drawing.Point(29, 4);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(409, 551);
            this.tabGroups.TabIndex = 4;
            this.tabGroups.Text = "  Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeColumns = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.ColumnHeadersVisible = false;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(0, 0);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.RowHeadersWidth = 51;
            this.dgvGroups.RowTemplate.Height = 42;
            this.dgvGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(409, 551);
            this.dgvGroups.TabIndex = 18;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChatRowOpen);
            // 
            // tabBots
            // 
            this.tabBots.Controls.Add(this.dgvBots);
            this.tabBots.Location = new System.Drawing.Point(29, 4);
            this.tabBots.Name = "tabBots";
            this.tabBots.Size = new System.Drawing.Size(409, 551);
            this.tabBots.TabIndex = 5;
            this.tabBots.Text = " Bots";
            this.tabBots.UseVisualStyleBackColor = true;
            // 
            // dgvBots
            // 
            this.dgvBots.AllowUserToAddRows = false;
            this.dgvBots.AllowUserToDeleteRows = false;
            this.dgvBots.AllowUserToResizeColumns = false;
            this.dgvBots.AllowUserToResizeRows = false;
            this.dgvBots.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBots.ColumnHeadersVisible = false;
            this.dgvBots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBots.Location = new System.Drawing.Point(0, 0);
            this.dgvBots.Name = "dgvBots";
            this.dgvBots.RowHeadersVisible = false;
            this.dgvBots.RowHeadersWidth = 51;
            this.dgvBots.RowTemplate.Height = 42;
            this.dgvBots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBots.Size = new System.Drawing.Size(409, 551);
            this.dgvBots.TabIndex = 19;
            this.dgvBots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChatRowOpen);
            // 
            // tabFavourites
            // 
            this.tabFavourites.Controls.Add(this.label1);
            this.tabFavourites.Location = new System.Drawing.Point(29, 4);
            this.tabFavourites.Name = "tabFavourites";
            this.tabFavourites.Size = new System.Drawing.Size(409, 551);
            this.tabFavourites.TabIndex = 2;
            this.tabFavourites.Text = "  Favourites";
            this.tabFavourites.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NotImplemented";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.accountToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 26);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(42, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(74, 22);
            this.accountToolStripMenuItem1.Text = "Account";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 22);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuChat
            // 
            this.menuChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuChat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuChat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huynyaToolStripMenuItem,
            this.deleteChannelToolStripMenuItem,
            this.leaveGroupToolStripMenuItem});
            this.menuChat.Name = "menuChat";
            this.menuChat.Size = new System.Drawing.Size(165, 70);
            this.menuChat.Text = "Chat options";
            // 
            // huynyaToolStripMenuItem
            // 
            this.huynyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justForMeToolStripMenuItem,
            this.forBothToolStripMenuItem});
            this.huynyaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.huynyaToolStripMenuItem.Name = "huynyaToolStripMenuItem";
            this.huynyaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.huynyaToolStripMenuItem.Text = "Delete chat";
            // 
            // justForMeToolStripMenuItem
            // 
            this.justForMeToolStripMenuItem.Name = "justForMeToolStripMenuItem";
            this.justForMeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.justForMeToolStripMenuItem.Text = "Just for me";
            // 
            // forBothToolStripMenuItem
            // 
            this.forBothToolStripMenuItem.Name = "forBothToolStripMenuItem";
            this.forBothToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.forBothToolStripMenuItem.Text = "For both";
            // 
            // deleteChannelToolStripMenuItem
            // 
            this.deleteChannelToolStripMenuItem.Name = "deleteChannelToolStripMenuItem";
            this.deleteChannelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteChannelToolStripMenuItem.Text = "Delete channel";
            // 
            // leaveGroupToolStripMenuItem
            // 
            this.leaveGroupToolStripMenuItem.Name = "leaveGroupToolStripMenuItem";
            this.leaveGroupToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.leaveGroupToolStripMenuItem.Text = "Leave Group";
            // 
            // ChatsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 585);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "ChatsListForm";
            this.Text = "Telegram Messenger for Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatsListForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatsListForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDialogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialogs)).EndInit();
            this.tabChannels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChannels)).EndInit();
            this.tabGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.tabBots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBots)).EndInit();
            this.tabFavourites.ResumeLayout(false);
            this.tabFavourites.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuChat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDialogs;
        private System.Windows.Forms.TabPage tabChannels;
        private System.Windows.Forms.TabPage tabFavourites;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDialogs;
        private System.Windows.Forms.DataGridView dgvChannels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.TabPage tabBots;
        private System.Windows.Forms.DataGridView dgvBots;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuChat;
        private System.Windows.Forms.ToolStripMenuItem huynyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justForMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forBothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
    }
}