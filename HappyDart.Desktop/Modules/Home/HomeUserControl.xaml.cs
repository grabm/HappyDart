using System.Windows.Controls;

namespace HappyDart.Desktop.Modules.Home
{
    /// <summary>
    /// Interaction logic for HomeUserControl.xaml
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
            DataContext = new HomeViewModel();
        }
    }
}