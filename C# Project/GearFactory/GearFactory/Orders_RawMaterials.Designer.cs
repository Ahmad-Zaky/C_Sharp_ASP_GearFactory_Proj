namespace GearFactory
{
    partial class Orders_RawMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_RawMaterials));
            System.Windows.Forms.Label id_orderLabel;
            System.Windows.Forms.Label id_rawmaterialLabel;
            System.Windows.Forms.Label measuresLabel;
            this.gEAR_FACTORY_DBDataSet1 = new GearFactory.GEAR_FACTORY_DBDataSet1();
            this.orders_RawMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orders_RawMaterialsTableAdapter = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.Orders_RawMaterialsTableAdapter();
            this.tableAdapterManager = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager();
            this.orders_RawMaterialsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orders_RawMaterialsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_orderTextBox = new System.Windows.Forms.TextBox();
            this.id_rawmaterialTextBox = new System.Windows.Forms.TextBox();
            this.measuresTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            id_orderLabel = new System.Windows.Forms.Label();
            id_rawmaterialLabel = new System.Windows.Forms.Label();
            measuresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_RawMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_RawMaterialsBindingNavigator)).BeginInit();
            this.orders_RawMaterialsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gEAR_FACTORY_DBDataSet1
            // 
            this.gEAR_FACTORY_DBDataSet1.DataSetName = "GEAR_FACTORY_DBDataSet1";
            this.gEAR_FACTORY_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orders_RawMaterialsBindingSource
            // 
            this.orders_RawMaterialsBindingSource.DataMember = "Orders_RawMaterials";
            this.orders_RawMaterialsBindingSource.DataSource = this.gEAR_FACTORY_DBDataSet1;
            // 
            // orders_RawMaterialsTableAdapter
            // 
            this.orders_RawMaterialsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Gears_Knifes_MachinesTableAdapter = null;
            this.tableAdapterManager.GearsProductsTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.MachinesTableAdapter = null;
            this.tableAdapterManager.OrderDetaileTableAdapter = null;
            this.tableAdapterManager.Orders_EmployeesTableAdapter = null;
            this.tableAdapterManager.Orders_RawMaterialsTableAdapter = this.orders_RawMaterialsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.RawMaterialsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SignInTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkScheduleTableAdapter = null;
            // 
            // orders_RawMaterialsBindingNavigator
            // 
            this.orders_RawMaterialsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orders_RawMaterialsBindingNavigator.BindingSource = this.orders_RawMaterialsBindingSource;
            this.orders_RawMaterialsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orders_RawMaterialsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orders_RawMaterialsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orders_RawMaterialsBindingNavigatorSaveItem});
            this.orders_RawMaterialsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orders_RawMaterialsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orders_RawMaterialsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orders_RawMaterialsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orders_RawMaterialsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orders_RawMaterialsBindingNavigator.Name = "orders_RawMaterialsBindingNavigator";
            this.orders_RawMaterialsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orders_RawMaterialsBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.orders_RawMaterialsBindingNavigator.TabIndex = 0;
            this.orders_RawMaterialsBindingNavigator.Text = "bindingNavigator1";
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
            // orders_RawMaterialsBindingNavigatorSaveItem
            // 
            this.orders_RawMaterialsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orders_RawMaterialsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orders_RawMaterialsBindingNavigatorSaveItem.Image")));
            this.orders_RawMaterialsBindingNavigatorSaveItem.Name = "orders_RawMaterialsBindingNavigatorSaveItem";
            this.orders_RawMaterialsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orders_RawMaterialsBindingNavigatorSaveItem.Text = "Save Data";
            this.orders_RawMaterialsBindingNavigatorSaveItem.Click += new System.EventHandler(this.orders_RawMaterialsBindingNavigatorSaveItem_Click);
            // 
            // id_orderLabel
            // 
            id_orderLabel.AutoSize = true;
            id_orderLabel.Location = new System.Drawing.Point(58, 87);
            id_orderLabel.Name = "id_orderLabel";
            id_orderLabel.Size = new System.Drawing.Size(48, 13);
            id_orderLabel.TabIndex = 3;
            id_orderLabel.Text = "id order:";
            // 
            // id_orderTextBox
            // 
            this.id_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orders_RawMaterialsBindingSource, "id_order", true));
            this.id_orderTextBox.Location = new System.Drawing.Point(142, 84);
            this.id_orderTextBox.Name = "id_orderTextBox";
            this.id_orderTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_orderTextBox.TabIndex = 4;
            // 
            // id_rawmaterialLabel
            // 
            id_rawmaterialLabel.AutoSize = true;
            id_rawmaterialLabel.Location = new System.Drawing.Point(58, 113);
            id_rawmaterialLabel.Name = "id_rawmaterialLabel";
            id_rawmaterialLabel.Size = new System.Drawing.Size(78, 13);
            id_rawmaterialLabel.TabIndex = 5;
            id_rawmaterialLabel.Text = "id rawmaterial:";
            // 
            // id_rawmaterialTextBox
            // 
            this.id_rawmaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orders_RawMaterialsBindingSource, "id_rawmaterial", true));
            this.id_rawmaterialTextBox.Location = new System.Drawing.Point(142, 110);
            this.id_rawmaterialTextBox.Name = "id_rawmaterialTextBox";
            this.id_rawmaterialTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_rawmaterialTextBox.TabIndex = 6;
            // 
            // measuresLabel
            // 
            measuresLabel.AutoSize = true;
            measuresLabel.Location = new System.Drawing.Point(58, 139);
            measuresLabel.Name = "measuresLabel";
            measuresLabel.Size = new System.Drawing.Size(57, 13);
            measuresLabel.TabIndex = 7;
            measuresLabel.Text = "measures:";
            // 
            // measuresTextBox
            // 
            this.measuresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orders_RawMaterialsBindingSource, "measures", true));
            this.measuresTextBox.Location = new System.Drawing.Point(142, 136);
            this.measuresTextBox.Name = "measuresTextBox";
            this.measuresTextBox.Size = new System.Drawing.Size(100, 20);
            this.measuresTextBox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Orders_RawMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_orderLabel);
            this.Controls.Add(this.id_orderTextBox);
            this.Controls.Add(id_rawmaterialLabel);
            this.Controls.Add(this.id_rawmaterialTextBox);
            this.Controls.Add(measuresLabel);
            this.Controls.Add(this.measuresTextBox);
            this.Controls.Add(this.orders_RawMaterialsBindingNavigator);
            this.Name = "Orders_RawMaterials";
            this.Text = "Orders_RawMaterials";
            this.Load += new System.EventHandler(this.Orders_RawMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_RawMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_RawMaterialsBindingNavigator)).EndInit();
            this.orders_RawMaterialsBindingNavigator.ResumeLayout(false);
            this.orders_RawMaterialsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEAR_FACTORY_DBDataSet1 gEAR_FACTORY_DBDataSet1;
        private System.Windows.Forms.BindingSource orders_RawMaterialsBindingSource;
        private GEAR_FACTORY_DBDataSet1TableAdapters.Orders_RawMaterialsTableAdapter orders_RawMaterialsTableAdapter;
        private GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orders_RawMaterialsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orders_RawMaterialsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_orderTextBox;
        private System.Windows.Forms.TextBox id_rawmaterialTextBox;
        private System.Windows.Forms.TextBox measuresTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}