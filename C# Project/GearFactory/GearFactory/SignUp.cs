using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GearFactory
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox4.Text && (textBox1.Text != "" || textBox2.Text != ""))
            {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();

            SqlCommand cmd2 = new SqlCommand("insert into SignIn (username,password,id_emp) values ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ")", conn);
            cmd2.ExecuteNonQuery();




            SqlCommand cmd1 = new SqlCommand("select * from SignIn where username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", conn);
            SqlDataReader reader = cmd1.ExecuteReader();
            //command will return read data after execution
            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }

            if (count > 1)
            {
                MessageBox.Show(" User and passward are exist");
                textBox1.Text = "";

                textBox2.Text = "";

                textBox4.Text = "";
            }
            else
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }

            }
            else
            {
                label5.Text = "Password Not Matched !";
                textBox2.Text = "";
                textBox4.Text = "";

            }

           
            
           

            
        }
    }
}
