using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Employees
    {
            int employeeId;
            string? employeeName,department;
            double basicPay;
            readonly int bonus;
          

        public Employees(int employeeId, string? employeeName, string? department, double basicPay)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Department = department;
            BasicPay = basicPay;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string? EmployeeName { get => employeeName; set => employeeName = value; }
        public string? Department { get => department; set => department = value; }
        public double BasicPay { get => basicPay; set => basicPay = value; }

        public double CalculateSalary()
        {
            double netSalary, grossSalary,allowences,deductions;
            deductions = BasicPay * 0.1;
            allowences = BasicPay * 0.3 + BasicPay * 0.2+BasicPay*0.15;
            grossSalary = BasicPay + allowences;
            netSalary =grossSalary- deductions;
            return netSalary;
        }
    }
}
