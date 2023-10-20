using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class College
    {
        public int CollegeId { get; set; }
        public string? CollegeName { get; set; }

        public void DisplayCollegeDeatails()
        {
            Console.WriteLine("ColegeID:{0}\nCollegeName:{1}", CollegeId, CollegeName);
        }
    }
}
