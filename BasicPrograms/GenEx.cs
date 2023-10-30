using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class GenEx<T>
    {
        /* private T? val1,val2;

         public GenEx(T? val1, T? val2)
         {
             this.Val1 = val1;
             this.Val2 = val2;
         }

         public T? Val1 { get => val1; set => val1 = value; }
         public T? Val2 { get => val2; set => val2 = value; }*/
        T[] arr;

        public GenEx(T[] arr)
        {
            this.Arr = arr;
        }

        public T[] Arr { get => arr; set => arr = value; }

        public void Display()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
