﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 4;

        // GET: Catalogue
        // Passes a ProductsListViewModel object as the model data to the view.
        public ActionResult Index(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = Repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    Repository.Products.Count() :
                    Repository.Products.Where(e =>
                    e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}