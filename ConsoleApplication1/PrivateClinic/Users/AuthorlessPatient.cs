namespace PrivateClinic.Users
{
    public class AuthorlessPatient : User
    {
        public AuthorlessPatient(string _fName, string _lName)
        {
            FirstName = _fName;
            LastName = _lName;
            Role = "Authorless patient";
        }

        public Historyes.History History
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public Appointments.PriceListAppointments PriceListAppointments
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
