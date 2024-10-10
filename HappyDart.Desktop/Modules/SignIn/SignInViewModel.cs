using HappyDart.Desktop.Commands;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace HappyDart.Desktop.Modules.SignIn
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SignInButtonCommand { get; }
        public SignInViewModel()
        {
            SignInButtonCommand = new RelayCommand(ExecudeLogIn);
        }

        public void ExecudeLogIn()
        {
            MessageBox.Show("kliknąłem ExecudeLogIn");
        }
    }
}