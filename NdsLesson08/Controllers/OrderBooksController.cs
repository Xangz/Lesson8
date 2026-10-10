using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NdsLesson08.Models;

namespace NdsLesson08.Controllers
{
    public class OrderBooksController : Controller
    {
        private readonly BookStoreDbContext _context;

        public OrderBooksController(BookStoreDbContext context)
        {
            _context = context;
        }

        // GET: OrderBooks
        public async Task<IActionResult> Index()
        {
            var bookStoreDbContext = _context.OrderBooks.Include(o => o.Account);
            return View(await bookStoreDbContext.ToListAsync());
        }
    }
}