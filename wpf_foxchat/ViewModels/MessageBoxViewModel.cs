using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf_foxchat.Controls;

namespace wpf_foxchat.ViewModels
{
    class MessageBoxViewModel : BaseViewModel
    {
        public MessageBoxViewModel()
        {
            CWindow win       = new CWindow();
            win.Width = 300;
            win.Height = 200;
            CMessageBox view = new CMessageBox();
            win.Content_Control.Children.Add(view);
            //view.DataContext = this;
            SetWindow(win);
        }
    }
}
