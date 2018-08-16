using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex02
{
    internal class MailAdapter
    {
        public string Mail { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        //private MatchUtils m_matchUtils;

        public MailAdapter(string i_mail, string i_message, string i_subject)
        {
            this.Mail = i_mail;
            this.Message = i_message;
            this.Subject = i_subject;
            //this.m_matchUtils = new MatchUtils();
        }

        internal bool sendMail()
        {
            MatchUtils matchUtils = new MatchUtils();
            matchUtils.sendMatchMessage(this.Mail, this.Message, this.Subject);
            return true;
        }
    }
}
