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
            IList<Book> books = new List<Book>();
            IList<MusicCD> cds = new List<MusicCD>();
            IList<Movie> movies = new List<Movie>();

            books = Repository.Products.OfType<Book>().ToList();
            cds = Repository.Products.OfType<MusicCD>().ToList();
            movies = Repository.Products.OfType<Movie>().ToList();

            ViewBag.Books = books;
            ViewBag.CDS = cds;          
            ViewBag.Movies = movies;
            ViewBag.Products = Repository.Products;
            return View();
        }
    }
}