using System;
using System.Collections.Generic;
using wpf_foxchat.Com;
using wpf_foxchat.Database;
using wpf_foxchat.Models;

namespace wpf_foxchat.Services
{
    public static class Conversion
    {
        //==================================================================================
        // Lấy format chuỗi thời gian một thời điểm so với hiện tại                         
        //==================================================================================
        public static string DT2StrCMPNow(DateTime dTime)
        {
            string strDataTime = "";
            DateTime dTimeNow = DateTime.Now;
            double diffDay = (dTimeNow - dTime).TotalDays;

            // Tin nhắn trong ngày 
            if (diffDay < 1)
            {
                strDataTime = dTime.ToString("HH:mm tt");
            }
            // Tin nhắn trong một năm
            else if (dTime.Year == dTimeNow.Year)
            {
                strDataTime = dTime.ToString("HH:mm tt ddd, dd MMM");
            }
            // Tin nhắn khác năm
            else
            {
                strDataTime = dTime.ToString("HH:mm tt ddd, dd MMM y");
            }

            return strDataTime;
        }
    }

    public static class DataConversion
    {

        // Chuyển đổi dữ liệu từ DataBase -> DataUI
        public static List<MessageItem> ConvertDataMessage(List<Message> MsgList)
        {
            UserInfo user = Session.GetUser();
            List<MessageItem> MsgItemList = new List<MessageItem>();

            for (int i = 0; i < MsgList.Count ; i ++)
            {
                Message     Msg     = MsgList[i];
                MessageItem MsgItem = new MessageItem();

                MsgItem.ID             = Msg.ID;
                MsgItem.Message        = Msg.Text;
                MsgItem.MessageTime    = Conversion.DT2StrCMPNow(Msg.Time);


                // Thiết lập tin nhắn là gửi hay nhận
                if (user.ID == Msg.IDUser)
                {
                    MsgItem.Status = MessageStatus.Sent;
                }
                else
                {
                    MsgItem.Status = MessageStatus.Received;
                }

                // Thiết lập thông tin về reaction
                if (Msg.nLike > 0) MsgItem.AddReaction(ReactionType.Like, Msg.nLike);
                if (Msg.nHaha > 0) MsgItem.AddReaction(ReactionType.Haha, Msg.nHaha);
                if (Msg.nLove > 0) MsgItem.AddReaction(ReactionType.Love, Msg.nLove);
                if (Msg.nSad  > 0) MsgItem.AddReaction(ReactionType.Sad , Msg.nSad) ;
                if (Msg.nWow  > 0) MsgItem.AddReaction(ReactionType.Wow , Msg.nWow) ;

                MsgItemList.Add(MsgItem);
            }
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
