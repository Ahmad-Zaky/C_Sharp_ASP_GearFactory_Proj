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
    public partial class A_Invoices : Form
    {
        public A_Invoices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Invoice (o_id,c_id,o_date,ship_id,ship_date,ship_via,ship_address) values (" + textBox1.Text + "," + textBox2.Text + ",'" + textBox3.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", conn);
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
            SqlCommand cmd = new SqlCommand("select   o_id,c_id,o_date,ship_id,ship_date,ship_via,ship_address from Invoice where id_invioce = " + textBox8.Text + "", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    textBox1.Text = rdr.GetInt32(0).ToString();

                    textBox2.Text = rdr.GetInt32(1).ToString();

                    textBox3.Text = rdr.GetString(2);

                    textBox4.Text = rdr.GetInt32(3).ToString();

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
            SqlCommand cmd = new SqlCommand("update Invoice set o_id = "+textBox1.Text+" ,c_id="+textBox2.Text+" ,o_date='"+textBox3.Text+"',ship_id="+textBox4.Text+" ,ship_date='"+textBox5.Text+"' ,ship_via='"+textBox6.Text+"',ship_address='"+textBox7.Text+"' where id_invioce= "+textBox8.Text +"", conn);

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

            SqlCommand cmd = new SqlCommand("delete from  Invoice where id_invioce =" + textBox8.Text + "", conn);
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

        private void button6_Click(object sender, EventArgs e)
        {
            Menue m = new Menue();
            m.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
