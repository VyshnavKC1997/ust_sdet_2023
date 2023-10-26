using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1.ExceptionHandling
{
    internal class PatientException:Exception
    {
       public static Dictionary<string, string> message = new Dictionary<string, string>()
        {
            {"NameNull","name should not be empty" },
            {"diagNull","diagnosis should not be empty" },
            {"age","Age should be between 0 and 120" }
        };
        public PatientException(string message):base(message) 
        {
            
        }
    }
}
