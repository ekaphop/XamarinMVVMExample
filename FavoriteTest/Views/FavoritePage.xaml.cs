using System;
using System.Collections.Generic;
using System.Net.Http;
using FavoriteTest.Interface;
using FavoriteTest.Models;
using FavoriteTest.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FavoriteTest.Views
{
    public partial class FavoritePage : ContentPage
    {
        public FavoritePage(string userName)
        {
            InitializeComponent();
            //GetFavoriteList();

            BindingContext = new FavoritePageViewModel(userName);
        }

        //public async void GetFavoriteList()
        //{
        //    var url = "https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes";
        //    var httpClient = new HttpClient();
        //    var response = await httpClient.GetStringAsync(url);
        //    var favoriteLists = JsonConvert.DeserializeObject<List<FavoriteItem>>(response);
        //    //FavoriteListView.ItemsSource = favoriteLists;
        //}
    }
}
