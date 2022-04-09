using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using wpf_foxchat.Com;
using wpf_foxchat.Controllers;
using wpf_foxchat.Controls;
using wpf_foxchat.Database;
using wpf_foxchat.Models;
using wpf_foxchat.Services;

namespace wpf_foxchat.ViewModels
{

    enum ResponseStatus
    {
        Ok,
        Error,
    }

    public class MainViewModel : BaseViewModel
    {
        public TextBoxVM    TBX_SendMessage  { set; get; }
        public ScrollViewer SCW_Conversation { set; get; }

        // ==================== Phần thuộc tính Binding đến View ==================== //
        public ObservableCollection<MessageItem>     Messages { get; set; }
        public ObservableCollection<UserContactItem> UserContactCardList { get; set; }

        // ==================== Phần thuộc tính Binding đến View ==================== //

        public MainViewModel(Controller ctrl): base(ctrl)
        {
            OnInitData();    // Khởi tạo properties
            OnInitControl(); // Khởi tạo dữ liệu
        }

        public override bool OnInitData()
        {

            // Thiết lập thông tin về người dùng
            UserInfo User = new UserInfo() { ID = "1", Name ="Ngô Văn Thường", UserName ="Thuong.NV" } ;
            Session.SetUser(User);


            Messages = new ObservableCollection<MessageItem>
            {
                new MessageItem() {Message="Tin nhắn thứ nhất cua fasdffffffffffffffffffffffffffffffffffffffasdfffffffffffffffffffffffffffffffffffffffff ", Status=MessageStatus.Sent    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                new MessageItem() {Message="Tin nhắn của khác hàng đây", Status=MessageStatus.Received,MessageTime="03/01/2022",ShowImageUserMessage = true },
                new MessageItem() {Message="Tin nhắn của tối tiếp"     , Status=MessageStatus.Sent    ,MessageTime="03/01/2022",ShowImageUserMessage = false },
                new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , Status=MessageStatus.Sent    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                new MessageItem() {Message="Tin nhắn của khác hàng đây", Status=MessageStatus.Received,MessageTime="03/01/2022",ShowImageUserMessage = true },
                new MessageItem() {Message="Tin nhắn của tối tiếp"     , Status=MessageStatus.Sent    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
                new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , Status=MessageStatus.Received,MessageTime="03/01/2022",ShowImageUserMessage = false },
                new MessageItem() {Message="Tin nhắn của tối tiếp"     , Status=MessageStatus.Received,MessageTime="03/01/2022",ShowImageUserMessage = false },
                new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , Status=MessageStatus.Received,MessageTime="03/01/2022",ShowImageUserMessage = true },
                new MessageItem() {Message="Tin nhắn của tối tiếp"     , Status=MessageStatus.Sent    ,MessageTime="03/01/2022",ShowImageUserMessage = false },
                new MessageItem() {Message="Tin nhắn thứ nhất cua toi" , Status=MessageStatus.Sent    ,MessageTime="03/01/2022",ShowImageUserMessage = true },
            };

            UserContactCardList = new ObservableCollection<UserContactItem>
            {
                new UserContactItem() { ID="0001", UserName ="Nguyễn Đức Phương", Seen= false, IsActive = true , LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactItem() { ID="0002", UserName ="Công Hoàng Tiến"  , Seen= true , IsActive = false, LastMessage= "Xin chào bạn nha cho mình làm quen", ImageLink="" },
                new UserContactItem() { ID="0003", UserName ="Nguyễn Văn Chương", Seen= false, IsActive = true , LastMessage= "Ba hoa lắm lời", ImageLink="" },
                new UserContactItem() { ID="0004", UserName ="Nguyễn Văn Tuấn"  , Seen= false, IsActive = false, LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactItem() { ID="0005", UserName ="Nguyễn Ngọc Khánh", Seen= false, IsActive = true , LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactItem() { ID="0006", UserName ="Nguyễn Ngọc Khánh", Seen= true , IsActive = true , LastMessage= "Chuyên xàm lồn và là thằng xàm lồn", ImageLink="" },
                new UserContactItem() { ID="0007", UserName ="Lý Văn Chản"      , Seen= true , IsActive = false, LastMessage= "Thế nào rồi ", ImageLink="" },
                new UserContactItem() { ID="0008", UserName ="Đinh Quang Vương" , Seen= false, IsActive = false, LastMessage= "Sao chúng mày không nhậu đi", ImageLink="" },
                new UserContactItem() { ID="0009", UserName ="Trần Đình Hùng"   , Seen= true , IsActive = true , LastMessage= "Thằng chuyên nói : tôi biết rồi", ImageLink="" },
                new UserContactItem() { ID="0005", UserName ="Nguyễn Ngọc Khánh", Seen= false, IsActive = true , LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactItem() { ID="0006", UserName ="Nguyễn Ngọc Khánh", Seen= true , IsActive = true , LastMessage= "Chuyên xàm lồn và là thằng xàm lồn", ImageLink="" },
                new UserContactItem() { ID="0007", UserName ="Lý Văn Chản"      , Seen= true , IsActive = false, LastMessage= "Thế nào rồi ", ImageLink="" },
                new UserContactItem() { ID="0008", UserName ="Đinh Quang Vương" , Seen= false, IsActive = false, LastMessage= "Sao chúng mày không nhậu đi", ImageLink="" },
                new UserContactItem() { ID="0009", UserName ="Trần Đình Hùng"   , Seen= true , IsActive = true , LastMessage= "Thằng chuyên nói : tôi biết rồi", ImageLink="" },
            };


            return true;
        }

        public override bool OnInitControl()
        {
            TBX_SendMessage = new TextBoxVM();
            return true;
        }

        #region *******************************[ Sự kiện]***********************************
        private MessageItem PackSendMessageItem(string msg)
        {
            MessageItem MsgItem = new MessageItem();

            // Thiết lập thông tin Msg Item khi SEND
            MsgItem.MessageTime          = DateTime.Now.ToString("HH:mm:ss tt");
            MsgItem.Status               = MessageStatus.Sent;
            MsgItem.ShowImageUserMessage = true;
            MsgItem.Message              = msg;

            MessageItem LastMsgItem = Messages.LastOrDefault();
            if (LastMsgItem != null && LastMsgItem.Status == MessageStatus.Sent)
            {
                LastMsgItem.ShowImageUserMessage = false;
                LastMsgItem.AddReaction(ReactionType.Like, 1);
                LastMsgItem.AddReaction(ReactionType.Haha, 1);
                LastMsgItem.AddReaction(ReactionType.Love, 1);
                LastMsgItem.AddReaction(ReactionType.Wow , 1);
            }
            return MsgItem;
        }

        //==================================================================================
        // Gửi dữ liệu lên server và xem có được sử lý                                      
        //==================================================================================
        private ResponseStatus SendMessage(MessageItem msg)
        {
            return ResponseStatus.Ok;
        }

        //==================================================================================
        // Lấy text từ người dùng nhập                                                      
        //==================================================================================
        private string GetInputMessage()
        {
            return TBX_SendMessage.Text;
        }

        //==================================================================================
        // Cập nhật lại trạng thái của các button chức năng                                 
        //==================================================================================
        private void OnOK()
        {
            MessageBoxViewModel msg = new MessageBoxViewModel(this.GetController(), this);
            msg.ShowDialog();

            if (msg.Result == CMessageResult.OK)
            {
                MessageBox.Show("OK");
            }
            else if (msg.Result == CMessageResult.CANCEL)
            {
                MessageBox.Show("Cancel");
            }
            else if (msg.Result == CMessageResult.RETRY)
            {
                MessageBox.Show("Retry");
            }
        }

        public List<Message> GetMoreMessage(int MsgIDStart)
        {
            List<Message> PreMsgList = new List<Message>();

            PreMsgList.Add(new Message() { ID = 1, IDUser = "0001", Text="CC" , nHaha = 2 });
            PreMsgList.Add(new Message() { ID = 2, IDUser = "0002", Text="CC2", nLike = 2 });
            PreMsgList.Add(new Message() { ID = 3, IDUser = "0003", Text="CC3", nHaha = 2 });


            return PreMsgList;
        }

        public void OnLoadMoreMessage()
        {
            List<Message> PreMsg = GetMoreMessage(Messages[0].ID);

            List<MessageItem> PreMsgItem = DataConversion.ConvertDataMessage(PreMsg);

            Messages.(PreMsgItem);
        }


        //==================================================================================
        // Gửi một thông điệp tại kênh chat hiện tại                                        
        //==================================================================================
        private void OnSendMessage()
        {
            string msg = GetInputMessage();
            if (msg == "") return;  // Không gửi đối với text rỗng 

            MessageItem msgItem = PackSendMessageItem(msg);

            if (SendMessage(msgItem) == ResponseStatus.Ok)
            {
                Messages.Add(msgItem);
                SCW_Conversation.ScrollToBottom();
                TBX_SendMessage.Text = "";
            }
            else
            {
                MessageBox.Show("Send message failed !");
            }
        }

        #endregion *************************************************************************

        #region ************************[ Xử lý sự kiện Command ]***************************
        /// <summary>
        /// Command Handle OK Button clicked
        /// </summary>
        private RelayCommand _CmdOnOK;
        public RelayCommand CmdOnOK
        {
            get
            {
                if(_CmdOnOK == null)
                {
                    _CmdOnOK = new RelayCommand((param) => OnOK());
                }
                return _CmdOnOK;
            }
        }

        /// <summary>
        /// Command Handle OK Button clicked
        /// </summary>
        private RelayCommand _CmdSendMessage;
        public RelayCommand CmdSendMessage
        {
            get
            {
                if (_CmdSendMessage == null)
                {
                    _CmdSendMessage = new RelayCommand((param) => OnSendMessage());
                }
                return _CmdSendMessage;
            }
        }

        public void CTBX_TextSend_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                OnSendMessage();
            }
        }
        #endregion *************************************************************************
    }
}
