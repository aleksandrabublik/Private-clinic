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
            Console.WriteLine("Records: ");
            for (int i = 0; i < Schedule.Count(); i ++)
            {
                Console.WriteLine(Schedule[i].toString());
                Console.WriteLine();

            }
        }       
    }
}
