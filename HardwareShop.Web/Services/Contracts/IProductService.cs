using HardwareShop.Models.Dtos;

namespace HardwareShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
