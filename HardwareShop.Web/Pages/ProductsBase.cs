using HardwareShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HardwareShop.Web.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
    }
}
