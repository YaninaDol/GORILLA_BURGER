using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveroo
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            
            InitializeComponent();
           
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            List<string> menuItem = new List<string>();
            menuItem.Add("Meal");
            menuItem.Add("Burgers");
            menuItem.Add("Fries");
            menuItem.Add("Drinks");
            menuItem.Add("Desserts");

            this.splitContainer1.Panel1.Controls.Clear();
            int x = 150;
            foreach (string item in menuItem)
            {
                MenuItems tmp = new MenuItems(item);
                tmp.Location = new Point(20, x);
                this.splitContainer1.Panel1.Controls.Add(tmp);
                x += tmp.Size.Height + 5;
            }
        }
    }
}
