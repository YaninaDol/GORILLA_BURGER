using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GORILLA_BURGER
{
    public partial class BasketUserControl : UserControl
    {
        public int INDX;
        public BasketUserControl(int Id,string Name,int Count,double Price)
        {
            InitializeComponent();
            INDX = Id;    
            this.Named.Text= Name;
            this.count.Text = Count.ToString();
            if (Count > 1)

            {
                double sum=Price*Convert.ToDouble(Count);
                this.Price.Text = sum.ToString();
            }
            else
                this.Price.Text = Price.ToString();
        }
    }
}
