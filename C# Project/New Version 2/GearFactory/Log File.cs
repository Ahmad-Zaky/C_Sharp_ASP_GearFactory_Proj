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
    public partial class Log_File : Form
    {
        public Log_File()
        {
            InitializeComponent();
        }

        private void log_FileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.log_FileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEAR_FACTORY_DBDataSet1);

        }

        private void Log_File_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gEAR_FACTORY_DBDataSet1.Log_File' table. You can move, or remove it, as needed.
            this.log_FileTableAdapter.Fill(this.gEAR_FACTORY_DBDataSet1.Log_File);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menue m = new Menue();
            m.Show();
            this.Hide();
        }
    }
}
