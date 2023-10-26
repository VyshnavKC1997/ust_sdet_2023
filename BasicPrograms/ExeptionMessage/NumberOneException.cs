using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms.ExeptionMessage
{
    internal class NumberOneException : Exception
    {
        public NumberOneException(string message) : base(message)
        {

        }
    }
}
