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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"))
            {
                con.Open();
                SqlCommand mycommand = new SqlCommand("UPDATE  CUSTOMER SET CITY=@CITY ,STATE =@STATE ,STREET=@STREET WHERE SSN=@SSN", con);
                mycommand.Parameters.AddWithValue("@CITY", textBox15.Text);
                mycommand.Parameters.AddWithValue("@STATE", textBox16.Text);
                mycommand.Parameters.AddWithValue("@STREET", textBox17.Text);
                mycommand.Parameters.AddWithValue("@SSN", textBox12.Text);


                mycommand.ExecuteNonQuery();
            }
        }
            

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IGD9FBE; Initial Catalog=banksys; Integrated Security=True;"))
            {
                con.Open();
                SqlCommand mycommand = new SqlCommand("UPDATE  BANK SET BANKNAME=@BANKNAME WHERE BANKCODE=@BANKCODE", con);
                mycommand.Parameters.AddWithValue("@BANKNAME", textBox24.Text);
                mycommand.Parameters.AddWithValue("@BANKCODE", textBox23.Text);
                mycommand.ExecuteNonQuery();
            }
        }
    }
}
