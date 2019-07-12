using BookAndEat.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public interface IInvoiceService
    {
        #region Invoice
        Task<Invoice> GetInvoiceById(int invoiceId);
        Task<int> SaveInvoice(Invoice invoice);
        Task<List<Invoice>> GetAllInvoices();
        Task<Invoice> DeleteInvoice(int invoiceId);
        #endregion Invoice

        #region InvoiceProduct
        Task<InvoiceProduct> GetInvoiceProductById(int invoiceProductId);
        Task<int> SaveInvoiceProduct(InvoiceProduct invoiceProduct);
        Task<List<InvoiceProduct>> GetAllInvoiceProducts();
        Task<InvoiceProduct> DeleteInvoiceProduct(int invoiceProductId);
        #endregion InvoiceProduct

        #region Supplier
        Task<Supplier> GetSupplierById(int supplierId);
        Task<int> SaveSupplier(Supplier supplier);
        Task<List<Supplier>> GetAllSupplier();
        Task<Supplier> DeleteSupplier(int supplierId);
        #endregion Supplier
    }
}
