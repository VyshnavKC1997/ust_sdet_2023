using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book:Genre
    {
        public string?  Title { get; set; }
        public string? Authors { get; set; }
        public int Isbn { get; set; }
        public double Price { get; set; }
        public bool Availability { get; set; }

        public void DisplayBook()
        {
            Console.WriteLine("Title:{0}\tAuthors{1}\tISBN{2}\tPrice{3}\tAvailability{4}\tType{5}",Title,
                Authors,Isbn,Price,Availability,TypeOfBook);



        }


    }
}
