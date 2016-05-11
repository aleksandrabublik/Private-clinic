using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrivateClinic.Appointments;
using PrivateClinic.Drugs;
using PrivateClinic.Historyes;
using PrivateClinic.Users;

namespace PrivateClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;

            Administrator admin = new Administrator("Ivan", "Sergeev");
            Doctor doctor = new Doctor("Sergei", "Ivanov");
            Operator operat = new Operator("Petr", "Petrov");
            AuthorlessPatient patient = new AuthorlessPatient("Vasja", "");

            History history = new History(patient, doctor);

            /*-----------------------------------------------------------------*/

            Console.WriteLine("Treatment:");
            string treat = Console.ReadLine();
            history.EditTreatment(treat);
            Console.WriteLine("Prescription:");
            string pres = Console.ReadLine();
            history.EditPrescription(pres);
            Console.WriteLine("Cource of Treatment:");
            string course = Console.ReadLine();
            history.CreateCourseTreatment(new CourseTreatment(course));
            history.PrintHistory();
            
            /*-----------------------------------------------------------------*

            Console.WriteLine(" *** Administrator *** ");
            while (true)
            {
                Console.WritegsLine();
                Console.Write("First Name: ");
                fname = Console.ReadLine();
                Console.Write("Last name: ");
                lname = Console.ReadLine();
                Console.WriteLine();
                if (admin.Login(fname, lname))
                    break;
            }
            Console.WriteLine();
            admin.PrintInfo();
            Console.WriteLine();
            admin.Logout();
            Console.WriteLine();

            /*-----------------------------------------------------------------*

            Console.WriteLine(" *** Doctor *** ");
            while (true)
            {
                Console.WriteLine();
                Console.Write("First Name: ");
                fname = Console.ReadLine();
                Console.Write("Last name: ");
                lname = Console.ReadLine();
                Console.WriteLine();
                if (doctor.Login(fname, lname))
                    break;
            }
            Console.WriteLine();
            doctor.PrintInfo();
            Console.WriteLine();
            doctor.Logout();
            Console.WriteLine();

            /*-----------------------------------------------------------------*

            Console.WriteLine(" *** Operator *** ");
            while (true)
            {
                Console.WriteLine();
                Console.Write("First Name: ");
                fname = Console.ReadLine();
                Console.Write("Last name: ");
                lname = Console.ReadLine();
                Console.WriteLine();
                if (operat.Login(fname, lname))
                    break;
            }
            Console.WriteLine();
            operat.PrintInfo();
            Console.WriteLine();
            operat.Logout();
            Console.WriteLine();

            /*-----------------------------------------------------------------*

            Console.WriteLine(" *** Authorless Patient *** ");
            while (true)
            {
                Console.WriteLine();
                Console.Write("First Name: ");
                fname = Console.ReadLine();
                Console.Write("Last name: ");
                lname = Console.ReadLine();
                Console.WriteLine();
                if (patient.Login(fname, lname))
                    break;
            }
            Console.WriteLine();
            patient.PrintInfo();
            Console.WriteLine();
            patient.Logout();
            Console.WriteLine();

            /*-----------------------------------------------------------------*/

        }
    }
}
