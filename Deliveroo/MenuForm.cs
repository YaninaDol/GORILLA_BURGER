using Microsoft.EntityFrameworkCore.Internal;
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
        int count = 0;
        private Controller controller;
        public List<PRODUCT> copy; 
        public MenuForm()
        {
            
            InitializeComponent();
            controller = new Controller();  
            copy = new List<PRODUCT>();
           
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
          

           
            int x = 191;
            foreach (var item in controller.gorillaBurgerList.CATEGORies)
            {
               Button button1 = new Button();
                button1.Text = item.CATEGORY_NAME.ToString();
                button1.BackColor = Color.FromArgb(255, 194, 68);
                button1.Click += Btn_Click;
                button1.Size = new Size(189, 64);
                button1.Font= new Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                button1.Location = new Point(65, x);
                this.panel1.Controls.Add(button1);
              
               x += button1.Size.Height + 15;
            }

        
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int INDX = controller.gorillaBurgerList.CATEGORies.ToList().Where(x => x.CATEGORY_NAME == (sender as Button).Text).FirstOrDefault().CATEGORYID;
            int h = 0;
          
                var list = controller.gorillaBurgerList.PRODUCTs.Where(x => x.CATEGORYID == INDX);
                this.panel2.Controls.Clear();


         

            foreach (var item in list)
            {
                ProductUserControl temp = new ProductUserControl(item.PRODUCTID, item.PRODUCT_NAME.ToString(), item.PRODUCT_SUBSCRIBE.ToString(), $"{item.PRICE.ToString()} AED",item.URL_PICTURE.ToString());
                temp.Name = INDX.ToString();
                temp.button1.Click += Temp_Click1;
                temp.Location = new Point(0, h);
                this.panel2.Controls.Add(temp);
                h += temp.Size.Height + 15;
            }
        }

        private void Temp_Click1(object sender, EventArgs e)
        {
           
            this.label2.Font = new Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.label2.Text = $"В корзине: {++count}  товаров";
            this.label2.Click += Label2_Click;

            ProductUserControl item = (sender as Button).Parent as ProductUserControl;
            PRODUCT pRODUCT = new PRODUCT() {PRODUCTID=item.ID, PRODUCT_NAME = item.label1.Text, PRODUCT_SUBSCRIBE = item.label2.Text, URL_PICTURE = item.pictureBox1.Name.ToString(), CATEGORYID = Convert.ToInt32(item.Name), PRICE = Convert.ToDouble(item.label3.Text.Remove(item.label3.Text.IndexOf('A'))) };
            copy.Add(pRODUCT);  
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Click(object sender, System.EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
