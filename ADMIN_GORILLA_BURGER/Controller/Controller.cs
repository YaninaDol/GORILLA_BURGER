using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMIN_GORILLA_BURGER
{
    public class Controller
    {
       private GBModel users=new GBModel();
       public List<USER> usersList;

        public Controller()
        {
            usersList = new List<USER>();
            usersList.AddRange(users.USERs.ToList());
        }

    }
}
