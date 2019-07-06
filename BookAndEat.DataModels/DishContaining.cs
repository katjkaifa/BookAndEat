using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class DishContaining : EntityInt, IHasCreationTime
    {
        public double Quantity { get; set; }
        public DateTime CreationTime { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}
