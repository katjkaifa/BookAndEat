using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class OrderTable: EntityInt, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int TableId { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }
}
