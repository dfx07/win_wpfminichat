using System;
using System.Collections;
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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpf_foxchat.ViewModels;

namespace wpf_foxchat.Controls
{
    /// <summary>
    /// Interaction logic for CConversation.xaml
    /// </summary>
    public partial class CConversation : UserControl
    {
        public CConversation()
        {
            InitializeComponent();
        }

        private void POPUP_React_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        public static IEnumerable<Popup> GetOpenPopups()
        {
            return PresentationSource.CurrentSources.OfType<HwndSource>()
                .Select(h => h.RootVisual)
                .OfType<FrameworkElement>()
                .Select(f => f.Parent)
                .OfType<Popup>()
                .Where(p => p.IsOpen);
        }


        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
                              DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(CConversation), new PropertyMetadata(null));

    }
}
