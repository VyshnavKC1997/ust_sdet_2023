using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct_19_Q2
{
    internal class Student
    {
        string? name;
        int[] mark=new int[3];
        char grade;

        public Student(string? name, int[] mark, char grade)
        {
            this.name = name;
            this.mark = mark;
            this.grade = grade;
        }

        public double CalculateAverage()
        {
            double average ;
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                sum+= mark[i];
            }
            average = sum/3;
            return average;
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Student name:{0}",
                name);
            Console.Write("marks:");
            int total = 0;
            foreach (int i in mark)
            {
                total += i;
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("Total:{0}\nAverage:{1}\nGrade:{2}",total,CalculateAverage(),grade);
            Console.WriteLine();
        }
        public void GetMarkSummary()
        {
            int max=mark.Max();
            Console.WriteLine("{0} Has {1} Marks.\nHighest Mark:{2} \nLowest Mark:{3}",name,mark.Length,mark.Max(),mark.Min());
            Console.WriteLine();
        }
    }
}
