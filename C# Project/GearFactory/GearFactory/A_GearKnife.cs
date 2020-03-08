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
    public partial class A_GearKnife : Form
    {
        public A_GearKnife()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into GearKnifes (type,module,description) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"')", conn);

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
            SqlCommand cmd = new SqlCommand("select   type,module,description from GearKnifes where id_Knife = " + textBox8.Text + "", conn);
            
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
            SqlCommand cmd = new SqlCommand("update GearKnifes set type = '" + textBox1.Text + "',module='" + textBox2.Text + "',description='" + textBox3.Text +"' where id_Knife=" + textBox8.Text + "", conn);

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

            SqlCommand cmd = new SqlCommand("delete from  GearKnifes where id_Knife =" + textBox8.Text + "", conn);
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

            Menue m = new Menue();
            m.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
