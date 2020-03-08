using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GearFactory
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A_Customers c = new A_Customers();
            c.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Log_File l = new Log_File();
            l.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            A_OrderDetails_W emp = new A_OrderDetails_W();
            emp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            A_Invoices emp = new A_Invoices();
            emp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            A_GearKnife emp = new A_GearKnife();
            emp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            A_Employees emp = new A_Employees();
            emp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A_Machines emp = new A_Machines();
            emp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A_GearsProducts emp = new A_GearsProducts();
            emp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A_Department emp = new A_Department();
            emp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            A_Employees emp = new A_Employees();
            emp.Show();
            this.Hide();
        }

       
       

        

       }
}
