using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LInqExample
    {
       
        public void RunExample()
        {
            List<string> stringCollection = new List<string>();
            stringCollection.Add("C tutorial");  
            stringCollection.Add("C sharp");
            stringCollection.Add("Java");
            stringCollection.Add("Ruby");
            stringCollection.Add("Angular");
            stringCollection.Add("React");
            
            var result=from i in stringCollection where i.Equals("Java") select i;
            var result2 = stringCollection.Where(x => x.Contains("C"));
            foreach(var i in result2)
            Console.WriteLine(i);
           

            
        }
        public void RunExample2() { 
        
        List<Student> students = new List<Student>();   
            students.Add(new Student(1,"fdf","CSE"));
            students.Add(new Student(2, "vyshnav", "CSE"));
            students.Add(new Student(3, "vishal", "EEE"));
            students.Add(new Student(4, "vyshnav", "CSE"));
            students.Add(new Student(5, "vyshnav", "CSE"));
            var stud = students.Where(x => x.Name =="vyshnav");
            Student? stud2 = students.FirstOrDefault(x => x.Id == 3);


            Console.WriteLine("****************************");
            var student2 = students.ToLookup(s => s.Name);
            foreach (var student in student2)
            {
                foreach (var s in student)
                    Console.WriteLine(student.Key + " " + s.Name + " " + s.Id);
            }

            if (stud2 == null)
            {
                Console.WriteLine("no student found");
            }
            else
            {
                Console.WriteLine(stud2.Name);
            }
            foreach(var student in stud)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("************************");
            var student1=students.OrderBy(x=>x.Name).ThenBy(x=>x.Id);    
            foreach(var student in student1)
            {
                Console.WriteLine(student.Name+" "+student.Id);
            }


        }
    }
}
