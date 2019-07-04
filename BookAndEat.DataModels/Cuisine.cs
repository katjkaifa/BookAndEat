using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Cuisine : EntityInt, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }

        public List<RestaurantCuisine> RestaurantCuisines { get; set; }
    }
}
