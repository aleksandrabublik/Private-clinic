using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Drugs
{
    public class MedicinesList
    {
        public List<Medicine> ListMedicines;
        public List<string> ListSuppliers;

        public MedicinesList()
        {
            
        }

        public void AddMedicine(Medicine _medicine)
        {
            ListMedicines.Add(_medicine);
            ListSuppliers.Add(_medicine.Fabricator);
        }
        


    }
}
