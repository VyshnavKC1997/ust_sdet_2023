﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_oct_18
{
    internal class Student
    {
        string? name;
        int markOne,markTwo,markThree;

        public Student(string? name, int markOne, int markTwo, int markThree)
        {
            this.name = name;
            this.markOne = markOne;
            this.markTwo = markTwo;
            this.markThree = markThree;
        }
        public double Average()
        {
            return (markOne + markTwo + markThree)/3;
        }
        public double TotalMark()
        {
            return markOne + markTwo + markThree;
        }
        public char TotalGrade()
        {
            double average=Average();
            if (average > 90)
                return 'A';
            else if (average > 80)
                return 'B';
            else if (average > 70)
                return 'C';
            else if (average > 60)
                return 'D';
            else
                return 'E';
        }
    }
}
