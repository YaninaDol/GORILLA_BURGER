using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN_GORILLA_BURGER
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_a8ec30_yanina001DataSet.DELIVERY_PERSON". При необходимости она может быть перемещена или удалена.
            this.dELIVERY_PERSONTableAdapter.Fill(this.db_a8ec30_yanina001DataSet.DELIVERY_PERSON);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_a8ec30_yanina001DataSet.LIST_PRODUCTS". При необходимости она может быть перемещена или удалена.
            this.lIST_PRODUCTSTableAdapter.Fill(this.db_a8ec30_yanina001DataSet.LIST_PRODUCTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_a8ec30_yanina001DataSet.PRODUCT". При необходимости она может быть перемещена или удалена.
            this.pRODUCTTableAdapter.Fill(this.db_a8ec30_yanina001DataSet.PRODUCT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_a8ec30_yanina001DataSet.USER". При необходимости она может быть перемещена или удалена.
            this.uSERTableAdapter.Fill(this.db_a8ec30_yanina001DataSet.USER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_a8ec30_yanina001DataSet.CLIENT_ORDER". При необходимости она может быть перемещена или удалена.
            this.cLIENT_ORDERTableAdapter.Fill(this.db_a8ec30_yanina001DataSet.CLIENT_ORDER);

        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.lIST_PRODUCTSTableAdapter.Update(this.db_a8ec30_yanina001DataSet.LIST_PRODUCTS);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.dELIVERY_PERSONTableAdapter.Update(this.db_a8ec30_yanina001DataSet.DELIVERY_PERSON);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.uSERTableAdapter.Update(this.db_a8ec30_yanina001DataSet.USER);
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.Update(this.db_a8ec30_yanina001DataSet.PRODUCT);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            this.cLIENT_ORDERTableAdapter.Update(this.db_a8ec30_yanina001DataSet.CLIENT_ORDER);
        }
    }
}
