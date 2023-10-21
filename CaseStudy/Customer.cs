using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
      internal class Customer
    {
       public int CustomerId { get; set; }
       public string? Name { get; set; }
       public string? ContactDetails  { get; set; }

        public void DisplayCustomer()
        {
            Console.WriteLine("CustomerId: {0}\tName:{1}\tContactDetails:{2}",CustomerId,Name,ContactDetails);
        }
    }
}
