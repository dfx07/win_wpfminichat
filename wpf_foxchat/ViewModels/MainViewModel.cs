using System.Collections.Generic;
using System.Windows;
using wpf_foxchat.Controllers;
using wpf_foxchat.Models;

namespace wpf_foxchat.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        // ==================== Phần thuộc tính Binding đến View ==================== //
        private List<MessageItem> _Messages;
        public List<MessageItem> Messages
        {
            get { return _Messages; }
            set
            {
                _Messages = value;
                RaisePropertyChanged("Messages");
            }
        }


        private List<UserContactCard> _UserContactCardList;
        public List<UserContactCard> UserContactCardList
        {
            get { return _UserContactCardList; }
            set
            {
                _UserContactCardList = value;
                RaisePropertyChanged("UserContactCardList");
            }
        }

        // ==================== Phần thuộc tính Binding đến View ==================== //

        public MainViewModel(Controller ctrl): base(ctrl)
        {
            OnInitData();    // Khởi tạo properties
            OnInitControl(); // Khởi tạo dữ liệu
        }

        public override bool OnInitData()
        {
            Messages = new List<MessageItem>
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

            UserContactCardList = new List<UserContactCard>
            {
                new UserContactCard() { ID="0001", UserName ="Nguyễn Đức Phương", Seen= false, IsActive = true , LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactCard() { ID="0002", UserName ="Công Hoàng Tiến"  , Seen= true , IsActive = false, LastMessage= "Xin chào bạn nha cho mình làm quen", ImageLink="" },
                new UserContactCard() { ID="0003", UserName ="Nguyễn Văn Chương", Seen= false, IsActive = true , LastMessage= "Ba hoa lắm lời", ImageLink="" },
                new UserContactCard() { ID="0004", UserName ="Nguyễn Văn Tuấn"  , Seen= false, IsActive = false, LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactCard() { ID="0005", UserName ="Nguyễn Ngọc Khánh", Seen= false, IsActive = true , LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactCard() { ID="0006", UserName ="Nguyễn Ngọc Khánh", Seen= true , IsActive = true , LastMessage= "Chuyên xàm lồn và là thằng xàm lồn", ImageLink="" },
                new UserContactCard() { ID="0007", UserName ="Lý Văn Chản"      , Seen= true , IsActive = false, LastMessage= "Thế nào rồi ", ImageLink="" },
                new UserContactCard() { ID="0008", UserName ="Đinh Quang Vương" , Seen= false, IsActive = false, LastMessage= "Sao chúng mày không nhậu đi", ImageLink="" },
                new UserContactCard() { ID="0009", UserName ="Trần Đình Hùng"   , Seen= true , IsActive = true , LastMessage= "Thằng chuyên nói : tôi biết rồi", ImageLink="" },
                new UserContactCard() { ID="0005", UserName ="Nguyễn Ngọc Khánh", Seen= false, IsActive = true , LastMessage= "Mày hỏi gì vậy thành cha mày", ImageLink="" },
                new UserContactCard() { ID="0006", UserName ="Nguyễn Ngọc Khánh", Seen= true , IsActive = true , LastMessage= "Chuyên xàm lồn và là thằng xàm lồn", ImageLink="" },
                new UserContactCard() { ID="0007", UserName ="Lý Văn Chản"      , Seen= true , IsActive = false, LastMessage= "Thế nào rồi ", ImageLink="" },
                new UserContactCard() { ID="0008", UserName ="Đinh Quang Vương" , Seen= false, IsActive = false, LastMessage= "Sao chúng mày không nhậu đi", ImageLink="" },
                new UserContactCard() { ID="0009", UserName ="Trần Đình Hùng"   , Seen= true , IsActive = true , LastMessage= "Thằng chuyên nói : tôi biết rồi", ImageLink="" },
            };

            return true;
        }

        public override bool OnInitControl()
        {
            return true;
        }

        // Xử lý sự kiện click button OK
        private RelayCommand _CmdOnOK { get; set; }
        public RelayCommand CmdOnOK
        {
            get
            {
                if(_CmdOnOK == null)
                {
                    _CmdOnOK = new RelayCommand((param) => OnOK(param));
                }
                return _CmdOnOK;
            }
        }

        private void OnOK(object param)
        {
            MessageBoxViewModel msg = new MessageBoxViewModel(this.GetController(), this);
            msg.ShowDialog();

            if(msg.Result == CMessageResult.OK)
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


    }

}
