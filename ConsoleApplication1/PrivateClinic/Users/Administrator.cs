﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
