namespace C18_Ex02
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;

    public class FacebookFriendsUtils: IFinder
    {
        private ArrayList m_currentFriends;
        private bool m_firstCreated;
        public ArrayList FilteredFriends { get; set; }

        internal FacebookFriendsUtils()
        {
            m_firstCreated = true;
        }

        public ArrayList CurrentFriends
        {
            get
            {
                return this.m_currentFriends;
            }

            set
            {
                this.m_currentFriends = value;   
            }
        }

        public bool IsFirstCreated
        {
            get
            {
                return this.m_firstCreated;
            }

            set
            {
                this.m_firstCreated = value;
            }
        }

        private ArrayList getFriendsFromFile(string i_fileName)
        {
            FacebookFriendsUtils friendFromFile = null;
            if (File.Exists(i_fileName))
            {
                this.m_firstCreated = false;
                using (Stream stream = new FileStream(i_fileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer deserializer = new XmlSerializer(this.GetType());
                    friendFromFile = deserializer.Deserialize(stream) as FacebookFriendsUtils;
                    friendFromFile.m_firstCreated = false;
                }
            }

            return friendFromFile.CurrentFriends;
        }

        internal void saveFriendListToFile(string i_filePath)
        {
            using (Stream stream = new FileStream(i_filePath, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        internal void createFirstFriendsFile(string i_filePath)
        {
            if(!File.Exists(i_filePath))
            {
                saveFriendListToFile(i_filePath);
            }
        }

        internal string compareFriendLists(string i_filePath, ref int o_unfriendCount)
        {
            string unfriendedName = null;
            ArrayList friendsFromFile = getFriendsFromFile(i_filePath);
            if(this.m_currentFriends.Count < friendsFromFile.Count)
            {
                foreach(User friend in friendsFromFile)
                {
                    if(!this.m_currentFriends.Contains(friend))
                    {
                        unfriendedName += friend.Name;
                        unfriendedName += Environment.NewLine;
                        o_unfriendCount++;
                    }
                }
            }

            return unfriendedName;
        }

        internal User findFriend(string o_friendName)
        {
            foreach(User friend in this.m_currentFriends)
            {
                if (friend.Name == o_friendName)
                    return friend;
            }

            return null;
        }

        public ArrayList findByCity(string i_city)
        {
            ArrayList friendsByCity = new ArrayList();
            try
            {
                foreach (User friend in this.FilteredFriends)
                {
                    if (friend.Hometown.ToString().ToLower() == i_city.ToLower())
                    {
                        friendsByCity.Add(friend);
                    }
                }
                return friendsByCity;
            }
            catch(Exception cityException)
            {
                throw cityException;
            }
        }

        public ArrayList findByGender(ArrayList i_genders)
        {
            ArrayList friendsByGender = new ArrayList();

            try
            {
                foreach (string gender in i_genders)
                {
                    foreach (User friend in this.FilteredFriends)
                    {
                        if (friend.Gender.ToString().ToLower() == gender.ToLower())
                        {
                            friendsByGender.Add(friend);
                        }
                    }
                }
            }
            catch(Exception genderException)
            {
                throw genderException;
            }

            return friendsByGender;
        }

        public ArrayList findByAge(int i_from, int i_to)
        {
            ArrayList friendsByAge = new ArrayList();

            foreach (User friend in this.FilteredFriends)
            {
                try
                {
                    int friendAge = DateTime.Now.Year - DateTime.Parse(friend.Birthday).Year;

                    if (friendAge >= i_from && friendAge <= i_to)
                    {
                        friendsByAge.Add(friend);
                    }
                }
                catch(Exception ageException)
                {
                    throw ageException;
                }
            }

            return friendsByAge;
        }

        public ArrayList findByCategory(ArrayList i_genders, string i_city, int i_fromAge, int i_toAge)
        {
            try
            {
                this.FilteredFriends = this.m_currentFriends;
                this.FilteredFriends = findByAge(i_fromAge, i_toAge);
                this.FilteredFriends = findByCity(i_city);
                this.FilteredFriends = findByGender(i_genders);
                return this.FilteredFriends;
            }
            catch(Exception findFriendsException)
            {
                throw findFriendsException;
            }
        }
    }
}
