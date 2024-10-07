using System.Windows;

namespace HappyDart.Desktop.Modules.Main
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }
    }
}