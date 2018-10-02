using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();

        static Repository()
        {
            Book book = new Book("George Orwell", "Animal farm", 120.5m, 1945, "Secker and Warburg", "01322240", "https://upload.wikimedia.org/wikipedia/commons/f/fb/Animal_Farm_-_1st_edition.jpg", 1);
            Book book2 = new Book("Arthur C. Clarke", "Childhood's End", 122.5m, 1953, "Ballantine Books", "21322240", "https://upload.wikimedia.org/wikipedia/en/7/72/ChildhoodsEnd%281stEd%29.jpg", 2);
             
            MusicCD cd = new MusicCD("Christian Löffler", "Mare", 73.5m, 2016, "https://img.discogs.com/N0Nzh3PCaPnHvDD66y8ZOJmcYh8=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-9199362-1476532535-7378.jpeg.jpg", 3);
            MusicCD cd2 = new MusicCD("Deadmau5", "4x4=12", 74.5m, 2010, "https://imagescdn.junodownload.com/150/CS2759107-02A.jpg", 4);
            Track track1 = new Track("Myiami", "Christian Löffler", new TimeSpan(0, 4, 38));
            Track track2 = new Track("Haul", "Christian Löffler", new TimeSpan(0, 5, 30));
            Track track3 = new Track("Mosaics", "Christian Löffler", new TimeSpan(0, 4, 22));
            Track track4 = new Track("Neo", "Christian Löffler", new TimeSpan(0, 3, 30));
            Track track5 = new Track("Youth", "Christian Löffler", new TimeSpan(0, 4, 10));
            Track track6 = new Track("Lid", "Christian Löffler", new TimeSpan(0, 2, 30));

            Track track7 = new Track("Some Chords", "DeadMau5", new TimeSpan(0, 2, 28));
            Track track8 = new Track("Sofi Needs a Ladder", "DeadMau5", new TimeSpan(0, 3, 30));
            Track track9 = new Track("A City in Florida", "DeadMau5", new TimeSpan(0, 4, 31));
            Track track10 = new Track("Bad Selection", "DeadMau5", new TimeSpan(0, 2, 31));

            // create a new Movie object with instance name jungleBook
            Movie movie1 = new Movie("Terminal", 160.50m, "https://m.media-amazon.com/images/M/MV5BYmEzOGVmNWQtZDBiMC00OTk4LTg3OWQtMzc2MzgxNjlkY2JjXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY1000_SX675_AL_.jpg", "Vaughn Stein", 5);
            Movie movie2 = new Movie("Mr. Nobody", 170m, "https://m.media-amazon.com/images/M/MV5BMTg4ODkzMDQ3Nl5BMl5BanBnXkFtZTgwNTEwMTkxMDE@._V1_SY1000_CR0,0,675,1000_AL_.jpg", "Jaco Van Dormael", 6);
            Movie movie3 = new Movie("Guardians of the Galaxy", 175m, "https://m.media-amazon.com/images/M/MV5BMTAwMjU5OTgxNjZeQTJeQWpwZ15BbWU4MDUxNDYxODEx._V1_SY1000_CR0,0,674,1000_AL_.jpg", "James Gunn", 7);
            Customer customer1 = new Customer("Hans", "Hansen", "Vestergade 2", "8600", "Silkeborg", new DateTime(1990, 04, 11), 1);
            Customer customer2 = new Customer("Søren", "Sørensen", "østergade 4", "8600", "Silkeborg", new DateTime(1980, 12, 18), 2);
            Invoice invoice1 = new Invoice(1, new DateTime(2018, 03, 22), customer1);
            Invoice invoice2 = new Invoice(2, new DateTime(2018, 06, 11), customer2);
            Invoice invoice3 = new Invoice(3, new DateTime(2018, 06, 12), customer1);
            invoice1.AddOrderItem(cd, 1);
            invoice2.AddOrderItem(cd2, 1);
            invoice3.AddOrderItem(cd2, 2);
            customer1.addInvoices(invoice1);
            customer1.addInvoices(invoice3);
            customer2.addInvoices(invoice2);
            // OrderItem orderItem = new OrderItem(cd, 1);
            // OrderItem orderItem2 = new OrderItem(cd2, 2);

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
            Invoices.Add(invoice3);

            cd.AddTrack(track1);
            cd.AddTrack(track2);
            cd.AddTrack(track3);
            cd.AddTrack(track4);
            cd.AddTrack(track5);
            cd.AddTrack(track6);

            cd2.AddTrack(track7);
            cd2.AddTrack(track8);
            cd2.AddTrack(track9);
            cd2.AddTrack(track10);

            Products.Add(book);
            Products.Add(book2);

            Products.Add(cd);
            Products.Add(cd2);

            Products.Add(movie1);
            Products.Add(movie2);
            Products.Add(movie3);

        }
    }
}
