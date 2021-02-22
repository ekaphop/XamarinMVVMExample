using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FavoriteTest.Views.Favorite
{
    public partial class FavoriteTabBarItem : ContentView
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                propertyName: nameof(Text),
                returnType: typeof(string),
                declaringType: typeof(FavoriteTabBarItem),
                defaultValue: null,
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: TextPropertyChanged);

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public static readonly BindableProperty IsSelectedProperty =
            BindableProperty.Create(
                propertyName: nameof(IsSelected),
                returnType: typeof(bool),
                declaringType: typeof(FavoriteTabBarItem),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: IsSelectedPropertyChanged);

        public int Index
        {
            get { return (int)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }

        public static readonly BindableProperty IndexProperty =
            BindableProperty.Create(
                propertyName: nameof(Index),
                returnType: typeof(int),
                declaringType: typeof(FavoriteTabBarItem),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: IndexPropertyChanged);


        public TapGestureRecognizer TapGesture
        {
            get { return Item_Clicked; }
        }

        public FavoriteTabBarItem()
        {
            InitializeComponent();
        }

        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FavoriteTabBarItem control)
            {
                var oValue = oldValue as string;
                if (newValue is string nValue)
                {
                    control.TabName.Text = nValue;
                    control.TabNameBold.Text = nValue;
                }
                else
                {
                    control.TabName.Text = oValue;
                    control.TabNameBold.Text = oValue;
                }
            }
        }

        private static void IsSelectedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FavoriteTabBarItem control)
            {
                if (newValue is bool nValue)
                {
                    control.YellowLine.IsVisible = nValue;

                    if (nValue)
                    {
                        control.TabName.IsVisible = false;
                        control.TabNameBold.IsVisible = true;
                    }
                    else
                    {
                        control.TabNameBold.IsVisible = false;
                        control.TabName.IsVisible = true;
                    }
                }
                else
                {
                    control.YellowLine.IsVisible = oldValue == null ? false : (bool)oldValue;
                }
            }
        }

        private static void IndexPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is FavoriteTabBarItem control)
            {
                if (newValue is int nValue)
                {
                    control.TabName.AutomationId = $"lbl_{nValue}";
                    control.TabNameBold.AutomationId = $"lbl_{nValue}_bold";
                }
            }
        }
    }
}
