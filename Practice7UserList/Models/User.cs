using System;
using System.Text.RegularExpressions;

namespace KMA.ProgrammingInCSharp2019.Practice7.UserList.Models
{
    [Serializable]
    internal class User
    {
        private string _fName;
        private string _lName;
        private string _email;
        private DateTime _date = DateTime.Today;

        private readonly bool _isAdult;
        private readonly string _sunSign;
        private readonly string _chineseSign;
        private readonly bool _isBirthday;
        private readonly string[] _chineseZodiaks = new string[]
        {
            "Щур", "Бик", "Тигр", "Кролик", "Дракон", "Змія", "Кінь", "Коза",
            "Мавпа", "Півень", "Собака", "Свиня"
        };
        private readonly string[] _zodiaks = new string[]
        {
            "Овен", "Телець", "Близнюки", "Рак", "Лев", "Діва", "Ваги",
            "Скорпіон", "Стрелець", "Козерог", "Водолій", "Риби"
        };


         internal User(string fName, string lName, string email, DateTime date)
        {
            _fName = fName;
            _lName = lName;
            _email = ValidateEmail(email);
            _date = date;
            _isAdult = CountAge() >= 18;
            _isBirthday = IsBirthday();
            _sunSign = CalculateSign();
            _chineseSign = CalculateChineseSign();
        }

        public User(string fName, string lName, string email)
        {
            _fName = fName;
            _lName = lName;
            _email = email;
        }

        public User(string fName, string lName, DateTime date)
        {
            _fName = fName;
            _lName = lName;
            _date = date;
            _isAdult = CountAge() >= 18;
            _isBirthday = IsBirthday();
            _sunSign = CalculateSign();
            _chineseSign = CalculateChineseSign();
        }

        private int CountAge()
        {
            int age = (DateTime.Today - _date).Days / 365;
            if (age >= 130)
            {
                throw new PersonException("Looks like u`r dead X(. Your age can`t be " +
                                          $"more than 135 and lower than 0. You entered: ", age.ToString());
            }
            else if (DateTime.Today < _date)
            {
                throw new PersonException("Looks like u`r not born yet. Your age can`t be " +
                                          $"more than 135 and lower than 0. You entered: ", age.ToString());
            }
            else
            {
                return age;
            }
        }

        private bool IsBirthday()
        {
            return _date.Day == DateTime.Today.Day && _date.Month == DateTime.Today.Month;
        }

        public string FirstName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string LastName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public bool IsAdult
        {
            get { return _isAdult; }
        }
        public string SunSign
        {
            get { return _sunSign; }
        }
        public string ChineseSign
        {
            get { return _chineseSign; }
        }
        public bool IsBirthdayGet
        {
            get { return _isBirthday; }
        }

        private string CalculateChineseSign()
        {
            return _chineseZodiaks[(_date.Year - 4) % 12];
        }
        private string CalculateSign()
        {
            return _zodiaks[(_date.Year - 4) % 12];
        }

        private string ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return email;
            throw new PersonException("Email is not valid. Must be like: xxxxxx@xxxx.com. You entered: ", email);
        }

    }
    class PersonException : ArgumentException
    {
        public string Value { get; }
        public PersonException(string message, string val)
            : base(message)
        {
            Value = val;
        }

    }
}
