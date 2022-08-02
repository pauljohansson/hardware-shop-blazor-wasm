using HardwareShop.Models.Dtos;
using HardwareShop.Web.Services.Contracts;

namespace HardwareShop.Web.Services
{
    public class ProductService : IProductService
    {
        public Task<IEnumerable<ProductDto>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
