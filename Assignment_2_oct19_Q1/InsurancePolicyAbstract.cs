using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal abstract class InsurancePolicyAbstract
    {
       
        public int PolicyId { get; set; }
        public string? PolicyName { get; set; } 
        public double PremiumAmount { get; set; }

        public abstract double CalculatePremium();
    }
}
