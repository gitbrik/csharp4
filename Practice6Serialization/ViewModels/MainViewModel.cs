using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools;
using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.Managers;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public string CurrentUser
        {
            get
            {
                return $"Current User {StationManager.CurrentUser}";
            }
        }
        
    }
}
