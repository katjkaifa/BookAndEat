using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class InvoiceProduct: EntityInt, IHasCreationTime
    {
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
