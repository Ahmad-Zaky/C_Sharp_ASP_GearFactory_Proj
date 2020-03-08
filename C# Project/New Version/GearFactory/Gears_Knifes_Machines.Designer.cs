namespace GearFactory
{
    partial class Gears_Knifes_Machines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gears_Knifes_Machines));
            System.Windows.Forms.Label id_gear_productLabel;
            System.Windows.Forms.Label id_knifeLabel;
            System.Windows.Forms.Label id_machineLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.gEAR_FACTORY_DBDataSet1 = new GearFactory.GEAR_FACTORY_DBDataSet1();
            this.gears_Knifes_MachinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gears_Knifes_MachinesTableAdapter = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.Gears_Knifes_MachinesTableAdapter();
            this.tableAdapterManager = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager();
            this.gears_Knifes_MachinesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.gears_Knifes_MachinesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_gear_productTextBox = new System.Windows.Forms.TextBox();
            this.id_knifeTextBox = new System.Windows.Forms.TextBox();
            this.id_machineTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            id_gear_productLabel = new System.Windows.Forms.Label();
            id_knifeLabel = new System.Windows.Forms.Label();
            id_machineLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gears_Knifes_MachinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gears_Knifes_MachinesBindingNavigator)).BeginInit();
            this.gears_Knifes_MachinesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gEAR_FACTORY_DBDataSet1
            // 
            this.gEAR_FACTORY_DBDataSet1.DataSetName = "GEAR_FACTORY_DBDataSet1";
            this.gEAR_FACTORY_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gears_Knifes_MachinesBindingSource
            // 
            this.gears_Knifes_MachinesBindingSource.DataMember = "Gears_Knifes_Machines";
            this.gears_Knifes_MachinesBindingSource.DataSource = this.gEAR_FACTORY_DBDataSet1;
            // 
            // gears_Knifes_MachinesTableAdapter
            // 
            this.gears_Knifes_MachinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.Emp_SkillsTableAdapter = null;
            this.tableAdapterManager.Employees_WorkScheduleTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.GearKnifesTableAdapter = null;
            this.tableAdapterManager.Gears_Knifes_MachinesTableAdapter = this.gears_Knifes_MachinesTableAdapter;
            this.tableAdapterManager.GearsProductsTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.MachinesTableAdapter = null;
            this.tableAdapterManager.OrderDetaileTableAdapter = null;
            this.tableAdapterManager.Orders_EmployeesTableAdapter = null;
            this.tableAdapterManager.Orders_RawMaterialsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.RawMaterialsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SignInTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkScheduleTableAdapter = null;
            // 
            // gears_Knifes_MachinesBindingNavigator
            // 
            this.gears_Knifes_MachinesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gears_Knifes_MachinesBindingNavigator.BindingSource = this.gears_Knifes_MachinesBindingSource;
            this.gears_Knifes_MachinesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gears_Knifes_MachinesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gears_Knifes_MachinesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.gears_Knifes_MachinesBindingNavigatorSaveItem});
            this.gears_Knifes_MachinesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gears_Knifes_MachinesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gears_Knifes_MachinesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gears_Knifes_MachinesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gears_Knifes_MachinesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gears_Knifes_MachinesBindingNavigator.Name = "gears_Knifes_MachinesBindingNavigator";
            this.gears_Knifes_MachinesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gears_Knifes_MachinesBindingNavigator.Size = new System.Drawing.Size(301, 25);
            this.gears_Knifes_MachinesBindingNavigator.TabIndex = 0;
            this.gears_Knifes_MachinesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // gears_Knifes_MachinesBindingNavigatorSaveItem
            // 
            this.gears_Knifes_MachinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gears_Knifes_MachinesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gears_Knifes_MachinesBindingNavigatorSaveItem.Image")));
            this.gears_Knifes_MachinesBindingNavigatorSaveItem.Name = "gears_Knifes_MachinesBindingNavigatorSaveItem";
            this.gears_Knifes_MachinesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.gears_Knifes_MachinesBindingNavigatorSaveItem.Text = "Save Data";
            this.gears_Knifes_MachinesBindingNavigatorSaveItem.Click += new System.EventHandler(this.gears_Knifes_MachinesBindingNavigatorSaveItem_Click);
            // 
            // id_gear_productLabel
            // 
            id_gear_productLabel.AutoSize = true;
            id_gear_productLabel.Location = new System.Drawing.Point(49, 56);
            id_gear_productLabel.Name = "id_gear_productLabel";
            id_gear_productLabel.Size = new System.Drawing.Size(84, 13);
            id_gear_productLabel.TabIndex = 3;
            id_gear_productLabel.Text = "id gear product:";
            // 
            // id_gear_productTextBox
            // 
            this.id_gear_productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gears_Knifes_MachinesBindingSource, "id_gear_product", true));
            this.id_gear_productTextBox.Location = new System.Drawing.Point(139, 53);
            this.id_gear_productTextBox.Name = "id_gear_productTextBox";
            this.id_gear_productTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_gear_productTextBox.TabIndex = 4;
            // 
            // id_knifeLabel
            // 
            id_knifeLabel.AutoSize = true;
            id_knifeLabel.Location = new System.Drawing.Point(49, 82);
            id_knifeLabel.Name = "id_knifeLabel";
            id_knifeLabel.Size = new System.Drawing.Size(45, 13);
            id_knifeLabel.TabIndex = 5;
            id_knifeLabel.Text = "id knife:";
            // 
            // id_knifeTextBox
            // 
            this.id_knifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gears_Knifes_MachinesBindingSource, "id_knife", true));
            this.id_knifeTextBox.Location = new System.Drawing.Point(139, 79);
            this.id_knifeTextBox.Name = "id_knifeTextBox";
            this.id_knifeTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_knifeTextBox.TabIndex = 6;
            // 
            // id_machineLabel
            // 
            id_machineLabel.AutoSize = true;
            id_machineLabel.Location = new System.Drawing.Point(49, 108);
            id_machineLabel.Name = "id_machineLabel";
            id_machineLabel.Size = new System.Drawing.Size(61, 13);
            id_machineLabel.TabIndex = 7;
            id_machineLabel.Text = "id machine:";
            // 
            // id_machineTextBox
            // 
            this.id_machineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gears_Knifes_MachinesBindingSource, "id_machine", true));
            this.id_machineTextBox.Location = new System.Drawing.Point(139, 105);
            this.id_machineTextBox.Name = "id_machineTextBox";
            this.id_machineTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_machineTextBox.TabIndex = 8;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(49, 134);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gears_Knifes_MachinesBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(139, 131);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gears_Knifes_Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_gear_productLabel);
            this.Controls.Add(this.id_gear_productTextBox);
            this.Controls.Add(id_knifeLabel);
            this.Controls.Add(this.id_knifeTextBox);
            this.Controls.Add(id_machineLabel);
            this.Controls.Add(this.id_machineTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.gears_Knifes_MachinesBindingNavigator);
            this.Name = "Gears_Knifes_Machines";
            this.Text = "Gears_Knifes_Machines";
            this.Load += new System.EventHandler(this.Gears_Knifes_Machines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gears_Knifes_MachinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gears_Knifes_MachinesBindingNavigator)).EndInit();
            this.gears_Knifes_MachinesBindingNavigator.ResumeLayout(false);
            this.gears_Knifes_MachinesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEAR_FACTORY_DBDataSet1 gEAR_FACTORY_DBDataSet1;
        private System.Windows.Forms.BindingSource gears_Knifes_MachinesBindingSource;
        private GEAR_FACTORY_DBDataSet1TableAdapters.Gears_Knifes_MachinesTableAdapter gears_Knifes_MachinesTableAdapter;
        private GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gears_Knifes_MachinesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton gears_Knifes_MachinesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_gear_productTextBox;
        private System.Windows.Forms.TextBox id_knifeTextBox;
        private System.Windows.Forms.TextBox id_machineTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}