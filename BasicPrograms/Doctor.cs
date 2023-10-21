using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{ 
    internal class Doctor:IDoctor,IAppoinment
    {
        public int DoctorId { get; set; }
        public string? DoctorName { get; set; }

        public void AddNewDoctor()
        {
            DoctorId = 1234;
            DoctorName ="ASWANTH";
        }

        public void ModifyDoctor()
        {
            DoctorId = 5345;
            DoctorName = "SHYAM";
        }
        public void DisplayDoctorDEtails()
        {
            Console.WriteLine("DoctorId:{0}\nDoctorName:{1}",DoctorId,DoctorName);
        }

        public void BookApp(int patientId,string? patientName)
        {
            Console.WriteLine("Booked with patient id {0} Appoinment for {1} patient",patientId,patientName);
        }

        public void DeleteAppoinment(int patientId, string? patientName)
        {
            Console.WriteLine("Removed Booking with patient id {0} Appoinment for {1} patient", patientId, patientName);
        }
    }
}
