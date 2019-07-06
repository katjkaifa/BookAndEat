using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    // TODO: Add to DB
    public class UserFavouriteDish: EntityInt, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }

        public int UserFavouriteId { get; set; }
        public UserFavourite UserFavourite { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
