using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal interface IAppoinment
    {
        void BookApp(int patientId, string? patientName);
        void DeleteAppoinment(int patientId, string? patientName);
    }
}
