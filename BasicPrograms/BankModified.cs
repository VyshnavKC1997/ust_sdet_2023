using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class BankModified:Bank
    {
        public BankModified(int customerId,long accountNumber,string? name,string? status):base(customerId,
            accountNumber,name,status)
        {
            
        }

        public new void WelcomeMessage()
        {
            Console.WriteLine("welcome {0}",Name);
        }
    }
}
