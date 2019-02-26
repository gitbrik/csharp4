using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Views
{
    public partial class MainView : UserControl, INavigatable
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); 
        }
    }
}
