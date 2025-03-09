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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            {
                string connectionString = "Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"; // Replace with your actual connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT c.SSN, c.FNAME, c.LNAME, c.CITY, a.ACCOUNTNO, a.BALANCE " +
                                   "FROM CUSTOMER c " +
                                   "INNER JOIN ACCOUNT a ON c.SSN = a.SSN"; // Modify the join condition based on your database schema

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable table = new DataTable();
                    table.Load(reader);

                    // Use the data table as needed, e.g., bind it to a DataGridView
                    dataGridView1.DataSource = table;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
