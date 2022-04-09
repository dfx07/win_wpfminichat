using System;

namespace wpf_foxchat.Database
{
    public struct Message
    {
        public int      ID;
        public string   IDUser;

        public DateTime Time;
        public string   Text;
        public int      nLike;
        public int      nHaha;
        public int      nLove;
        public int      nWow;
        public int      nSad;

        public Message(string _Text = "")
        {
            ID     = 0;
            IDUser = "None";
            Time   = new DateTime();
            Text   = _Text;
            nLike  = nLove = nWow = 0;
            nHaha  = nSad = 0;
        }
    }

    public struct UserContact
    {
        public string   IDChanel;

        public bool     Active;
        public string   LastMessage;
    }
}
