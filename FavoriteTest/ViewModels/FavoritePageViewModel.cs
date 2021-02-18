using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using FavoriteTest.Interface;
using FavoriteTest.Models;
using FavoriteTest.SAL;
using Newtonsoft.Json;

namespace FavoriteTest.ViewModels
{
    public class FavoritePageViewModel : BaseViewModel
    {
        private string _loginUser;

        public string LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; }
        }

        public ObservableCollection<FavoriteItem> ObserveFavoriteItems { get; set; }

        public FavoritePageViewModel(string parameter)
        {
            _loginUser = parameter;
            ObserveFavoriteItems = new ObservableCollection<FavoriteItem>();

            GetFavoriteList();

            //FavoriteService favoriteService = new FavoriteService();
            //var listAPIItems = await favoriteService.GetFavoriteList();
        }

        public async void GetFavoriteList()
        {
            var url = "https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes";
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url);
            var listItems = JsonConvert.DeserializeObject<List<FavoriteItem>>(response);

            foreach (var item in listItems)
            {
                ObserveFavoriteItems.Add(item);
            }
        }
    }
}
