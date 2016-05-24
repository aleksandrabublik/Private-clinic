using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Schedulies
{
    public class Scheduling
    {
        public List<Record> Schedule { get; private set; }
        public Scheduling ()
        {
            Schedule = new List<Record>();
        }
        public void AddRecord (Record _rec)
        {
            Schedule.Add(_rec);
            Console.WriteLine("Record Create Success \n");
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
        public void PrintSchedule()
        {
            for (int i = 0; i < Schedule.Count(); i ++)
            {
                Console.WriteLine("Record Time: " + Schedule[i].Date);
                Console.WriteLine();
                Console.WriteLine("Patient Name: " + Schedule[i].Patient.FirstName + " " + Schedule[i].Patient.LastName);
                Console.WriteLine();
                Console.WriteLine("Doctor Name: " + Schedule[i].Procedure.Doctor.FirstName + " " + Schedule[i].Procedure.Doctor.FirstName);
                Console.WriteLine();
                Console.WriteLine("Procedure: " + Schedule[i].Procedure.Name + " Price: " + Schedule[i].Procedure.Price);
                Console.WriteLine();
            }   
        }       
    }
}
