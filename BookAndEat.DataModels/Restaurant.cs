using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Restaurant: EntityInt, IAudited
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Photo { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public List<RestaurantPhoto> RestaurantPhotos { get; set; }
        public List<RestaurantCuisine> RestaurantCuisines { get; set; }
        public List<RestaurantType> RestaurantTypes { get; set; }
        public List<Dish> Dishes { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<RestaurantHall> RestaurantHalls { get; set; }
        public List<UserComment> UserComments { get; set; }
        public List<UserFavourite> UserFavourites { get; set; }
        public List<Order> Orders { get; set; }
    }
}
