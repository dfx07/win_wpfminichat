namespace wpf_foxchat.Models
{
    //=========================================================================
    // Chứa thông tin thông tin cá nhân giao tiếp trong nhóm chat
    //=========================================================================
    public class UserContactItem
    {
        public string ID            { get; set; } // Định danh người dùng
        public string UserName      { get; set; } // Tên người dùng
        public bool   IsActive      { get; set; } // Trạng thái : Đang hoạt động | Không
        public string LastMessage   { get; set; } // Tin nhắn cuối cùng
        public bool   Seen          { get; set; } // Đã đọc tin nhắn cuối cùng hay chưa
        public string ImageLink     { get; set; } // Đường dẫn hình ảnh người dùng

        public UserContactItem()
        {
            ID          = "";
            UserName    = "Không rõ";
            IsActive    = false;
            Seen        = false;
            LastMessage = "";
            ImageLink   = "";
        }
    }
}
