using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_foxchat.ViewModels
{
    class MainViewModel
    {
        public List<MessageItem> Messages
        {
            get
            {
                return new List<MessageItem>
                {
                    new MessageItem() {Message="Tin nhắn thứ nhất cua fasdffffffffffffffffffffffffffffffffffffffasdfffffffffffffffffffffffffffffffffffffffff ", MessageStatus="Sent"    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                    new MessageItem() {Message="Tin nhắn của khác hàng đây", MessageStatus="Received",MessageTime="03/01/2022",ShowImageUserMessage = true },
                    new MessageItem() {Message="Tin nhắn của tối tiếp"     , MessageStatus="Sent"    ,MessageTime="03/01/2022",ShowImageUserMessage = false },
                    new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , MessageStatus="Sent"    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                    new MessageItem() {Message="Tin nhắn của khác hàng đây", MessageStatus="Received",MessageTime="03/01/2022",ShowImageUserMessage = true },
                    new MessageItem() {Message="Tin nhắn của tối tiếp"     , MessageStatus="Sent"    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                    new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , MessageStatus="Received",MessageTime="03/01/2022",ShowImageUserMessage = false },
                    new MessageItem() {Message="Tin nhắn của tối tiếp"     , MessageStatus="Received",MessageTime="03/01/2022",ShowImageUserMessage = false },
                    new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , MessageStatus="Received",MessageTime="03/01/2022",ShowImageUserMessage = true },
                    new MessageItem() {Message="Tin nhắn của tối tiếp"     , MessageStatus="Sent"    ,MessageTime="03/01/2022",ShowImageUserMessage = false },
                    new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , MessageStatus="Sent"    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                };
            }
        }
    }

    //=========================================================================
    // Chứa thông tin thống kể reaction của một tin nhắn
    //=========================================================================
    public class MessageItemReactionStatistical
    {
        public int ReactionType  { get; set; }
        public int ReactionCount { get; set; }

        public MessageItemReactionStatistical()
        {
            ReactionType  = 0;
            ReactionCount = 0;
        }
    }

    //=========================================================================
    // Chứa thông tin cần thiết của một tin nhắn
    //=========================================================================
    public class MessageItem
    {
        public string Message               { get; set; } // Nội dung tin nhắn
        public string MessageStatus         { get; set; } // Trạng thái : Gửi / Nhận
        public string MessageTime           { get; set; } // Thời gian gửi tin
        public bool   ShowImageUserMessage  { get; set; } // Hiển thị hình ảnh hay không : 1 : có | 0 :không

        public List<MessageItemReactionStatistical> Reaction { get; set; }

        public MessageItem()
        {
            Reaction = new List<MessageItemReactionStatistical>();
            Reaction.Add(new MessageItemReactionStatistical { ReactionType = 0, ReactionCount = 4 });
            Reaction.Add(new MessageItemReactionStatistical { ReactionType = 2, ReactionCount = 4 });
        }
    }
}
