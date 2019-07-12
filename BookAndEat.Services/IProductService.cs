using BookAndEat.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public interface IProductService
    {
        #region Product
        Task<Product> GetProductById(int productId);
        Task<int> SaveProduct(Product product);
        Task<List<Product>> GetAllProducts();
        Task<Product> DeleteProduct(int productId);
        #endregion Product
    }
}
