namespace WinGram
{
    partial class MsgBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttNo = new System.Windows.Forms.Button();
            this.marginBetweenNoAndYes = new System.Windows.Forms.Label();
            this.buttYes = new System.Windows.Forms.Button();
            this.marginBetweenYesAndOk = new System.Windows.Forms.Label();
            this.buttOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttNo);
            this.panel1.Controls.Add(this.marginBetweenNoAndYes);
            this.panel1.Controls.Add(this.buttYes);
            this.panel1.Controls.Add(this.marginBetweenYesAndOk);
            this.panel1.Controls.Add(this.buttOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 9, 17, 9);
            this.panel1.Size = new System.Drawing.Size(352, 53);
            this.panel1.TabIndex = 0;
            // 
            // buttNo
            // 
            this.buttNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttNo.Location = new System.Drawing.Point(100, 9);
            this.buttNo.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttNo.Name = "buttNo";
            this.buttNo.Size = new System.Drawing.Size(75, 31);
            this.buttNo.TabIndex = 2;
            this.buttNo.Text = "No";
            this.buttNo.UseVisualStyleBackColor = true;
            this.buttNo.Click += new System.EventHandler(this.buttNo_Click);
            // 
            // marginBetweenNoAndYes
            // 
            this.marginBetweenNoAndYes.AutoSize = true;
            this.marginBetweenNoAndYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.marginBetweenNoAndYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marginBetweenNoAndYes.Location = new System.Drawing.Point(175, 9);
            this.marginBetweenNoAndYes.Margin = new System.Windows.Forms.Padding(0);
            this.marginBetweenNoAndYes.Name = "marginBetweenNoAndYes";
            this.marginBetweenNoAndYes.Size = new System.Drawing.Size(3, 4);
            this.marginBetweenNoAndYes.TabIndex = 3;
            this.marginBetweenNoAndYes.Text = " ";
            // 
            // buttYes
            // 
            this.buttYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttYes.Location = new System.Drawing.Point(178, 9);
            this.buttYes.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttYes.Name = "buttYes";
            this.buttYes.Size = new System.Drawing.Size(75, 31);
            this.buttYes.TabIndex = 1;
            this.buttYes.Text = "Yes";
            this.buttYes.UseVisualStyleBackColor = true;
            this.buttYes.Click += new System.EventHandler(this.buttYes_Click);
            // 
            // marginBetweenYesAndOk
            // 
            this.marginBetweenYesAndOk.AutoSize = true;
            this.marginBetweenYesAndOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.marginBetweenYesAndOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marginBetweenYesAndOk.Location = new System.Drawing.Point(253, 9);
            this.marginBetweenYesAndOk.Margin = new System.Windows.Forms.Padding(0);
            this.marginBetweenYesAndOk.Name = "marginBetweenYesAndOk";
            this.marginBetweenYesAndOk.Size = new System.Drawing.Size(3, 4);
            this.marginBetweenYesAndOk.TabIndex = 4;
            this.marginBetweenYesAndOk.Text = " ";
            // 
            // buttOK
            // 
            this.buttOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttOK.Location = new System.Drawing.Point(256, 9);
            this.buttOK.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttOK.Name = "buttOK";
            this.buttOK.Size = new System.Drawing.Size(75, 31);
            this.buttOK.TabIndex = 0;
            this.buttOK.Text = "OK";
            this.buttOK.UseVisualStyleBackColor = true;
            this.buttOK.Click += new System.EventHandler(this.buttOK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelMessage);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 125);
            this.panel2.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.labelMessage.Location = new System.Drawing.Point(73, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.labelMessage.Size = new System.Drawing.Size(275, 121);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "linkLabel1";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(12, 9, 0, 9);
            this.panel3.Size = new System.Drawing.Size(73, 121);
            this.panel3.TabIndex = 2;
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIcon.Image = global::WinGram.Properties.Resources.square_shadow_logo;
            this.picIcon.Location = new System.Drawing.Point(12, 9);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(61, 103);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 4;
            this.picIcon.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 178);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinGram";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttNo;
        private System.Windows.Forms.Button buttYes;
        private System.Windows.Forms.Button buttOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel labelMessage;
        private System.Windows.Forms.Label marginBetweenNoAndYes;
        private System.Windows.Forms.Label marginBetweenYesAndOk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picIcon;
    }
}