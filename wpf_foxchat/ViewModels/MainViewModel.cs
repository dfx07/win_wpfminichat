using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
            Controller ctrl = GetController();
            var MainViewModel =  ctrl.GetMainView();
            
            msg.ShowDialog();
        }


    }

}
