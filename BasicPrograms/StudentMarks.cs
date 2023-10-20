using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StudentMarks:StudentDetails
    {
   /*     public StudentMarks(int rollNumber, string? studentName, string? city,int firstMark, int secondMark, int thirdMark, int total, double average):
            base(rollNumber,studentName,city)
        {
            FirstMark = firstMark;
            SecondMark = secondMark;
            ThirdMark = thirdMark;
            Total = total;
            Average = average;
        }*/

        public int FirstMark { get; set; }
        public int SecondMark { get; set; }
        public int ThirdMark { get; set; }

        public int Total {  get; set; }
        public double Average { get; set; }

        public int CalculateTotal()
        {
            Total=FirstMark+SecondMark+ThirdMark;
            return Total;
        }
        public double CalculateAverage()
        {
            Average = Total / 3;
            return Average;
        }
    }
}
