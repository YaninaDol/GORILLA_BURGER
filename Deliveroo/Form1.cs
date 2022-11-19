using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveroo
{
    public partial class Form1 : Form
    {
       public string login;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.button3.Visible = true;

            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
            this.textBox4.Visible = true;
            this.button3.Visible = false;
            this.button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.login = this.textBox1.Text;
            this.Close();

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(255, 194, 68);
            
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }
    }
}
