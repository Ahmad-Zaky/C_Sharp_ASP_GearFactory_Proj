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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=GEAR_FACTORY_DB;Integrated Security=True");
            connection.Open();

            DateTime date1 = new DateTime();
            date1 = DateTime.Now;
            label4.Text = date1.ToString();
            SqlCommand cmd1 = new SqlCommand("insert into Log_File (username,password,sign_in_date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + label4.Text + "')", connection);
            cmd1.ExecuteNonQuery();


            SqlCommand cmd = new SqlCommand("select * from SignIn where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", connection);
            
            
            SqlDataReader reader = cmd.ExecuteReader();
              //command will return read data after execution
            int count = 0;
            
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("user and passward is correct");
                    connection.Dispose();   //to release all resources
                    //to hide this form
                    Menue m = new Menue();
                    m.Show();
                    this.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("doublicate user and passward");
                }
                else
                {   textBox1.Text = "";

                    textBox2.Text = "";
                    MessageBox.Show("user and passward not correct");
                }
                

                
                

           
            connection.Close(); 

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {




            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        
    }
}
