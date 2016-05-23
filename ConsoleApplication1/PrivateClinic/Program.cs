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
            testUsers();
          
        }
       
        static void testAppointnents() { }
        static void testDrugs() { }
        static void testHistories() {
            /*-----------------------------------------------------------------*/
            /*---------------------- Test History -----------------------------*/
            /*
            Console.WriteLine(" *** History *** ");

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
            */
        }
        static void testSchedulies() { }
        static void testUsers()
        {
            List<User> Users = new List<User>();

            Console.WriteLine();
            Console.WriteLine(" ***  CREATE USER  *** ");
            Console.WriteLine();

            string f_name, l_name;
            int n_role;
            bool exit = false;
            string ex;

            while (!exit)
            {
                try
                {
                    Console.Write("First name: ");
                    f_name = Console.ReadLine();

                    Console.Write("Last name: ");
                    l_name = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Changed role:");
                    Console.WriteLine(" 1. Administrator");
                    Console.WriteLine(" 2. Doctor");
                    Console.WriteLine(" 3. Operator");
                    Console.WriteLine(" 4. Authoreless patient");
                    Console.WriteLine();

                    n_role = 0;
                    while (n_role < 1 || n_role > 4)
                    {
                        Console.Write("Your role: ");
                        n_role = Convert.ToInt32(Console.ReadLine());
                        if (n_role < 1 || n_role > 4)
                            Console.WriteLine("Changed number role (1 - 4).");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Account create!");
                    Console.WriteLine();

                    switch (n_role)
                    {
                        case 1: Users.Add(new     Administrator(f_name, l_name)); Users.ElementAt(Users.Count-1).PrintInfo(); break;
                        case 2: Users.Add(new            Doctor(f_name, l_name)); Users.ElementAt(Users.Count-1).PrintInfo(); break;
                        case 3: Users.Add(new          Operator(f_name, l_name)); Users.ElementAt(Users.Count-1).PrintInfo(); break;
                        case 4: Users.Add(new AuthorlessPatient(f_name, l_name)); Users.ElementAt(Users.Count-1).PrintInfo(); break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    
                    ex = "a"; 
                    while (ex == "a")
                    {
                        Console.Write("Create new account? (y/n): "); ;
                        ex = Console.ReadLine();
                        if (ex == "n")
                            exit = true;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }

            








            /*-----------------------------------------------------------------*/
            /*------------------- Test Administrator --------------------------*/
            /*
            Console.WriteLine(" *** Administrator *** ");
            while (true)
            {
                Console.WriteLine();

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

            /*-----------------------------------------------------------------*/
            /*----------------------- Test Doctor -----------------------------*/
            /*
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

            /*-----------------------------------------------------------------*/
            /*---------------------- Test Operator ----------------------------*/
            /*
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

            /*-----------------------------------------------------------------*/
            /*------------------- Test Authorless Patient ---------------------*/
            /*
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
