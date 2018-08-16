namespace C18_Ex02
{
    public partial class MatchForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Male");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Female");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Male");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Female");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchForm));
            this.listViewGroupA = new System.Windows.Forms.ListView();
            this.listViewGroupB = new System.Windows.Forms.ListView();
            this.listBoxGroupA = new System.Windows.Forms.ListBox();
            this.listBoxGroupB = new System.Windows.Forms.ListBox();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.labelGroupA = new System.Windows.Forms.Label();
            this.labelGroupB = new System.Windows.Forms.Label();
            this.labelGroupAGender = new System.Windows.Forms.Label();
            this.labelGroupBGender = new System.Windows.Forms.Label();
            this.pictureBoxFriendA = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriendB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendB)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewGroupA
            // 
            this.listViewGroupA.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewGroupA.Location = new System.Drawing.Point(15, 24);
            this.listViewGroupA.Name = "listViewGroupA";
            this.listViewGroupA.Size = new System.Drawing.Size(102, 28);
            this.listViewGroupA.TabIndex = 0;
            this.listViewGroupA.Text = "Select filter";
            this.listViewGroupA.UseCompatibleStateImageBehavior = false;
            this.listViewGroupA.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewGroupA_ItemSelectionChanged);
            // 
            // listViewGroupB
            // 
            this.listViewGroupB.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listViewGroupB.Location = new System.Drawing.Point(233, 24);
            this.listViewGroupB.Name = "listViewGroupB";
            this.listViewGroupB.Size = new System.Drawing.Size(102, 28);
            this.listViewGroupB.TabIndex = 1;
            this.listViewGroupB.Text = "Select filter";
            this.listViewGroupB.TileSize = new System.Drawing.Size(50, 28);
            this.listViewGroupB.UseCompatibleStateImageBehavior = false;
            this.listViewGroupB.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewGroupB_ItemSelectionChanged);
            // 
            // listBoxGroupA
            // 
            this.listBoxGroupA.FormattingEnabled = true;
            this.listBoxGroupA.Location = new System.Drawing.Point(15, 80);
            this.listBoxGroupA.Name = "listBoxGroupA";
            this.listBoxGroupA.Size = new System.Drawing.Size(102, 173);
            this.listBoxGroupA.TabIndex = 2;
            this.listBoxGroupA.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupA_SelectedIndexChanged);
            // 
            // listBoxGroupB
            // 
            this.listBoxGroupB.FormattingEnabled = true;
            this.listBoxGroupB.Location = new System.Drawing.Point(233, 80);
            this.listBoxGroupB.Name = "listBoxGroupB";
            this.listBoxGroupB.Size = new System.Drawing.Size(102, 173);
            this.listBoxGroupB.TabIndex = 3;
            this.listBoxGroupB.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupB_SelectedIndexChanged);
            // 
            // buttonMatch
            // 
            this.buttonMatch.Image = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.match_jpg;
            this.buttonMatch.Location = new System.Drawing.Point(143, 379);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(62, 22);
            this.buttonMatch.TabIndex = 4;
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            this.buttonMatch.MouseEnter += new System.EventHandler(this.buttonMatch_MouseEnter);
            this.buttonMatch.MouseLeave += new System.EventHandler(this.buttonMatch_MouseLeave);
            // 
            // labelGroupA
            // 
            this.labelGroupA.AutoSize = true;
            this.labelGroupA.BackColor = System.Drawing.Color.Transparent;
            this.labelGroupA.ForeColor = System.Drawing.Color.White;
            this.labelGroupA.Location = new System.Drawing.Point(12, 64);
            this.labelGroupA.Name = "labelGroupA";
            this.labelGroupA.Size = new System.Drawing.Size(78, 13);
            this.labelGroupA.TabIndex = 5;
            this.labelGroupA.Text = "Select a friend:";
            // 
            // labelGroupB
            // 
            this.labelGroupB.AutoSize = true;
            this.labelGroupB.BackColor = System.Drawing.Color.Transparent;
            this.labelGroupB.ForeColor = System.Drawing.Color.White;
            this.labelGroupB.Location = new System.Drawing.Point(230, 64);
            this.labelGroupB.Name = "labelGroupB";
            this.labelGroupB.Size = new System.Drawing.Size(78, 13);
            this.labelGroupB.TabIndex = 6;
            this.labelGroupB.Text = "Select a friend:";
            // 
            // labelGroupAGender
            // 
            this.labelGroupAGender.AutoSize = true;
            this.labelGroupAGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGroupAGender.ForeColor = System.Drawing.Color.White;
            this.labelGroupAGender.Location = new System.Drawing.Point(12, 8);
            this.labelGroupAGender.Name = "labelGroupAGender";
            this.labelGroupAGender.Size = new System.Drawing.Size(76, 13);
            this.labelGroupAGender.TabIndex = 7;
            this.labelGroupAGender.Text = "Select gender:";
            // 
            // labelGroupBGender
            // 
            this.labelGroupBGender.AutoSize = true;
            this.labelGroupBGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGroupBGender.ForeColor = System.Drawing.Color.White;
            this.labelGroupBGender.Location = new System.Drawing.Point(230, 8);
            this.labelGroupBGender.Name = "labelGroupBGender";
            this.labelGroupBGender.Size = new System.Drawing.Size(76, 13);
            this.labelGroupBGender.TabIndex = 8;
            this.labelGroupBGender.Text = "Select gender:";
            // 
            // pictureBoxFriendA
            // 
            this.pictureBoxFriendA.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_blank_photo_11;
            this.pictureBoxFriendA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriendA.Location = new System.Drawing.Point(15, 259);
            this.pictureBoxFriendA.Name = "pictureBoxFriendA";
            this.pictureBoxFriendA.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxFriendA.TabIndex = 9;
            this.pictureBoxFriendA.TabStop = false;
            // 
            // pictureBoxFriendB
            // 
            this.pictureBoxFriendB.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_blank_photo_11;
            this.pictureBoxFriendB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriendB.Location = new System.Drawing.Point(233, 259);
            this.pictureBoxFriendB.Name = "pictureBoxFriendB";
            this.pictureBoxFriendB.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxFriendB.TabIndex = 10;
            this.pictureBoxFriendB.TabStop = false;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_background;
            this.ClientSize = new System.Drawing.Size(356, 412);
            this.Controls.Add(this.pictureBoxFriendB);
            this.Controls.Add(this.pictureBoxFriendA);
            this.Controls.Add(this.labelGroupBGender);
            this.Controls.Add(this.labelGroupAGender);
            this.Controls.Add(this.labelGroupB);
            this.Controls.Add(this.labelGroupA);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.listBoxGroupB);
            this.Controls.Add(this.listBoxGroupA);
            this.Controls.Add(this.listViewGroupB);
            this.Controls.Add(this.listViewGroupA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Make a match";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGroupA;
        private System.Windows.Forms.ListView listViewGroupB;
        private System.Windows.Forms.ListBox listBoxGroupA;
        private System.Windows.Forms.ListBox listBoxGroupB;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Label labelGroupA;
        private System.Windows.Forms.Label labelGroupB;
        private System.Windows.Forms.Label labelGroupAGender;
        private System.Windows.Forms.Label labelGroupBGender;
        private System.Windows.Forms.PictureBox pictureBoxFriendA;
        private System.Windows.Forms.PictureBox pictureBoxFriendB;
    }
}