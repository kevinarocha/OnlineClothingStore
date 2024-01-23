using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineClothingStore.Data;
using OnlineClothingStore.Models;
using System.Data;

namespace OnlineClothingStore.Controllers
{
    public class OrderController : Controller
    {

        public readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> PrintList()
        {
            List<Order> orders = _context.Orders.Include(o=>o.OrderDetails).ToList();

            return View(orders);
        }




    }
}
