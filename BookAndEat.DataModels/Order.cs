using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Order: EntityInt, IAudited
    {
        public DateTime? DateTimeTo { get; set; }
        public bool IsConfirmed { get; set; }
        public string Phone { get; set; }
        public bool IsToGo { get; set; }
        public string Details { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<OrderTable> OrderTables { get; set; }
    }
}
