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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;");

        public Form6()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
       

        private void button5_Click_1(object sender, EventArgs e)
        {
            {
                new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;");
                con.Open();
                SqlCommand myCommand = new SqlCommand("delete from ACCOUNT where SSN = '" + textBox19.Text + "'", con);
                myCommand.ExecuteNonQuery();
                con.Close();
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            {
                new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;");
                con.Open();
                SqlCommand myCommand = new SqlCommand("delete from CUSTOMER where SSN = '" + textBox20.Text + "'", con);
                myCommand.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
