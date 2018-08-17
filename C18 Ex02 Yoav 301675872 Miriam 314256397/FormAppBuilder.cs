using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C18_Ex02
{
    internal class FormAppBuilder
    {

        internal enum eViewItems
        {
            Friends, Statuses, Events, Pages
        }

        internal FormApp createFormApp(ArrayList i_settings, LoginResult i_loginResult)
        {
            FormApp app = new FormApp(i_settings, i_loginResult);
            //foreach (eViewItems setting in i_settings)
            //{
            //    switch (setting)
            //    {
            //        case eViewItems.Events:
            //            app.UseListBoxEvents = true;
            //            break;
            //        case eViewItems.Friends:
            //            app.UseListBoxFriends = true;
            //            break;
            //        case eViewItems.Pages:
            //            app.UseListBoxPages = true;
            //            break;
            //        case eViewItems.Statuses:
            //            app.UseListBoxStatuses = true;
            //            break;
            //    }
            //}
            //app.fetchBySettings(i_settings);
            return app;
        }
    }
}
