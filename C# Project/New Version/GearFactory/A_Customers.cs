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
    public partial class A_Customers : Form
    {
        public A_Customers()
        {
            InitializeComponent();
        }

       

        private void A_Customers_Load(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("insert into Customers (name_customer,company_name,address,m_phone,fax,e_mail,url) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", conn);
            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select   name_customer,company_name,address,m_phone,fax,e_mail,url from Customers where id_customer = " + textBox8.Text + "", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    textBox1.Text = rdr.GetString(0);

                    textBox2.Text = rdr.GetString(1);

                    textBox3.Text = rdr.GetString(2);

                    textBox4.Text = rdr.GetString(3);

                    textBox5.Text = rdr.GetString(4);

                    textBox6.Text = rdr.GetString(5);

                    textBox7.Text = rdr.GetString(6);
                }
            }
            else
            {
                textBox1.Text = "";

                textBox2.Text = "";

                textBox3.Text = "";

                textBox4.Text = "";

                textBox5.Text = "";

                textBox6.Text = "";

                textBox7.Text = "";

                textBox8.Text = "";

                label9.Text = "Not Exist ";
            }


            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Customers set name_customer = '" + textBox1.Text + "',company_name='" + textBox2.Text + "',address='" + textBox3.Text + "',m_phone='" + textBox4.Text + "',fax='" + textBox5.Text + "',e_mail='" + textBox6.Text + "',url='" + textBox7.Text + "' where id_customer=" + textBox8.Text + "", conn);
           
            cmd.ExecuteNonQuery();
            conn.Close();

            textBox1.Text = "";

            textBox2.Text = "";

            textBox3.Text = "";

            textBox4.Text = "";

            textBox5.Text = "";

            textBox6.Text = "";

            textBox7.Text = "";

            textBox8.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
           
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("delete from  Customers where id_customer =" + textBox8.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

       
    }
}
