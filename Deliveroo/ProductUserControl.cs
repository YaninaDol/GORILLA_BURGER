using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveroo
{
    public partial class ProductUserControl : UserControl
    {
        public int ID;
        public ProductUserControl(int Id,string name,string subscribe,string price,string img)
        {
            //this.SetStyle(ControlStyles.UserPaint, true);
          
            InitializeComponent();
            ID = Id;   
            this.label1.Text = name;
            this.label2.Text = subscribe;
            this.label3.Text = price;
            this.pictureBox1.Image=GetImage(img);
            this.pictureBox1.Name = img; Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.OrangeRed,
            //ButtonBorderStyle.Solid);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.WhiteSmoke, 3, ButtonBorderStyle.Solid, Color.WhiteSmoke, 3, ButtonBorderStyle.Solid, Color.WhiteSmoke, 3, ButtonBorderStyle.Solid, Color.WhiteSmoke, 3, ButtonBorderStyle.Solid);
            base.OnPaint(e);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect, // x-coordinate of upper-left corner
    int nTopRect, // y-coordinate of upper-left corner
    int nRightRect, // x-coordinate of lower-right corner
    int nBottomRect, // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
 );
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Image GetImage(string name) 
        {
            var request = WebRequest.Create(name);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }

    }
}
