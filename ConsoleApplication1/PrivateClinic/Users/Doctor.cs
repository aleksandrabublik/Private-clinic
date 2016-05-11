using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
