using Jsgrid2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jsgrid2.Controllers
{
    public class JsGridController : Controller
    {
        private readonly ApplicationDbContext context;

        public JsGridController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult JsGrid()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            var products = context.Gridsystem.ToList(); 
            return Json(products);
        }
        [HttpPost]
        public IActionResult AddProducts(Gridlist obj)
        {
            var Addproduct = context.Gridsystem.Add(obj);
            context.SaveChanges();
            return Ok();
        }


        [HttpPost]

        public IActionResult UpdateProducts(Gridlist product)
        {

            context.Gridsystem.Update(product);
            context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteProduct(Gridlist product)
        {
            // Delete the product from your data source based on the product.Id
            var obj = context.Gridsystem.Find(product.Id);
            if (obj == null)
            {
                return NotFound();
            }

            context.Gridsystem.Remove(obj);
            context.SaveChanges();
            return Ok();
        }


    }
}
