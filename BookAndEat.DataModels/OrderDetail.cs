using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    // TODO: Add to DB
    public class OrderDetail: EntityInt, IAudited
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int GuestNo { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
