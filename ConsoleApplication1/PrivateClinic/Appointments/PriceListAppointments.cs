using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Appointments
{
    public class PriceListAppointments
    {
        public string Name { get; private set; }

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

        private List<Appointment> ListAppointment;

        public PriceListAppointments(string _name)
        {
            Rename(_name);
            ListAppointment = new List<Appointment>();
        }

        public void Rename(string _name)
        {
            try
            {
                if (_name == Name)
                    throw new Exception("Entered name matches the current name!");
                else if (_name == "")
                    throw new Exception("Entered name is empty!");

                Name = _name;
            }
            catch (Exception e)
            {
                string m_appointmentList = e.Message;
            }
        }

        public void AddAppointment(Appointment _appointment)
        {
            ListAppointment.Add(_appointment);
        }
        public void RemoveAppintment(Appointment _appointment)
        {
            ListAppointment.Remove(_appointment);
        }
        public int Count()
        {
            return ListAppointment.Count();
        }

        public string toString()
        {
            string pricelist = "";

            pricelist += " ***  LIST APPOINTMENTS *** \n";
            for (int i = 0; i < ListAppointment.Count(); i++)
            {
                pricelist += (i + 1) +  ".\t" + ListAppointment[i].toString() + "\n";
            }

            return pricelist;
        }

    }
}
