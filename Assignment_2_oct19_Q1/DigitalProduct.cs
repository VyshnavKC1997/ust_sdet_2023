using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class DigitalProduct:ElectronicProduct
    {
        string? fileFormat;

        public DigitalProduct(string? productName, double price, int quantity, int warrentyPeriod,
            string? fileFormat):base(productName,price,quantity,warrentyPeriod)
        {
            this.fileFormat = fileFormat;
        }
        public void DigitalProductFileFormatDisplay()
        {
            Console.WriteLine("FileFormat:{0}",fileFormat);
        }
    }
}
