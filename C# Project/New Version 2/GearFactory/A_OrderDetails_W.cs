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
    public partial class A_OrderDetails_W : Form
    {
        public A_OrderDetails_W()
        {
            InitializeComponent();
        }

        private void orderDetaileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetaileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void A_OrderDetails_W_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.OrderDetaile' table. You can move, or remove it, as needed.
            this.orderDetaileTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.OrderDetaile);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menue m = new Menue();
            m.Show();
            this.Hide();
        }
    }
}
