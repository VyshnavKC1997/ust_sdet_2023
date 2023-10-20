using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StudentGrade:StudentMarks
    {
        public char? Grade { get; set; }

        public char CalculateGrade()
        {
            if (Average >= 90)
                return 'A';
            else if (Average >= 60)
                return 'B';
            else if (Average >= 40)
                return 'C';
            else
                return 'D';
                
        }

    }
}
