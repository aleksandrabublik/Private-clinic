using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateClinic.Users;
using PrivateClinic.Appointments;

namespace PrivateClinic.Schedulies
{
   public  class Record
    {
        public Appointment Procedure { get; private set; }
        public AuthorlessPatient Patient { get; private set; }
        public   DateTime Date { get; private set; }
     
        public Record (Appointment _appointment, AuthorlessPatient _patiet, DateTime _date)
        {
            Procedure = _appointment;
            Patient = _patiet;
            Date = _date;
        }
    }
}
