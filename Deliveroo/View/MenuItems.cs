using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GORILLA_BURGER
{
    public partial class MenuItems : UserControl
    {
        public MenuItems(string textItem)
        {
            
            InitializeComponent();
            this.label1.Text = textItem;
        }
    }
}
