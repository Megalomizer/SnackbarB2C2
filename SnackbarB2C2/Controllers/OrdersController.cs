using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer.Localisation.TimeToClockNotation;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SnackbarB2C2.Data;
using SnackbarB2C2.Models;
using SnackbarB2C2Library;

namespace SnackbarB2C2.Controllers
{
    public class OrdersController : Controller
    {
        private readonly SystemDbContext _context;
        private static List<Product> newOrderProductList = new();

        public OrdersController(SystemDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var systemDbContext = _context.Orders.Include(o => o.Customer);
            return View(await systemDbContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            List<Product> productList = _context.Products.ToList();
            VMOrderProducts model = new VMOrderProducts();
            model.Products = productList;
            return View(model);
        }

        // Create new order!
        public IActionResult CreateNewOrder()
        {
            // Get the list of new items and clear the static list
            List<Product> products = new();
            if (newOrderProductList != null)
            {
                products = newOrderProductList;
            }

            // Get the other properties
            int customerid = 2;
            float cost = 0;
            foreach(Product product in products) // Get the total price of all products together
            {
                cost += product.Price;
            }

            DateTime dateoforder = DateTime.Now; // Get current Date and Time
            Customer customer = _context.Customer.Where(customer => customer.Id == customerid).First(); //Get customer with corresponding id

            Order order = new Order(0, cost, dateoforder, customer, products); // id = 0 cause it gets set in db

            _context.Orders.Add(order);
            _context.SaveChanges();

            newOrderProductList.Clear();

            return RedirectToAction("Index");
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cost,DateOfOrder,IsFavorited,Status,CustomerId,Products")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        public IActionResult AddProductToOrderlist()
        {
            var urlId = RouteData.Values["id"];

            foreach(var item in _context.Products)
            {
                if(item.Id == Int32.Parse(urlId.ToString()))
                {
                    newOrderProductList.Add(item);
                }
            }

            return RedirectToAction("Create");
        }
    }
}
