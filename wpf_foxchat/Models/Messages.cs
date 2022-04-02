using System.Collections.Generic;

namespace wpf_foxchat.Models
{
    //=========================================================================
    // Chứa thông tin thống kể reaction của một tin nhắn
    //=========================================================================
    public class MessageItemReactionStatistical
    {
        public int ReactionType { get; set; }
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
            Reaction.Add(new MessageItemReactionStatistical { ReactionType = 0, ReactionCount = 2 });
            Reaction.Add(new MessageItemReactionStatistical { ReactionType = 2, ReactionCount = 2 });
        }
    }
}
