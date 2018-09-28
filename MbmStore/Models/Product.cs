using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }

        public Product()
        {

        }

        public Product(string title, decimal price, string imageURL)
        {
            Title = title;
            Price = price;
            ImageURL = imageURL;
        }
    }
}
