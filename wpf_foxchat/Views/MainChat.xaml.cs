using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpf_foxchat.Controls;

namespace wpf_foxchat
{
    public partial class MainChat : Window
    {

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName]string propertyName = null)
        //{
        //    if (!EqualityComparer<T>.Default.Equals(field, newValue))
        //    {
        //        field = newValue;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //        return true;
        //    }
        //    return false;
        //}

        //protected virtual void RaisePropertyChanged(string propertyName)
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        //}

        // Phần thuộc tính thiết lập cài đặt window chính
        //public Visibility VisiblePopupDialog { get; set; }

        public MainChat()
        {
            DefaultSetting();
            InitializeComponent();
        }

        private void DefaultSetting()
        {
            //VisiblePopupDialog = Visibility.Collapsed;
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // ================== Xử lý chung các sự kiện ================== 
        private void Maximize()
        {
            if (WindowState != WindowState.Maximized)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        private void Minimize()
        {
            if (WindowState != WindowState.Minimized)
            {
                WindowState = WindowState.Minimized;
            }
        }


        // ================== Xử lý sự kiện thông qua ================== 
        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            this.Maximize();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.Minimize();
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.LeftButton == MouseButtonState.Pressed )
            //{
            //    double percentHorizontal = e.GetPosition(this).X / ActualWidth;
            //    double targetHorizontal = RestoreBounds.Width * percentHorizontal;

            //    double percentVertical = e.GetPosition(this).Y / ActualHeight;
            //    double targetVertical = RestoreBounds.Height * percentVertical;

            //    Left = e.GetPosition(null).X - targetHorizontal;
            //    Top = e.GetPosition(null).Y - targetVertical;

            //    WindowState = WindowState.Normal;
            //    DragMove();
            //}
        }

        private void SetDstImage(RenderTargetBitmap bitmap)//,Size size)
        {
            var ib = new ImageBrush(bitmap);
            ib.Stretch = Stretch.Fill;

            xGrid_NavigationLeft.Background = ib;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ClickCount == 2)
            //    this.Maximize();
        }

        private void ChangeMininavigation(object sender, DependencyPropertyChangedEventArgs e)
        {
            Grid ic = sender as Grid;
            RenderTargetBitmap bitmap = Utils.RenderToBitmap(ic);

            SetDstImage(bitmap);
        }

        private void BTN_MininaviClick(object sender, RoutedEventArgs e)
        {
            xGird_Naviheader.Visibility  = Visibility.Hidden;
            xGrid_Navisearch.Visibility  = Visibility.Hidden;
            xGrid_Navicontact.Visibility = Visibility.Hidden;
            xGrid_Navifooter.Visibility  = Visibility.Hidden;

            xGrid_Contentchat.Visibility = Visibility.Hidden;
        }

        private void xGrid_NavigationLeftMini_End(object sender, EventArgs e)
        {
            xGird_Naviheader.Visibility  = Visibility.Visible;
            xGrid_Navisearch.Visibility  = Visibility.Visible;
            xGrid_Navicontact.Visibility = Visibility.Visible;
            xGrid_Navifooter.Visibility  = Visibility.Visible;

            xGrid_Contentchat.Visibility = Visibility.Visible;
        }
    }
}
