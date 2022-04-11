using System.Collections.ObjectModel;
using wpf_foxchat.Com;

namespace wpf_foxchat.Models
{
    //=========================================================================
    // Chứa thông tin thống kể reaction của một tin nhắn
    //=========================================================================
    public class MessageItemReactionStatistical: ModelBase
    {
        public ReactionType   Type { get; set; } // Loại reaction : 1: Haha, 2: Like, 3 :Wow, 4: Sad, 5: Heard
        public int  _Count         { get; set; } // Số lượng reaction mỗi loại
        public int   Count
        {
            get { return _Count; }
            set
            {
                _Count = value;
                RaisePropertyChanged("Count");
            }
        }


        public MessageItemReactionStatistical()
        {
            Type   = ReactionType.Like;
            Count  = 0;
        }
    }

    //=========================================================================
    // Chứa thông tin cần thiết của một tin nhắn
    //=========================================================================
    public class MessageItem : ModelBase
    {
        public  int           ID                    { get; set; } // ID tin nhắn trong kênh
        public  string        IDUser                { get; set; } // ID người nhắn tin
        public  string        Message               { get; set; } // Nội dung tin nhắn
        public  MessageStatus Status                { get; set; } // Trạng thái : Gửi / Nhận
        public  string        Time                  { get; set; } // Thời gian gửi tin

        private bool   _ShowImageUser               { get; set; } // Hiển thị hình ảnh hay không : 1 : có | 0 :không
        public  bool   ShowImageUser
        {
            get { return _ShowImageUser; }
            set
            {
                _ShowImageUser = value;
                RaisePropertyChanged("ShowImageUser");
            }
        }

        public ObservableCollection<MessageItemReactionStatistical> Reactions { get; set; }

        public MessageItem()
        {
            Reactions = new ObservableCollection<MessageItemReactionStatistical>
            {
                new MessageItemReactionStatistical() {  Type = ReactionType.Like , Count=0},// Like
                new MessageItemReactionStatistical() {  Type = ReactionType.Haha , Count=0},// Haha
                new MessageItemReactionStatistical() {  Type = ReactionType.Love , Count=0},// Love
                new MessageItemReactionStatistical() {  Type = ReactionType.Wow  , Count=0},// Wow
                new MessageItemReactionStatistical() {  Type = ReactionType.Sad  , Count=0},// Sad
            };
        }

        //=========================================================================
        // Thêm số lượng vào reaction 
        // Nếu : Tồn tại rồi thì add thêm số lượng  Không có thì thêm mới reaction
        //=========================================================================
        public void AddReaction(ReactionType type, int number)
        {
            for (int i = 0; i < Reactions.Count; i++)
            {
                if (type == Reactions[i].Type)
                {
                    Reactions[i].Count += number;
                    return;
                }
            }
            // Không tồn tại
            Reactions.Add(new MessageItemReactionStatistical() { Type = type, Count = number });
        }
    }
}
