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
        Photo m_photo;

        public PicAdapter(User i_user)
        {
            this.m_user = i_user;
            this.m_photo = null;
        }

        public PicAdapter(Photo i_photo)
        {
            this.m_photo = i_photo;
            this.m_user = null;
        }

        public System.Drawing.Image ProfilePic { get { return this.m_user.ImageNormal; } }

        public System.Drawing.Image Photo { get { return this.m_photo.ImageNormal; } }
    }
}
