using Organization.Model;
using Organization.ViewModel;
using System.Windows;

namespace Organization
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            //DepTextCol = Departments
        }
    }
}
