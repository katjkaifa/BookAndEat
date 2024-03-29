﻿using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class RestaurantPhoto: EntityInt, IHasCreationTime
    {
        public string Photo { get; set; }
        public DateTime CreationTime { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
