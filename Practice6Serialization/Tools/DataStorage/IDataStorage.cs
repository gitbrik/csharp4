using KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Tools.DataStorage
{
    internal interface IDataStorage
    {
        bool UserExists(string login);

        User GetUserByLogin(string login);

        void AddUser(User user);
    }
}
