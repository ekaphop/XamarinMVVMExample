using System;
using FavoriteTest.ViewModels.Base;

namespace FavoriteTest.DTO.Favorite
{
    public class FavoriteTabBarEntity : ExtendedBindableObject
    {
        private string _tabName;
        public string TabName
        {
            get => _tabName;
            set
            {
                _tabName = value;
                OnPropertyChanged(nameof(TabName));
            }
        }

        private FavoriteTabType _type;
        public FavoriteTabType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }
}
