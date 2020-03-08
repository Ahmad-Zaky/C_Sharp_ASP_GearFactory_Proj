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
    public partial class A_GearsProducts : Form
    {
        public A_GearsProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into GearsProducts (type_gear,_desc,notes) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);

            cmd.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select   type_gear,_desc,notes from GearsProducts where id_gear = " + textBox8.Text + "", conn);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    textBox1.Text = rdr.GetString(0);

                    textBox2.Text = rdr.GetString(1);

                    textBox3.Text = rdr.GetString(2);


                }
            }
            else
            {
                textBox1.Text = "";

                textBox2.Text = "";

                textBox3.Text = "";

                textBox8.Text = "";

                label9.Text = "Not Exist ";
            }


            conn.Close();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update GearsProducts set type_gear = '" + textBox1.Text + "',_desc='" + textBox2.Text + "',notes='" + textBox3.Text + "' where id_gear=" + textBox8.Text + "", conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            textBox1.Text = "";

            textBox2.Text = "";

            textBox3.Text = "";

            textBox8.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from  GearsProducts where id_gear =" + textBox8.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
