using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN_GORILLA_BURGER
{
    public partial class LoginForm : Form
    {
        Controller controller;
        public LoginForm()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(this.materialSingleLineTextField1.Text!=string.Empty && this.materialSingleLineTextField2.Text != string.Empty)
            {
                USER item=controller.usersList.ToList().Where(x=>x.USER_LOGIN.ToString()==this.materialSingleLineTextField1.Text).FirstOrDefault();
                if(item!=null) 
                {
                   if(item.USER_PASSWORD==this.materialSingleLineTextField2.Text && item.ROLEID==2) 
                    
                    {
                     this.Close();
                    }
                   else
                    {
                        MessageBox.Show("Erorr Password");
                        this.materialSingleLineTextField2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Erorr Login");
                }
                
            }
        }
    }
}
