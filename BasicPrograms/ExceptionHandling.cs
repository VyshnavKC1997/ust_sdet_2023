using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicPrograms.ExeptionMessage;

namespace BasicPrograms
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }

        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public void Divide()
        {
            try
            {
             
                int result = NumberOne / NumberTwo;
                Console.WriteLine(result);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine(MyException.exceptionMessage[2]);
            }
           
        }
        public void numcheck()
        {
            if (NumberOne > NumberTwo)
            {
                Console.WriteLine("success");
            }
            else
            {
                throw new NumberOneException(MyException.exceptionMessage[2]);  
            }
        }

    }
}
