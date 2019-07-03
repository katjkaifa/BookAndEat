using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class DishContaining : IHasStringId, IHasCreationTime
    {
        public string Id { get; set; }
        public double Quantity { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
