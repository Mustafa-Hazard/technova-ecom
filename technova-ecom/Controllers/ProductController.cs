using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourProjectNamespace.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /Products/
        public IActionResult Index()
        {
            // Example data - replace with your database if needed
            var products = new List<string>
            {
                "Laptop",
                "Smartphone",
                "Headphones",
                "Keyboard"
            };

            // Pass the data to the view
            return View(products);
        }

        // Optional: details of a single product
        public IActionResult Details(int id)
        {
            // Example: get product by id
            var product = $"Product {id}";
            return View("Details", product);
        }
    }
}
 