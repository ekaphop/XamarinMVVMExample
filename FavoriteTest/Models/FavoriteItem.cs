using System;
namespace FavoriteTest.Models
{
    public class FavoriteItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}