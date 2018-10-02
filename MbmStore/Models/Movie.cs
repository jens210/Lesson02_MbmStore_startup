using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        private decimal price; 
        private string director;


        public string Director
        {
            get { return director; }
        }

        public new virtual decimal Price 
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else {
                    price = value;
                }
            }
            get { return price; }
        }

        // constructors
        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        // Nedarver title, price og imageUrl fra base klassen "Product".
        public Movie(string title, decimal price, string imageUrl, string director, int productID) : base (title, price, imageUrl, productID)
        {
            this.director = director;
            Title = title;
            Price = price;
            ProductID = productID;
        }
    }
}