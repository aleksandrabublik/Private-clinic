using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public void PrintHistory()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tHistory");
            Console.WriteLine();
            Console.WriteLine("Patient:");
            Console.WriteLine("First name: " + PatientAccount.FirstName);
            Console.WriteLine("Last name:  " + PatientAccount.LastName);
            Console.WriteLine();
            Console.WriteLine("Doctor: {0} {1}.", DoctorAccount.FirstName, DoctorAccount.LastName);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tCourse of treatment");
            Console.WriteLine();
            Console.WriteLine(Course.Treatment);
            Console.WriteLine();
            Console.Write("Drugs: ");
            Console.WriteLine("No drugs!!!!!!");
            Console.WriteLine();



        }



    }
}
