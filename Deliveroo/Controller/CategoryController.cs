using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliveroo
{
    public class CategoryController
    {
        private GorillaBurgerModel database=new GorillaBurgerModel();
        public List <CATEGORY> categories ;
        public CategoryController()
        {
            categories = new List<CATEGORY>();
            categories.AddRange(database.CATEGORies.ToList());  
        }
    }
}
