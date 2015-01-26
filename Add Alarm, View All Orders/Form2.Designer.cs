namespace MIS_122_Stuff
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier_ETD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipping_Line_ETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shiping_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.View_Button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(105, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.Add_Button);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.View_Button);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shipments";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1146, 251);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Documents";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(801, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 22);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1074, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_No,
            this.Product,
            this.Supplier,
            this.Supplier_ETD,
            this.RETA,
            this.Shipping_Line_ETA,
            this.Last_updated,
            this.Shiping_Status});
            this.dataGridView1.Location = new System.Drawing.Point(0, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order_No
            // 
            this.Order_No.HeaderText = "Order No.";
            this.Order_No.Name = "Order_No";
            this.Order_No.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Supplier_ETD
            // 
            this.Supplier_ETD.HeaderText = "Supplier\'s ETD";
            this.Supplier_ETD.Name = "Supplier_ETD";
            this.Supplier_ETD.ReadOnly = true;
            // 
            // RETA
            // 
            this.RETA.HeaderText = "RETA";
            this.RETA.Name = "RETA";
            this.RETA.ReadOnly = true;
            // 
            // Shipping_Line_ETA
            // 
            this.Shipping_Line_ETA.HeaderText = "Shipping Line ETA";
            this.Shipping_Line_ETA.Name = "Shipping_Line_ETA";
            this.Shipping_Line_ETA.ReadOnly = true;
            // 
            // Last_updated
            // 
            this.Last_updated.HeaderText = "Last Updated";
            this.Last_updated.Name = "Last_updated";
            this.Last_updated.ReadOnly = true;
            // 
            // Shiping_Status
            // 
            this.Shiping_Status.HeaderText = "Shipping Status";
            this.Shiping_Status.Name = "Shiping_Status";
            this.Shiping_Status.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(961, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Tomato;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1055, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Tomato;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(22, 52);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(113, 23);
            this.Add_Button.TabIndex = 9;
            this.Add_Button.Text = "Add Order";
            this.Add_Button.UseVisualStyleBackColor = false;
            // 
            // View_Button
            // 
            this.View_Button.BackColor = System.Drawing.Color.Tomato;
            this.View_Button.BackgroundImage = global::MIS_122_Stuff.Properties.Resources.tomato_color;
            this.View_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View_Button.ForeColor = System.Drawing.Color.White;
            this.View_Button.Location = new System.Drawing.Point(866, 132);
            this.View_Button.Name = "View_Button";
            this.View_Button.Size = new System.Drawing.Size(75, 23);
            this.View_Button.TabIndex = 6;
            this.View_Button.Text = "View";
            this.View_Button.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 297);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Primebeef Co. Monitoring System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button View_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier_ETD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipping_Line_ETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shiping_Status;
    }
}