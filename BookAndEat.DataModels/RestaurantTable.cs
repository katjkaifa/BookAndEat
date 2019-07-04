using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class RestaurantTable: EntityInt, IHasCreationTime
    {
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }

        public int RestaurantHallId { get; set; }
        public RestaurantHall RestaurantHall { get; set; }

        public List<OrderTable> OrderTables { get; set; }
    }
}
