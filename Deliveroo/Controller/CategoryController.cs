using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORILLA_BURGER
{
    public class CategoryController
    {
        private GorillaBurgerModel database;
        public List <CATEGORY> categories ;
        public CategoryController()
        {
            database = new GorillaBurgerModel();
            categories = new List<CATEGORY>();
            categories.AddRange(database.CATEGORies.ToList());  
        }
    }
}
