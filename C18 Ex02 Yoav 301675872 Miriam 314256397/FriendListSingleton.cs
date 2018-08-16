using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C18_Ex02
{
    public sealed class FriendListSingletone
    {
        private static FriendListSingletone s_Instance = null;
        private static object s_LockObj = new Object();
        private ArrayList m_friends;

        private FriendListSingletone(User i_userConnected)
        {
            this.m_friends = new ArrayList();
            foreach(User friend in i_userConnected.Friends)
            {
                this.m_friends.Add(friend as User);
            }
        }

        public static FriendListSingletone Instance(User i_userConnected)
        {
            if (s_Instance == null)
            {
                lock (s_LockObj)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new FriendListSingletone(i_userConnected);
                    }
                }
            }
            return s_Instance;
        }
    }
}
