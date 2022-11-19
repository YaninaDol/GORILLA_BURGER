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
        public Basket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string name=this.textBox1.Text;
           string area = this.textBox2.Text;
           string adress = this.textBox3.Text;
           string phone = this.textBox4.Text;
           DELIVERY_PERSON dELIVERY_PERSON=new DELIVERY_PERSON() {DELIVERY_PERSON_NAME= this.textBox1.Text,DELIVERY_PERSON_AREA= this.textBox2.Text,DELIVERY_PERSON_FULL_ADDRESS= this.textBox3.Text,DELIVERY_PERSON_CONTACTNUMBER= this.textBox4.Text };
            Model model=new Model();    
            model.DELIVERY_PERSON.Add(dELIVERY_PERSON); 
            int indx_person=model.DELIVERY_PERSON.ToList().IndexOf(dELIVERY_PERSON);   

        }
    }
}
