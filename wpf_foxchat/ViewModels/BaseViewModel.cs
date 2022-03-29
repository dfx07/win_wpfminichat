using System.Windows;
using System.Windows.Controls;
using wpf_foxchat.Controllers;
using wpf_foxchat.Controls;

namespace wpf_foxchat.ViewModels
{
    public abstract class BaseViewModel : BaseControl
    {
        private Controller      m_pCtrl;
        private CWindow         m_Window;
        private BaseViewModel   m_ParentViewModel;
        private bool            m_bModeless;

        #region ****************[ Phần thuộc tính thiết lập chung View ]***************

        public Visibility _VisiblePopupOverflow { get; set; }
        public Visibility  VisiblePopupOverflow
        {
            get { return _VisiblePopupOverflow; }
            set
            {
                _VisiblePopupOverflow = value;
                RaisePropertyChanged("VisiblePopupOverflow");
            }
        }
        #endregion ********************************************************************

        private void SetDefaultProperty()
        {
            VisiblePopupOverflow = Visibility.Collapsed;
            m_bModeless          = false;
            m_ParentViewModel    = null;
            m_Window             = null;
        }

        public BaseViewModel(Controller ctrl)
        {
            m_pCtrl = ctrl;
            SetDefaultProperty();
        }

        public CWindow GetWindow()
        {
            return m_Window;
        }

        public Controller GetController()
        {
            return m_pCtrl;
        }
        // =============================================================================
        // Đóng cửa sổ window                                                           
        // =============================================================================
        public void Close()
        {
            m_Window.Close();
        }

        // =============================================================================
        // Hiển thị window                                                              
        // =============================================================================
        public void Show()
        {
            if (m_Window != null)
            {
                m_bModeless = false;
                m_Window.Show();
            }
        }

        // =============================================================================
        // Hiển thị window modeless                                                     
        // =============================================================================
        public void ShowDialog()
        {
            if (m_Window != null)
            {
                m_bModeless = true;

                // Hiển thị Popup Overflow lên
                if (m_ParentViewModel != null)
                {
                    m_ParentViewModel.VisiblePopupOverflow = Visibility.Visible;
                }
                m_Window.ShowDialog();

                // Ẩn thị Popup Overflow lên
                if (m_ParentViewModel != null)
                {
                    m_ParentViewModel.VisiblePopupOverflow = Visibility.Collapsed;
                }
            }
        }

        // =============================================================================
        // Gắn phần View và Datacontext vào Gird chứa content_control                   
        // =============================================================================
        private bool AttachToView(UserControl view)
        {
            if (m_Window == null) return false;

            m_Window.Content_Control.Children.Add(view); // Thêm View vào content window
            view.DataContext = this;                     // Thiết lập ngữ cảnh

            return true;
        }

        // =============================================================================
        // Thiết lập parent ViewModel cho viewModel hiện tại                   
        // =============================================================================
        public bool SetParentViewModel(BaseViewModel Parent)
        {
            if (Parent == null) return false;

            m_ParentViewModel = Parent;            // Thiết lập ViewModel cha
            m_Window.Owner    = Parent.GetWindow();// Thiết lập window cha

            return true;
        }

        // =============================================================================
        // Khởi tạo Dialog và các thiết lập ban đầu                                     
        // Khi thêm mới một ViewModel sẽ thêm vào đây                                   
        // Giai đoạn : - Khởi tạo Window 
        //             - khởi tạo ViewModel
        //             - khởi tạo InitData
        //             - khởi tạo InitControl
        // =============================================================================
        protected bool CreateDialog(DlgType IDC_Dialog, BaseViewModel Parent = null)
        {
            CWindow     win  = new CWindow();
            UserControl view = null;

            switch (IDC_Dialog)
            {
                case DlgType.DLG_MESSAGE_BOX: view = new CMessageBox(); break;

                default: view = null; break;
            }

            if (view == null) return false;
            m_Window          = win;           // Thiết lập Window
            m_Window.Loaded  += OnLoad;        // Sau khi khởi tạo xong sẽ chạy nó
            this.SetParentViewModel(Parent);   // Thiết lập ViewModel cha
            this.OnInitData();                 // Khởi tạo dữ liệu

            return AttachToView(view);
        }

        // =============================================================================
        // Khởi tạo thành phần của ViewModel : Sau khi UI đã load thành công            
        // Thường được override bởi ViewModel kế thừa                                   
        // =============================================================================
        public virtual bool OnInitControl()
        {
            return true;
        }


        // =============================================================================
        // Phần khởi tạo dữ liệu : Sau khi UI đã load thành công 
        // Thường được override bởi ViewModel kế thừa                                   
        // =============================================================================
        public virtual bool OnInitData()
        {
            return true;
        }


        #region ***************[ Phần này xử lý sự kiện không chỉnh sửa ]***************
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            this.OnInitControl();
        }
        #endregion *********************************************************************
    }
}
