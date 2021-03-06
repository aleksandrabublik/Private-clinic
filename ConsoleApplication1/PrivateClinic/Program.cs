﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Globalization;

using PrivateClinic.Appointments;
using PrivateClinic.Drugs;
using PrivateClinic.Historyes;
using PrivateClinic.Users;
using PrivateClinic.Schedulies;
namespace PrivateClinic
{

    class Program
    {
        

        static void Main(string[] args)
        {

           List<User> Users = testCreateUsers();
           testLoginUsers(Users);
           testDrugs();
           testAppointnents();
           testHistories();
           testSchedulies();
        }

        static List<User> testCreateUsers()
        {
            List<User> Users = new List<User>();

            Console.WriteLine();
            Console.WriteLine(" ***  CREATE USERS  *** ");
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
                        case 1: Users.Add(new Administrator(f_name, l_name)); break;
                        case 2: Users.Add(new Doctor(f_name, l_name)); break;
                        case 3: Users.Add(new Operator(f_name, l_name)); break;
                        case 4: Users.Add(new AuthorlessPatient(f_name, l_name)); break;
                    }
                    Console.WriteLine();

                    ex = "a";
                    while (ex == "a")
                    {
                        Console.Write("Create new account? (y/n): "); ;
                        ex = Console.ReadLine();
                        if (ex == "n")
                        {
                            exit = true;
                            Console.WriteLine();
                            for (int i = 0; i < Users.Count; i++)
                            {
                                Users.ElementAt(i).PrintInfo();
                                Console.WriteLine();
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }

            return Users;
        }
        static void testLoginUsers(List<User> users)
        {
            string fname, lname;
            bool exit = false;
            string ex;

            Console.WriteLine();
            Console.WriteLine(" ***  TEST LOGIN/LOGOUT  *** ");
            Console.WriteLine();


            while (!exit)
            {
                Console.WriteLine();

                Console.Write("First Name: ");
                fname = Console.ReadLine();

                Console.Write("Last name: ");
                lname = Console.ReadLine();
                Console.WriteLine();

                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Login(fname, lname))
                    {
                        users[i].Logout();
                        break;
                    }
                    else if (i == users.Count - 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You not create account!");
                    }
                }

                Console.WriteLine();

                ex = "a";
                while (ex == "a")
                {
                    Console.Write("Login next account? (y/n): "); ;
                    ex = Console.ReadLine();
                    if (ex == "n")
                    {
                        exit = true;
                        Console.WriteLine();
                    }
                }
            }
        }
        static void testAppointnents()
        {
            string nameList;
            string nameAppointment;
            double price;

            bool exit = false;
            string ex;

            Console.WriteLine();
            Console.WriteLine(" ***  TEST APPOINTMENTS  *** ");
            Console.WriteLine();

            Console.WriteLine("Creating price list.");
            Console.Write("Name: ");
            nameList = Console.ReadLine();
            PriceListAppointments priceList = new PriceListAppointments(nameList);
            Console.WriteLine();
            Console.WriteLine("Price list is created!");

            Doctor House = new Doctor("House", "Gragory");


            Console.WriteLine();
            Console.WriteLine("Create appointments.");
            while (!exit)
            {
                Console.Write("Name: ");
                nameAppointment = Console.ReadLine();

                Console.Write("Price: $");
                price = Convert.ToDouble(Console.ReadLine());

                priceList.AddAppointment(new Appointment(nameAppointment, price, House));

                Console.WriteLine();

                ex = "a";
                while (ex == "a")
                {
                    Console.Write("Create new appointment? (y/n): ");
                    ex = Console.ReadLine();
                    if (ex == "n")
                    {
                        exit = true;
                        Console.WriteLine();
                    }
                }

                if (exit)
                    Console.WriteLine(priceList.toString());

            }

        }
        static void testDrugs()
        {
            Console.WriteLine();
            Console.WriteLine(" ***  TEST DRAGS *** ");
            Console.WriteLine();

            string _drugsName, fubricator;
            bool Prescription;
            DateTime fData, sData;
            double price;
            bool exit = false;

            Administrator Admin = new Administrator("Wasya", "Pupkin");
            MedicinesList MedList = Admin.CreateMedicinesList();

            while (!exit)
            {
                try
                {
                    Console.Write("Drugs name: ");
                    _drugsName = Console.ReadLine();

                    Console.Write("Manufacture data: ");
                    fData = DateTime.Parse(Console.ReadLine());

                    Console.Write("Expiration data: ");
                    sData = DateTime.Parse(Console.ReadLine());



                    Console.Write("Fubricator name: ");
                    fubricator = Console.ReadLine();

                    Console.Write("Prescription need? (y/n):");
                    {
                        if (Console.ReadLine() == "y")
                        {
                            Prescription = true;
                        }
                        else
                        {
                            Prescription = false;
                        }
                    }

                    Console.Write("Entered price: ");
                    price = double.Parse(Console.ReadLine());
                    Medicine Drug = new Medicine(_drugsName, fData, sData, fubricator, Prescription, price);
                    MedList.AddMedicine(Drug);
                    string a = "a";
                    while (a == "a")
                    {
                        Console.Write("Add new Drug? (y/n): "); ;
                        a = Console.ReadLine();
                        if (a == "n")
                        {
                            exit = true;
                            MedList.PrintInfo();
                            Console.WriteLine();

                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }



        }
        static void testHistories() {
            string Prescription, CourseTreatmen, Recomendation;

            Medicine Tea = new Medicine("Tea", new DateTime(1996, 01, 01), new DateTime(2010, 01, 01), "Zavod Pupkina", true, 3);

            Console.WriteLine(" *** HISTORY *** ");
            AuthorlessPatient Patient = new AuthorlessPatient("Super", "Max");
            Doctor Docer = new Doctor("Gregory", "House");
            History newHistory = Docer.CreateHistory(Patient);

            newHistory.CreateDrageList();

            Console.WriteLine("Write some Prescription");
            Prescription = Console.ReadLine();
            newHistory.EditPrescription(Prescription);

            Console.WriteLine("Add some drugs: Tea");
            newHistory.AddDragsForPatient(Tea);

            Console.WriteLine("Add some recomendation");
            Recomendation = Console.ReadLine();
            newHistory.EditTreatment(Recomendation);


            Console.WriteLine("Write Course Treatment for patient");
            CourseTreatmen = Console.ReadLine();
            CourseTreatment CourseTreatmentForPatient = new CourseTreatment(CourseTreatmen);
            newHistory.CreateCourseTreatment(CourseTreatmentForPatient);

            newHistory.PrintHistory();
        }
        static void testSchedulies() {
            bool exit = false;

            Console.WriteLine(" *** SCHEDULING *** ");

            while (!exit)
            {
                Administrator Admin = new Administrator("Supet", "Max");
                Scheduling Schedule = Admin.CreateScheduling();
                try
                {
                    Console.Write("Your first name: ");
                    string fName = Console.ReadLine();
                    Console.Write("Your last name: ");
                    string lName = Console.ReadLine();
                    AuthorlessPatient Patient = new AuthorlessPatient(fName, lName);

                    Doctor Doct = new Doctor("Gregory", "House");
                    Console.Write("Procedure: ");
                    string nameApp = Console.ReadLine();
                    Appointment Procedura = new Appointment(nameApp, 50, Doct);

                    Console.Write("Chose time: ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());

                    Record newRecord = new Record(Procedura, Patient, date);
                    Schedule.Schedule.Add(newRecord);


                    string a = "a";
                    while (a == "a")
                    {
                        Console.Write("Add new procedure? (y/n): "); ;
                        a = Console.ReadLine();
                        if (a == "n")
                        {
                            exit = true;
                            Schedule.PrintSchedule();
                            Console.WriteLine();

                        }
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }
            

        }
        
    }
}
