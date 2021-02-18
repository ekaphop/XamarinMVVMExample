using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FavoriteTest.Views;
using Xamarin.Forms;

namespace FavoriteTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }
        public ICommand PopupAlertCommand { get; set; }

        public INavigation _navigation;

        public string UserName
        {
            get => _userName; 
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        private string _userName;

        public MainViewModel(INavigation navigation)
        {
            LoginCommand = new Command(Login);
            PopupAlertCommand = new Command(PopupAlert);

            _navigation = navigation;
        }


        private void Login()
        {
            _navigation.PushAsync(new FavoritePage(_userName));
        }

        private void PopupAlert()
        {
            App.Current.MainPage.DisplayAlert("Title Nakrub", "Message: "+_userName, "Back");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
