using System.Windows;
using System.Windows.Controls;

namespace wpf_foxchat.Controls
{
    public class FButton: Button
    {
        static FButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FButton),
               new FrameworkPropertyMetadata(typeof(FButton)));
        }

        public FButton()
        {
            InitializeCornerButton();
        }

        private void InitializeCornerButton()
        {

        }

        public static readonly DependencyProperty BorderRadiusProperty =
                       DependencyProperty.Register("BorderRadius", typeof(CornerRadius), typeof(FButton),
                           new PropertyMetadata(new CornerRadius(0, 0, 0, 0)));

        public CornerRadius BorderRadius
        {
            get { return (CornerRadius)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }

    }
}
