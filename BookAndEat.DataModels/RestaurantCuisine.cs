using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class RestaurantCuisine: EntityInt, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
