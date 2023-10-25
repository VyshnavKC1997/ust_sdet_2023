using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class LifeInsurance : InsurancePolicyAbstract
    {
        public int Age { get; set; }
        public override double CalculatePremium()
        {
            if (Age > 70)
            {
                return PremiumAmount * 2.1;
            }
            else if (Age > 40)
                return PremiumAmount * 1.1;
            else if (Age > 20)
                return PremiumAmount * 0.5;
            else
                return PremiumAmount;
        }
    }
}
