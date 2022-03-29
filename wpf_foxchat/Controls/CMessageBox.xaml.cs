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
    // Image hiển thị cùng thông báo
    public enum CMessageIcon
    {
        INFORMATION,
        WARNING,
        ERROR,
        QUESTION,
        SUCCESS
    }

    // Trạng thái các button hiển thị cùng thông báo
    public enum CMessageButton
    {
        OK,
        OK_CANCEL,
        OK_CANCEL_RETRY,
    }



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
