using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission13.Infrastructure;
using Mission13.Models;

namespace Mission13.Pages
{
    public class Bowlers : PageModel
    {

        private IBowlerRepository repo { get; set; }

        public BowlerModel(IBowlerRepository temp, Bowler b)
        {
            repo = temp;
            bowler = b;
        }

        public Bowler bowler { get; set; }
        public string ReturnURL { get; set; }
        public void OnGet(string returnURL)
        {
            ReturnURL = returnURL ?? "/";
        }

        public IActionResult OnPost(int bowlerID, string returnURL)
        {
            Bowler b = repo.Bowler.FirstOrDefault(x => x.BowlerID == bowlerID);

            bowler.AddItem(b, 1);

            return RedirectToPage(new { ReturnURL = returnURL });
        }

        public IActionResult OnPostRemove(int bowlerID, string returnUrl)
        {
            bowler.RemoveItem(bowler.Items.First(x => x.Bowler.BowlerID == bowlerID).Project);

            return RedirectToPage(new { ReturnURL = returnUrl });
        }

    }
}
