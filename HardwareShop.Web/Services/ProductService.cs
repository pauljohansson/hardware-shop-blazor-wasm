using HardwareShop.Models.Dtos;
using HardwareShop.Web.Services.Contracts;

namespace HardwareShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<IEnumerable<ProductDto>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
