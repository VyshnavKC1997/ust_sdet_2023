using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class EmployeeClass
    {
        public EmployeeClass(int employeeId, string? employeeName, double performanceRating)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }

        public double PerformanceRating {  get; set; }

        public static double BonusCalc(EmployeeClass employeeClass)
        {
            double performance=employeeClass.PerformanceRating;
            return performance * 1000;
        }
        public static double BonusCalcAccount(EmployeeClass employeeClass)
        {
            double performance=employeeClass.PerformanceRating;
            return performance * 2000;
        }
    }
}
