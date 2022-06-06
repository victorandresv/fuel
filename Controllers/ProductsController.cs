using System.Collections.Generic;
using System.Threading.Tasks;
using Fuel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fuel.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        // Get all by company id
        [HttpGet("{company_id}")]
        async public Task<List<ProductModel>> Get(string company_id)
        {

            var products = new ProductContext();
            return await products.GetByCompanyId(company_id);
        }

        // Get by product id
        [HttpGet("{company_id}/{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
