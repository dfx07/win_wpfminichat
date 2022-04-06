using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

using wpf_foxchat.Com;

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
