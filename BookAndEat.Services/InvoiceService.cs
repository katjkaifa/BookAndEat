using BookAndEat.DataAccess;
using BookAndEat.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ApplicationDbContext dbContext;
        public InvoiceService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Invoice
        public async Task<Invoice> GetInvoiceById(int invoiceId)
        {
            return await dbContext.Invoices.Where(x => x.Id == invoiceId).FirstOrDefaultAsync();
        }

        public async Task<int> SaveInvoice(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException(nameof(invoice), "Parameter is null");
            }
            if (invoice.Id == 0)
            {
                dbContext.Invoices.Add(invoice);
            }
            else
            {
                Invoice dbEntry = dbContext.Invoices.Find(invoice.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Invoice not found");
                }
                dbEntry.DateTo = invoice.DateTo;
                dbEntry.IsApproved = invoice.IsApproved;
                dbEntry.IsSent = invoice.IsSent;
                dbEntry.IsDone = invoice.IsDone;
            }

            await dbContext.SaveChangesAsync();
            return invoice.Id;
        }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            return await dbContext.Invoices.ToListAsync();
        }

        public async Task<Invoice> DeleteInvoice(int invoiceId)
        {
            Invoice dbEntry = dbContext.Invoices.Find(invoiceId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Invoice not found");
            }
            dbContext.Invoices.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion Invoice

        #region InvoiceProduct
        public async Task<InvoiceProduct> GetInvoiceProductById(int invoiceProductId)
        {
            return await dbContext.InvoiceProducts.Where(x => x.Id == invoiceProductId).FirstOrDefaultAsync();
        }

        public async Task<int> SaveInvoiceProduct(InvoiceProduct invoiceProduct)
        {
            if (invoiceProduct == null)
            {
                throw new ArgumentNullException(nameof(invoiceProduct), "Parameter is null");
            }
            if (invoiceProduct.Id == 0)
            {
                dbContext.InvoiceProducts.Add(invoiceProduct);
            }
            else
            {
                InvoiceProduct dbEntry = dbContext.InvoiceProducts.Find(invoiceProduct.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Invoice product not found");
                }
                dbEntry.Quantity = invoiceProduct.Quantity;
                dbEntry.Price = invoiceProduct.Price;
            }

            await dbContext.SaveChangesAsync();
            return invoiceProduct.Id;
        }

        public async Task<List<InvoiceProduct>> GetAllInvoiceProducts()
        {
            return await dbContext.InvoiceProducts.ToListAsync();
        }

        public async Task<InvoiceProduct> DeleteInvoiceProduct(int invoiceProductId)
        {
            InvoiceProduct dbEntry = dbContext.InvoiceProducts.Find(invoiceProductId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Invoice product not found");
            }
            dbContext.InvoiceProducts.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion InvoiceProduct

        #region Supplier
        public async Task<Supplier> GetSupplierById(int supplierId)
        {
            return await dbContext.Suppliers.Where(x => x.Id == supplierId).FirstOrDefaultAsync();
        }

        public async Task<int> SaveSupplier(Supplier supplier)
        {
            if (supplier == null)
            {
                throw new ArgumentNullException(nameof(supplier), "Parameter is null");
            }
            if (supplier.Id == 0)
            {
                dbContext.Suppliers.Add(supplier);
            }
            else
            {
                Supplier dbEntry = dbContext.Suppliers.Find(supplier.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Supplier not found");
                }
                dbEntry.Name = supplier.Name;
                dbEntry.Phone = supplier.Phone;
                dbEntry.ContactPerson = supplier.ContactPerson;
                dbEntry.Address = supplier.Address;
                dbEntry.Email = supplier.Email;
            }

            await dbContext.SaveChangesAsync();
            return supplier.Id;
        }

        public async Task<List<Supplier>> GetAllSupplier()
        {
            return await dbContext.Suppliers.ToListAsync();
        }

        public async Task<Supplier> DeleteSupplier(int supplierId)
        {
            Supplier dbEntry = dbContext.Suppliers.Find(supplierId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Supplier not found");
            }
            dbContext.Suppliers.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion Supplier
    }
}
