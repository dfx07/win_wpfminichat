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
using wpf_foxchat.ViewModels;

namespace wpf_foxchat.Controls
{
    /// <summary>
    /// Interaction logic for CReaction.xaml
    /// </summary>
    public partial class CReaction : UserControl
    {
        public CReaction()
        {
            InitializeComponent();
        }

        private void Btn_React_Click(object sender, RoutedEventArgs e)
        {
            var popup = Utils.FindParent<Popup>(sender as Button);
            if (popup != null)
            {
                popup.IsOpen = false;
            }
        }
    }
}
