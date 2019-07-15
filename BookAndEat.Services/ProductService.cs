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
            return await dbContext.Products
                .Where(x => x.Id == productId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Parameter is null");
            }
            if (product.Id == 0)
            {
                dbContext.Products.Add(product);
            }
            else
            {
                Product dbEntry = dbContext.Products.Find(product.Id);
                if (dbEntry == null)
                {
                    throw new InvalidOperationException("Product not found");
                }
                dbEntry.Name = product.Name;
                dbEntry.Mesurement = product.Mesurement;
            }

            await dbContext.SaveChangesAsync();
            return product.Id;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            Product dbEntry = dbContext.Products.Find(productId);
            if (dbEntry == null)
            {
                throw new InvalidOperationException("Product not found");
            }
            dbContext.Products.Remove(dbEntry);

            await dbContext.SaveChangesAsync();
            return dbEntry;
        }
        #endregion Product
    }
}
