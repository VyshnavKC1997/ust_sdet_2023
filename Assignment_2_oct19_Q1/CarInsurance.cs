using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class CarInsurance:InsurancePolicyAbstract
    {
        public string? VehicleType {  get; set; }

        public override double CalculatePremium()
        {
            if (VehicleType == "private")
            {
                PremiumAmount = PremiumAmount * 1.1;
                return PremiumAmount;
            }
            else if (VehicleType == "Transport")
            {
                PremiumAmount = PremiumAmount * 2.1;
                return PremiumAmount;
            }

            else
            {
                return PremiumAmount;
            }

        }
    }
}
