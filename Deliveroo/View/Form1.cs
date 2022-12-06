using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GORILLA_BURGER
{
    public partial class Form1 : Form
    {
       public string login;
       public string password;
       private ControllerDB controller;
       public USER user;
        
        public Form1()
        {
            InitializeComponent();
            controller = new ControllerDB(); 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.button3.Visible = false;
            this.button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.login = this.textBox1.Text;
            this.password = this.textBox2.Text;
            if(login!=string.Empty&& password!=string.Empty)
            {
                if(controller.gorillaBurgerList.USERs.ToList().Contains(controller.gorillaBurgerList.USERs.ToList().Where(x=>x.USER_LOGIN==login).FirstOrDefault()))
                {
                    if (controller.gorillaBurgerList.USERs.ToList().Where(x => x.USER_LOGIN == login).FirstOrDefault().USER_PASSWORD == password)
                    {
                        user = controller.gorillaBurgerList.USERs.ToList().Where(x => x.USER_LOGIN == login).FirstOrDefault();
                        this.Close();
                    }
                    else
                    {
                        this.textBox2.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Erorr Login");
                }
            }
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.login = this.textBox1.Text;
            this.password = this.textBox2.Text;
            user= new USER() {USER_LOGIN= this.textBox1.Text, USER_PASSWORD= this.textBox2.Text, ROLEID=1};
            var context = new ValidationContext(user);
            var resValid = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, context, resValid, true))
            {
                foreach (var item in resValid)
                {
                    MessageBox.Show(item.ToString());
                }
               
            }
            else
            {
                MessageBox.Show("Login confirm");
                controller.gorillaBurgerList.USERs.Add(user);
                controller.gorillaBurgerList.SaveChanges();
                this.Close();
            }
            
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(255, 194, 68);
            button4.BackColor = Color.FromArgb(255, 194, 68);
            
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as TextBox).Text = string.Empty;          
        }

      
    }
}
