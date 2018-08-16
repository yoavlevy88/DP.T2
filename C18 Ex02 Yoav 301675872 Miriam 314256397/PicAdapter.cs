using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
namespace C18_Ex02
{
    internal class PicAdapter: IPicture
    {
        User m_user;

        public PicAdapter(User i_user)
        {
            this.m_user = i_user;
        }

        public System.Drawing.Image ProfilePic { get { return this.m_user.ImageNormal; } }
    }
}
