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
        Model model;
        public MenuForm()
        {
            
            InitializeComponent();
            model = new Model();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
          

           
            int x = 191;
            foreach (var item in model.CATEGORies)
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
            int h = 0;
            if ((sender as Button).Text == "Most Selling")
            {
                var list = model.PRODUCTs.Where(x => x.CATEGORYID == 1);
                this.panel2.Controls.Clear();

                foreach (var item in list)
                {
                    ProductUserControl temp = new ProductUserControl(item.PRODUCT_NAME.ToString(),item.PRODUCT_SUBSCRIBE.ToString(), $"{item.PRICE.ToString()} AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
                    temp.button1.Click += Temp_Click;
                    temp.Location = new Point(0, h);
                    this.panel2.Controls.Add(temp);
                    h += temp.Size.Height + 15;
                }

                //for (int i = 0; i < 5; i++)
                //{
                //    ProductUserControl temp = new ProductUserControl("Double Gorilla Cheesburger Meal ", " burgers and small frehch fries and coke 0.5L", "90 AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
                //    temp.button1.Click += Temp_Click;
                //    temp.Location = new Point(0, h);
                //    this.panel2.Controls.Add(temp);
                //    h += temp.Size.Height + 15;
                //}
               
            }
            else if((sender as Button).Text == "Combo Meals")
            {
                var list = model.PRODUCTs.Where(x => x.CATEGORYID == 2);
                this.panel2.Controls.Clear();
                foreach (var item in list)
                {
                    ProductUserControl temp = new ProductUserControl(item.PRODUCT_NAME.ToString(), item.PRODUCT_SUBSCRIBE.ToString(), $"{item.PRICE.ToString()} AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
                    temp.button1.Click += Temp_Click;
                    temp.Location = new Point(0, h);
                    this.panel2.Controls.Add(temp);
                    h += temp.Size.Height + 15;
                }

            }
            else if ((sender as Button).Text == "Gorilla Burgers")
            {
              
            }
            else if ((sender as Button).Text == "Drinks")
            {

            }
            else if ((sender as Button).Text == "Desserts")
            {

            }
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            //count++;
            this.label2.Font = new Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.label2.Text = $"В корзине: {++count}  товаров";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show(this.panel1.Controls[0].Name);
            //Product temp = new Product("Double Gorilla Cheesburger ", "most tasty burger in the woooorld", "30 AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
            //temp.Location = new Point(20, h);
            //this.panel2.Controls.Add(temp);
            //h += 150;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
