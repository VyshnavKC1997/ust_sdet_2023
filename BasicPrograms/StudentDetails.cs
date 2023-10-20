using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StudentDetails
    {
    /*    public StudentDetails(int rollNumber, string? studentName, string? city)
        {
            RollNumber = rollNumber;
            StudentName = studentName;
            City = city;
        }
*/
        public int RollNumber { get; set; }
        public string? StudentName { get; set; }
        public string? City { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll no:{0}\nName:{1}\nCity:{2}\n",RollNumber,StudentName,City);
        }
    }
}
