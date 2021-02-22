using System;
namespace FavoriteTest.DTO.Favorite
{
    public class FavoriteItemsEntity
    {
        public string FavoriteImageUrl { get; set; }
        public string FavoriteNickName { get; set; }
        public string FavoriteAccountNo { get; set; }

        public int FavoriteNickNameColSpan { get; set; }

        public bool IsViewMode { get; set; }
        public bool IsEditMode { get; set; }
    }
}
