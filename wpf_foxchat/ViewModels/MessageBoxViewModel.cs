using System.Windows;
using wpf_foxchat.Com;
using wpf_foxchat.Controllers;
using wpf_foxchat.Controls;

namespace wpf_foxchat.ViewModels
{
    //==================================================================================
    // Kết quả trả về khi hiển thị dialog                                               
    //==================================================================================
    public enum CMessageResult
    {
        NONE,         // Click vào Button Close
        OK,           // Click vào Button OK
        CANCEL,       // Click vào Button Cancel
        RETRY,        // Click vào Button Retry
    }

    class MessageBoxViewModel : BaseViewModel
    {
        public MessageBoxViewModel(Controller ctrl, BaseViewModel parent): base(ctrl)
        {
            if (CreateDialog( DlgType.DLG_MESSAGE_BOX, parent))
            {
                // Khởi tạo dialog thành công
            }
        }

        public CMessageResult Result = CMessageResult.NONE;

        public override bool OnInitControl()
        {
            CWindow win = GetWindow();
            win.BTN_Minimize.Visibility = Visibility.Collapsed;
            win.BTN_Maximize.Visibility = Visibility.Collapsed;
            win.VisibleImageTitleBar    = Visibility.Collapsed;


            //VisibleImage = Visibility.Collapsed;
            XIcon                       = CMessageIcon.SUCCESS;
            XButton                     = CMessageButton.OK_CANCEL_RETRY;

            return true;
        }

        //==================================================================================
        // Cập nhật lại trạng thái của các button chức năng                                 
        //==================================================================================
        private void UpdateMessageBoxButton(CMessageButton btn)
        {
            _XButton = btn;
            bool bShowOK     = (XButton == CMessageButton.OK) ||
                               (XButton == CMessageButton.OK_CANCEL) ||
                               (XButton == CMessageButton.OK_CANCEL_RETRY);

            bool bShowCancel = (XButton == CMessageButton.OK_CANCEL) ||
                               (XButton == CMessageButton.OK_CANCEL_RETRY);

            bool bShowRetry  = (XButton == CMessageButton.OK_CANCEL_RETRY);

            BTN_OK.Visibility     = bShowOK     ? Visibility.Visible : Visibility.Collapsed;
            BTN_Cancel.Visibility = bShowCancel ? Visibility.Visible : Visibility.Collapsed;
            BTN_Retry.Visibility  = bShowRetry  ? Visibility.Visible : Visibility.Collapsed;
        }

        public override bool OnInitData()
        {
            // Khởi tạo data của control 
            BTN_OK      = new ButtonVM();
            BTN_Cancel  = new ButtonVM();
            BTN_Retry   = new ButtonVM();

            // Khởi tạo dữ liệu thông thường
            return true;
        }

        #region ****************[ Phần thuộc tính thiết lập chung View ]***************
        private Visibility _VisibleImage;
        public Visibility   VisibleImage
        {
            get { return _VisibleImage; }
            set
            {
                _VisibleImage = value;
                RaisePropertyChanged("VisibleImage");
            }
        }

        private CMessageIcon _XIcon;
        public  CMessageIcon  XIcon
        {
            get { return _XIcon; }
            set
            {
                _XIcon = value;
                RaisePropertyChanged("XIcon");
            }
        }

        private CMessageButton _XButton;
        public  CMessageButton  XButton
        {
            get { return _XButton; }
            set
            {
                UpdateMessageBoxButton(value);
            }
        }

        public ButtonVM BTN_OK      { get; set; }
        public ButtonVM BTN_Cancel  { get; set; }
        public ButtonVM BTN_Retry   { get; set; }
        #endregion *********************************************************************

        #region **********************[ Xử lý sự kiện Command ]*************************
        /// <summary>
        /// Command Handle OK Button clicked
        /// </summary>
        /// 
        private RelayCommand _CmdOnOK;
        public RelayCommand   CmdOnOK
        {
            get
            {
                if (_CmdOnOK == null)
                {
                    _CmdOnOK = new RelayCommand((param) => OnOK(param));
                }
                return _CmdOnOK;
            }
        }
        private void OnOK(object param)
        {
            Result = CMessageResult.OK;
            Close();
        }


        /// <summary>
        /// Command Handle Cancel Button clicked
        /// </summary>
        private RelayCommand _CmdOnCancel { get; set; }
        public RelayCommand   CmdOnCancel
        {
            get
            {
                if (_CmdOnCancel == null)
                {
                    _CmdOnCancel = new RelayCommand((param) => OnCancel(param));
                }
                return _CmdOnCancel;
            }
        }
        private void OnCancel(object param)
        {
            Result = CMessageResult.CANCEL;
            Close();
        }

        /// <summary>
        /// Command Handle Retry Button clicked
        /// </summary>
        private RelayCommand _CmdOnRetry;
        public RelayCommand   CmdOnRetry
        {
            get
            {
                if (_CmdOnRetry == null)
                {
                    _CmdOnRetry = new RelayCommand((param) => OnRetry(param));
                }
                return _CmdOnRetry;
            }
        }
        private void OnRetry(object param)
        {
            Result = CMessageResult.RETRY;
            Close();
        }

        #endregion *********************************************************************
    }
}
