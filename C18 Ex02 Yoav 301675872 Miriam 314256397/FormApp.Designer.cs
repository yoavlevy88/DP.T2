﻿namespace C18_Ex02
{
    public partial class FormApp
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelConnect = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.labelConnected = new System.Windows.Forms.Label();
            this.buttonMakeAMatch = new System.Windows.Forms.Button();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonWhoUnfriendedMe = new System.Windows.Forms.Button();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(55, 43);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(55, 68);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(323, 42);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(429, 20);
            this.textBoxStatus.TabIndex = 4;
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.BackColor = System.Drawing.Color.Transparent;
            this.labelConnect.ForeColor = System.Drawing.Color.White;
            this.labelConnect.Location = new System.Drawing.Point(94, 31);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(144, 13);
            this.labelConnect.TabIndex = 7;
            this.labelConnect.Text = "Please connect to Facebook";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelPostStatus.Enabled = false;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostStatus.ForeColor = System.Drawing.Color.White;
            this.labelPostStatus.Location = new System.Drawing.Point(320, 20);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(155, 13);
            this.labelPostStatus.TabIndex = 8;
            this.labelPostStatus.Text = "What\'s on your mind right now?";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Enabled = false;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.Location = new System.Drawing.Point(469, 87);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(156, 212);
            this.listBoxFriends.TabIndex = 9;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Enabled = false;
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(466, 72);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(44, 13);
            this.labelFriends.TabIndex = 10;
            this.labelFriends.Text = "Friends:";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.BackColor = System.Drawing.Color.Transparent;
            this.labelPosts.Enabled = false;
            this.labelPosts.ForeColor = System.Drawing.Color.White;
            this.labelPosts.Location = new System.Drawing.Point(27, 320);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(36, 13);
            this.labelPosts.TabIndex = 12;
            this.labelPosts.Text = "Posts:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.statusBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.Enabled = false;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.Location = new System.Drawing.Point(26, 342);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(156, 212);
            this.listBoxPosts.TabIndex = 11;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Status);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.BackColor = System.Drawing.Color.Transparent;
            this.labelEvents.Enabled = false;
            this.labelEvents.ForeColor = System.Drawing.Color.White;
            this.labelEvents.Location = new System.Drawing.Point(291, 66);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(43, 13);
            this.labelEvents.TabIndex = 14;
            this.labelEvents.Text = "Events:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Enabled = false;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.Location = new System.Drawing.Point(294, 87);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(156, 212);
            this.listBoxEvents.TabIndex = 13;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.BackColor = System.Drawing.Color.Transparent;
            this.labelPages.Enabled = false;
            this.labelPages.ForeColor = System.Drawing.Color.White;
            this.labelPages.Location = new System.Drawing.Point(118, 66);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(40, 13);
            this.labelPages.TabIndex = 16;
            this.labelPages.Text = "Pages:";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.HorizontalScrollbar = true;
            this.listBoxPages.Location = new System.Drawing.Point(121, 87);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(156, 212);
            this.listBoxPages.TabIndex = 15;
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Location = new System.Drawing.Point(88, 25);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(0, 13);
            this.labelConnected.TabIndex = 19;
            this.labelConnected.Visible = false;
            // 
            // buttonMakeAMatch
            // 
            this.buttonMakeAMatch.Image = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.match_jpg;
            this.buttonMakeAMatch.Location = new System.Drawing.Point(15, 164);
            this.buttonMakeAMatch.Name = "buttonMakeAMatch";
            this.buttonMakeAMatch.Size = new System.Drawing.Size(77, 27);
            this.buttonMakeAMatch.TabIndex = 17;
            this.buttonMakeAMatch.UseVisualStyleBackColor = true;
            this.buttonMakeAMatch.Click += new System.EventHandler(this.buttonMakeAMatch_Click);
            this.buttonMakeAMatch.MouseEnter += new System.EventHandler(this.buttonMakeAMatch_MouseEnter);
            this.buttonMakeAMatch.MouseLeave += new System.EventHandler(this.buttonMakeAMatch_MouseLeave);
            // 
            // buttonPost
            // 
            this.buttonPost.Image = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.FB_Post;
            this.buttonPost.Location = new System.Drawing.Point(767, 36);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(61, 31);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            this.buttonPost.MouseEnter += new System.EventHandler(this.buttonPost_MouseEnter);
            this.buttonPost.MouseLeave += new System.EventHandler(this.buttonPost_MouseLeave);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Image = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.FB_Connect;
            this.buttonConnect.Location = new System.Drawing.Point(12, 101);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(81, 27);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Visible = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseEnter += new System.EventHandler(this.buttonConnect_MouseEnter);
            this.buttonConnect.MouseLeave += new System.EventHandler(this.buttonConnect_MouseLeave);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_blank_photo_11;
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(80, 73);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonWhoUnfriendedMe
            // 
            this.buttonWhoUnfriendedMe.Image = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.unfriend;
            this.buttonWhoUnfriendedMe.Location = new System.Drawing.Point(26, 216);
            this.buttonWhoUnfriendedMe.Name = "buttonWhoUnfriendedMe";
            this.buttonWhoUnfriendedMe.Size = new System.Drawing.Size(46, 48);
            this.buttonWhoUnfriendedMe.TabIndex = 21;
            this.buttonWhoUnfriendedMe.UseVisualStyleBackColor = true;
            this.buttonWhoUnfriendedMe.Click += new System.EventHandler(this.buttonWhoUnfriendedMe_Click);
            this.buttonWhoUnfriendedMe.MouseEnter += new System.EventHandler(this.buttonWhoUnfriendedMe_MouseEnter);
            this.buttonWhoUnfriendedMe.MouseLeave += new System.EventHandler(this.buttonWhoUnfriendedMe_MouseLeave);
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_blank_photo_11;
            this.pictureBoxFriendProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(642, 118);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(162, 162);
            this.pictureBoxFriendProfile.TabIndex = 23;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBoxStatus);
            this.panel2.Controls.Add(createdTimeLabel);
            this.panel2.Controls.Add(this.createdTimeDateTimePicker);
            this.panel2.Controls.Add(messageLabel);
            this.panel2.Controls.Add(this.messageTextBox);
            this.panel2.Location = new System.Drawing.Point(211, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 211);
            this.panel2.TabIndex = 25;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStatus.Location = new System.Drawing.Point(378, 40);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(171, 150);
            this.pictureBoxStatus.TabIndex = 4;
            this.pictureBoxStatus.TabStop = false;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.statusBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(134, 39);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(134, 65);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 125);
            this.messageTextBox.TabIndex = 3;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_background;
            this.ClientSize = new System.Drawing.Size(859, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxFriendProfile);
            this.Controls.Add(this.buttonWhoUnfriendedMe);
            this.Controls.Add(this.labelConnected);
            this.Controls.Add(this.buttonMakeAMatch);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.pictureBoxProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApp";
            this.Text = "Facebook Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonMakeAMatch;
        private System.Windows.Forms.Label labelConnected;
        private System.Windows.Forms.Button buttonWhoUnfriendedMe;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
    }
}