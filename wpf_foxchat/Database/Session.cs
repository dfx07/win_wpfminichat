using System;
using System.Collections.Generic;

namespace wpf_foxchat.Database
{
    public class UserInfo
    {
        public string ID;
        public string Name;
        public string UserName;
    }

    public abstract class SessionDataBase
    {

    }


    // Thông tin sử dụng chung cho toàn bộ ứng dụng
    public static class Session
    {
        private static UserInfo User = new UserInfo();
        private static Dictionary<string, SessionDataBase> DataSessions = new Dictionary<string, SessionDataBase>();

        public static UserInfo GetUser()
        {
            return User;
        }

        public static void SetUser(UserInfo user)
        {
            User = user;
        }

        public static void SetData(string key, SessionDataBase value)
        {
            DataSessions.Add(key, value);
        }

        public static SessionDataBase GetData(string key)
        {
            return DataSessions[key];
        }
    }
}
