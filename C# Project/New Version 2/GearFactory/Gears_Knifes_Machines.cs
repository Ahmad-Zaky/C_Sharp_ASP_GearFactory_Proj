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
    public partial class Gears_Knifes_Machines : Form
    {
        public Gears_Knifes_Machines()
        {
            InitializeComponent();
        }

        private void gears_Knifes_MachinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gears_Knifes_MachinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Gears_Knifes_Machines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Gears_Knifes_Machines' table. You can move, or remove it, as needed.
            this.gears_Knifes_MachinesTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Gears_Knifes_Machines);

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
