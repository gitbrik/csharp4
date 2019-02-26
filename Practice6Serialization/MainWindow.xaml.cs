using System.Windows;
using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IContentOwner
    {
        public ContentControl ContentControl {
            get { return _contentControl; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            StationManager.Initialize(new SerializedDataStorage());
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.SignIn);
        }
    }
}
