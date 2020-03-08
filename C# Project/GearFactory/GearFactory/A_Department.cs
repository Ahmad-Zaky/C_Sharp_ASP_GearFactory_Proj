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
    public partial class A_Department : Form
    {
        public A_Department()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Menue m = new Menue();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Department (name_dept,_desc) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select   name_dept,_desc from Department where id_dept = " + textBox8.Text + "", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    textBox1.Text = rdr.GetString(0);

                    textBox2.Text = rdr.GetString(1);


                }
            }
            else
            {
                textBox1.Text = "";

                textBox2.Text = "";

                label3.Text = "Not Exist ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Department set name_dept = '" + textBox1.Text + "',_desc='" + textBox2.Text + "' where id_dept=" + textBox8.Text + "", conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            textBox1.Text = "";

            textBox2.Text = "";

            textBox8.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from Department where id_dept =" + textBox8.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            
            textBox8.Text = "";
        }

        

        
    }
}
