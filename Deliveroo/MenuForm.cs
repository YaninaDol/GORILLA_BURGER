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
       
        public MenuForm()
        {
            
            InitializeComponent();
           
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            List<string> menuItem = new List<string>();
            menuItem.Add("Meal");
            menuItem.Add("Burgers");
            menuItem.Add("Fries");
            menuItem.Add("Drinks");
            menuItem.Add("Desserts");

           
            int x = 191;
            foreach (string item in menuItem)
            {
               Button button1 = new Button();
                button1.Text = item;
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
            if ((sender as Button).Text == "Meal")
            {
                this.panel2.Controls.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Product temp = new Product("Double Gorilla Cheesburger Meal ", " burgers and small frehch fries and coke 0.5L", "90 AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
                    temp.button1.Click += Temp_Click;
                    temp.Location = new Point(0, h);
                    this.panel2.Controls.Add(temp);
                    h += temp.Size.Height + 15;
                }
               
            }
            else if((sender as Button).Text == "Burgers")
            {
                this.panel2.Controls.Clear();
                for (int i = 0; i < 3; i++)
                {
                    Product temp = new Product("Double Gorilla Cheesburger ", "Most popular", "30 AED", Image.FromFile(@"C:\Users\1\Downloads\ezgif.com-gif-maker (7).jpg"));
                    temp.button1.Click += Temp_Click;
                    temp.Location = new Point(0, h);
                    this.panel2.Controls.Add(temp);
                    h += temp.Size.Height + 15;
                }

            }
            else if ((sender as Button).Text == "Fries")
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
