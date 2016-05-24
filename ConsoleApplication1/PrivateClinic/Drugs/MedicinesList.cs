using System;
using System.Collections.Generic;

namespace PrivateClinic.Drugs
{
    public class MedicinesList
    {
        public List<Medicine> ListMedicines { get; set; }
        public List<string> ListSuppliers { get; set; }
        public MedicinesList()
        {
            ListMedicines = new List<Medicine>();
            ListSuppliers = new List<string>();
        }

        public void AddMedicine(Medicine _medicine)
        {

            ListMedicines.Add(_medicine);
            ListSuppliers.Add(_medicine.Fabricator);
            Console.Write("Success \n");

        }

        public void DeleteMedicine(string MedicineName)
        {
            foreach (Medicine mes in ListMedicines)
            {
                if (mes.Name == MedicineName)
                {
                    ListMedicines.Remove(mes);
                }
            }
        }
        virtual public void PrintInfo()
        {
            foreach (Medicine mes in ListMedicines)
            {
                Console.WriteLine("------------------AllMedicine--------------------");
                Console.WriteLine("Medicine name: " + mes.Name);
                Console.WriteLine("MfnufactureDate: " + mes.YearManufacture);
                Console.WriteLine("ExpirationDate: " + mes.ExpirationDate);
                Console.WriteLine("Fabricator: " + mes.Fabricator);
                Console.WriteLine("IssuedPrescription:");
                Console.WriteLine(mes.IssuedPrescription ? "Need" : "Don't need");
                Console.WriteLine("Price: " + mes.Price);
            }

        }

    }
}
