using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();
            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstnavn + " " + invoice.Customer.Lastnavn,
                    Value = invoice.Customer.CustomerID.ToString()
                });
            }
            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();
            ViewBag.Invoices = Repository.Invoices;
            ViewBag.Customers = customers;

            return View();
        }
        [HttpPost]
        public IActionResult Index(int? customer) //int? betyder nullable, hvilket vil sige det kan være null eller int.
        {

            // declare the lists
            List<SelectListItem> customers = new List<SelectListItem>();
            List<Invoice> invoices = Repository.Invoices;
            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
                {
                    if (invoice.Customer.CustomerID == customer)
                    {
                        customers.Add(new SelectListItem
                        {
                            Text = invoice.Customer.Firstnavn + " " + invoice.Customer.Lastnavn,
                            Value = invoice.Customer.CustomerID.ToString(),
                            Selected = true
                        });
                    }

                    else
                    {
                        customers.Add(new SelectListItem
                        {
                            Text = invoice.Customer.Firstnavn + " " + invoice.Customer.Lastnavn,
                            Value = invoice.Customer.CustomerID.ToString()
                        });
                    }
                }

            // vælger hvilken data der skal vises udfra customerID
            if (customer != null)
            {
                // select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerID == customer).ToList();
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();
            ViewBag.Invoices = invoices;
            ViewBag.Customers = customers;
            return View();
        }
    }
}