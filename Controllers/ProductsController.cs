using System.Collections.Generic;
using Fuel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fuel.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // Get all by company id
        [HttpGet("{company_id}")]
        public List<ProductModel> Get(string company_id)
        {
            List<ProductModel> list = new List<ProductModel>();
            ProductModel product = new ProductModel() {
                Name = "Name",
                Price = 5.6,
                Img = "URL img",
                Unit = "unit"
            };
            list.Add(product);
            return list;
        }

        // Get by product id
        [HttpGet("{company_id}/{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
