using System.Collections.Generic;
using wpf_foxchat.Database;
using wpf_foxchat.Models;

namespace wpf_foxchat.Services
{
    public static class DataConversion
    {
        public static List<MessageItem> ConvertDataMessage(List<Message> MsgList)
        {
            List<MessageItem> MsgItemList = new List<MessageItem>();

            MessageItem MsgItem = new MessageItem();

            // Thiết lập giá trị từ việc convert

            MsgItemList.Add(MsgItem);

            return MsgItemList;
        }

        public static List<UserContactItem> ConvertDataUserContact(List<UserContact> UserContactList)
        {
            List<UserContactItem> UserContactItemList = new List<UserContactItem>();

            UserContactItem UserContactItem = new UserContactItem();

            // Thiết lập giá trị từ việc convert

            UserContactItemList.Add(UserContactItem);

            return UserContactItemList;
        }
    }
}
