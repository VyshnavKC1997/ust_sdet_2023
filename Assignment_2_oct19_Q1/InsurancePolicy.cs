using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class InsurancePolicy
    {
         int policyId;
         string? policyName;
         double premiumAmount;

        public InsurancePolicy(int policyId, string? policyName, double premiumAmount)
        {
            this.policyId = policyId;
            this.policyName = policyName;
            this.premiumAmount = premiumAmount;
        }

        public void RenewPolicy(double newPremium)
        {
            premiumAmount = newPremium;
           
        }
        public void RenewPolicy()
        {
            premiumAmount+= (premiumAmount * .1);
        }
        public void Display()
        {
            Console.WriteLine("policy id:{1}\tpolicy name:{1}\tpolicyAmount:{2}",policyId,policyName,premiumAmount);
        }
    }
}
