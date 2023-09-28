using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SnackbarB2C2.Data;
using SnackbarB2C2.Models;
using SnackbarB2C2Library;
using System.Diagnostics;
using System.Reflection;

namespace SnackbarB2C2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SystemDbContext db;

        public HomeController(ILogger<HomeController> logger, SystemDbContext Db)
        {
            _logger = logger;
            db = Db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = db.Products.ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}