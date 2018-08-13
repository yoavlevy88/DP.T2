﻿namespace C18_Ex02
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public partial class FormApp : Form
    {
        private LoginResult m_loginResult = null;
        private ArrayList m_friends;
        private FacebookFriendsUtils m_fbFriendsUtils;
        private MatchForm m_match;
        private string m_debugPath, m_path;
        private Thread m_mainThread;

        public FormApp()
        {
            InitializeComponent();
            this.m_friends = new ArrayList();
            this.m_fbFriendsUtils = new FacebookFriendsUtils();
            this.m_debugPath = Directory.GetCurrentDirectory();
            this.m_path = Path.GetFullPath(Path.Combine(this.m_debugPath, @"..\..\"));
            this.m_mainThread = Thread.CurrentThread;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            try
            {
                m_loginResult = FacebookService.Login("1765156366870770", "public_profile", "email", "user_friends", "user_posts", "user_birthday", "user_gender", "user_likes", "user_photos", "user_events");
            }
            catch (Exception loginException)
            {
                throw loginException;
            }

            MessageBox.Show(string.Format(@"Welcome {0}!", m_loginResult.LoggedInUser.FirstName), "Welcome", okButton);
            updateComponentsSettingsAfterLogin();
            new Thread(fetchFriends).Start();
            saveFriendListToFile();
            new Thread(fetchPosts).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchPages).Start();
        }

        private void fetchPages()
        {
            try
            {
                this.listBoxPages.Invoke(new Action(() => this.listBoxPages.Items.Clear()));
                this.listBoxPages.Invoke(new Action(() => this.listBoxPages.DisplayMember = "Name"));
                foreach (Page page in this.m_loginResult.LoggedInUser.LikedPages)
                {
                    this.listBoxPages.Invoke(new Action(() => this.listBoxPages.Items.Add(page)));
                }

                if (this.m_loginResult.LoggedInUser.LikedPages.Count == 0)
                {
                    this.listBoxPages.Invoke(new Action(() => this.listBoxPages.Items.Add("No pages to display!")));
                }
            }
            catch
            {
                this.listBoxPages.Invoke(new Action(() => this.listBoxPages.Items.Add("Due to Facebook permission issues, cannot display pages at the moment")));
            }
        }

        private void fetchEvents()
        {
            
            try
            {
                this.listBoxEvents.Invoke(new Action(() => this.listBoxEvents.Items.Clear()));
                this.listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
                foreach (Event userEvent in this.m_loginResult.LoggedInUser.Events)
                {
                    this.listBoxEvents.Invoke(new Action(() => this.listBoxEvents.Items.Add(userEvent)));
                }

                if (this.m_loginResult.LoggedInUser.Events.Count == 0)
                {
                    this.listBoxEvents.Invoke(new Action(() => this.listBoxEvents.Items.Add("No events to display!")));
                }
            }
            catch
            {
                this.listBoxEvents.Invoke(new Action(() => this.listBoxEvents.Items.Add("Due to Facebook permission issues, cannot display events at the moment")));
            }
        }

        private void fetchPosts()
        {
            try
            {
                this.listBoxPosts.Invoke(new Action(() => this.listBoxPosts.Items.Clear()));
                foreach (Post post in this.m_loginResult.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        this.listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    }
                    else if (post.Caption != null)
                    {
                        this.listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                        this.listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                    }
                }

                if (this.m_loginResult.LoggedInUser.Posts.Count == 0)
                {
                    this.listBoxPosts.Invoke(new Action(() => this.listBoxPages.Items.Add("No posts to display!")));
                }
            }
            catch
            {
                this.listBoxPosts.Invoke(new Action(() => this.listBoxPages.Items.Add("Due to Facebook permission issues, cannot display posts at the moment")));
            }
        }

        private void fetchFriends()
        {
            try
            {
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Clear()));
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.DisplayMember = "Name"));
                foreach (User friend in this.m_loginResult.LoggedInUser.Friends)
                {
                    if (Thread.CurrentThread != this.m_mainThread)
                    {
                        this.m_friends.Add(friend.Name);
                    }
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add(friend)));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }

                if (this.m_loginResult.LoggedInUser.Friends.Count == 0)
                {
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add("No friends to display!")));
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Enabled = false));
                }
            }
            catch
            {
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add("Due to Facebook permission issues, cannot display friends at the moment")));
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (this.textBoxStatus.TextLength == 0)
            {
                MessageBox.Show(this, "Cannot upload empty post!", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    Status statusToPost = this.m_loginResult.LoggedInUser.PostStatus(this.textBoxStatus.Text);
                    MessageBox.Show(this, "Statuse posted! :)", "Posted", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show(this, "Due to Facebook permission problems, we are unable to post this to your Facebook profile", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonMakeAMatch_Click(object sender, EventArgs e)
        {
            this.m_match.Select();
            this.m_match.ShowDialog();
        }

        private void saveFriendListToFile()
        {
            this.m_fbFriendsUtils.CurrentFriends = this.m_friends;
            this.m_fbFriendsUtils.createFirstFriendsFile(this.m_path + this.m_loginResult.LoggedInUser.Name + "fbFriends.xml");
        }

        private void buttonConnect_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonConnect_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonMakeAMatch_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonMakeAMatch_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonWhoUnfriendedMe_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonWhoUnfriendedMe_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonPost_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonPost_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonWhoUnfriendedMe_Click(object sender, EventArgs e)
        {
            string friendOrFriends = null;
            string hasOrHave = null;
            int unfriendedCount = 0;
            string unfriendedName = this.m_fbFriendsUtils.compareFriendLists(this.m_path + "fbFriends.xml", ref unfriendedCount);
            string message = null;

            if (unfriendedName == null)
            {
                message = "No one has unfriended you since your last check!";
            }
            else
            {
                if (unfriendedCount == 1)
                {
                    friendOrFriends = "friend";
                    hasOrHave = "has";
                }
                else
                {
                    friendOrFriends = "friends";
                    hasOrHave = "have";
                }

                message = string.Format(
                    @"Since your last check, {0} {1} {2} unfriended you:
{3}",
                    unfriendedCount,
                    friendOrFriends,
                    hasOrHave,
                    unfriendedName);
            }

            MessageBox.Show(this, message, "Who unfriended me?", MessageBoxButtons.OK);
            this.m_fbFriendsUtils.saveFriendListToFile(this.m_path + "fbFriends.xml");
        }

        private void updateComponentsSettingsAfterLogin()
        {
            this.pictureBoxProfile.AccessibleDescription = string.Format(@"{0}'s profile picture", m_loginResult.LoggedInUser.FirstName);
            this.pictureBoxProfile.Image = this.m_loginResult.LoggedInUser.ImageNormal;
            this.labelConnect.Visible = false;
            this.labelConnected.Font = new Font(this.labelConnected.Font, FontStyle.Bold);
            this.labelConnected.Text = string.Format(@"{0}'s Facebook profile", this.m_loginResult.LoggedInUser.Name);
            this.labelConnected.Visible = true;
            this.buttonConnect.Enabled = false;
            this.labelFriends.Enabled = true;
            this.labelPosts.Enabled = true;
            this.labelEvents.Enabled = true;
            this.labelPages.Enabled = true;
            this.labelPostStatus.Enabled = true;
            this.textBoxStatus.Enabled = true;
            this.buttonMakeAMatch.Enabled = true;
            this.buttonPost.Enabled = true;
            this.buttonWhoUnfriendedMe.Enabled = true;
            this.listBoxEvents.Enabled = true;
            this.listBoxFriends.Enabled = true;
            this.listBoxPages.Enabled = true;
            this.listBoxPosts.Enabled = true;
            this.m_match = new MatchForm(this.m_loginResult.LoggedInUser);
        }
    }
}
