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
    public partial class A_Employees : Form
    {
        public A_Employees()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
             SqlCommand cmd1 = new SqlCommand("select id_dept from Department where name_dept ='"+comboBox1.Text+"'", conn);
             SqlDataReader rdr = cmd1.ExecuteReader();
             if (rdr.HasRows)
             {
                 while (rdr.Read())
                 {
                     label17.Text = rdr.GetInt32(0).ToString();
                 }
             }
             rdr.Close();
             SqlCommand cmd = new SqlCommand("insert into Employees (name_emp,country,city,street,h_phone,m_phone,e_mail,url,date_employed,salary,free_days,gender,id_dept) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox10.Text + "','" + textBox11.Text + "'," + textBox12.Text + ",'" + textBox13.Text + "','" + textBox14.Text + "'," + label17.Text + ")", conn);
             cmd.ExecuteNonQuery();

             textBox1.Text = "";
             textBox2.Text = "";
             textBox3.Text = "";
             textBox4.Text = "";
             textBox5.Text = "";
             textBox6.Text = "";
             textBox7.Text = "";
             
             textBox10.Text = "";
             textBox11.Text = "";
             textBox12.Text = "";
             textBox13.Text = "";
             textBox14.Text = "";
             label17.Text = "";
            
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();

            SqlCommand cmd1 = new SqlCommand("select id_emp from Employees where name_emp ='" + comboBox2.Text + "'", conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                {
                    label17.Text = rdr1.GetInt32(0).ToString();
                }
            }
            rdr1.Close();

            SqlCommand cmd = new SqlCommand("select   name_emp,country,city,street,h_phone,m_phone,e_mail,url,date_employed,salary,free_days,gender,name_dept from Department inner join Employees  on id_emp = " + label17.Text + " and (Department.id_dept = Employees.id_dept)", conn);
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

                    textBox10.Text = rdr.GetString(7);

                    textBox11.Text = rdr.GetString(8);

                    textBox12.Text = rdr.GetDecimal(9).ToString();

                    textBox13.Text = rdr.GetString(10);

                    textBox14.Text = rdr.GetString(11);

                    comboBox1.Text = rdr.GetString(12).ToString();



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

                // textBox8.Text = "";

                textBox10.Text = "";

                textBox11.Text = "";

                textBox12.Text = "";

                textBox13.Text = "";

                textBox14.Text = "";

                label17.Text = "";

                label9.Text = "Not Exist ";
            }

            label17.Text = "";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select id_dept from Department where name_dept ='" + comboBox1.Text + "'", conn);
            SqlDataReader rdr = cmd2.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    label17.Text = rdr.GetInt32(0).ToString();
                }
            }
            rdr.Close();

            SqlCommand cmd1 = new SqlCommand("select id_emp from Employees where name_emp ='" + comboBox2.Text + "'", conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                {
                    label18.Text = rdr1.GetInt32(0).ToString();
                }
            }
            rdr1.Close();

            SqlCommand cmd = new SqlCommand("update Employees set name_emp = '" + textBox1.Text + "',country='" + textBox2.Text + "',city='" + textBox3.Text + "',street='" + textBox4.Text + "',h_phone='" + textBox5.Text + "',m_phone='" + textBox7.Text + "',e_mail='" + textBox7.Text + "',url='" + textBox10.Text + "',date_employed='" + textBox11.Text + "',salary=" + textBox12.Text + ",free_days='" + textBox13.Text + "',gender='" + textBox14.Text + "',id_dept=" + label17.Text + " where id_emp=" + label18.Text + "", conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            textBox1.Text = "";

            textBox2.Text = "";

            textBox3.Text = "";

            textBox4.Text = "";

            textBox5.Text = "";

            textBox6.Text = "";

            textBox7.Text = "";

            //textBox8.Text = "";

            textBox10.Text = "";

            textBox11.Text = "";

            textBox12.Text = "";

            textBox13.Text = "";

            textBox14.Text = "";

            //  textBox15.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");


            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select id_emp from Employees where name_emp ='" + comboBox2.Text + "'", conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                {
                    label17.Text = rdr1.GetInt32(0).ToString();
                }
            }
            rdr1.Close();


            SqlCommand cmd = new SqlCommand("delete from  Employees where id_emp =" + label17.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            //textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            // comboBox1.Text = "";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void A_Employees_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True";
            conn.Open();
            string str = "select name_dept from Department  ";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    comboBox1.Items.Add(rdr["name_dept"].ToString());

                }


            }
            

                
           
            conn.Close();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True";
            conn.Open();
            string str1 = "select name_emp from  Employees ";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            SqlDataReader rdr1 = cmd1.ExecuteReader();


            if (rdr1.HasRows)
            {
                while (rdr1.Read())
                {


                    comboBox2.Items.Add(rdr1["name_emp"].ToString());
                }

            }
        }

        
    }
}
