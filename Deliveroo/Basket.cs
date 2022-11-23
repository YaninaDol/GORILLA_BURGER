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
        private Controller controller;
        private List<LIST_PRODUCTS> selectProducts;
        List<PRODUCT> copy;
        private USER user;
        public Basket(USER user, List<PRODUCT> copy)
        {
            InitializeComponent();
            controller = new Controller();
            this.user= user;
            this.copy = copy;
            selectProducts = this.getList(this.copy);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string name=this.textBox1.Text;
           string area = this.textBox2.Text;
           string adress = this.textBox3.Text;
           string phone = this.textBox4.Text;
           DELIVERY_PERSON dELIVERY_PERSON=new DELIVERY_PERSON() {DELIVERY_PERSON_NAME= this.textBox1.Text,DELIVERY_PERSON_AREA= this.textBox2.Text,DELIVERY_PERSON_FULL_ADDRESS= this.textBox3.Text,DELIVERY_PERSON_CONTACTNUMBER= this.textBox4.Text };
            controller.gorillaBurgerList.DELIVERY_PERSON.Add(dELIVERY_PERSON); 
            int deliveryPersonId= controller.gorillaBurgerList.DELIVERY_PERSON.ToList().IndexOf(dELIVERY_PERSON);
            
            //int clientId = 1;


        }

        private void Basket_Load(object sender, EventArgs e)
        {
            int h = 0;
            foreach (var item in selectProducts)
            {
               BasketUserControl temp=new BasketUserControl(copy.ToList().Where(x=>x.PRODUCTID==item.PRODUCTID).FirstOrDefault().PRODUCT_NAME,item.COUNT,Convert.ToDouble( copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRICE));
                temp.Location = new Point(0, h);
                this.panel1.Controls.Add(temp);
                h += temp.Size.Height + 15;
            }
        }

        private List<LIST_PRODUCTS> getList(List<PRODUCT> copy)

        {
            selectProducts = new List<LIST_PRODUCTS>();
            foreach (var item in copy)
            {

                if(selectProducts.Contains(selectProducts.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault()))
                {
                    selectProducts.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().COUNT += 1;
                }
                else
                {
                    selectProducts.Add(new LIST_PRODUCTS() { PRODUCTID = item.PRODUCTID, COUNT = 1 });

                }
            }

            return selectProducts;
           
        }
    }
}
