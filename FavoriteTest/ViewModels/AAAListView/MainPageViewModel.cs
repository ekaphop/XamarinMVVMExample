﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using FavoriteTest.Models.AAAListView;
using Xamarin.Forms;

namespace FavoriteTest.ViewModels.AAAListView
{
    public class MainPageViewModel : BindableObject
    {
        private ObservableCollection<OffersModel> _CollectionsList;
        public ObservableCollection<OffersModel> CollectionsList
        {
            get
            {
                return _CollectionsList;
            }
            set
            {
                _CollectionsList = value;
                OnPropertyChanged();
            }
        }

        public ICommand DeleteCommand { get; }
        public ICommand AddCommand { get; }

        public MainPageViewModel()
        {
            CollectionsList = new ObservableCollection<OffersModel>()
            {
                new OffersModel{ Name= "MM50"},
                new OffersModel{ Name= "MM50123"},
                new OffersModel{ Name= "MM50111"},
                new OffersModel{ Name= "MM50356"},
            };

            DeleteCommand = new Command(OnDeleteTapped);

            AddCommand = new Command(AddItmes);
        }

        private void AddItmes(object obj)
        {
            OffersModel offersModel = new OffersModel
            {
                Name = "New Item Added " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")
            };
            CollectionsList.Add(offersModel);
        }

        private void OnDeleteTapped(object obj)
        {
            var content = obj as OffersModel;
            CollectionsList.Remove(content);
        }
    }
}