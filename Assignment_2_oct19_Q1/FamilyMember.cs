using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class FamilyMember<T> 
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public List<FamilyMember<T>> Families=new List<FamilyMember<T>>();

      
    }
}
