namespace KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.Navigation
{
    internal enum ViewType
    {
        AddUser,
        DeleteUser,
        Main
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
