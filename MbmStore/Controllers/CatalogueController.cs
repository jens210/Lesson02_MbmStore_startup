using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            // send a list of products to the view.
            return View(Repository.Products);
        }
    }
}