using Assignment_2_oct19_Q1.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Assignment_2_oct19_Q1
{
    internal class Patient
    {
        public static List<Patient> patients = new List<Patient>(); 
        public int PatientId { get; set; }
        public string? PatientName { get; set;}
        public int Age { get; set; }
        public string? Diaganosis { get; set; }

        public void GetPatient(int patientId,int age,string? name,string? diagnosis)
        {
            if (age <= 0 || age >= 120)
            {
                throw new PatientException(PatientException.message["age"]);
            }
            else if (string.IsNullOrEmpty(diagnosis))
            {
                throw new PatientException(PatientException.message["diagNull"]);
            }
            else if (string.IsNullOrEmpty(name))
            {
                throw new PatientException(PatientException.message["NameNull"]);
            }
            else
            {
                PatientId = patientId;
                PatientName = name;
                Age = age;
                Diaganosis = diagnosis;
               Patient patient = new Patient();
                patients.Add(patient);
            }
            
        }


    }
}
