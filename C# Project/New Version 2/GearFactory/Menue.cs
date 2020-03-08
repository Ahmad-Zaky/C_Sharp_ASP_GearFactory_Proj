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

       
       

        

       }
}
