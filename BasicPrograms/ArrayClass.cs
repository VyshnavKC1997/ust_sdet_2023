using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class ArrayClass
    {
        int[] numbersArray =new int[3];
        int[,] numberArrayTwo= new int[3,3];
        public void SortArray()
        {
            Array.Sort(numbersArray);
        }
        public void DisplayArray()
        {
            foreach(var item in numbersArray)
            {
                Console.WriteLine(item);
            }
        }
        public void ReadArray()
        {
            for(int i = 0;i < numbersArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void WriteArrayTwoDimension()
        {
           /* for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(numberArrayTwo[i,j]);
            }*/
           foreach (var item in numberArrayTwo)
            {
                Console.WriteLine(item);
            }
        }
        public void ReadTwoDimensionalArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter number for [{0},{1}]",i,j);
                    numberArrayTwo[i,j]= Convert.ToInt32(Console.ReadLine());
                }
                }
        }

        public void JaggedArray()
        {
            int[][,] arrayJagged = new int[][,]
            {
                new int[,] {{1,2},{3,4}},
                new int[,] {{5,6},{34,54} },
                new int[,] {{23,234},
                { 54, 456 },{ 23,234} }
              
            };
         /*   foreach (var item in arrayJagged)
            {

                foreach (var j in item)
                { 
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }*/
            /* for (int i = 0; i < arrayJagged.Length; i++)
             {
                 int x = 0;
                 for (int j = 0; j < arrayJagged[i].GetLength(x); j++)
                 {
                     for (int k = 0; k < arrayJagged[j].Rank; k++)
                     {
                         Console.WriteLine(arrayJagged[i][j, k] + " ");
                     }
                     Console.WriteLine();
                 }
                 x++;
             }*/
        }
    }
}
