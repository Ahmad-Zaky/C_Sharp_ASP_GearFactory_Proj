namespace GearFactory
{
    partial class Oreders
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
            System.Windows.Forms.Label o_dateLabel;
            System.Windows.Forms.Label dead_lineLabel;
            System.Windows.Forms.Label ship_idLabel;
            System.Windows.Forms.Label ship_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_postalcodeLabel;
            System.Windows.Forms.Label cust_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oreders));
            this.gEAR_FACTORY_DBDataSet1 = new GearFactory.GEAR_FACTORY_DBDataSet1();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.o_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dead_lineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ship_idTextBox = new System.Windows.Forms.TextBox();
            this.ship_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_postalcodeTextBox = new System.Windows.Forms.TextBox();
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            o_dateLabel = new System.Windows.Forms.Label();
            dead_lineLabel = new System.Windows.Forms.Label();
            ship_idLabel = new System.Windows.Forms.Label();
            ship_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_postalcodeLabel = new System.Windows.Forms.Label();
            cust_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // o_dateLabel
            // 
            o_dateLabel.AutoSize = true;
            o_dateLabel.Location = new System.Drawing.Point(60, 87);
            o_dateLabel.Name = "o_dateLabel";
            o_dateLabel.Size = new System.Drawing.Size(64, 13);
            o_dateLabel.TabIndex = 3;
            o_dateLabel.Text = "OrederDate";
            // 
            // dead_lineLabel
            // 
            dead_lineLabel.AutoSize = true;
            dead_lineLabel.Location = new System.Drawing.Point(60, 113);
            dead_lineLabel.Name = "dead_lineLabel";
            dead_lineLabel.Size = new System.Drawing.Size(51, 13);
            dead_lineLabel.TabIndex = 5;
            dead_lineLabel.Text = "DeadLine";
            // 
            // ship_idLabel
            // 
            ship_idLabel.AutoSize = true;
            ship_idLabel.Location = new System.Drawing.Point(60, 138);
            ship_idLabel.Name = "ship_idLabel";
            ship_idLabel.Size = new System.Drawing.Size(38, 13);
            ship_idLabel.TabIndex = 7;
            ship_idLabel.Text = "ShipID";
            // 
            // ship_dateLabel
            // 
            ship_dateLabel.AutoSize = true;
            ship_dateLabel.Location = new System.Drawing.Point(60, 165);
            ship_dateLabel.Name = "ship_dateLabel";
            ship_dateLabel.Size = new System.Drawing.Size(53, 13);
            ship_dateLabel.TabIndex = 9;
            ship_dateLabel.Text = "Ship Date";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(60, 190);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(57, 13);
            ship_nameLabel.TabIndex = 11;
            ship_nameLabel.Text = "Ship Name";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(60, 216);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(69, 13);
            ship_countryLabel.TabIndex = 13;
            ship_countryLabel.Text = "Ship Country";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(60, 242);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(49, 13);
            ship_cityLabel.TabIndex = 15;
            ship_cityLabel.Text = "Ship City";
            // 
            // ship_postalcodeLabel
            // 
            ship_postalcodeLabel.AutoSize = true;
            ship_postalcodeLabel.Location = new System.Drawing.Point(60, 268);
            ship_postalcodeLabel.Name = "ship_postalcodeLabel";
            ship_postalcodeLabel.Size = new System.Drawing.Size(61, 13);
            ship_postalcodeLabel.TabIndex = 17;
            ship_postalcodeLabel.Text = "PostalCode";
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Location = new System.Drawing.Point(60, 294);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(67, 13);
            cust_idLabel.TabIndex = 19;
            cust_idLabel.Text = "Customer ID";
            // 
            // gEAR_FACTORY_DBDataSet1
            // 
            this.gEAR_FACTORY_DBDataSet1.DataSetName = "GEAR_FACTORY_DBDataSet1";
            this.gEAR_FACTORY_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.gEAR_FACTORY_DBDataSet1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Orders_RawMaterialsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.RawMaterialsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SignInTableAdapter = null;
            this.tableAdapterManager.SkillsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkScheduleTableAdapter = null;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(402, 25);
            this.ordersBindingNavigator.TabIndex = 0;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // o_dateDateTimePicker
            // 
            this.o_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "o_date", true));
            this.o_dateDateTimePicker.Location = new System.Drawing.Point(151, 83);
            this.o_dateDateTimePicker.Name = "o_dateDateTimePicker";
            this.o_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.o_dateDateTimePicker.TabIndex = 4;
            // 
            // dead_lineDateTimePicker
            // 
            this.dead_lineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "dead_line", true));
            this.dead_lineDateTimePicker.Location = new System.Drawing.Point(151, 109);
            this.dead_lineDateTimePicker.Name = "dead_lineDateTimePicker";
            this.dead_lineDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dead_lineDateTimePicker.TabIndex = 6;
            // 
            // ship_idTextBox
            // 
            this.ship_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_id", true));
            this.ship_idTextBox.Location = new System.Drawing.Point(151, 135);
            this.ship_idTextBox.Name = "ship_idTextBox";
            this.ship_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.ship_idTextBox.TabIndex = 8;
            // 
            // ship_dateDateTimePicker
            // 
            this.ship_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ship_date", true));
            this.ship_dateDateTimePicker.Location = new System.Drawing.Point(151, 161);
            this.ship_dateDateTimePicker.Name = "ship_dateDateTimePicker";
            this.ship_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ship_dateDateTimePicker.TabIndex = 10;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.ship_nameTextBox.Location = new System.Drawing.Point(151, 187);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.ship_nameTextBox.TabIndex = 12;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.ship_countryTextBox.Location = new System.Drawing.Point(151, 213);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.ship_countryTextBox.TabIndex = 14;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.ship_cityTextBox.Location = new System.Drawing.Point(151, 239);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.ship_cityTextBox.TabIndex = 16;
            // 
            // ship_postalcodeTextBox
            // 
            this.ship_postalcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postalcode", true));
            this.ship_postalcodeTextBox.Location = new System.Drawing.Point(151, 265);
            this.ship_postalcodeTextBox.Name = "ship_postalcodeTextBox";
            this.ship_postalcodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.ship_postalcodeTextBox.TabIndex = 18;
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(151, 291);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.cust_idTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Oreders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(o_dateLabel);
            this.Controls.Add(this.o_dateDateTimePicker);
            this.Controls.Add(dead_lineLabel);
            this.Controls.Add(this.dead_lineDateTimePicker);
            this.Controls.Add(ship_idLabel);
            this.Controls.Add(this.ship_idTextBox);
            this.Controls.Add(ship_dateLabel);
            this.Controls.Add(this.ship_dateDateTimePicker);
            this.Controls.Add(ship_nameLabel);
            this.Controls.Add(this.ship_nameTextBox);
            this.Controls.Add(ship_countryLabel);
            this.Controls.Add(this.ship_countryTextBox);
            this.Controls.Add(ship_cityLabel);
            this.Controls.Add(this.ship_cityTextBox);
            this.Controls.Add(ship_postalcodeLabel);
            this.Controls.Add(this.ship_postalcodeTextBox);
            this.Controls.Add(cust_idLabel);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Name = "Oreders";
            this.Text = "Oreders";
            this.Load += new System.EventHandler(this.Oreders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEAR_FACTORY_DBDataSet1 gEAR_FACTORY_DBDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GEAR_FACTORY_DBDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker o_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dead_lineDateTimePicker;
        private System.Windows.Forms.TextBox ship_idTextBox;
        private System.Windows.Forms.DateTimePicker ship_dateDateTimePicker;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_postalcodeTextBox;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}