using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClinic.Drugs
{
    public class Medicine
    {
        public string Name { get; set; }
        public DateTime YearManufacture { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Fabricator { get; set; }
        public bool IssuedPrescription { get; set; }
        public double Price { get; set; }

        public Medicine(
            string _name, 
            DateTime _manufacture, 
            DateTime _expiration, 
            string _fabricator,
            bool _issuedPrescription,
            double _price)
        {
            Name = _name;
            YearManufacture = _manufacture;
            ExpirationDate = _expiration;
            Fabricator = _fabricator;
            IssuedPrescription = _issuedPrescription;
            Price = _price;
        }



    }
}
