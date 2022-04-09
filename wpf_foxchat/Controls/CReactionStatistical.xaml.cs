using System.Collections;
using System.Windows;
using System.Windows.Controls;


namespace wpf_foxchat.Controls
{
    /// <summary>
    /// Interaction logic for CReactionStatiscal.xaml
    /// </summary>
    public partial class CReactionStatiscal : UserControl
    {
        public CReactionStatiscal()
        {
            InitializeComponent();
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
                              DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(CReactionStatiscal), new PropertyMetadata(null));
    }
}
