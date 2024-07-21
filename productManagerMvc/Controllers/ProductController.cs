using Microsoft.AspNetCore.Mvc;
using productManagerMvc.Data;
using productManagerMvc.Models;

namespace productManagerMvc.Controllers
{
    public class ProductController : Controller
    {
        // Making a instance obj for ApplicationDbContext
        private readonly ApplicationDbContext _context;

        // Using Dependency Injection inorder to use _context
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Prodcut
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }


        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Product/Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // POST: Product/Delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var productToDelete = _context.Products.Find(id);

            _context.Products.Remove(productToDelete);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
