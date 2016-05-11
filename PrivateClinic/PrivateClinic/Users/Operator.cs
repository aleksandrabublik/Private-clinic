using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Users
{
    public class Operator : User
    {
        public Operator(string _fname, string _lname)
        {
            FirstName = _fname;
            LastName = _lname;
            Role = "Operator";
        }
    }
}
