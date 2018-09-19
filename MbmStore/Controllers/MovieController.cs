using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Hansi");
            Movie forrestGump = new Movie("Forrest Gump", 170m, "forrest-gump.jpg", "Yesman");
            Movie gladiator = new Movie("Gladiator", 175m, "gladiator.jpg", "Dude");
            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.ForrestGump = forrestGump;
            ViewBag.Gladiator = gladiator;
            return View();
        }
    }
}