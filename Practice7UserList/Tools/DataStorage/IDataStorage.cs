using System.Collections.Generic;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Models;

namespace KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.DataStorage
{
    internal interface IDataStorage
    {
        void SaveChanges();
        void AddUser(User user);
        List<User> UsersList { get; set; }
    }
}
