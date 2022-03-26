using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_foxchat.ViewModels;

namespace wpf_foxchat.Controllers
{
    public class MainViewController
    {
        private MainViewModel mViewModel;
        private MainChat      mView;

        public MainViewController()
        {
            InitMainViewModel();
        }

        public void InitMainViewModel()
        {
            mView      = new MainChat();
            mViewModel = new MainViewModel();

            mView.DataContext = mViewModel;

            mView.Show();
        }
    }
}
