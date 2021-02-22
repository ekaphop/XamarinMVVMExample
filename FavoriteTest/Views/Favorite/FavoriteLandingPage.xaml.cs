using System;
using System.Collections.Generic;
using FavoriteTest.ViewModels.Favorite;
using NewKMA.Services;
using Xamarin.Forms;

namespace FavoriteTest.Views.Favorite
{
    public partial class FavoriteLandingPage : ContentPage
    {
        public FavoriteLandingPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            InitialData();
            BindingContext = new FavoriteLandingPageViewModel(Navigation);
        }

        private void InitialData()
        {
            FontFavoriteUtils.UpdateFontStyles();
            FontUtils.UpdateFontStyles();
            FontSwiftUtils.UpdateFontStyles();

            try
            {
                FavoriteLandingPageAddNewDataImageButton.Source = ImageSource.FromResource("FavoriteTest.Images.Favorite.addFavorite.png");
            }
            catch (Exception ex)
            {

            }
        }

        void FavoriteListItemsListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
        }
    }
}
