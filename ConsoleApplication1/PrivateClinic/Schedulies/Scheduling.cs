using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace PrivateClinic.Schedulies
{
    public class Scheduling
    {
        public List<Record> Schedule { get; private set; }
        public Record Record
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Scheduling ()
        {
            Schedule = new List<Record>();
        }

        public void AddRecord (Record _rec)
        {
            Schedule.Add(_rec);
            Console.WriteLine("Record Create Success \n");
        }

        public void PrintSchedule()
        {
            Console.WriteLine("Records: ");
            for (int i = 0; i < Schedule.Count(); i++)
            {

                Console.WriteLine(Schedule[i].toString());

                Console.WriteLine("Record Time:" + Schedule[i].Date.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
                Console.WriteLine();
                Console.WriteLine("Patient Name: " + Schedule[i].Patient.FirstName + " " + Schedule[i].Patient.LastName);
                Console.WriteLine();
                Console.WriteLine("Doctor Name: " + Schedule[i].Procedure.Doctor.FirstName + " " + Schedule[i].Procedure.Doctor.LastName);
                Console.WriteLine();

            }
        }

        public bool CheckRecord(Record _rec)
        {
            bool a = true;
            for (int i = 0; i < Schedule.Count(); i++)
            {
                if (Schedule[i].Date == _rec.Date && Schedule[i].Procedure.Doctor.FirstName == _rec.Procedure.Doctor.FirstName)
                {
                    a = false;
                }
                else a = true;
            }
            return a;

        }
        public void RemoveRecord (string _doctorLName, DateTime _date)
        {
            for (int i = 0; i < Schedule.Count(); i ++)
            {
                if (Schedule[i].Date == _date && Schedule[i].Procedure.Doctor.LastName == _doctorLName)
                {
                    Schedule.Remove(Schedule[i]);
                }
            }
        }
              
    }
}
