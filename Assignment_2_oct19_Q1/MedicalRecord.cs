using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_oct19_Q1.ExceptionHandling;

namespace Assignment_2_oct19_Q1
{
    internal class MedicalRecord:Patient
    {
        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }

        List<MedicalRecord> MedicalRecords=new List<MedicalRecord>();

        public void AddMedicalRecord(int recordId,string? patientName,string? diagnosis,double treatmentCost)
        {
            MedicalRecord medicicalRecord = new MedicalRecord();    
            medicicalRecord.RecordId = recordId;
            if(string.IsNullOrEmpty(patientName) )
            {
                throw new InvalidPatientException("patient name should not be null");
            }
            else if(string.IsNullOrEmpty(diagnosis))
            {
                throw new InvalidPatientException("diagnosis should not be null");
            }
            else if (treatmentCost < 0)
            {
                throw new InvalidMedicalRecordException("treatment cost must be positive");
            }
            medicicalRecord.PatientName = patientName;
            medicicalRecord.Diaganosis = diagnosis;
            medicicalRecord.TreatmentCost = treatmentCost;
            MedicalRecords.Add(medicicalRecord);
        }
    }
}
