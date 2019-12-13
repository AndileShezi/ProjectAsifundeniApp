using Bashana.Services.Interface;
using NguniLearning2.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace Bashana.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private IDatabase _database;

        string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        private UserDetails _latestDetails;
        public UserDetails LatestDetails
        {
            get { return _latestDetails; }
            set { SetProperty(ref _latestDetails, value); }
        }


        public DelegateCommand LoginCommand { get; set; }




        private async void Login()
        {
            Preferences.Set("Name", UserName);
            Preferences.Set("Password", Password);

            await NavigationService.NavigateAsync("Page1");

                     
        }


        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Asifundeni";



            LoginCommand = new DelegateCommand(() => Login());

        }

    }
}
