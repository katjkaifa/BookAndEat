using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Restaurant: IHasStringId, IAudited
    {
        public string Id { get; set; }
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
    }
}
