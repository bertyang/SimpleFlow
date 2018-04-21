using System;
using System.Collections.Generic;
using System.Text;


    public class AdminInfo
    {
        private string m_EnglishName;
        private string m_Extension;
        private string m_Email;

        public string EnglishName
        {
            get { return m_EnglishName; }
            set { m_EnglishName = value; }
        }

        public string Extension
        {
            get { return m_Extension; }
            set { m_Extension = value; }
        }

        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
    }
