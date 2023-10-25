using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class Employee : Person,IDisplayable
    {
        int employeeId;
        public Employee(int employeeId,string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {
            this.employeeId = employeeId;
        }

       

       

        public void Displayinfo()
        {
            Console.WriteLine("Employee Id:{3}\tFull Name:{0} {1}\tAge:{2}", FirstName, LastName, Age, employeeId);
        }
    }
}
