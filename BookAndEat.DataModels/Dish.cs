using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Dish: EntityInt, IAudited
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsInMenu { get; set; }
        public string Photo { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int DishCategoryId { get; set; }
        public DishCategory DishCategory { get; set; }

        public List<DishContaining> DishContainings { get; set; }
        //public List<UserFavouriteDish> UserFavouriteDishes { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}
