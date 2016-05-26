using System;

using PrivateClinic.Users;

namespace PrivateClinic.Appointments
{
    public class Appointment
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public Doctor Doctor { get; private set; }

        public Doctor Doctor1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Appointment(string _name, double _price, Doctor _doctor)
        {
            Rename(_name);
            SetNewPrice(_price);
            SetDoctor(_doctor);
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
                string m_appointment = e.Message;
            }
        }

        public void SetNewPrice(double _price)
        {
            try
            {
                if (_price == Price)
                    throw new Exception("Entered price matches the current price!");
                else if (_price <= 0.0)
                    throw new Exception("Entered price is less $0.0!");

                Price = _price;
            }
            catch (Exception e)
            {
                string m_appointment = e.Message;
            }
        }

        public void SetDoctor(Doctor _doctor)
        {
            Doctor = _doctor;
        }

        public string toString()
        {
            string info = "";

            info += "\"" + Name + "\"\t";
            info += "doctor: " + Doctor.FirstName + " " + Doctor.LastName + ", ";
            info += "price: $" + Price + ")";

            return info;
        }

    }
}
