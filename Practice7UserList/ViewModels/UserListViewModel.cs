using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Models;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Properties;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.DataStorage;
using KMA.ProgrammingInCSharp2019.Practice7.UserList.Tools.Managers;

namespace KMA.ProgrammingInCSharp2019.Practice7.UserList.ViewModels
{
     class UserListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<User> _users;
        private Thread _workingThread;
        private CancellationToken _token;
        private CancellationTokenSource _tokenSource;


        public ObservableCollection<User> Users
        {
            get => _users;
            set
            {
                _users = value;
               
                OnPropertyChanged();
                
            }
        }


        internal UserListViewModel()
        {
            if (!StationManager.DataStorage.UsersList.Any())
            {
                for (int i = 1; i <= 50; i++)
                    StationManager.DataStorage.AddUser(new User("FirstNAme" + i, "LastNAme" + i, i + "@email.com", DateTime.Today));
            }
            _users = new ObservableCollection<User>(StationManager.DataStorage.UsersList);
            _tokenSource = new CancellationTokenSource();
            _token = _tokenSource.Token;
            StartWorkingThread();
            StationManager.StopThreads += StopWorkingThread;
        }

        private void StartWorkingThread()
        {
            _workingThread = new Thread(WorkingThreadProcess);
            _workingThread.Start();
        }


        
        private void WorkingThreadProcess()
        {
            int i = 0;
            while (!_token.IsCancellationRequested)
            {
                
                if (_users.Count < new ObservableCollection<User>(StationManager.DataStorage.UsersList).Count)
               Refresh();
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(50);
                    if (_token.IsCancellationRequested)
                    {
                        
                        break;
                    }
                }

                if (_token.IsCancellationRequested)
                {
                    
                    break;
                }

                i++;
            }
            
        }
        private async void Refresh()
        {
            LoaderManager.Instance.ShowLoader();
            await Task.Run(() =>
            {
                Users = new ObservableCollection<User>(StationManager.DataStorage.UsersList);
            });
             LoaderManager.Instance.HideLoader();
        }

        internal void StopWorkingThread()
        {
            _tokenSource.Cancel();
            _workingThread.Join(2000);
            _workingThread.Abort();
            _workingThread = null;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}