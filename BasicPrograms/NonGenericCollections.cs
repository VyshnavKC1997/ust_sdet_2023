using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonGenericCollections
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();  
            arrayList.Add(0);
            arrayList.Add("dffdf");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(0);
            stack.Push("sdaa");
            stack.Push(3.4);
            stack.Push(66);
            Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());
        }
        public void QueueHandling()
        {
            Queue queue = new Queue();  
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Enqueue("ssdads");
            queue.Enqueue(12.5);
            queue.Enqueue(15);
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();    
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public void HashTableHandling()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "sdda");
            hashTable.Add("2", "fsj");
            foreach(var item in hashTable)
            {
                Console.WriteLine(item);
            }

        }
        public void SortedListHandling()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(111, "dsd");
            sortedList.Add(12, "daadsasd");
            sortedList.Add(94, "dasddasdas");
            sortedList.Add(5, "AA");
            foreach(var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
