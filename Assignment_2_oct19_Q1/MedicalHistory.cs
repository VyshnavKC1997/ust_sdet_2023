using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class MedicalHistory
    {
        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }

        public static List<MedicalHistory> medicalHistories = new List<MedicalHistory>();

        public void AddHistory(int recordId,int patientId,string? description,string? date)
        {
            MedicalHistory medical=new MedicalHistory();
            medical.RecordId = recordId;
            medical.PatientId = patientId;
            medical.Description = description;
            medical.Date = date;

            medicalHistories.Add(medical);
        }
    }
}
