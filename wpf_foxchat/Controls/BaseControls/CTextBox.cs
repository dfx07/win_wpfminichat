using System.Windows;
using System.Windows.Controls;

namespace wpf_foxchat.Controls
{
    public class CTextBox : TextBox
    {
        static CTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CTextBox),
                                    new FrameworkPropertyMetadata(typeof(CTextBox)));
        }

        public CTextBox()
        {
            InitializeCornerButton();
        }

        private void InitializeCornerButton()
        {

        }

        //========================================== Additional attributes ======================================//
        /// <summary>
        ///  Thuộc tính BorderRadius
        /// </summary>
        public static readonly DependencyProperty BorderRadiusProperty =
                       DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(CTextBox),
                       new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));

        public CornerRadius BorderRadius
        {
            get { return (CornerRadius)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }

        /// <summary>
        ///  Thuộc tính Placeholder
        /// </summary>
        public static readonly DependencyProperty PlaceholderProperty =
                       DependencyProperty.Register("Placeholder", typeof(string), typeof(CTextBox),
                       new PropertyMetadata(default(string)));

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }
    }
}
