using System.Windows;

namespace wpf_foxchat.ViewModels
{
    public abstract class BaseViewModel : BaseControl
    {
        // Thực hiện một vài thao tác với Dialog bình thường ở đây 
        private Window  window;

        public void SetWindow(Window win)
        {
            window = win;
        }

        public void Show()
        {
            if(window != null) window.Show();
        }

        public void ShowDialog()
        {
            if(window != null) window.ShowDialog();
        }
    }
}
