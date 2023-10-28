using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1.ExceptionHandling
{
    internal class InvalidMedicalRecordException:Exception
    {
        public InvalidMedicalRecordException(string? message) : base(message) 
        {
            
        }
    }
}
