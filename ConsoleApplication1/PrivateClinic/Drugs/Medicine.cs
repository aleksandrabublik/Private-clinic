using System;

namespace PrivateClinic.Drugs
{
    public class Medicine
    {
        public string Name { get; set; }
        public DateTime YearManufacture { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public string Fabricator { get; private set; }
        public bool IssuedPrescription { get; set; }
        public double Price { get; private set; }

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


        public void ChangePrice(double _price)
        {
            Price = _price;
        }



    }
}
