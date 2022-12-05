using ADMIN_GORILLA_BURGER.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN_GORILLA_BURGER
{
    public partial class MainForm : MaterialForm
    {
        DataTable selectUsers;
      
        private List<CLIENT_ORDER> clients;
        private ClientOrderController clientOrderController;
        public MainForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
            clientOrderController= new ClientOrderController();   
            clients=new List<CLIENT_ORDER>();
          

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

            dataGridView6.DataSource = this.db_a8ec30_yanina001DataSet.CLIENT_ORDER;
            //selectUsers= this.db_a8ec30_yanina001DataSet.USER.Select("ROLEID='1'").CopyToDataTable();
            //dataGridView2.DataSource = selectUsers;
            //dataGridView2.Columns["USER_PASSWORD"].Visible= false;

            this.db_a8ec30_yanina001DataSet.USER.DefaultView.RowFilter = "ROLEID='1'";
            dataGridView2.DataSource = this.db_a8ec30_yanina001DataSet.USER.DefaultView;
            dataGridView2.Columns["USER_PASSWORD"].Visible = false;


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

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            clients.Clear();
           
            if (materialSingleLineTextField1.Text != string.Empty)
            {
                var deliveri_persons = this.db_a8ec30_yanina001DataSet.DELIVERY_PERSON.ToList().Where(x => x.DELIVERY_USERID == Convert.ToInt32(materialSingleLineTextField1.Text)).ToList();
               
                foreach (var item in deliveri_persons)
                {
                    if(item!=null)
                   clients.Add(clientOrderController.CLIENT_ORDER.Where(x => x.DELIVERY_PERSONID == item.DELIVERY_PERSONID).FirstOrDefault());
                
                }
                dataGridView6.DataSource = clients ;
            }
            else
            { dataGridView6.DataSource = this.db_a8ec30_yanina001DataSet.CLIENT_ORDER; }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Text=string.Empty;
        }
    }
}
