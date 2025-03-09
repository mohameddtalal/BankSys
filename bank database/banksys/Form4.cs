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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace banksys
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"))
            {
                con.Open();

                string query = "INSERT INTO branch (BRANCHNO, B_CITY, B_STATE, B_STREET, BANKCODE) " +
                               "VALUES (@branchNo, @city, @state, @street, @bankCode)";

                SqlCommand mycommand = new SqlCommand(query, con);
                mycommand.Parameters.AddWithValue("@branchNo", textBox1.Text);
                mycommand.Parameters.AddWithValue("@city", textBox2.Text);
                mycommand.Parameters.AddWithValue("@state", textBox3.Text);
                mycommand.Parameters.AddWithValue("@street", textBox4.Text);
                mycommand.Parameters.AddWithValue("@bankCode", textBox5.Text);

                mycommand.ExecuteNonQuery();

                con.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into bank values ('" + textBox6.Text.ToString() + "' ,'" + textBox7.Text.ToString() + " ',   ' " + textBox8.Text.ToString() + " ' )", con);


            mycommand.ExecuteNonQuery();

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //insert an account

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"))
            {
                con.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO ACCOUNT (SSN, TYPE, BALANCE, ACCOUNTNO) VALUES (@SSN, @TYPE, @BALANCE, @ACCOUNTNO)", con);
                mycommand.Parameters.AddWithValue("@SSN", textBox28.Text);
                mycommand.Parameters.AddWithValue("@BALANCE", textBox27.Text);
                mycommand.Parameters.AddWithValue("@TYPE", textBox26.Text);
                mycommand.Parameters.AddWithValue("@ACCOUNTNO", textBox25.Text);

                mycommand.ExecuteNonQuery();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"))
            {
                con.Open();
                SqlCommand mycommand = new SqlCommand("INSERT INTO CUSTOMER (SSN, FName, LName, CITY, STATE, STREET) VALUES (@SSN, @FName, @LName, @CITY, @STATE, @STREET)", con);
                mycommand.Parameters.AddWithValue("@SSN", textBox14.Text);
                mycommand.Parameters.AddWithValue("@FName", textBox13.Text);
                mycommand.Parameters.AddWithValue("@LName", textBox11.Text);
                mycommand.Parameters.AddWithValue("@CITY", textBox10.Text);
                mycommand.Parameters.AddWithValue("@STATE", textBox9.Text);
                mycommand.Parameters.AddWithValue("@STREET", textBox18.Text);


                mycommand.ExecuteNonQuery();
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
