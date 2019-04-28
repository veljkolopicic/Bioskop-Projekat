using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BioskopApp.Data;
using Microsoft.AspNetCore.Mvc;
using BioskopApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BioskopApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dbContext {get; set; }


        public HomeController(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            this.dbContext = dbContext;

        }
        public IActionResult Index()
        {

            ViewData["Movies"] = dbContext.Movies.Where(m => m.Highlighted);
            ViewData["Repertoar"] = dbContext.Movies.ToList();
                
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
