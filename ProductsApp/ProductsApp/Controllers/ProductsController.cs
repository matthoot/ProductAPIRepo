using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Ketchup", Category = "Condiments", Price = 4 },
            new Product { Id = 2, Name = "Rubix Cube", Category = "Puzzles", Price = 20 },
            new Product { Id = 3, Name = "Laptop", Category = "Devices", Price = 600 }
        };

        public ProductsController(): base()
        {

        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }


    
}