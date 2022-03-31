using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission13.Models;
using Mission13.Models.ViewModels;

namespace WaterProject.Controllers
{
    public class HomeController : Controller
    {
        private IBowlerRepository repo;
        public HomeController(IBowlerRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            var x = new BowlerViewModel
            {
                Bowler = repo.Bowler
                .OrderBy(B => B.BowlerFirstName),

            };

            return View(x);
        }
    }
}
