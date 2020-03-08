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
    public partial class skills : Form
    {
        public skills()
        {
            InitializeComponent();
        }

        private void skillsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.skillsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void skills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Skills' table. You can move, or remove it, as needed.
            this.skillsTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Skills);

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
