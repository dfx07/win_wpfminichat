using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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


        /// <summary>
        ///  Thuộc tính GradientStartColor
        /// </summary>
        public static readonly DependencyProperty GradientStartColorProperty =
                               DependencyProperty.Register("GradientStartColor", typeof(Color), typeof(CButton),
                               new PropertyMetadata(default(Color)));

        public Color GradientStartColor
        {
            get { return (Color)GetValue(GradientStartColorProperty); }
            set { SetValue(GradientStartColorProperty, value); }
        }


        /// <summary>
        ///  Thuộc tính GradientEndColor
        /// </summary>
        public static readonly DependencyProperty GradientEndColorProperty =
                               DependencyProperty.Register("GradientEndColor", typeof(Color), typeof(CButton),
                               new PropertyMetadata(default(Color)));

        public Color GradientEndColor
        {
            get { return (Color)GetValue(GradientEndColorProperty); }
            set { SetValue(GradientEndColorProperty, value); }
        }
    }
}
