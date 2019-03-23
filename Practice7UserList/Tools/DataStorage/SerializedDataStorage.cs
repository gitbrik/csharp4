using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Models;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.Managers;

namespace KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.DataStorage
{
    internal class SerializedDataStorage:IDataStorage
    {
        private  List<User> _users;

        internal SerializedDataStorage()
        {
            try
            {
                _users = SerializationManager.Deserialize<List<User>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _users = new List<User>();
            }
        }
        

        public void AddUser(User user)
        {
            foreach (User u in _users)
                if (u.Email == user.Email)
                {
                    MessageBox.Show("Email is already used");
                    return;
                }
            _users.Add(user);
            SaveChanges();
        }
        public void removeUser(string mail)
        {
            foreach (User u in _users)
                if (u.Email == mail)
                {
                    _users.RemoveAt(_users.IndexOf(u));
                    SaveChanges();
                    return;
                }

            MessageBox.Show("User not found");
        }

        public List<User> UsersList
        {
            get { return _users; }
            set
            {
                _users = value;
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        }
        
    }
}

