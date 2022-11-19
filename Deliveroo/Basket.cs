using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Basket : Form
    {
        private Model model;
        private string clientLogin;
        private List<PRODUCT> selectProducts;
        public Basket(string LOGIN, List<PRODUCT> copy)
        {
            InitializeComponent();
            model = new Model();
            
            clientLogin=LOGIN;
            this.textBox1.Text = clientLogin;
            selectProducts= copy;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string name=this.textBox1.Text;
           string area = this.textBox2.Text;
           string adress = this.textBox3.Text;
           string phone = this.textBox4.Text;
           DELIVERY_PERSON dELIVERY_PERSON=new DELIVERY_PERSON() {DELIVERY_PERSON_NAME= this.textBox1.Text,DELIVERY_PERSON_AREA= this.textBox2.Text,DELIVERY_PERSON_FULL_ADDRESS= this.textBox3.Text,DELIVERY_PERSON_CONTACTNUMBER= this.textBox4.Text };
          
            model.DELIVERY_PERSON.Add(dELIVERY_PERSON); 
            int personId=model.DELIVERY_PERSON.ToList().IndexOf(dELIVERY_PERSON);
            int clientId=model.CLIENTs.ToList().IndexOf(model.CLIENTs.Where(x=>x.CLIENT_LOGIN== clientLogin).FirstOrDefault());
            
            //int clientId = 1;


        }

        private void Basket_Load(object sender, EventArgs e)
        {
            int h = 0;
            foreach (var item in selectProducts)
            {
                ProductUserControl temp = new ProductUserControl(item.PRODUCT_NAME.ToString(), item.PRODUCT_SUBSCRIBE.ToString(), $"{item.PRICE.ToString()} AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
               
                temp.Location = new Point(0, h);
                this.panel1.Controls.Add(temp);
                h += temp.Size.Height + 15;
            }
        }
    }
}
