using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace wpf_foxchat.Models
{
    //=========================================================================
    // Chứa thông tin thống kể reaction của một tin nhắn
    //=========================================================================
    public class MessageItemReactionStatistical: ModelBase
    {
        public int   ReactionType  { get; set; } // Loại reaction : 1: Haha, 2: Like, 3 :Wow, 4: Sad, 5: Heard
        public int  _ReactionCount { get; set; } // Số lượng reaction mỗi loại
        public int   ReactionCount
        {
            get { return _ReactionCount; }
            set
            {
                _ReactionCount = value;
                RaisePropertyChanged("ReactionCount");
            }
        }


        public MessageItemReactionStatistical()
        {
            ReactionType  = 0;
            ReactionCount = 0;
        }
    }

    //=========================================================================
    // Chứa thông tin cần thiết của một tin nhắn
    //=========================================================================
    public class MessageItem : ModelBase
    {
        public  string Message               { get; set; } // Nội dung tin nhắn
        public  string MessageStatus         { get; set; } // Trạng thái : Gửi / Nhận
        public  string MessageTime           { get; set; } // Thời gian gửi tin

        private bool   _ShowImageUserMessage { get; set; } // Hiển thị hình ảnh hay không : 1 : có | 0 :không
        public  bool   ShowImageUserMessage
        {
            get { return _ShowImageUserMessage; }
            set
            {
                _ShowImageUserMessage = value;
                RaisePropertyChanged("ShowImageUserMessage");
            }
        }

        public ObservableCollection<MessageItemReactionStatistical> Reaction { get; set; }

        public MessageItem()
        {
            Reaction = new ObservableCollection<MessageItemReactionStatistical>
            {
                new MessageItemReactionStatistical() {  ReactionType = 0 ,ReactionCount=0},// Like
                new MessageItemReactionStatistical() {  ReactionType = 1 ,ReactionCount=0},// Haha
                new MessageItemReactionStatistical() {  ReactionType = 2 ,ReactionCount=0},// Love
                new MessageItemReactionStatistical() {  ReactionType = 3 ,ReactionCount=0},// Wow
                new MessageItemReactionStatistical() {  ReactionType = 4 ,ReactionCount=0},// Sad
            };
        }
    }
}
