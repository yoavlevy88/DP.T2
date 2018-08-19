namespace C18_Ex02
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
        private FacebookFriendsUtils m_fbFriendsUtils;
        private MatchForm m_match;
        private string m_debugPath, m_path;
        private Thread m_mainThread;
        private PicAdapter m_userPicAdapter;
        FacebookObjectCollection<Status> statusesToDisplay;
        ArrayList m_friends;
        private ArrayList m_setting;
        private bool m_friendsFetched;

        public FormApp(ArrayList i_settings, LoginResult i_loginResult)
        {
            InitializeComponent();
            this.m_friendsFetched = false;
            this.m_loginResult = i_loginResult;
            this.m_setting = i_settings;
            this.m_friends = new ArrayList();
            this.m_fbFriendsUtils = new FacebookFriendsUtils();
            this.m_debugPath = Directory.GetCurrentDirectory();
            this.m_path = Path.GetFullPath(Path.Combine(this.m_debugPath, @"..\..\"));
            this.m_mainThread = Thread.CurrentThread;
            statusesToDisplay = new FacebookObjectCollection<Status>();
            this.Shown += new System.EventHandler(FormApp_Shown);
            //fetchBySettings(i_settings);
            this.m_userPicAdapter = new PicAdapter(this.m_loginResult.LoggedInUser);
            //this.pictureBoxProfile.AccessibleDescription = string.Format(@"{0}'s profile picture", m_loginResult.LoggedInUser.FirstName);
            this.pictureBoxProfile.Image = this.m_userPicAdapter.ProfilePic;
            //MessageBox.Show(string.Format(@"Welcome {0}!", m_loginResult.LoggedInUser.FirstName), "Welcome", MessageBoxButtons.OK);
            //updateComponentsSettingsAfterLogin();
            //new Thread(fetchFriends).Start();
            //// new Thread(fetchPosts).Start();
            //fetchPosts();
            //new Thread(fetchEvents).Start();
            //new Thread(fetchPages).Start();
        }

        internal void fetchBySettings(ArrayList i_settings)
        {
            foreach(FormAppBuilder.eViewItems item in i_settings)
            {
                switch(item)
                {
                    case FormAppBuilder.eViewItems.Events:
                        this.listBoxEvents.Enabled = true;
                        this.labelEvents.Enabled = true;
                        new Thread(fetchEvents).Start();
                        break;
                    case FormAppBuilder.eViewItems.Friends:
                        this.listBoxFriends.Enabled = true;
                        this.labelFriends.Enabled = true;
                        this.m_friendsFetched = true;
                        new Thread(fetchFriends).Start();
                        break;
                    case FormAppBuilder.eViewItems.Pages:
                        this.listBoxPages.Enabled = true;
                        this.labelPages.Enabled = true;
                        new Thread(fetchPages).Start();
                        break;
                    case FormAppBuilder.eViewItems.Statuses:
                        this.messageTextBox.Enabled = true;
                        this.createdTimeDateTimePicker.Enabled = true;
                        this.listBoxPosts.Enabled = true;
                        this.labelPosts.Enabled = true;
                        fetchPosts();
                        break;
                }
            }
        }

        public bool UseListBoxEvents
        {
            set
            {
                this.listBoxEvents.Enabled = value;
            }
        }

        public bool UseListBoxFriends
        {
            set
            {
                this.listBoxFriends.Enabled = value;
            }
        }

        public bool UseListBoxStatuses
        {
            set
            {
                this.listBoxPosts.Enabled = value;
            }
        }

        public bool UseListBoxPages
        {
            set
            {
                this.listBoxPages.Enabled = value;
            }
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
            //try
            //{
            //    this.listBoxPosts.Invoke(new Action(() => this.listBoxPosts.Items.Clear()));
            //    foreach (Post post in this.m_loginResult.LoggedInUser.Posts)
            //    {
            //        if (post.Message != null)
            //        {
            //            this.listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
            //        }
            //        else if (post.Caption != null)
            //        {
            //            this.listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
            //        }
            //        else
            //        {
            //            this.listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
            //        }
            //    }

            //    if (this.m_loginResult.LoggedInUser.Posts.Count == 0)
            //    {
            //        this.listBoxPosts.Invoke(new Action(() => this.listBoxPages.Items.Add("No posts to display!")));
            //    }
            //}
            //catch
            //{
            //    this.listBoxPosts.Invoke(new Action(() => this.listBoxPages.Items.Add("Due to Facebook permission issues, cannot display posts at the moment")));
            //}

            cleanEmpty();
            this.statusBindingSource.DataSource = statusesToDisplay;
        }

        private void cleanEmpty()
        {
            foreach (Status status in this.m_loginResult.LoggedInUser.Statuses)
            {
                if (status.Message != null)
                {
                    statusesToDisplay.Add(status);
                }
            }
        }

        private void fetchFriends()
        {
            try
            {
                //this.m_friendList = //FriendListSingletone.Instance(this.m_loginResult.LoggedInUser);
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Clear()));
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.DisplayMember = "Name"));
                foreach (User friend in this.m_loginResult.LoggedInUser.Friends)
                {
                    if (Thread.CurrentThread != this.m_mainThread)
                    {
                        this.m_friends.Add(friend);
                    }
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add(friend)));
                    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                }

                if (this.m_loginResult.LoggedInUser.Friends.Count == 0)
                {
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add("No friends to display!")));
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Enabled = false));
                }
                saveFriendListToFile();
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
            if(!this.m_friendsFetched)
            {
                fetchFriends();
                this.m_friendsFetched = true;
            }
            //this.m_match.Select();
            this.m_match = new MatchForm(this.m_loginResult.LoggedInUser);
            this.m_match.ShowDialog();
        }

        private void saveFriendListToFile()
        {
            this.m_fbFriendsUtils.CurrentFriends = this.m_friends;
            this.m_fbFriendsUtils.createFirstFriendsFile(this.m_path + "fbFriends.xml");
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
            if (!this.m_friendsFetched)
            {
                fetchFriends();
                this.m_friendsFetched = true;
            }
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

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friendSelected = this.listBoxFriends.SelectedItem as User;
            PicAdapter friendPic = new PicAdapter(friendSelected);
            this.pictureBoxFriendProfile.Image = friendPic.ProfilePic;
            this.pictureBoxFriendProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void updateComponentsSettingsAfterLogin()
        {
            this.labelConnect.Visible = false;
            this.labelConnected.Font = new Font(this.labelConnected.Font, FontStyle.Bold);
            this.labelConnected.Text = string.Format(@"{0}'s Facebook profile", this.m_loginResult.LoggedInUser.Name);
            this.labelConnected.Visible = true;
            //this.buttonConnect.Enabled = false;
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
        }

        private void messageTextBox_Leave(object sender, EventArgs e)
        {
            //(listBoxPosts.SelectedItem as Status).Message = messageTextBox.Text;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBoxPosts.SelectedItem != null)
            //{
            //    Status selectedItem = listBoxPosts.SelectedItem as Status;
            //    messageTextBox.Text = selectedItem.Message;
            //    createdTimeDateTimePicker.Value = selectedItem.CreatedTime.Value;
            //}
        }

        private void buttonFindFriends_Click(object sender, EventArgs e)
        {
            if (!this.m_friendsFetched)
            {
                fetchFriends();
                this.m_friendsFetched = true;
            }
            FindFriends findForm = new FindFriends(this.m_friends);
            findForm.ShowDialog();
        }

        private void buttonFindFriends_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonFindFriends_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void FormApp_Shown(Object sender, EventArgs e)
        {
            fetchBySettings(this.m_setting);
        }
    }
}
