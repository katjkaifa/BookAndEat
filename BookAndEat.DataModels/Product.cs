using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Product: EntityInt, IHasCreationTime
    {
        public string Name { get; set; }
        public Mesurement Mesurement { get; set; }
        public DateTime CreationTime { get; set; }

        public List<DishContaining> DishContainings { get; set; }
        public List<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
