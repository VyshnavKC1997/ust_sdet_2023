using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class Product
    {
        string? productName;
        int quantity;
        double price;

        public Product(string? productName, double price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }
        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("product name:{0} \nprice:{1}\nquantity:{2}\n",productName,price,quantity);
        }
        public void ProductValue()
        {
            Console.WriteLine("product name:{0}\ntotal price:{1}\n",productName,quantity*price);
        }
    }
}
