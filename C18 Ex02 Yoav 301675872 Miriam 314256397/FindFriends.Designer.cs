namespace C18_Ex02
{
    partial class FindFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindFriends));
            this.checkedListBoxGender = new System.Windows.Forms.CheckedListBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.listViewFilteredFriends = new System.Windows.Forms.ListView();
            this.numericUpDownFromAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownToAge = new System.Windows.Forms.NumericUpDown();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelFromAge = new System.Windows.Forms.Label();
            this.labelToAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToAge)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxGender
            // 
            this.checkedListBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.checkedListBoxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxGender.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxGender.FormattingEnabled = true;
            this.checkedListBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.checkedListBoxGender.Location = new System.Drawing.Point(106, 50);
            this.checkedListBoxGender.Name = "checkedListBoxGender";
            this.checkedListBoxGender.Size = new System.Drawing.Size(98, 30);
            this.checkedListBoxGender.TabIndex = 0;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Yahud",
            "Givat ada",
            "Givataim",
            "Petach tikva",
            "Tel aviv"});
            this.comboBoxCity.Location = new System.Drawing.Point(290, 50);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 3;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Transparent;
            this.buttonFind.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_background;
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(167, 161);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(94, 32);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Find friends!";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // listViewFilteredFriends
            // 
            this.listViewFilteredFriends.Location = new System.Drawing.Point(25, 224);
            this.listViewFilteredFriends.Name = "listViewFilteredFriends";
            this.listViewFilteredFriends.Size = new System.Drawing.Size(395, 195);
            this.listViewFilteredFriends.TabIndex = 5;
            this.listViewFilteredFriends.UseCompatibleStateImageBehavior = false;
            // 
            // numericUpDownFromAge
            // 
            this.numericUpDownFromAge.Location = new System.Drawing.Point(106, 98);
            this.numericUpDownFromAge.Name = "numericUpDownFromAge";
            this.numericUpDownFromAge.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownFromAge.TabIndex = 6;
            // 
            // numericUpDownToAge
            // 
            this.numericUpDownToAge.Location = new System.Drawing.Point(267, 98);
            this.numericUpDownToAge.Name = "numericUpDownToAge";
            this.numericUpDownToAge.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownToAge.TabIndex = 7;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.ForeColor = System.Drawing.Color.White;
            this.labelGender.Location = new System.Drawing.Point(22, 50);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 13);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Gender:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(246, 50);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "City:";
            // 
            // labelFromAge
            // 
            this.labelFromAge.AutoSize = true;
            this.labelFromAge.BackColor = System.Drawing.Color.Transparent;
            this.labelFromAge.ForeColor = System.Drawing.Color.White;
            this.labelFromAge.Location = new System.Drawing.Point(22, 98);
            this.labelFromAge.Name = "labelFromAge";
            this.labelFromAge.Size = new System.Drawing.Size(54, 13);
            this.labelFromAge.TabIndex = 10;
            this.labelFromAge.Text = "From age:";
            // 
            // labelToAge
            // 
            this.labelToAge.AutoSize = true;
            this.labelToAge.BackColor = System.Drawing.Color.Transparent;
            this.labelToAge.ForeColor = System.Drawing.Color.White;
            this.labelToAge.Location = new System.Drawing.Point(242, 100);
            this.labelToAge.Name = "labelToAge";
            this.labelToAge.Size = new System.Drawing.Size(19, 13);
            this.labelToAge.TabIndex = 11;
            this.labelToAge.Text = "to:";
            // 
            // FindFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_background;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.labelToAge);
            this.Controls.Add(this.labelFromAge);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.numericUpDownToAge);
            this.Controls.Add(this.numericUpDownFromAge);
            this.Controls.Add(this.listViewFilteredFriends);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.checkedListBoxGender);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindFriends";
            this.Text = "FindFriends";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxGender;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListView listViewFilteredFriends;
        private System.Windows.Forms.NumericUpDown numericUpDownFromAge;
        private System.Windows.Forms.NumericUpDown numericUpDownToAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelFromAge;
        private System.Windows.Forms.Label labelToAge;
    }
}