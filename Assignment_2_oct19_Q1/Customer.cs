using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class Customer
    {
        public static List<Customer> list = new List<Customer>();
    
        public int CustomerId { get; set; } 
        public string? CustomerName { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }

       public void SearchCustomer(long phone)
        {
            var number = list.Find(x => x.PhoneNumber == phone);
            if (number!=null)
            {
                Console.WriteLine("Customer Name:{0}\tBalance:{1}", number.CustomerName, number.Balance);
            }
            else
            {
                Console.WriteLine("No phone number not found");
            }
                   
            
        }
        public void DisplayDetails()
        {
            foreach
                (var customer in list)
            {
                Console.WriteLine("CustomerId:{0}\tCustomer Name:{1}\tPhone Number:{2}\tBalance:{3}", customer.CustomerId, 
                    customer.CustomerName,customer.PhoneNumber,customer.Balance);
            }
        }
    }
}
