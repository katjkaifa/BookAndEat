using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class RestaurantType: EntityInt, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
