using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicPrograms.ExeptionMessage
{
    internal class MyException
    {
        public static Dictionary<int, string> exceptionMessage = new Dictionary<int, string>()
        {
            { 1,"Dont give Denominator as 0" },
            { 2,"Index is out of range" },
            {3, "Unknown Exception" }
        };

    }
}
