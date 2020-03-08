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
            A_OrderDetails_W l = new A_OrderDetails_W();
            l.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            A_Invoices l = new A_Invoices();
            l.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            A_GearKnife l = new A_GearKnife();
            l.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            A_Employees l = new A_Employees();
            l.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A_Machines l = new A_Machines();
            l.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A_GearsProducts l = new A_GearsProducts();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A_Department l = new A_Department();
            l.Show();
            this.Hide();
        }

       
       

        

       }
}
