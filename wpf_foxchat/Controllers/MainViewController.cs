using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf_foxchat.ViewModels;

namespace wpf_foxchat.Controllers
{
    public abstract class Controller
    {
        public BaseViewModel MainViewModel;
        public Window        MainView;

        public BaseViewModel GetMainView()
        {
            return MainViewModel;
        }
    }

    public class MainViewController : Controller
    {
        public MainViewController()
        {
            InitMainViewModel();
        }

        public void InitMainViewModel()
        {
            MainView      = new MainChat();
            MainViewModel = new MainViewModel(this);

            MainView.DataContext = MainViewModel;

            MainView.Show();
        }
    }
}
