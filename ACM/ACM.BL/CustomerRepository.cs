using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerID)
        {
            Customer customer = new Customer(customerID);
            customer.AddressList = addressRepository.RetrieveByCustomerID(customerID).ToList();
            if (customerID == 1)
            {
                //customer.CustomerId = 1;
                customer.EmailAddress = "wimh0206@yahoo.com.vn";
                customer.Firstname = "Nhu";
                customer.LastName = "Nguyen";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
