using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace banksys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;");


        /*private void button1_Click(object sender, EventArgs e)
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
        }*/


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;");
            con.Open();
            SqlCommand mycommand = new SqlCommand("insert into bank values ('" + textBox6.Text.ToString() + "' ,'" + textBox7.Text.ToString() + " ',   ' " + textBox8.Text.ToString() + " ' )", con); 


             mycommand.ExecuteNonQuery();

            con.Close();
        }*/
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

       /* private void button1_Click_1(object sender, EventArgs e)
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

        }*/

        
        private void label25_Click(object sender, EventArgs e)
        {

        }

      /*  private void button6_Click(object sender, EventArgs e)
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


        }*/

       

        

        private void button8_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog(); 
            this.Close();
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
