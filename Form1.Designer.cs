namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_company = new System.Windows.Forms.TextBox();
            this.rich = new System.Windows.Forms.RichTextBox();
            this.btn_records = new System.Windows.Forms.Button();
            this.db_grid = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.radioButton1_Customers = new System.Windows.Forms.RadioButton();
            this.radioButton2_Orders = new System.Windows.Forms.RadioButton();
            this.radioButton3_Employees = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.db_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Company Name";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(53, 116);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(168, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(205, 26);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 22);
            this.tb_id.TabIndex = 3;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_company
            // 
            this.tb_company.Location = new System.Drawing.Point(205, 67);
            this.tb_company.Name = "tb_company";
            this.tb_company.Size = new System.Drawing.Size(100, 22);
            this.tb_company.TabIndex = 4;
            // 
            // rich
            // 
            this.rich.Enabled = false;
            this.rich.Location = new System.Drawing.Point(533, 12);
            this.rich.Name = "rich";
            this.rich.Size = new System.Drawing.Size(318, 113);
            this.rich.TabIndex = 5;
            this.rich.Text = "";
            // 
            // btn_records
            // 
            this.btn_records.Location = new System.Drawing.Point(639, 131);
            this.btn_records.Name = "btn_records";
            this.btn_records.Size = new System.Drawing.Size(115, 23);
            this.btn_records.TabIndex = 6;
            this.btn_records.Text = "Records";
            this.btn_records.UseVisualStyleBackColor = true;
            this.btn_records.Click += new System.EventHandler(this.buttonRecords_Click);
            // 
            // db_grid
            // 
            this.db_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_grid.Location = new System.Drawing.Point(53, 228);
            this.db_grid.Name = "db_grid";
            this.db_grid.RowHeadersWidth = 51;
            this.db_grid.RowTemplate.Height = 24;
            this.db_grid.Size = new System.Drawing.Size(798, 139);
            this.db_grid.TabIndex = 7;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(376, 373);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 8;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btnView_Click);
            // 
            // radioButton1_Customers
            // 
            this.radioButton1_Customers.AutoSize = true;
            this.radioButton1_Customers.Location = new System.Drawing.Point(385, 116);
            this.radioButton1_Customers.Name = "radioButton1_Customers";
            this.radioButton1_Customers.Size = new System.Drawing.Size(131, 20);
            this.radioButton1_Customers.TabIndex = 9;
            this.radioButton1_Customers.TabStop = true;
            this.radioButton1_Customers.Text = "Customers Table";
            this.radioButton1_Customers.UseVisualStyleBackColor = true;
            this.radioButton1_Customers.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2_Orders
            // 
            this.radioButton2_Orders.AutoSize = true;
            this.radioButton2_Orders.Location = new System.Drawing.Point(385, 152);
            this.radioButton2_Orders.Name = "radioButton2_Orders";
            this.radioButton2_Orders.Size = new System.Drawing.Size(108, 20);
            this.radioButton2_Orders.TabIndex = 10;
            this.radioButton2_Orders.TabStop = true;
            this.radioButton2_Orders.Text = "Orders Table";
            this.radioButton2_Orders.UseVisualStyleBackColor = true;
            // 
            // radioButton3_Employees
            // 
            this.radioButton3_Employees.AutoSize = true;
            this.radioButton3_Employees.Location = new System.Drawing.Point(385, 189);
            this.radioButton3_Employees.Name = "radioButton3_Employees";
            this.radioButton3_Employees.Size = new System.Drawing.Size(136, 20);
            this.radioButton3_Employees.TabIndex = 11;
            this.radioButton3_Employees.TabStop = true;
            this.radioButton3_Employees.Text = "Employees Table";
            this.radioButton3_Employees.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(918, 408);
            this.Controls.Add(this.radioButton3_Employees);
            this.Controls.Add(this.radioButton2_Orders);
            this.Controls.Add(this.radioButton1_Customers);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.db_grid);
            this.Controls.Add(this.btn_records);
            this.Controls.Add(this.rich);
            this.Controls.Add(this.tb_company);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.db_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.RichTextBox rec;
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_company;
        private System.Windows.Forms.RichTextBox rich;
        private System.Windows.Forms.Button btn_records;
        private System.Windows.Forms.DataGridView db_grid;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.RadioButton radioButton1_Customers;
        private System.Windows.Forms.RadioButton radioButton2_Orders;
        private System.Windows.Forms.RadioButton radioButton3_Employees;
    }
}

