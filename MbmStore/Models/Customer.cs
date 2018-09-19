using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        public string firstnavn { get; set; }
        public string lastnavn { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string phonenumber { get; }
        public List<string> PhoneNumbers { get; } = new List<string>();
        private DateTime birthDate;
        private int age;
        public List<Invoice> Invoices = new List<Invoice>();

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
   
                age = now.Year - birthDate.Year;
                // calculate to see if the customer hasn’t had birthday yet
                // subtract one year if that is so
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month &&
                now.Day < birthDate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public DateTime BirthDate
        {
           set
            {
                if (value > DateTime.Now &&  DateTime.Now.Year - value.Year < 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
            get
            {
                return birthDate;
            }
        }

        public void addPhoneNumbers(string phonenumber)
        {
            PhoneNumbers.Add(phonenumber);
        }

        public void addInvoices(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
        public Customer(string firstnavn, string lastnavn, string address, string zip, string city, DateTime birthDay)
        {
            this.firstnavn = firstnavn;
            this.lastnavn = lastnavn;
            this.address = address;
            this.zip = zip;
            this.city = city;
           //this.phonenumber = phonenumber;
            this.birthDate = birthDay;
        }
    }
}
