using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct:Product,IOderable
    {
        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }

        public static List<DigitalProduct> Products = new List<DigitalProduct>();
        public void DeliveringProduct()
        {
            throw new NotImplementedException();
        }

        public void PlacingOrder()
        {
            throw new NotImplementedException();
        }

        public void ProcessingPayment()
        {
            Console.WriteLine("Enter the card details for product {0}", ProductName);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment successful");
            }
        }
    }
}
