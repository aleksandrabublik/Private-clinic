using System;

using PrivateClinic.Users;
using PrivateClinic.Appointments;

namespace PrivateClinic.Schedulies
{
   public  class Record
    {
        public Appointment Procedure { get; private set; }
        public AuthorlessPatient Patient { get; private set; }
        public DateTime Date { get; private set; }

        public Appointment Appointment
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public AuthorlessPatient AuthorlessPatient
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Record (Appointment _appointment, AuthorlessPatient _patiet, DateTime _date)
        {
            Procedure = _appointment;
            Patient = _patiet;
            Date = _date;
        }

        public string toString()
        {
            string info = "";

            info += Patient.FirstName + " " + Patient.LastName + "\n";
            info += "-------------------------------------\n";
            info += "Date: " + Date.Day + " " + Date.Month + " " + Date.Year + "\n";
            info += "Time: " + Date.Hour + ":" + Date.Minute + "\n";
            info += "-------------------------------------\n";
            info += "Procedure | " + Procedure.Name + "\n";
            info += "Doctor    | " + Procedure.Doctor.FirstName + " " + Procedure.Doctor.LastName +  "\n";
            
            return info;
        }


    }
}
