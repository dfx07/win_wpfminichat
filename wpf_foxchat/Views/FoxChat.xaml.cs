using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_foxchat
{
    /// <summary>
    /// Interaction logic for FoxChat.xaml
    /// </summary>
    public partial class FoxChat : Window
    {
        public FoxChat()
        {
            InitializeComponent();
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
            if (e.LeftButton == MouseButtonState.Pressed )
            {
                double percentHorizontal = e.GetPosition(this).X / ActualWidth;
                double targetHorizontal = RestoreBounds.Width * percentHorizontal;

                double percentVertical = e.GetPosition(this).Y / ActualHeight;
                double targetVertical = RestoreBounds.Height * percentVertical;

                Left = e.GetPosition(null).X - targetHorizontal;
                Top = e.GetPosition(null).Y - targetVertical;

                WindowState = WindowState.Normal;
                DragMove();
            }
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                this.Maximize();
        }
    }
}
