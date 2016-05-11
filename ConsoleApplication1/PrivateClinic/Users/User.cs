using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Users
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }

        public User() { }

        virtual public bool Login(string _fName, string _lName)
        {
            try
            {
                if (_fName != FirstName)
                    throw new Exception("You entered is unvalidate first name!");
                else if (_lName != LastName)
                    throw new Exception("You entered is unvalidate last name!");

                Console.WriteLine("Hello, {0} {1}!", FirstName, LastName);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        virtual public void Logout()
        {
            Console.WriteLine("Goodby, " + FirstName);
        }

        virtual public void PrintInfo()
        {
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Role: " + Role);
        }
    }
}
