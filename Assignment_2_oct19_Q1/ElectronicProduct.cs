using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class ElectronicProduct:Product
    {
        int warrentyPeriod;

        public ElectronicProduct(string? productName, double price, int quantity,int warrentyPeriod):base(productName,price,quantity)
        {
            this.warrentyPeriod = warrentyPeriod;
        }

        public void ElectronicWarrenty()
        {
            Console.WriteLine("warrenty period:{0}",warrentyPeriod);
        }
    }
}
