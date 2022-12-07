using GORILLA_BURGER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORILLA_BURGER
{
    public class UserController
    {
        private GorillaBurgerModel database;
        public List<USER> users;
        public UserController()
        {
            database = new GorillaBurgerModel();
            users = new List<USER>();
            users.AddRange(database.USERs.ToList());
        }
    }
}
