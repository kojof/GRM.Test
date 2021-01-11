using System;
using System.Collections.Generic;
using System.Text;
using GRM.Domain.Services;

namespace GRM.ConsoleApp
{
    public class ConsoleApplication
    {
        private readonly IProductService _productService;

        public ConsoleApplication(IProductService productService)
        {
            _productService = productService;
        }

        public void Run()
        {
        //    _productService.Search();
        }
    }
}