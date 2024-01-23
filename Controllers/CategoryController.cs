using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineClothingStore.Data;
using OnlineClothingStore.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace OnlineClothingStore.Controllers
{
    public class CategoryController : Controller
    {

        public readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> PrintList()
        {
            List<Category> categories = _context.Categories.Include("Items").ToList();

            //var categories = _context.Categories.Incl

            return View(categories);
        }



    }
}
