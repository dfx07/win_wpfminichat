using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_foxchat.Database;

namespace wpf_foxchat.Services
{
    static class ServerAPI
    {
        public static List<Message> GetMoreMessage(int MsgIDStart, int limit)
        {
            List<Message> PreMsgList = new List<Message>();

            PreMsgList.Add(new Message() { ID = 1, IDUser = "0001", Text = "CC" ,Time = new DateTime(2022,3,12,20,2,0), ShowImgUser=true, nHaha = 2 });
            PreMsgList.Add(new Message() { ID = 2, IDUser = "0002", Text = "CC2",Time = new DateTime(2022,3,12,20,2,0), ShowImgUser=true,  nLike = 2 });
            PreMsgList.Add(new Message() { ID = 3, IDUser = "0003", Text = "CC3",Time = new DateTime(2022,3,20,20,2,0), ShowImgUser=true,  nHaha = 2 });

            return PreMsgList;
        }
    }
}
