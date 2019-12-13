using Bashana.Services.Interface;
using NguniLearning2.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace Bashana.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {

        private ObservableCollection<UserDetails> _userList;
        private IDatabase _database;

        public ObservableCollection<UserDetails> UserList
        {
            get { return _userList; }
            set { SetProperty(ref _userList, value); }
        }

        string _UserName;
        private IDatabase database;

        public string UserName
        {
            get { return _UserName; }
            set { SetProperty(ref _UserName, value); }
        }


        public Page1ViewModel(INavigationService navigationService) : base(navigationService)
        {

            UserName = Preferences.Get("Name", UserName);

            _database = database;

        }


        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            var userDetails = await _database.GetSortedData();

            UserList = new ObservableCollection<UserDetails>(userDetails);
        }
    }

}
