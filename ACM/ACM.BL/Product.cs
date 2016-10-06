using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product:EntityBase, ILogable
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            this.ProductID=ProductID;
        }
        public Decimal? CurrentPrice { get; set; }
        public int ProductID { get; private set; }
        public string ProductDescription { get; set; }
        private String _ProductName;

        public String ProductName
        {
            get {
                return _ProductName.InsertSpace();
                //return StringHandler.InsertSpace(_ProductName);
            }
            set { _ProductName = value; }
        }
        
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice ==null) isValid = false;
            return isValid;
        }

        public Product Retrieve(int customerID)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public string Log()
        {
            var logstring = this.ProductID + ": " +
                            this.ProductName + " " +
                            "Detail: " + this.ProductDescription + " " +
                            "Status: " + this.EntityState.ToString();
            return logstring;
        }
      
    }
}
