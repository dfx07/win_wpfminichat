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


        void AnimationNavigation(double _from, double _to, double _from2, double _to2)
        {
            Storyboard storyboard = new Storyboard();

            DoubleAnimation dbAnima = new DoubleAnimation();
            dbAnima.From        = _from;
            dbAnima.To          = _to;
            dbAnima.Duration    = new Duration(TimeSpan.FromSeconds(0.5));
            dbAnima.AutoReverse = false;
            dbAnima.Completed  += xGrid_NavigationLeftMini_End;

            PowerEase easingFunction = new PowerEase();
            easingFunction.EasingMode = EasingMode.EaseOut;
            dbAnima.EasingFunction = easingFunction;

            storyboard.Children.Add(dbAnima);

            Storyboard.SetTargetName(dbAnima, xGrid_NavigationLeft.Name);
            Storyboard.SetTargetProperty(dbAnima, new PropertyPath("Width"));


            //DoubleAnimation dbAnima2 = new DoubleAnimation();
            //dbAnima2.From = _from2;
            //dbAnima2.To = _to2;
            //dbAnima2.Duration = new Duration(TimeSpan.FromSeconds(0.1));

            //storyboard.Children.Add(dbAnima2);

            //Storyboard.SetTargetName(dbAnima2, xGrid_Contentchat.Name);
            //Storyboard.SetTargetProperty(dbAnima2, new PropertyPath("RenderTransform.(TranslateTransform.X)"));

            storyboard.Begin(this);
        }

        private void BTN_MininaviClick(object sender, RoutedEventArgs e)
        {
            double dFrom, dTo, dFrom2, dTo2;
            if (xGrid_NavigationLeft.Width >= 300)
            {
                dFrom = 300;
                dTo   = 70;

                dFrom2 = 0;
                dTo2   = -(dFrom - dTo);
            }
            else
            {
                dFrom   = 70;
                dTo     = 300;

                dFrom2  = -(dTo - dFrom);
                dTo2    = 0;
            }
            AnimationNavigation(dFrom, dTo, 0, 0);
        }

        private void xGrid_NavigationLeftMini_End(object sender, EventArgs e)
        {
            //xGrid_Contentchat.Visibility = Visibility.Visible;
        }
    }
}
