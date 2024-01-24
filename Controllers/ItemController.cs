using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineClothingStore.Data;
using OnlineClothingStore.Models;

namespace OnlineClothingStore.Controllers
{
    public class ItemController : Controller
    {

        public readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> PrintList()
        {
            List<Item> items = _context.Items.Include("Producer").ToList();

            return View(items);
        }


        public ActionResult PrintItemInfo(int id)
        {
            //Use the received data in your action
            List<Item> items = _context.Items.ToList();
            Item foundModel = items.FirstOrDefault(item => item.ItemId == id);
            //Item foundmodel = _context.Items.FirstOrDefault(Item => Item.ItemId == int.Parse(id));

            //if (foundmodel != null)
            //{
            //    //ViewBag.ReceivedData = id;
            //    return View(foundmodel);
            //}
            //else
            //{
            //    //  return View("NotFound");
            //    return View();
            //}

            //ViewBag.Id = id;

            return View(foundModel);
        }

        public ActionResult MensHomepage()
        {
            List<Item> items = _context.Items.ToList();

            return View(items);
        }

        public ActionResult MensShirts()
        {
            List<Item> items = _context.Items.ToList();

            return View(items);
        }

        public ActionResult MensPants()
        {
            List<Item> items = _context.Items.ToList();

            return View(items);
        }

        public ActionResult WomensHomepage()
        {
            List<Item> items = _context.Items.ToList();

            return View(items);
        }

        public ActionResult WomensShirts()
        {
            List<Item> items = _context.Items.ToList();

            return View(items);
        }
        public ActionResult WomensPants()
        {
            List<Item> items = _context.Items.ToList();

            return View(items);
        }
    }
}
