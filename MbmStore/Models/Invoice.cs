using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal TotalPrice { get; set; } 
        public int Invoiceid { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }

        public Invoice(int invoiceid, DateTime orderDate, Customer customer)
        {
            this.Invoiceid = invoiceid;
            this.OrderDate = orderDate;
            this.Customer = customer;
        }
    }
}
