using Northwind.DataAccess.Concrete;
using Northwind.Entities3.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {

        ProductDal productDal = new ProductDal();
        public List<Product> GetAll() 
        {
            //business code 
            
            return productDal.GetAll();

        }
    }
}
