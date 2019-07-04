using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class OrderWaiter: EntityInt, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }

        public string WaiterId { get; set; }
        public AppUser Waiter { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
