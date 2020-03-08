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
    public partial class Emp_Skills : Form
    {
        public Emp_Skills()
        {
            InitializeComponent();
        }

        private void emp_SkillsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emp_SkillsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Emp_Skills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Emp_Skills' table. You can move, or remove it, as needed.
            this.emp_SkillsTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Emp_Skills);

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
