using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressID)
        {
            Address address = new Address(addressID);
            if (addressID == 1)
            {
                address.AddressType = 1;
                address.City = "HCM";
                address.Country = "Vietnam";
                address.PostCode = "221";
                address.State = "";
                address.StreetLine1 = "Line1";
                address.StreetLine2 = "Line2";
            }
            return address;
        }

        public List<Address> Retrieve()
        {
            return new List<Address>();
        }

        // Retrieve by customer id
        public IEnumerable<Address> RetrieveByCustomerID (int customerID)
        {

            var addressList = new List<Address>();
            //Temporary data
            Address address = new Address(1);
            {
                address.AddressType = 1;
                address.City = "HCM";
                address.Country = "Vietnam";
                address.PostCode = "221";
                address.State = "HCM";
                address.StreetLine1 = "Line1";
                address.StreetLine2 = "Line2";
            }
            addressList.Add(address);
            address = new Address(1);
            {
                address.AddressType = 2;
                address.City = "Heilbronn";
                address.Country = "Germany";
                address.PostCode = "74074";
                address.State = "Baden";
                address.StreetLine1 = "Line3";
                address.StreetLine2 = "Line4";
            }
            addressList.Add(address);

            return addressList;
        }
        public bool Save()
        {
            return true;
        }
    }
}
