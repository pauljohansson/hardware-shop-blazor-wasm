using HardwareShop.Api.Entities;
using HardwareShop.Api.Repositories.Contracts;

namespace HardwareShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<ProductCategory>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
