using System;
using System.Collections.Generic;
using FavoriteTest.ViewModels.AAAListView;
using Xamarin.Forms;

namespace FavoriteTest.Views.AAAListView
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
