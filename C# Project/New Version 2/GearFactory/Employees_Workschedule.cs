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
    public partial class Employees_Workschedule : Form
    {
        public Employees_Workschedule()
        {
            InitializeComponent();
        }

        private void employees_WorkScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employees_WorkScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Employees_Workschedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Employees_WorkSchedule' table. You can move, or remove it, as needed.
            this.employees_WorkScheduleTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Employees_WorkSchedule);

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
