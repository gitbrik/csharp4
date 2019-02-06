using System.Windows.Controls;

namespace KMA.ProgrammingInCSharp2019.Practice3.LoginControlMVVM
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SignInControl : UserControl
    {
        public SignInControl()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
