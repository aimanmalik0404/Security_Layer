using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called..."); rich.Text = "Startup..."; try
            {
                /* 
                System.Diagnostics.Debug.WriteLine("within the try"); 
                SqlConnection connection = new SqlConnection(@"Data 
Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");                 connection.Open(); 
                txtMessageText.Text = "Connection Successful";                 connection.Close(); 
                */
                var datasource = @"DESKTOP-O31QORP\SQLEXPRESS"; // Note: Removed unnecessary semicolon
                var database = "Northwind";
                var thisUsername = login.username; // Make sure login.username is a valid variable.
                var thisPassword = login.password; // Make sure login.password is a valid variable.
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;

                SqlConnection conn = new SqlConnection(connString); conn.Open();
                rich.Text = "Connection Successful on Startup"; conn.Close();

            }

            catch (Exception ex)
            {
                rich.Text = "Error, " + ex;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            btn_update.Text = "Inserting Record...";
            command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" + tb_id.Text + "','" + tb_company.Text + "')";
            command.ExecuteNonQuery();
            rich.Text = "Record Inserted...";
            connection.Close();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            btn_records.Text = "Counting Records...";
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            rich.Text = "Number of records: " + count;
            connection.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string currentTable = "";
            if (radioButton1_Customers.Checked)
            {
                currentTable = "Customers";
            }
            else if (radioButton3_Employees.Checked)
            {
                currentTable = "Employees";
            }
            else if (radioButton2_Orders.Checked)
            {
                currentTable = "Orders";
            }



            db_grid.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                var datasource = @"DESKTOP-O31QORP\SQLEXPRESS";                 var database = "Northwind";                 var thisUsername = login.username;                 var thisPassword = login.password; 
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                rich.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                // Change this line to reference the correct DataGridView name
                db_grid.DataSource = dt;

                rich.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                rich.Text = "Error, " + ex;
            }

        }


        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
