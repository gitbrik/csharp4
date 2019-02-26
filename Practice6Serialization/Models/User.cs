using System;

namespace KMA.ProgrammingInCSharp2019.Practice6.Serialization.Models
{
    [Serializable]
    internal class User
    {
        #region Fields
        private Guid _guid;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _login;
        private string _password;
        #endregion

        #region Properties
        internal Guid Guid
        {
            get
            {
                return _guid;
            }
            private set
            {
                _guid = value;
            }
        }
        internal string FirstName
        {
            get
            {
                return _firstName;
            }
            private set
            {
                _firstName = value;
            }
        }
        internal string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                _lastName = value;
            }
        }
        internal string Email
        {
            get
            {
                return _email;
            }
            private set
            {
                _email = value;
            }
        }

        internal string Login
        {
            get
            {
                return _login;
            }
            private set
            {
                _login = value;
            }
        }
        private string Password
        {
            get
            {
                return _password;
            }
        }
        #endregion

        #region Constructor

        public User(string firstName, string lastName, string email, string login, string password)
        {
            _guid = Guid.NewGuid();
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _login = login;
            SetPassword(password);
        }
        #endregion

        private void SetPassword(string password)
        {
            //TODO Add encription
            _password = password;
        }

        internal bool CheckPassword(string password)
        {
            //TODO Compare encrypted passwords
            return _password == password;
        }
        
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
