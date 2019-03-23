using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Models;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.Managers;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.Navigation;


namespace KMA.ProgrammingInCSharp2019.Practice7.UserList.ViewModels
{
    internal class AddUserViewModel : BaseViewModel
    {
        #region Fields
        private string _fName = "";
        private string _lName = "";
        private string _email = "";
        private DateTime _date = DateTime.Today;

        #region Commands
        private RelayCommand<object> _signInCommand;
        #endregion
        #endregion

        #region Properties
        public string FName
        {
            get { return _fName; }
            set
            {
                _fName = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }
        public string LName
        {
            get { return _lName; }
            set
            {
                _lName = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }
        public string EMAIL
        {
            get { return _email; }
            set
            {

                _email = value.Replace(" ", "Space");
                OnPropertyChanged();
            }
        }

        public DateTime DATE
        {
            get { return _date; }
            set
            {

                _date = value;
                OnPropertyChanged();


            }
        }

        #region Commands

        public RelayCommand<object> SignInCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand<object>(
                           Proceed, o => CanExecuteCommand()));
            }
        }



        #endregion
        #endregion

        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_fName) && !string.IsNullOrWhiteSpace(_lName)
                    && !string.IsNullOrWhiteSpace(_email);
        }


        private async void Proceed(object obj)
        {

            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
            {
                try
                {
                    var user = new User(_fName, _lName, _email, _date);
                    StationManager.DataStorage.AddUser(user);
                }
                catch (PersonException ex)
                {

                    MessageBox.Show($"Error: {ex.Message} {ex.Value}");
                }
            });
            LoaderManager.Instance.HideLoader();
            FName = "";
            LName = "";
            EMAIL = "";
            DATE = DateTime.Today;
            NavigationManager.Instance.Navigate(ViewType.Main);
        }
    }
}
