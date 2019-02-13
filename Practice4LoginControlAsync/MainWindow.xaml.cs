using System.Windows;
using KMA.ProgrammingInCSharp2019.Practice4.LoginControlAsync.ViewModels;

namespace KMA.ProgrammingInCSharp2019.Practice4.LoginControlAsync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
