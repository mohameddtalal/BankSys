using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banksys
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void Form2_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"; // Replace with your actual connection string
            string commandString = "SELECT * FROM CUSTOMER";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(commandString, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                cUSTOMERDataGridView.DataSource = table;
            }


        }

        private void back_Click(object sender, EventArgs e)
        {

             Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void cUSTOMERDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
