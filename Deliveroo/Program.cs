using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveroo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Application.Run(form1);
            MenuForm menuForm = new MenuForm();
            Application.Run(menuForm);
            Basket basket=new Basket(form1.user,menuForm.copy);
            Application.Run(basket);
        }
    }
}
