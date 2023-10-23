using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Bank
    {
        public Bank(int customerId, long accountNumber, string? name, string? status)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Name = name;
            Status = status;
        }

        public int CustomerId { get; set; }
        public long AccountNumber { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }

      /*  public Bank()
        {
            CustomerId = 0;
            AccountNumber=0;
            Name = string.Empty;
            Status = string.Empty;
        }

        public Bank(int customerId, long accountNumber, string? name)
        {
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Name = name;
            Status = "Active";
        }*/

        public  void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }
        public void GetAccountDetails(int cid)
        {
            if(CustomerId ==cid )
            {
                Console.WriteLine("Account Number:{0}\tName:{1}\tstatus:{2}",AccountNumber,Name,Status);
            }
            else
                Console.WriteLine("Customer id does not Exist");
        }
        public void GetAccountDetails(long accNum)
        {
            if (AccountNumber==accNum)
            {
                Console.WriteLine("Customer id:{0}\tName:{1}\tstatus:{2}", CustomerId, Name, Status);
            }
            else
                Console.WriteLine("Account Number does not Exist");
        }
        public void GetAccountDetails(string? accName)
        {
            if (Name== accName)
            {
                Console.WriteLine("Customer id:{0}\tAccount number:{1}\tstatus:{2}", CustomerId, AccountNumber, Status);
            }
            else
                Console.WriteLine("Name does not Exist");
        }

    }
}
