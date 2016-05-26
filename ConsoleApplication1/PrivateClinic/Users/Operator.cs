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
