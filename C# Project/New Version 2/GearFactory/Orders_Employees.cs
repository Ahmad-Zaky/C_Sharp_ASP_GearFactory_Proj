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
    public partial class Orders_Employees : Form
    {
        public Orders_Employees()
        {
            InitializeComponent();
        }

        private void orders_EmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orders_EmployeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Orders_Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Orders_Employees' table. You can move, or remove it, as needed.
            this.orders_EmployeesTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Orders_Employees);

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
