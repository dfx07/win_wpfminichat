using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using wpf_foxchat.Controllers;
using wpf_foxchat.Controls;
using wpf_foxchat.Database;
using wpf_foxchat.Models;
using wpf_foxchat.Services;

namespace wpf_foxchat.ViewModels
{
    enum MessageStatus
    {
        Send,
        Received
    }

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
            Messages = new ObservableCollection<MessageItem>
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
            MsgItem.MessageStatus        = "Sent";
            MsgItem.ShowImageUserMessage = true;
            MsgItem.Message              = msg;

            MessageItem LastMsgItem = Messages.LastOrDefault();
            if (LastMsgItem != null && LastMsgItem.MessageStatus == "Sent")
            {
                LastMsgItem.ShowImageUserMessage = false;
                LastMsgItem.Reaction[0].ReactionCount++;
                LastMsgItem.Reaction[1].ReactionCount++;
                LastMsgItem.Reaction[2].ReactionCount++;
                LastMsgItem.Reaction[3].ReactionCount++;
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

        //==================================================================================
        // Lấy format chuỗi thời gian một thời điểm so với hiện tại                         
        //==================================================================================
        public string ConvertDT2StrCMPNow(DateTime dTime)
        {
            string strDataTime = "";
            DateTime dTimeNow = DateTime.Now;
            double   diffDay  = (dTimeNow - dTime).TotalDays;

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

        public void AppendHeadMessage(List<Message> MsgList)
        {
            List<MessageItem> MsgItemList = DataConversion.ConvertDataMessage(MsgList);

            //Messages.Insert(0, MsgItemList);
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
