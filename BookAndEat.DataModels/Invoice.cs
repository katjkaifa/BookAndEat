using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndEat.DataModels
{
    public class Invoice: EntityInt, IAudited
    {
        public DateTime? DateTo { get; set;}
        public bool IsApproved { get; set; }
        public bool IsSent { get; set; }
        public bool IsDone { get; set;}
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<InvoiceProduct> InvoiceProducts { get; set; }
    }
}
