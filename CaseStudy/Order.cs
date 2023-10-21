using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
       public Book listOfBooks;
       public string? orderDate;
       public double totalCost;

        public void DisplayOrder()
        {
            Console.WriteLine("Title:{0}\tAuthors{1}\tISBN{2}\tPrice{3}\tAvailability{4}\tType{5}\torderdate:{6}\ttotalcost{7}",listOfBooks.Title,
                listOfBooks.Authors, listOfBooks.Isbn, listOfBooks.Price, listOfBooks.Availability, listOfBooks.TypeOfBook
                ,orderDate,totalCost);
        }
    }
}
