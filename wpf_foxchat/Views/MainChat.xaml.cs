using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using wpf_foxchat.Com;
using wpf_foxchat.ViewModels;

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
            Loaded += new RoutedEventHandler(MainChat_Loaded);
        }

        private void DefaultSetting()
        {
            //VisiblePopupDialog = Visibility.Collapsed;
        }

        private void MainChat_Loaded(object sender, RoutedEventArgs e)
        {
            MainViewModel model = DataContext as MainViewModel;
            model.SCW_Conversation = xSCW_Conversation;
            xSCW_Conversation.ScrollToBottom();
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

        static void SwapDouble(ref double num1, ref double num2)
        {
            double temp;

            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        void AnimationNavigation(bool bExpand, double _timeduration)
        {
            Storyboard storyboard = new Storyboard();

            double _from    = 70, _to    = 300;
            double _fromOpa = 0 , _toOpa = 1;
            if(!bExpand)
            {
                SwapDouble(ref _from   , ref _to   );
                SwapDouble(ref _fromOpa, ref _toOpa);
            }

            DoubleAnimation dbAnima = new DoubleAnimation();
            dbAnima.From        = _from;
            dbAnima.To          = _to;
            dbAnima.Duration    = new Duration(TimeSpan.FromSeconds(_timeduration));
            dbAnima.AutoReverse = false;
            dbAnima.Completed  += xGrid_NavigationLeftMini_End;

            PowerEase easingFunction  = new PowerEase();
            easingFunction.EasingMode = EasingMode.EaseOut;
            dbAnima.EasingFunction    = easingFunction;

            storyboard.Children.Add(dbAnima);

            Storyboard.SetTargetName(dbAnima, xGrid_NavigationLeft.Name);
            Storyboard.SetTargetProperty(dbAnima, new PropertyPath("Width"));


            dbAnima = new DoubleAnimation();
            dbAnima.From = _fromOpa;
            dbAnima.To   = _toOpa;
            dbAnima.Duration = new Duration(TimeSpan.FromSeconds(_timeduration));
            dbAnima.AutoReverse = false;

            easingFunction = new PowerEase();
            easingFunction.EasingMode = EasingMode.EaseOut;
            dbAnima.EasingFunction = easingFunction;

            storyboard.Children.Add(dbAnima);

            Storyboard.SetTargetName(dbAnima, xLAB_UserName.Name);
            Storyboard.SetTargetProperty(dbAnima, new PropertyPath("Opacity"));

            storyboard.Begin(this);
        }

        private void BTN_MininaviClick(object sender, RoutedEventArgs e)
        {
            bool bExpand = true;
            if (xGrid_NavigationLeft.Width >= 300)
            {
                bExpand = false;
            }

            AnimationNavigation(bExpand, 0.5);
        }

        private void xGrid_NavigationLeftMini_End(object sender, EventArgs e)
        {
            //xLAB_UserName.Visibility = Visibility.Collapsed;
        }

        private void CScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scrollViewer = sender as ScrollViewer;
            scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            if (e.VerticalChange == 0)
            {
                scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            }
        }

        private void CTBX_TextSend_KeyDown(object sender, KeyEventArgs e)
        {
            MainViewModel model = DataContext as MainViewModel;
            model.CTBX_TextSend_KeyDown(sender, e);
        }
    }
}
