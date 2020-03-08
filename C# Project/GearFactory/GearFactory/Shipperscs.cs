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
    public partial class Shipperscs : Form
    {
        public Shipperscs()
        {
            InitializeComponent();
        }

        private void shippersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shippersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Shipperscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Shippers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menue m = new Menue();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
