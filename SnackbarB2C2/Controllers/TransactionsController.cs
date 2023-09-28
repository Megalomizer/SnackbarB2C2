using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SnackbarB2C2.Data;
using SnackbarB2C2Library;


namespace SnackbarB2C2.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly SystemDbContext db;

        public TransactionsController(SystemDbContext Db)
        {
            db = Db;
        }

        // GET: Transactions
        public IActionResult Index()
        {
            var systemDbContext = db.Transactions.Include(t => t.Customer).Include(t => t.Order);
            return View(systemDbContext.ToList());
        }
    }
}
