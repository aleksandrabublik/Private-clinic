using PrivateClinic.Historyes;

namespace PrivateClinic.Users
{
    public class Doctor : User
    {
        public Doctor(string _fName, string _lName)
        {
            FirstName = _fName;
            LastName = _lName;
            Role = "Doctor";
        }

        public History CreateHistory(AuthorlessPatient _patient)
        {
            History NewHistory = new History(_patient, this);
            return NewHistory;

        }

        public History History
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
