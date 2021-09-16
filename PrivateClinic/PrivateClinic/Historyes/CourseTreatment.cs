using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Historyes
{
    public class CourseTreatment
    {
        public string Treatment { get; set; }

        public CourseTreatment(string _treatment)
        {
            Treatment = _treatment;
        }
    }
}
