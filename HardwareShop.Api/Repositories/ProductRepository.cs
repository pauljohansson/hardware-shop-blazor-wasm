using HardwareShop.Api.Data;
using HardwareShop.Api.Entities;
using HardwareShop.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HardwareShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly HardwareShopDbContext hardwareShopDbContext;

        public ProductRepository(HardwareShopDbContext hardwareShopDbContext)
        {
            this.hardwareShopDbContext = hardwareShopDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.hardwareShopDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.hardwareShopDbContext.Products.ToListAsync();

            return products;
        }
    }
}
