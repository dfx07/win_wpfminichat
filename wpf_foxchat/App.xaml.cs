using System.Windows;
using wpf_foxchat.Controllers;


namespace wpf_foxchat
{
    public partial class App : Application
    {
        private MainViewController MainController;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Khởi tạo điều khiển sang màn hình chính
            MainController = new MainViewController();
        }
    }
}
