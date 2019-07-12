using BookAndEat.DataAccess;
using BookAndEat.DataModels;
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
            Invoice result = dbContext.Invoices.Where(x => x.Id == invoiceId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveInvoice(Invoice invoice)
        {
            if (invoice.Id == 0)
            {
                dbContext.Invoices.Add(invoice);
            }
            else
            {
                Invoice dbEntry = dbContext.Invoices.Find(invoice.Id);
                if (dbEntry != null)
                {
                    dbEntry.DateTo = invoice.DateTo;
                    dbEntry.IsApproved = invoice.IsApproved;
                    dbEntry.IsSent = invoice.IsSent;
                    dbEntry.IsDone = invoice.IsDone;
                }
            }

            await dbContext.SaveChangesAsync();

            return invoice.Id;
        }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            List<Invoice> result = null;

            result = dbContext.Invoices.ToList();

            return await Task.FromResult(result);
        }

        public async Task<Invoice> DeleteInvoice(int invoiceId)
        {
            Invoice dbEntry = dbContext.Invoices.Find(invoiceId);
            if (dbEntry != null)
            {
                dbContext.Invoices.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Invoice

        #region InvoiceProduct
        public async Task<InvoiceProduct> GetInvoiceProductById(int invoiceProductId)
        {
            InvoiceProduct result = dbContext.InvoiceProducts.Where(x => x.Id == invoiceProductId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveInvoiceProduct(InvoiceProduct invoiceProduct)
        {
            if (invoiceProduct.Id == 0)
            {
                dbContext.InvoiceProducts.Add(invoiceProduct);
            }
            else
            {
                InvoiceProduct dbEntry = dbContext.InvoiceProducts.Find(invoiceProduct.Id);
                if (dbEntry != null)
                {
                    dbEntry.Quantity = invoiceProduct.Quantity;
                    dbEntry.Price = invoiceProduct.Price;
                }
            }

            await dbContext.SaveChangesAsync();

            return invoiceProduct.Id;
        }

        public async Task<List<InvoiceProduct>> GetAllInvoiceProducts()
        {
            List<InvoiceProduct> result = null;

            result = dbContext.InvoiceProducts.ToList();

            return await Task.FromResult(result);
        }

        public async Task<InvoiceProduct> DeleteInvoiceProduct(int invoiceProductId)
        {
            InvoiceProduct dbEntry = dbContext.InvoiceProducts.Find(invoiceProductId);
            if (dbEntry != null)
            {
                dbContext.InvoiceProducts.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion InvoiceProduct

        #region Supplier
        public async Task<Supplier> GetSupplierById(int supplierId)
        {
            Supplier result = dbContext.Suppliers.Where(x => x.Id == supplierId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveSupplier(Supplier supplier)
        {
            if (supplier.Id == 0)
            {
                dbContext.Suppliers.Add(supplier);
            }
            else
            {
                Supplier dbEntry = dbContext.Suppliers.Find(supplier.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = supplier.Name;
                    dbEntry.Phone = supplier.Phone;
                    dbEntry.ContactPerson = supplier.ContactPerson;
                    dbEntry.Address = supplier.Address;
                    dbEntry.Email = supplier.Email;
                }
            }

            await dbContext.SaveChangesAsync();

            return supplier.Id;
        }

        public async Task<List<Supplier>> GetAllSupplier()
        {
            List<Supplier> result = null;

            result = dbContext.Suppliers.ToList();

            return await Task.FromResult(result);
        }

        public async Task<Supplier> DeleteSupplier(int supplierId)
        {
            Supplier dbEntry = dbContext.Suppliers.Find(supplierId);
            if (dbEntry != null)
            {
                dbContext.Suppliers.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Supplier
    }
}
