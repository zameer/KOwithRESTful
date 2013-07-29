using KOwithRESTful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KOwithRESTful.Controllers
{
    public class ProductsController : ApiController
    {
        static List<Product> Products = new List<Product>() { 
            new Product{ ProductId=1, Name="MVC4", Quantity = 40, UnitPrice = 12.5},
            new Product{ ProductId=1, Name="ASP.NET", Quantity = 100, UnitPrice = 10.5},
            new Product{ ProductId=1, Name="KnockoutJS", Quantity = 30, UnitPrice = 6}
        };

        // GET api/products
        public IEnumerable<Product> Get()
        {
            return Products.ToList();
        }

        // GET api/products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/products
        public void Post(Product product)
        {
        }

        // PUT api/products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/products/5
        public void Delete(int id)
        {
        }
    }
}
