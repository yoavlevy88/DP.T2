using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C18_Ex02
{
    public partial class FindFriends : Form
    {
        //private FacebookObjectCollection<User> m_friendList;
        private FacebookFriendsUtils m_friends;

        public FindFriends(ArrayList i_friends)
        {
            InitializeComponent();
            this.m_friends = new FacebookFriendsUtils();
            this.m_friends.CurrentFriends = i_friends;    
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            ArrayList filteredFriends;
            int ageFrom = int.Parse(this.numericUpDownFromAge.Text);
            int ageTo = int.Parse(this.numericUpDownToAge.Text);
            int i;
            string city = this.comboBoxCity.Text;
            ArrayList gender = new ArrayList();
            for (i = 0; i < this.checkedListBoxGender.CheckedItems.Count; i++)
            {
                gender.Add((this.checkedListBoxGender.Items[this.checkedListBoxGender.CheckedIndices[i]]).ToString());
            }
            try
            {
                filteredFriends = this.m_friends.findByCategory(gender, city, ageFrom, ageTo);
                foreach (User friend in filteredFriends)
                {
                    this.listViewFilteredFriends.Items.Add(friend.Name);
                }
            }
            catch
            {
                MessageBox.Show(this, "Due to Facebook permisssion problems, we are unable to use this feature", "Error", MessageBoxButtons.OK);
            }

        }

        private void FindFriends_Shown(object sender, EventArgs e)
        {
            foreach(User friend in this.m_friends.CurrentFriends)
            {
                if(!this.comboBoxCity.Items.Equals(friend.Hometown))
                {
                    this.comboBoxCity.Items.Add(friend.Hometown);
                }
            }
        }
    }
}
