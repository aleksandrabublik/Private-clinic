using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Appointments
{
    public class Appointment
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Appointment(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
    }
}
