using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveroo
{
    public partial class ProductUserControl : UserControl
    {
        public int ID;
        public ProductUserControl(int Id,string name,string subscribe,string price,string img)
        {
          
            InitializeComponent();
            ID = Id;   
            this.label1.Text = name;
            this.label2.Text = subscribe;
            this.label3.Text = price;
            this.pictureBox1.Image=GetImage(img);
            this.pictureBox1.Name = img;

           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Image GetImage(string name) 
        {
            var request = WebRequest.Create(name);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }

    }
}
