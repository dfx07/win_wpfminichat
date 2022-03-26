using System.Windows;
using System.Windows.Controls;

namespace wpf_foxchat.Controls
{
    public class CButton : Button
    {
        static CButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CButton),
                                    new FrameworkPropertyMetadata(typeof(CButton)));
        }

        public CButton()
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
                               DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(CButton),
                               new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));

        public CornerRadius BorderRadius
        {
            get { return (CornerRadius)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }
    }
}
