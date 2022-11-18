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
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(string name,string subscribe,string price,Image img)
        {
          
            InitializeComponent();
            this.label1.Text = name;
            this.label2.Text = subscribe;
            this.label3.Text = price;
            this.pictureBox1.Image = img;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
