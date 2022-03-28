using wpf_foxchat.Controllers;

namespace wpf_foxchat.ViewModels
{
    class MessageBoxViewModel : BaseViewModel
    {
        public MessageBoxViewModel(Controller ctrl, BaseViewModel parent): base(ctrl)
        {
            if (CreateDialog( DlgType.DLG_MESSAGE_BOX, parent))
            {
                // Khởi tạo dialog thành công
            }
        }

        public override bool OnInitControl()
        {
            return true;
        }

        public override bool OnInitData()
        {
            return true;
        }
    }
}
