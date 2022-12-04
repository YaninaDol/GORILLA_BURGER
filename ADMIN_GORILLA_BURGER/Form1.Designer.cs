using MaterialSkin.Controls;
using System.Windows.Forms;

namespace ADMIN_GORILLA_BURGER
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.db_a8ec30_yanina001DataSet = new ADMIN_GORILLA_BURGER.db_a8ec30_yanina001DataSet();
            this.dba8ec30yanina001DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENT_ORDERTableAdapter = new ADMIN_GORILLA_BURGER.db_a8ec30_yanina001DataSetTableAdapters.CLIENT_ORDERTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new ADMIN_GORILLA_BURGER.db_a8ec30_yanina001DataSetTableAdapters.USERTableAdapter();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new ADMIN_GORILLA_BURGER.db_a8ec30_yanina001DataSetTableAdapters.PRODUCTTableAdapter();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLPICTUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lISTPRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIST_PRODUCTSTableAdapter = new ADMIN_GORILLA_BURGER.db_a8ec30_yanina001DataSetTableAdapters.LIST_PRODUCTSTableAdapter();
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dELIVERYPERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dELIVERY_PERSONTableAdapter = new ADMIN_GORILLA_BURGER.db_a8ec30_yanina001DataSetTableAdapters.DELIVERY_PERSONTableAdapter();
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYUSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELIVERYPERSONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_a8ec30_yanina001DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dba8ec30yanina001DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTPRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYPERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYPERSONBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 574);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.materialFlatButton2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.ImageKey = "user-add-icon.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(829, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USER";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage3.Controls.Add(this.materialFlatButton3);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.ImageKey = "aafdea1e25408dc9e20307a7762f8c2f.jpg";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(829, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PRODUCT";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aafdea1e25408dc9e20307a7762f8c2f.jpg");
            this.imageList1.Images.SetKeyName(1, "home.jpg");
            this.imageList1.Images.SetKeyName(2, "new-product-icon-9.jpg");
            this.imageList1.Images.SetKeyName(3, "user-add-icon.png");
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage4.Controls.Add(this.materialFlatButton1);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.ImageKey = "new-product-icon-9.jpg";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(829, 531);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ORDER";
            // 
            // db_a8ec30_yanina001DataSet
            // 
            this.db_a8ec30_yanina001DataSet.DataSetName = "db_a8ec30_yanina001DataSet";
            this.db_a8ec30_yanina001DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dba8ec30yanina001DataSetBindingSource
            // 
            this.dba8ec30yanina001DataSetBindingSource.DataSource = this.db_a8ec30_yanina001DataSet;
            this.dba8ec30yanina001DataSetBindingSource.Position = 0;
            // 
            // cLIENTORDERBindingSource
            // 
            this.cLIENTORDERBindingSource.DataMember = "CLIENT_ORDER";
            this.cLIENTORDERBindingSource.DataSource = this.dba8ec30yanina001DataSetBindingSource;
            // 
            // cLIENT_ORDERTableAdapter
            // 
            this.cLIENT_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.uSERLOGINDataGridViewTextBoxColumn,
            this.uSERPASSWORDDataGridViewTextBoxColumn,
            this.rOLEIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.uSERBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(108, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(554, 407);
            this.dataGridView2.TabIndex = 1;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.dba8ec30yanina001DataSetBindingSource;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            this.uSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uSERLOGINDataGridViewTextBoxColumn
            // 
            this.uSERLOGINDataGridViewTextBoxColumn.DataPropertyName = "USER_LOGIN";
            this.uSERLOGINDataGridViewTextBoxColumn.HeaderText = "USER_LOGIN";
            this.uSERLOGINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSERLOGINDataGridViewTextBoxColumn.Name = "uSERLOGINDataGridViewTextBoxColumn";
            this.uSERLOGINDataGridViewTextBoxColumn.Width = 125;
            // 
            // uSERPASSWORDDataGridViewTextBoxColumn
            // 
            this.uSERPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "USER_PASSWORD";
            this.uSERPASSWORDDataGridViewTextBoxColumn.HeaderText = "USER_PASSWORD";
            this.uSERPASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSERPASSWORDDataGridViewTextBoxColumn.Name = "uSERPASSWORDDataGridViewTextBoxColumn";
            this.uSERPASSWORDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rOLEIDDataGridViewTextBoxColumn
            // 
            this.rOLEIDDataGridViewTextBoxColumn.DataPropertyName = "ROLEID";
            this.rOLEIDDataGridViewTextBoxColumn.HeaderText = "ROLEID";
            this.rOLEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOLEIDDataGridViewTextBoxColumn.Name = "rOLEIDDataGridViewTextBoxColumn";
            this.rOLEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView3.DataSource = this.cLIENTORDERBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(29, 31);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(687, 372);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ORDERTIME";
            this.dataGridViewTextBoxColumn1.HeaderText = "ORDERTIME";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENT_ORDERID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CLIENT_ORDERID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DELIVERY_PERSONID";
            this.dataGridViewTextBoxColumn3.HeaderText = "DELIVERY_PERSONID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LIST_PRODUCTSID";
            this.dataGridViewTextBoxColumn4.HeaderText = "LIST_PRODUCTSID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn5.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.materialFlatButton1.FlatAppearance.BorderSize = 300;
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialFlatButton1.Location = new System.Drawing.Point(271, 432);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(294, 61);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Save changes";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.materialFlatButton2.FlatAppearance.BorderSize = 3;
            this.materialFlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialFlatButton2.Location = new System.Drawing.Point(318, 441);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = true;
            this.materialFlatButton2.Size = new System.Drawing.Size(222, 54);
            this.materialFlatButton2.TabIndex = 3;
            this.materialFlatButton2.Text = "Save changes";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn,
            this.uRLPICTUREDataGridViewTextBoxColumn,
            this.cATEGORYIDDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 407);
            this.dataGridView1.TabIndex = 2;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dba8ec30yanina001DataSetBindingSource;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTSUBSCRIBEDataGridViewTextBoxColumn
            // 
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_SUBSCRIBE";
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn.HeaderText = "PRODUCT_SUBSCRIBE";
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn.Name = "pRODUCTSUBSCRIBEDataGridViewTextBoxColumn";
            this.pRODUCTSUBSCRIBEDataGridViewTextBoxColumn.Width = 125;
            // 
            // uRLPICTUREDataGridViewTextBoxColumn
            // 
            this.uRLPICTUREDataGridViewTextBoxColumn.DataPropertyName = "URL_PICTURE";
            this.uRLPICTUREDataGridViewTextBoxColumn.HeaderText = "URL_PICTURE";
            this.uRLPICTUREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRLPICTUREDataGridViewTextBoxColumn.Name = "uRLPICTUREDataGridViewTextBoxColumn";
            this.uRLPICTUREDataGridViewTextBoxColumn.Width = 125;
            // 
            // cATEGORYIDDataGridViewTextBoxColumn
            // 
            this.cATEGORYIDDataGridViewTextBoxColumn.DataPropertyName = "CATEGORYID";
            this.cATEGORYIDDataGridViewTextBoxColumn.HeaderText = "CATEGORYID";
            this.cATEGORYIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORYIDDataGridViewTextBoxColumn.Name = "cATEGORYIDDataGridViewTextBoxColumn";
            this.cATEGORYIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.materialFlatButton3.FlatAppearance.BorderSize = 3;
            this.materialFlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialFlatButton3.Location = new System.Drawing.Point(321, 484);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = true;
            this.materialFlatButton3.Size = new System.Drawing.Size(139, 36);
            this.materialFlatButton3.TabIndex = 4;
            this.materialFlatButton3.Text = "Save changes";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialFlatButton5);
            this.tabPage1.Controls.Add(this.dataGridView5);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(829, 531);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "DELIVERY PERSON";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialFlatButton4);
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(829, 531);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "LIST PRODUCTS";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn,
            this.pRODUCTIDDataGridViewTextBoxColumn1,
            this.cOUNTDataGridViewTextBoxColumn,
            this.uSERIDDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.lISTPRODUCTSBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(137, 39);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(554, 407);
            this.dataGridView4.TabIndex = 4;
            // 
            // lISTPRODUCTSBindingSource
            // 
            this.lISTPRODUCTSBindingSource.DataMember = "LIST_PRODUCTS";
            this.lISTPRODUCTSBindingSource.DataSource = this.dba8ec30yanina001DataSetBindingSource;
            // 
            // lIST_PRODUCTSTableAdapter
            // 
            this.lIST_PRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // lISTPRODUCTSIDDataGridViewTextBoxColumn
            // 
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn.DataPropertyName = "LIST_PRODUCTSID";
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn.HeaderText = "LIST_PRODUCTSID";
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn.Name = "lISTPRODUCTSIDDataGridViewTextBoxColumn";
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lISTPRODUCTSIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn1
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn1.DataPropertyName = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn1.HeaderText = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.pRODUCTIDDataGridViewTextBoxColumn1.Name = "pRODUCTIDDataGridViewTextBoxColumn1";
            this.pRODUCTIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cOUNTDataGridViewTextBoxColumn
            // 
            this.cOUNTDataGridViewTextBoxColumn.DataPropertyName = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.HeaderText = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOUNTDataGridViewTextBoxColumn.Name = "cOUNTDataGridViewTextBoxColumn";
            this.cOUNTDataGridViewTextBoxColumn.Width = 125;
            // 
            // uSERIDDataGridViewTextBoxColumn1
            // 
            this.uSERIDDataGridViewTextBoxColumn1.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn1.HeaderText = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.uSERIDDataGridViewTextBoxColumn1.Name = "uSERIDDataGridViewTextBoxColumn1";
            this.uSERIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.materialFlatButton4.FlatAppearance.BorderSize = 300;
            this.materialFlatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialFlatButton4.Location = new System.Drawing.Point(308, 474);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = true;
            this.materialFlatButton4.Size = new System.Drawing.Size(218, 51);
            this.materialFlatButton4.TabIndex = 5;
            this.materialFlatButton4.Text = "Save changes";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn,
            this.dELIVERYUSERIDDataGridViewTextBoxColumn,
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn,
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn,
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn,
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.dELIVERYPERSONBindingSource1;
            this.dataGridView5.Location = new System.Drawing.Point(24, 54);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(809, 407);
            this.dataGridView5.TabIndex = 5;
            // 
            // dELIVERYPERSONBindingSource
            // 
            this.dELIVERYPERSONBindingSource.DataMember = "DELIVERY_PERSON";
            this.dELIVERYPERSONBindingSource.DataSource = this.dba8ec30yanina001DataSetBindingSource;
            // 
            // dELIVERY_PERSONTableAdapter
            // 
            this.dELIVERY_PERSONTableAdapter.ClearBeforeFill = true;
            // 
            // dELIVERYPERSONIDDataGridViewTextBoxColumn
            // 
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn.DataPropertyName = "DELIVERY_PERSONID";
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn.HeaderText = "DELIVERY_PERSONID";
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn.Name = "dELIVERYPERSONIDDataGridViewTextBoxColumn";
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dELIVERYPERSONIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELIVERYUSERIDDataGridViewTextBoxColumn
            // 
            this.dELIVERYUSERIDDataGridViewTextBoxColumn.DataPropertyName = "DELIVERY_USERID";
            this.dELIVERYUSERIDDataGridViewTextBoxColumn.HeaderText = "DELIVERY_USERID";
            this.dELIVERYUSERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELIVERYUSERIDDataGridViewTextBoxColumn.Name = "dELIVERYUSERIDDataGridViewTextBoxColumn";
            this.dELIVERYUSERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELIVERYPERSONNAMEDataGridViewTextBoxColumn
            // 
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "DELIVERY_PERSON_NAME";
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn.HeaderText = "DELIVERY_PERSON_NAME";
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn.Name = "dELIVERYPERSONNAMEDataGridViewTextBoxColumn";
            this.dELIVERYPERSONNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn
            // 
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn.DataPropertyName = "DELIVERY_PERSON_FULL_ADDRESS";
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn.HeaderText = "DELIVERY_PERSON_FULL_ADDRESS";
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn.Name = "dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn";
            this.dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELIVERYPERSONAREADataGridViewTextBoxColumn
            // 
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn.DataPropertyName = "DELIVERY_PERSON_AREA";
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn.HeaderText = "DELIVERY_PERSON_AREA";
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn.Name = "dELIVERYPERSONAREADataGridViewTextBoxColumn";
            this.dELIVERYPERSONAREADataGridViewTextBoxColumn.Width = 125;
            // 
            // dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn
            // 
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "DELIVERY_PERSON_CONTACTNUMBER";
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn.HeaderText = "DELIVERY_PERSON_CONTACTNUMBER";
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn.Name = "dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn";
            this.dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // dELIVERYPERSONBindingSource1
            // 
            this.dELIVERYPERSONBindingSource1.DataMember = "DELIVERY_PERSON";
            this.dELIVERYPERSONBindingSource1.DataSource = this.dba8ec30yanina001DataSetBindingSource;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(100)))));
            this.materialFlatButton5.FlatAppearance.BorderSize = 300;
            this.materialFlatButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialFlatButton5.Location = new System.Drawing.Point(322, 484);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = true;
            this.materialFlatButton5.Size = new System.Drawing.Size(139, 36);
            this.materialFlatButton5.TabIndex = 6;
            this.materialFlatButton5.Text = "Save changes";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(837, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_a8ec30_yanina001DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dba8ec30yanina001DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lISTPRODUCTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYPERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYPERSONBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private TabPage tabPage4;
        private ImageList imageList1;
        private BindingSource dba8ec30yanina001DataSetBindingSource;
        private db_a8ec30_yanina001DataSet db_a8ec30_yanina001DataSet;
        private BindingSource cLIENTORDERBindingSource;
        private db_a8ec30_yanina001DataSetTableAdapters.CLIENT_ORDERTableAdapter cLIENT_ORDERTableAdapter;
        private DataGridView dataGridView2;
        private BindingSource uSERBindingSource;
        private db_a8ec30_yanina001DataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uSERLOGINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uSERPASSWORDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rOLEIDDataGridViewTextBoxColumn;
        private MaterialFlatButton materialFlatButton1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MaterialFlatButton materialFlatButton2;
        private DataGridView dataGridView1;
        private BindingSource pRODUCTBindingSource;
        private db_a8ec30_yanina001DataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private MaterialFlatButton materialFlatButton3;
        private DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRODUCTSUBSCRIBEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uRLPICTUREDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cATEGORYIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private TabPage tabPage5;
        private DataGridView dataGridView4;
        private TabPage tabPage1;
        private BindingSource lISTPRODUCTSBindingSource;
        private db_a8ec30_yanina001DataSetTableAdapters.LIST_PRODUCTSTableAdapter lIST_PRODUCTSTableAdapter;
        private MaterialFlatButton materialFlatButton4;
        private DataGridViewTextBoxColumn lISTPRODUCTSIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cOUNTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn1;
        private DataGridView dataGridView5;
        private BindingSource dELIVERYPERSONBindingSource;
        private db_a8ec30_yanina001DataSetTableAdapters.DELIVERY_PERSONTableAdapter dELIVERY_PERSONTableAdapter;
        private MaterialFlatButton materialFlatButton5;
        private DataGridViewTextBoxColumn dELIVERYPERSONIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dELIVERYUSERIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dELIVERYPERSONNAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dELIVERYPERSONFULLADDRESSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dELIVERYPERSONAREADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dELIVERYPERSONCONTACTNUMBERDataGridViewTextBoxColumn;
        private BindingSource dELIVERYPERSONBindingSource1;
    }
}

