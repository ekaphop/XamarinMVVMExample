using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FavoriteTest.Models;

namespace FavoriteTest.Interface
{
    public interface IFavorite
    {
        Task<List<FavoriteItem>> GetFavoriteList();
    }
}
