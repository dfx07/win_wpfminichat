using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_foxchat.Controls
{
    /// <summary>
    /// Interaction logic for CMessage.xaml
    /// </summary>
    public partial class CMessageBox : UserControl
    {
        public CMessageBox()
        {
            InitializeComponent();
        }

        //================== Phần thuộc tính sẽ thêm vào UserControl Custom  ==================//
        /// <summary>
        /// Thuộc tính BorderRadius
        /// </summary>
        public static readonly DependencyProperty BorderRadiusProperty =
                       DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(CMessageBox),
                       new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));

        public CornerRadius BorderRadius
        {
            get { return (CornerRadius)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }
    }
}
