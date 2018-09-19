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
        public Movie()
        {

        }

        public Movie(string title, decimal price, string imageUrl, string director)
        {
            this.Title = title;
            this.Price = price;
            this.ImageURL = imageUrl;
            this.director = director;
        }
    }
}