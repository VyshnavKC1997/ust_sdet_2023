using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class GenericCollection
    {
        public void ListHandling()
        {
            List<string> list = new List<string>();
            list.Add("ghs");
            list.Add("dffdf");
            list.Add("fdssfdafsda");
            list.Add("uwreyrew");
            list.Add("fsdjjsfd");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(8);
            stack.Push(37);
            stack.Push(66);
            Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());
        }
        public void DictionaryHandling()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "fsddsf");
            dict.Add(231, "daadsdasdsa");
            dict.Add(24, "adasddsad");
            foreach(var item in dict)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
