using HardwareShop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace HardwareShop.Web.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
