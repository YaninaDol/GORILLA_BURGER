namespace Deliveroo
{
    partial class BasketUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Named = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Named
            // 
            this.Named.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Named.ForeColor = System.Drawing.Color.Orange;
            this.Named.Location = new System.Drawing.Point(3, 0);
            this.Named.Name = "Named";
            this.Named.Size = new System.Drawing.Size(228, 76);
            this.Named.TabIndex = 2;
            this.Named.Text = "Name";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(289, 13);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(57, 28);
            this.count.TabIndex = 3;
            this.count.Text = "Count";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(439, 13);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(57, 28);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(531, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(254, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(352, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BasketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.Named);
            this.Name = "BasketUserControl";
            this.Size = new System.Drawing.Size(574, 76);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Named;
        public System.Windows.Forms.Label count;
        public System.Windows.Forms.Label Price;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
    }
}
