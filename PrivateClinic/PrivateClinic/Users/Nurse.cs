using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Users
{
    public class Nurse : User
    {
        public Nurse(string _fname, string _lname)
        {
            FirstName = _fname;
            LastName = _lname;
            Role = "Nurse";
        }
    }
}
