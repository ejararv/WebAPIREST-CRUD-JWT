using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

using System.Threading.Tasks;

namespace WebApplication6.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        ProductContext db;
        public ProductController(ProductContext context)
        {
            db = context;
            if (!db.Products.Any())
            {
                db.Products.Add(new Product { Name = "iPhone X", Company = "Apple",  });
                db.Products.Add(new Product { Name = "Galaxy S8", Company = "Samsung" });
                db.Products.Add(new Product { Name = "Pixel 2", Company = "Google" });
                db.SaveChanges();
            }
        }
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return db.Products.ToList();
        }

        /*[HttpGet("{id}")]
        public Product Get(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }*/

        [HttpPost]
        public IActionResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Update(product);
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        /*[HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return Ok(product);
        }*/
    }
}