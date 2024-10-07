using HappyDart.Desktop.Modules.Home;
using HappyDart.Desktop.Modules.SignIn;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace HappyDart.Desktop.Modules.Main
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private object _currentViewModel = new SignInViewModel();
        public object CurrentViewModel
        {
            get => _currentViewModel;
            set 
            {
                _currentViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentViewModel)));
            } 
        }

        // "Zainteresowany tym eventem" jest każdy element graficzny WPFa, czyli WPF podpina metodę która aktualizuje kontrolkę wartością podpiętej właściwości z klasy przypisanej do DataContext
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
        }
    }
}