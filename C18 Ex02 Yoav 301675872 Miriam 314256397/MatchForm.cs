﻿namespace C18_Ex02
{
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
    using FacebookWrapper.ObjectModel;

    public partial class MatchForm : Form
    {
        private User m_loggedInUser;
        private MatchUtils m_appLogic;

        public MatchForm(User i_loggedInUser)
        {
            this.m_loggedInUser = i_loggedInUser;
            InitializeComponent();
            this.m_appLogic = new MatchUtils();
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            string personalMessage = string.Empty;
            if (this.listBoxGroupA.SelectedItems.Count != 1 || this.listBoxGroupB.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose one person from each list", "Error!", MessageBoxButtons.OK);
                return;
            }

            if (((User)this.listBoxGroupA.Items[this.listBoxGroupA.SelectedIndex]).Name == ((User)this.listBoxGroupB.Items[this.listBoxGroupB.SelectedIndex]).Name)
            {
                MessageBox.Show("Cannot choose the same person twice", "Error!", MessageBoxButtons.OK);
                return;
            }

            personalMessage = getPersonalMessage();
            if (personalMessage == "Cancel")
            {
                this.Close();
                return;
            }

            User[] friendsToMatch = new User[] { this.listBoxGroupA.Items[this.listBoxGroupA.SelectedIndex] as User, this.listBoxGroupB.Items[this.listBoxGroupB.SelectedIndex] as User };
            if(friendsToMatch[0].Email == null || friendsToMatch[1].Email == null)
            {
                MessageBox.Show(this, "We are unable to send the match message at the time, due to Facebook persmission. The friend's emails are unavailable.", "error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.m_appLogic.generateMatchMessages(this.m_loggedInUser, friendsToMatch, personalMessage);
                    MessageBox.Show(this, "Match made!", "Matched");
                }
                catch
                {
                    MessageBox.Show(this, "Unable to make a match", "Error");
                }
            }

            this.Close();
        }

        private void listViewGroupA_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            genderSelectionChanged(this.listViewGroupA, this.listBoxGroupA, e);
        }

        private void genderSelectionChanged(ListView genderList, ListBox friendsList, ListViewItemSelectionChangedEventArgs genderChangedEvent)
        {
            string selectedGender = genderChangedEvent.Item.Text.ToLower();
            foreach (ListViewItem gender in genderList.Items)
            {
                if (gender != genderChangedEvent.Item)
                {
                    gender.ForeColor = Color.Gray;
                }
            }

            friendsList.Enabled = true;
            genderChangedEvent.Item.ForeColor = Color.Black;
            friendsList.Items.Clear();
            friendsList.DisplayMember = "Name";
            foreach (User friend in this.m_loggedInUser.Friends)
            {
                if (friend.Gender.ToString() == selectedGender)
                {
                    friendsList.Items.Add(friend);
                }
            }

            if (friendsList.Items.Count == 0)
            {
                friendsList.Enabled = false;
                friendsList.Items.Add(string.Format(@"No {0} friends", selectedGender.ToLower()));
            }
        }

        private void listViewGroupB_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            genderSelectionChanged(this.listViewGroupB, this.listBoxGroupB, e);
        }

        private string getPersonalMessage()
        {
            string message = string.Empty;
            MatchMessageForm matchMessage = new MatchMessageForm();
            matchMessage.ShowDialog();
            DialogResult matchResult = matchMessage.DialogResult;
            if(matchResult == DialogResult.Cancel)
            {
                return "Cancel";
            }

            return matchMessage.MatchMessage;
        }

        private void buttonMatch_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonMatch_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void MatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.listViewGroupA.SelectedItems.Clear();
            this.listViewGroupB.SelectedItems.Clear();
            this.listBoxGroupA.SelectedItems.Clear();
            this.listBoxGroupB.SelectedItems.Clear();
        }
    }
}
