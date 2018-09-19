using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;


namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer customer1 = new Customer("Lars", "Larsen", "Vestergade 2", "8600", "Silkeborg",  new DateTime(1990, 2, 2));
            Customer customer2 = new Customer("Karl", "Karlsen", "Vestergade 3", "8600", "Silkeborg", new DateTime(1992, 12, 2));
            Customer customer3 = new Customer("Hans", "Hansen", "Vestergade 4", "8600", "Silkeborg",  new DateTime(1999, 12, 2));

            customer1.PhoneNumbers.Add("12 44 33 22");
            customer1.PhoneNumbers.Add("12 12 23 22");

            customer2.PhoneNumbers.Add("22 44 33 22");
            customer2.PhoneNumbers.Add("22 12 23 22");

            customer3.PhoneNumbers.Add("32 44 33 22");
            customer3.PhoneNumbers.Add("32 12 23 22");

            ViewBag.customer1 = customer1;
            ViewBag.customer2 = customer2;
            ViewBag.customer3 = customer3;
            return View();
        }
    }
}