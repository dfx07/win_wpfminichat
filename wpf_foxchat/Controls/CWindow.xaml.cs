using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using wpf_foxchat.ViewModels;

namespace wpf_foxchat.Controls
{
    /// <summary>
    /// Interaction logic for CWindow.xaml
    /// </summary>
    public partial class CWindow : Window, INotifyPropertyChanged
    {
        #region ***********************[ Raise property changed ]*********************
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName]string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion ********************************************************************


        #region ****************[ Phần thuộc tính thiết lập chung View ]***************
        private Visibility _VisibleTitleBar { get; set; }
        public  Visibility  VisibleTitleBar
        {
            get { return _VisibleTitleBar; }
            set
            {
                _VisibleTitleBar = value;
                RaisePropertyChanged("VisibleTitleBar");
            }
        }

        private Visibility _VisibleImageTitleBar { get; set; }
        public  Visibility  VisibleImageTitleBar
        {
            get { return _VisibleImageTitleBar; }
            set
            {
                _VisibleImageTitleBar = value;
                RaisePropertyChanged("VisibleImageTitleBar");
            }
        }

        public ButtonVM    BTN_Minimize   { get; set; }
        public ButtonVM    BTN_Maximize   { get; set; }
        public ButtonVM    BTN_Close      { get; set; }
        #endregion *********************************************************************


        public CWindow()
        {
            DefaultSettting();
            InitializeControl();
            InitializeStyle();
            InitializeComponent();

            // DataContext explains WPF in which object WPF. Here Vis is in "this" then
            DataContext = this;
        }

        public void InitializeControl()
        {
            Title         = "Thông báo";
            BTN_Minimize  = new ButtonVM();
            BTN_Maximize  = new ButtonVM();
            BTN_Close     = new ButtonVM();
        }

        public void DefaultSettting()
        {
            VisibleTitleBar      = Visibility.Visible;
        }

        public void InitializeStyle()
        {
            
        }

        // ============================  Xử lý sự kiện Button TitleBar ============================ //

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
