using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefDish.Models;
using Microsoft.EntityFrameworkCore;


namespace ChefDish.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            ViewBag.AllDishes = _context.Dishes.Include(c => c.Chef).ToList();
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult addChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                ViewBag.AllChefs = _context.Chefs.ToList();
                ViewBag.AllDishes = _context.Dishes.Include(c => c.Chef).ToList();
                return View("Chef");
            }
        }
        
        [HttpGet("Chef")]
        public IActionResult Chef()
        {
            return View();
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction ("Index");
            }else{
                ViewBag.AllChefs = _context.Chefs.ToList();
                ViewBag.AllDishes = _context.Dishes.Include(c => c.Chef).ToList();
                return View("Dish");
            }
        }

        [HttpGet("Dish")]
        public IActionResult Dish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            ViewBag.AllDishes = _context.Dishes.Include(c => c.Chef).ToList();
            return View();
        }
    }
}
