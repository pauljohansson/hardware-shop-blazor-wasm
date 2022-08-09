﻿using HardwareShop.Models.Dtos;
using HardwareShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HardwareShop.Web.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
