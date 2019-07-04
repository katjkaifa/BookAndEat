using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class RestaurantHall: EntityInt, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<RestaurantTable> RestaurantTables { get; set; }
    }
}
