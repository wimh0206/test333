using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);
            if (productID == 1)
            {
                product.ProductName = "soft1";
                product.ProductDescription = "Nhu";
                product.CurrentPrice = 200;
            }
            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    //call an insert stored procedure
                }
                else
                {
                    //call an upate store procedure
                }
            }
            return success;
        }
    }
}
