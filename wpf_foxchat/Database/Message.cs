using System;

namespace wpf_foxchat.Database
{
    public struct Message
    {
        public string   IDUser;

        public DateTime Time;
        public string   Text;
        public int      nLike;
        public int      nHaha;
        public int      nLove;
        public int      nWow;
        public int      nSad;
    }

    public struct UserContact
    {
        public string   IDChanel;

        public bool     Active;
        public string   LastMessage;
    }
}
