using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StaffDetails:College
    {
        public int StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Department { get; set; }
       
        public void DisplayStaffDetails()
        {
            Console.WriteLine("staffid:{0}\nStaff Name:{1}\nDepartment{2}", StaffId, StaffName, Department);
        }

    }
}
