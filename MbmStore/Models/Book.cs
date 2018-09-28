using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    // book derived from product
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        public Book()
        {

        }

        public Book(string author, string title, decimal price, short published, string publisher, string isbn, string imageURL)
        {
            Author = author;
            Title = title;
            Price = price;
            Published = published;
            Publisher = publisher;
            ISBN = isbn;
            ImageURL = imageURL;
        }
    }
}
