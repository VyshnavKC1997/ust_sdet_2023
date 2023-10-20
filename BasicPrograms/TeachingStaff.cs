using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class TeachingStaff:StaffDetails
    {
        public string? Specialisation { get; set; }
        public int Semester { get; set; }
        public void DisplayTeachingStaffDetails()
        {
            Console.WriteLine("Specialisation:{0}\nSemester:{1}", Specialisation, Semester);
        }
    }
}
