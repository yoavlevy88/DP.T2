namespace C18_Ex02
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
            this.textBoxWelcome = new System.Windows.Forms.TextBox();
            this.checkedListBoxFeatures = new System.Windows.Forms.CheckedListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWelcome
            // 
            this.textBoxWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.textBoxWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWelcome.ForeColor = System.Drawing.Color.White;
            this.textBoxWelcome.Location = new System.Drawing.Point(8, 25);
            this.textBoxWelcome.Multiline = true;
            this.textBoxWelcome.Name = "textBoxWelcome";
            this.textBoxWelcome.Size = new System.Drawing.Size(262, 67);
            this.textBoxWelcome.TabIndex = 0;
            this.textBoxWelcome.Text = "Welcome to the Facebook Desktop App! Please choose the features you\'d like to vie" +
    "w, and press Connect:";
            this.textBoxWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkedListBoxFeatures
            // 
            this.checkedListBoxFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.checkedListBoxFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxFeatures.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxFeatures.FormattingEnabled = true;
            this.checkedListBoxFeatures.Items.AddRange(new object[] {
            "Statuses",
            "Events",
            "Pages",
            "Friends"});
            this.checkedListBoxFeatures.Location = new System.Drawing.Point(8, 111);
            this.checkedListBoxFeatures.Name = "checkedListBoxFeatures";
            this.checkedListBoxFeatures.Size = new System.Drawing.Size(262, 135);
            this.checkedListBoxFeatures.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(91, 276);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(87, 31);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C18_Ex02_Yoav_301675872_Miriam_314256397.Properties.Resources.facebook_background;
            this.ClientSize = new System.Drawing.Size(282, 319);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.checkedListBoxFeatures);
            this.Controls.Add(this.textBoxWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWelcome;
        private System.Windows.Forms.CheckedListBox checkedListBoxFeatures;
        private System.Windows.Forms.Button buttonConnect;
    }
}