using System;
using System.Collections.Generic;
using FavoriteTest.ViewModels.AAAListView;
using Xamarin.Forms;

namespace FavoriteTest.Views.AAAListView
{
    public partial class HumanPage : ContentPage
    {
        public HumanPage()
        {
            InitializeComponent();
            BindingContext = new HumanViewModels();
        }
    }
}
