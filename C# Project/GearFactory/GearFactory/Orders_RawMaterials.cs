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
    public partial class Orders_RawMaterials : Form
    {
        public Orders_RawMaterials()
        {
            InitializeComponent();
        }

        private void orders_RawMaterialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orders_RawMaterialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Orders_RawMaterials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Orders_RawMaterials' table. You can move, or remove it, as needed.
            this.orders_RawMaterialsTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Orders_RawMaterials);

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
