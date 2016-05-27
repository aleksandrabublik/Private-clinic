using System;
using System.Collections.Generic;

namespace PrivateClinic.Drugs
{
    public class MedicinesList
    {
        public List<Medicine> ListMedicines { get; set; }
        public List<string> ListSuppliers { get; set; }

        public Medicine Medicine
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

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
            Console.WriteLine(" ***  MEDICINES LIST  *** ");
            foreach (Medicine mes in ListMedicines)
            {
                int i = 1;
                Console.WriteLine(i++ + ".\tMedicine name: " + mes.Name);
                Console.WriteLine("\tManufacture date: " + mes.YearManufacture);
                Console.WriteLine("\tExpiration date: " + mes.ExpirationDate);
                Console.WriteLine("\tFabricator: " + mes.Fabricator);
                Console.Write("\tPrescription: ");
                Console.WriteLine(mes.IssuedPrescription ? "Need" : "Don't need");
                Console.WriteLine("\tPrice: " + mes.Price);
            }

        }

    }
}
