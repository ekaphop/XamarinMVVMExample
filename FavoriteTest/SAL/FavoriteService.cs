using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FavoriteTest.Interface;
using FavoriteTest.Models;
using Newtonsoft.Json;

namespace FavoriteTest.SAL
{
    public class FavoriteService
    {
        public async Task<List<FavoriteItem>> GetFavoriteList()
        {
            var url = "https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes";
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<FavoriteItem>>(response);
        }
    }
}
