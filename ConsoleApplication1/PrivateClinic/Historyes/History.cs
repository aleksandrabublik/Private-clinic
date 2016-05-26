using System;
using System.Collections.Generic;
using System.Linq;

using PrivateClinic.Drugs;
using PrivateClinic.Users;

namespace PrivateClinic.Historyes
{
    public class History
    {
        public AuthorlessPatient PatientAccount { get; private set; }
        public Doctor DoctorAccount { get; private set; }
        public string Treatment { get; private set; }
        public string Prescription { get; private set; }
        public CourseTreatment Course { get; private set; }
        public List<Medicine> DrugList { get; private set; }


        public History(
            AuthorlessPatient _patient,
            Doctor _doctor)
        {
            PatientAccount = _patient;
            DoctorAccount = _doctor;
        }

        public void CreateDrageList()
        {
            DrugList = new List<Medicine>();
        }
        public void EditTreatment(string _treatment)
        {
            Treatment = _treatment;
        }

        public void EditPrescription(string _prescription)
        {
            Prescription = _prescription;
        }

        public void CreateCourseTreatment(CourseTreatment _course)
        {
            Course = _course;
        }

        public void AddDragsForPatient (Medicine med)
        {
            DrugList.Add(med);
        }


        public void RemoveDrags(string name)
        {
            for (int i = 0; i < DrugList.Count(); i++)
            {
                if (DrugList[i].Name == name)
                {
                    DrugList.Remove(DrugList[i]);
                }
            }
        }


        public void PrintHistory()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tHistory");
            Console.WriteLine();
            Console.WriteLine("Patient: {0} {1}", PatientAccount.FirstName, PatientAccount.LastName);
            Console.WriteLine();
            Console.WriteLine("Doctor: {0} {1}.", DoctorAccount.FirstName, DoctorAccount.LastName);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tCourse of treatment");
            Console.WriteLine();
            Console.WriteLine(Course.Treatment);
            Console.WriteLine();
            Console.Write("Drugs: ");
            for (int i = 0; i < DrugList.Count(); i ++ )
            {
                Console.WriteLine("Name:" + i+1 + " " + DrugList[i].Name);
            }
               
            Console.WriteLine();



        }


        public CourseTreatment CourseTreatment
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }


    }
}
