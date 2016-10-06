using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILogable
    {
        public Customer():this(0)
        {

        }

        public Customer(int customerID)
        {
            this.CustomerId = customerID;
            AddressList=new List<Address>();
        }
        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public string  EmailAddress { get; set; }
        public int CustomerId { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public string FullName
        {
            get
            {
                string fullName=LastName;
                if(!string.IsNullOrWhiteSpace(Firstname))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                }
                fullName += Firstname;
                return fullName;
            }
        }
        public override bool Validate()
        {
            var isValid=true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
        public string Log()
        {
            var logstring = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.EmailAddress + " " +
                            "Status: " + this.EntityState.ToString();
            return logstring;
        }
    }
}
