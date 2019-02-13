using System.Windows.Controls;
using KMA.ProgrammingInCSharp2019.Practice4.LoginControlAsync.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2019.Practice4.LoginControlAsync.Views.Authentication
{
    public partial class SignInControl : UserControl
    {
        internal SignInControl()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
