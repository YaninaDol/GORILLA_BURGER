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
           //string name=this.textBox1.Text;
           //string area = this.textBox2.Text;
           //string adress = this.textBox3.Text;
           //string phone = this.textBox4.Text;
           //DELIVERY_PERSON dELIVERY_PERSON=new DELIVERY_PERSON() {DELIVERY_PERSON_NAME= this.textBox1.Text,DELIVERY_PERSON_AREA= this.textBox2.Text,DELIVERY_PERSON_FULL_ADDRESS= this.textBox3.Text,DELIVERY_PERSON_CONTACTNUMBER= this.textBox4.Text };
           // controller.gorillaBurgerList.DELIVERY_PERSONS.Add(dELIVERY_PERSON); 
           //int deliveryPersonId= controller.gorillaBurgerList.DELIVERY_PERSONS.ToList().IndexOf(dELIVERY_PERSON);

           // foreach (var item in selectProducts)
           // {
           //     LIST_PRODUCTS items = new LIST_PRODUCTS() { PRODUCTID = item.PRODUCTID, COUNT = item.COUNT };
           //     controller.gorillaBurgerList.LIST_PRODUCTSS.Add(items);
           // }


            LIST_PRODUCTS items1 = new LIST_PRODUCTS() { PRODUCTID =48, COUNT = 1 };
          
            controller.gorillaBurgerList.LIST_PRODUCTS.Add(items1);
          

            controller.gorillaBurgerList.SaveChanges(); 
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            int h = 0;
            double total = 0;
            foreach (var item in selectProducts)
            {
               BasketUserControl temp=new BasketUserControl(Convert.ToInt32(item.PRODUCTID), copy.ToList().Where(x=>x.PRODUCTID==item.PRODUCTID).FirstOrDefault().PRODUCT_NAME,item.COUNT,Convert.ToDouble( copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRICE));
                temp.Location = new Point(0, h);
                temp.button1.Click += Button1_Click;
                temp.button2.Click += Button2_Click;
                temp.button3.Click += UC_Button3_Click;
                this.panel1.Controls.Add(temp);
                total += Convert.ToDouble(temp.Price.Text);
               h += temp.Size.Height + 10;
            }
            this.Total.Text= $"Total: \t {total} AED";  
        }

        private void UC_Button3_Click(object sender, EventArgs e)
        {
            selectProducts.Where(x => x.PRODUCTID == ((sender as Button).Parent as BasketUserControl).INDX).FirstOrDefault().COUNT += 1;
            this.panel1.Controls.Clear();
            double total = 0;
            int h = 0;
            foreach (var item in selectProducts)
            {
                BasketUserControl temp = new BasketUserControl(Convert.ToInt32(item.PRODUCTID), copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRODUCT_NAME, item.COUNT, Convert.ToDouble(copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRICE));
                temp.Location = new Point(0, h);
                temp.button1.Click += Button1_Click;
                temp.button2.Click += Button2_Click;
                temp.button3.Click += UC_Button3_Click;
                this.panel1.Controls.Add(temp);
                total += Convert.ToDouble(temp.Price.Text);
                h += temp.Size.Height + 10;
            }
            this.Total.Text = $"Total: \t {total} AED";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (selectProducts.Where(x => x.PRODUCTID == ((sender as Button).Parent as BasketUserControl).INDX).FirstOrDefault().COUNT > 1)
            {
                selectProducts.Where(x => x.PRODUCTID == ((sender as Button).Parent as BasketUserControl).INDX).FirstOrDefault().COUNT -= 1;

                this.panel1.Controls.Clear();
                int h = 0;
                double total = 0;
                foreach (var item in selectProducts)
                {
                    BasketUserControl temp = new BasketUserControl(Convert.ToInt32(item.PRODUCTID), copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRODUCT_NAME, item.COUNT, Convert.ToDouble(copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRICE));
                    temp.Location = new Point(0, h);
                    temp.button1.Click += Button1_Click;
                    temp.button2.Click += Button2_Click;
                    temp.button3.Click += UC_Button3_Click;
                    this.panel1.Controls.Add(temp);
                    total += Convert.ToDouble(temp.Price.Text);
                    h += temp.Size.Height + 10;
                }
                this.Total.Text = $"Total: \t {total} AED";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
           
              selectProducts.Remove(selectProducts.Where(x => x.PRODUCTID == ((sender as Button).Parent as BasketUserControl).INDX).FirstOrDefault());

            this.panel1.Controls.Clear();
            int h = 0;
            double total = 0;
            foreach (var item in selectProducts)
            {
                BasketUserControl temp = new BasketUserControl(Convert.ToInt32(item.PRODUCTID), copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRODUCT_NAME, item.COUNT, Convert.ToDouble(copy.ToList().Where(x => x.PRODUCTID == item.PRODUCTID).FirstOrDefault().PRICE));
                temp.Location = new Point(0, h);
                temp.button1.Click += Button1_Click;
                temp.button2.Click += Button2_Click;
                temp.button3.Click += UC_Button3_Click;
                this.panel1.Controls.Add(temp);
                total += Convert.ToDouble(temp.Price.Text);
                h += temp.Size.Height + 10;
            }
            this.Total.Text = $"Total: \t {total} AED";
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
