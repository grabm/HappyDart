using System.Windows.Controls;

namespace HappyDart.Desktop.Modules.SignIn
{
    public partial class SignInUserControl : UserControl
    {
        public SignInUserControl()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}