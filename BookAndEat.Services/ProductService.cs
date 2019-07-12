using BookAndEat.DataAccess;
using BookAndEat.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAndEat.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext dbContext;
        public ProductService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region Product
        public async Task<Product> GetProductById(int productId)
        {
            Product result = dbContext.Products.Where(x => x.Id == productId).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<int> SaveProduct(Product product)
        {
            if (product.Id == 0)
            {
                dbContext.Products.Add(product);
            }
            else
            {
                Product dbEntry = dbContext.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Mesurement = product.Mesurement;
                }
            }

            await dbContext.SaveChangesAsync();

            return product.Id;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> result = null;

            result = dbContext.Products.ToList();

            return await Task.FromResult(result);
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            Product dbEntry = dbContext.Products.Find(productId);
            if (dbEntry != null)
            {
                dbContext.Products.Remove(dbEntry);
            }

            await dbContext.SaveChangesAsync();

            return dbEntry;
        }
        #endregion Product
    }
}
