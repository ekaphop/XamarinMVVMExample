using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FavoriteTest.DTO.Favorite;
using Xamarin.Forms;

namespace FavoriteTest.Views.Favorite
{
    public partial class FavoriteTabBar : ContentView
    {
        private int selectedIndex;

        public Command<FavoriteTabType> ItemClickedCommand
        {
            get { return (Command<FavoriteTabType>)GetValue(ItemClickedCommandProperty); }
            set { SetValue(ItemClickedCommandProperty, value); }
        }

        public static readonly BindableProperty ItemClickedCommandProperty =
            BindableProperty.Create(
                propertyName: nameof(ItemClickedCommand),
                returnType: typeof(Command<FavoriteTabType>),
                declaringType: typeof(FavoriteTabBar),
                defaultValue: null,
                defaultBindingMode: BindingMode.OneWay);

        public ObservableCollection<FavoriteTabBarEntity> ItemsSource
        {
            get { return (ObservableCollection<FavoriteTabBarEntity>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                propertyName: nameof(ItemsSource),
                returnType: typeof(ObservableCollection<FavoriteTabBarEntity>),
                declaringType: typeof(FavoriteTabBar),
                defaultValue: null,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: ItemsSourcePropertyChanged);

        public FavoriteTabBar()
        {
            InitializeComponent();
        }

        private void CreateTabbedBar()
        {
            TabBar.Children.Clear();

            var itemCount = 0;
            foreach (FavoriteTabBarEntity item in ItemsSource)
            {
                if (itemCount == 0)
                {
                    selectedIndex = 0;
                    item.IsSelected = true;
                }

                TabBar.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                var tmp = new FavoriteTabBarItem
                {
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Text = item.TabName,
                    Index = itemCount + 1
                };

                tmp.SetBinding(FavoriteTabBarItem.IsSelectedProperty, new Binding() { Source = item, Path = "IsSelected" });
                tmp.TapGesture.Command = new Command<int>((x) => ItemClicked(x));
                tmp.TapGesture.CommandParameter = itemCount;
                tmp.TapGesture.AutomationId = $"tap_{itemCount + 1}";
                TabBar.Children.Add(tmp, itemCount, 0);
                itemCount++;
            }
        }

        public void TabbedBarScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            var scrollX = TabbedBarScrollView.ScrollX;
            if (scrollX <= 0)
            {
                TabbedBarScrollView.ScrollToAsync(0, 0, false);
                return;
            }

            double scrollingSpace = TabbedBarScrollView.ContentSize.Width - TabbedBarScrollView.Width;

            if (scrollingSpace <= e.ScrollX)
            {
                TabbedBarScrollView.ScrollToAsync(scrollingSpace, 0, false);
            }
        }

        public void ItemClicked(int index)
        {
            if (index == selectedIndex) return;

            if (index < ItemsSource.Count)
            {
                ItemsSource[index].IsSelected = true;
                ItemsSource[selectedIndex].IsSelected = false;
                selectedIndex = index;

                ItemClickedCommand?.Execute(ItemsSource[selectedIndex].Type);
            }
        }


        private static void ItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FavoriteTabBar control)
            {
                var oValue = oldValue as ObservableCollection<FavoriteTabBarEntity>;
                if (newValue is ObservableCollection<FavoriteTabBarEntity> nValue)
                {
                    control.ItemsSource = nValue;
                    if (control.ItemsSource != null && control.ItemsSource.Count > 0)
                    {
                        control.CreateTabbedBar();
                    }
                }
                else
                {
                    control.ItemsSource = oValue;
                }
            }
        }
    }
}