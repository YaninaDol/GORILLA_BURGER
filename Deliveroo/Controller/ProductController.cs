using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORILLA_BURGER
{
    public class ProductController
    {
        private GorillaBurgerModel database = new GorillaBurgerModel();
        public List<PRODUCT> products;
        public ProductController()
        {
            products = new List<PRODUCT>();
            products.AddRange(database.PRODUCTs.ToList());
        }
    }
}
