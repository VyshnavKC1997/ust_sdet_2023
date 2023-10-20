using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NonTeachingStaff:StaffDetails
    {
        public string? Responsibilities { get; set; }
        public int Expirence { get; set; }

        public void DisplayNonTeachingStaffDetails()
        {
            Console.WriteLine("Responsibilities:{0}\nExperience:{1}", Responsibilities, Expirence);
        }
    }
}
