﻿namespace WinGram
{
    partial class MessageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelDocument = new System.Windows.Forms.Panel();
            this.buttDocumentGo = new System.Windows.Forms.Button();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panelLefter = new System.Windows.Forms.Panel();
            this.pictureContent = new System.Windows.Forms.PictureBox();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.picDocIcon = new System.Windows.Forms.PictureBox();
            this.richMessage = new WinGram.PassthroughRichTextBox();
            this.panelBackground.SuspendLayout();
            this.panelDocument.SuspendLayout();
            this.panelUpper.SuspendLayout();
            this.panelLefter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDocIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBackground.Controls.Add(this.panelDocument);
            this.panelBackground.Controls.Add(this.pictureContent);
            this.panelBackground.Controls.Add(this.richMessage);
            this.panelBackground.Controls.Add(this.panelUpper);
            this.panelBackground.Controls.Add(this.panelLefter);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(322, 135);
            this.panelBackground.TabIndex = 2;
            // 
            // panelDocument
            // 
            this.panelDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDocument.Controls.Add(this.picDocIcon);
            this.panelDocument.Controls.Add(this.buttDocumentGo);
            this.panelDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDocument.Location = new System.Drawing.Point(55, 25);
            this.panelDocument.Name = "panelDocument";
            this.panelDocument.Padding = new System.Windows.Forms.Padding(10);
            this.panelDocument.Size = new System.Drawing.Size(263, 106);
            this.panelDocument.TabIndex = 7;
            this.panelDocument.Visible = false;
            // 
            // buttDocumentGo
            // 
            this.buttDocumentGo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttDocumentGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttDocumentGo.Location = new System.Drawing.Point(10, 10);
            this.buttDocumentGo.Name = "buttDocumentGo";
            this.buttDocumentGo.Size = new System.Drawing.Size(239, 51);
            this.buttDocumentGo.TabIndex = 6;
            this.buttDocumentGo.Text = "Download rferhcb hebc hecbew ch chewchwe cwehc ";
            this.buttDocumentGo.UseVisualStyleBackColor = true;
            this.buttDocumentGo.Click += new System.EventHandler(this.DocumentGo);
            // 
            // panelUpper
            // 
            this.panelUpper.Controls.Add(this.labelName);
            this.panelUpper.Controls.Add(this.labelDateTime);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(55, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(263, 25);
            this.panelUpper.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelName.Size = new System.Drawing.Size(154, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(154, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(109, 25);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "label2";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLefter
            // 
            this.panelLefter.Controls.Add(this.pictureAvatar);
            this.panelLefter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLefter.Location = new System.Drawing.Point(0, 0);
            this.panelLefter.Name = "panelLefter";
            this.panelLefter.Size = new System.Drawing.Size(55, 131);
            this.panelLefter.TabIndex = 2;
            // 
            // pictureContent
            // 
            this.pictureContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureContent.Location = new System.Drawing.Point(55, 25);
            this.pictureContent.Name = "pictureContent";
            this.pictureContent.Size = new System.Drawing.Size(263, 106);
            this.pictureContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureContent.TabIndex = 5;
            this.pictureContent.TabStop = false;
            this.pictureContent.Click += new System.EventHandler(this.pictureContent_Click);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(55, 55);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 0;
            this.pictureAvatar.TabStop = false;
            // 
            // picDocIcon
            // 
            this.picDocIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picDocIcon.Image = global::WinGram.Properties.Resources.file_document;
            this.picDocIcon.Location = new System.Drawing.Point(10, 61);
            this.picDocIcon.Name = "picDocIcon";
            this.picDocIcon.Size = new System.Drawing.Size(43, 31);
            this.picDocIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDocIcon.TabIndex = 7;
            this.picDocIcon.TabStop = false;
            // 
            // richMessage
            // 
            this.richMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richMessage.Location = new System.Drawing.Point(55, 25);
            this.richMessage.Name = "richMessage";
            this.richMessage.ReadOnly = true;
            this.richMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richMessage.Size = new System.Drawing.Size(263, 106);
            this.richMessage.TabIndex = 4;
            this.richMessage.Text = "";
            this.richMessage.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richMessage_LinkClicked);
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(322, 135);
            this.Resize += new System.EventHandler(this.MessageControl_Resize);
            this.panelBackground.ResumeLayout(false);
            this.panelDocument.ResumeLayout(false);
            this.panelUpper.ResumeLayout(false);
            this.panelLefter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDocIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelLefter;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Label labelDateTime;
        private PassthroughRichTextBox richMessage;
        private System.Windows.Forms.PictureBox pictureContent;
        private System.Windows.Forms.Button buttDocumentGo;
        private System.Windows.Forms.Panel panelDocument;
        private System.Windows.Forms.PictureBox picDocIcon;
    }
}
