using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Supplier: EntityInt, IHasCreationTime
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreationTime { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}
