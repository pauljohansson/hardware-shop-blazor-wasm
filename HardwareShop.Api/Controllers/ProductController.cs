using HardwareShop.Api.Repositories.Contracts;
using HardwareShop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardwareShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();

                if (products == null || productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
