using System.Windows;
using wpf_foxchat.Com;

namespace wpf_foxchat.Controls
{
    //==========================================================================
    // Class : CommonControl                                                    
    // Các control sẽ có các thuộc tính chung này                               
    //==========================================================================
    public class CommonControl : BindableBase
    {
        public CommonControl()
        {
            IsEnabled  = true;
            Visibility = Visibility.Visible;
        }

        private bool _IsEnabled;         // Enable - Disable control 
        public bool IsEnabled
        {
            get { return _IsEnabled; }
            set
            {
                _IsEnabled = value;
                RaisePropertyChanged("IsEnabled");
            }
        }

        private Visibility _Visibility;     // Hiden - Show control 
        public Visibility Visibility
        {
            get { return _Visibility; }
            set
            {
                _Visibility = value;
                RaisePropertyChanged("Visibility");
            }
        }
    }

    //==========================================================================
    // Class : ButtonVM                                                         
    // Thuộc tính Button sẽ được Bidding                                        
    //==========================================================================
    public class ButtonVM : CommonControl
    {
        public ButtonVM(): base()
        {

        }
    }

    //==========================================================================
    // Class : TextBoxVM                                                        
    // Thuộc tính TextBox sẽ được Bidding                                       
    //==========================================================================
    public class TextBoxVM : CommonControl
    {
        private bool _Focus;            // Focus - LostFocus control 
        public bool Focus
        {
            get { return _Focus; }
            set
            {
                _Focus = value;
                RaisePropertyChanged("Focus");
            }
        }

        private string _Text;         // String control 
        public string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                RaisePropertyChanged("Text");
            }
        }
    }
}
