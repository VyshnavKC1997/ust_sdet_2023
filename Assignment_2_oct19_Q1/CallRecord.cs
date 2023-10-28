using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class CallRecord
    {
        public int CallId { get; set; }
        public long PhoneNumber { get; set; }
        public double CallTime {  get; set; }   

        public static List<CallRecord> callRecords=new List<CallRecord>();

       public void CallHistory(long phone)
        {
           List<CallRecord> allcalls= callRecords.FindAll(x=>x.PhoneNumber == phone);
           if(allcalls.Count != 0)
            {
                foreach(var record in allcalls)
                {
                    Console.WriteLine("callid:{0}\tPhoneNumber:{1}\tCall Time:{2}",CallId,PhoneNumber
                        ,CallTime);
                }
            }
            else
            {
                Console.WriteLine("No history Found");
            }

        }
        public void TotalCall()
        {
           Dictionary<long,int> callCount=new Dictionary<long,int>();
            foreach (CallRecord record in callRecords) {
                if (callCount.ContainsKey(record.PhoneNumber))
                {
                    callCount[record.PhoneNumber]++;
                }
                else
                {
                    callCount.Add(record.PhoneNumber, 1);
                }
            }
            foreach(var item in callCount)
            {
                Console.WriteLine("phone number:{0}\tCount:{1}",item.Key,item.Value);
            }
        }

    }
}
