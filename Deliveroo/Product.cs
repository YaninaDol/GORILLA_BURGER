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
    public partial class Product : UserControl
    {
        public Product(string Title,string Subscribe,string price,Image image)
        {
            InitializeComponent();
            this.label1.Text = Title;
            this.label2.Text = Subscribe;
            this.label3.Text = price;
            this.pictureBox1.Image = image;
        }
    }
}
