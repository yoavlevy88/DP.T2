using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;

namespace C18_Ex02
{
    public partial class LoginForm : Form
    {
        private FormAppBuilder m_appBuilder;
        private FormApp m_app;

        public LoginForm()
        {
            InitializeComponent();
            m_appBuilder = new FormAppBuilder();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ArrayList settings = new ArrayList();
            LoginResult loginResult = null;
            try
            {
                loginResult = FacebookService.Login("1765156366870770", "public_profile", "email", "user_friends", "user_posts", "user_birthday", "user_gender", "user_likes", "user_photos", "user_events");
                for(int i=0; i<this.checkedListBoxFeatures.CheckedItems.Count; i++)
                {
                    switch(this.checkedListBoxFeatures.CheckedItems[i].ToString())
                    {
                        case "Events":
                            settings.Add(FormAppBuilder.eViewItems.Events);
                            break;
                        case "Friends":
                            settings.Add(FormAppBuilder.eViewItems.Friends);
                            break;
                        case "Pages":
                            settings.Add(FormAppBuilder.eViewItems.Pages);
                            break;
                        case "Statuses":
                            settings.Add(FormAppBuilder.eViewItems.Statuses);
                            break;
                    }
                }

                this.m_app = this.m_appBuilder.createFormApp(settings, loginResult);
                this.Visible = false;
                this.m_app.ShowDialog();
            }
            catch (Exception loginException)
            {
                throw loginException;
            }
        }
    }
}
