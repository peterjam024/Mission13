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
        private IBowlerRepository repo { get; set; }
        private BowlersDBContext _context { get; set; }
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Teams = repo.Teams.ToList();
            var person = repo.Bowlers.Single(x => x.BowlerID == id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            ViewBag.Teams = repo.Teams.ToList();
            repo.SaveBowler(b);
            return RedirectToAction("TeamView", "Team", null);
        }

        // ----- DELETE -------

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var person = repo.Bowlers.Single(x => x.BowlerID == id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Delete(Bowler bowler)
        {
            repo.DeleteBowler(bowler);
            return RedirectToAction("TeamView", "Team", null);

        }
    }
}
