using PrivateClinic.Drugs;
using PrivateClinic.Schedulies;

namespace PrivateClinic.Users
{
    public class Administrator : User
    {

        public Administrator(string _fName, string _lName)
        {
            FirstName = _fName;
            LastName = _lName;
            Role = "Administrator";
        }

        public MedicinesList CreateMedicinesList()
        {
            MedicinesList MedList = new MedicinesList();
            return MedList;
        }

        public Scheduling CreateScheduling()
        {
            Scheduling Schedule = new Scheduling();
            return Schedule;
        }

        public Scheduling Scheduling
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public MedicinesList MedicinesList
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
