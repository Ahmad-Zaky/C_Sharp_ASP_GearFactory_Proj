namespace GearFactory
{
    partial class A_Machines
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
            System.Windows.Forms.Label name_machLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label date_producedLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Machines));
            this.gEAR_FACTORY_DBDataSet1 = new GearFactory.GEAR_FACTORY_DBDataSet1();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machinesTableAdapter = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.MachinesTableAdapter();
            this.tableAdapterManager = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager();
            this.machinesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.machinesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.name_machTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.date_producedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            name_machLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            date_producedLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingNavigator)).BeginInit();
            this.machinesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_machLabel
            // 
            name_machLabel.AutoSize = true;
            name_machLabel.Location = new System.Drawing.Point(43, 174);
            name_machLabel.Name = "name_machLabel";
            name_machLabel.Size = new System.Drawing.Size(65, 13);
            name_machLabel.TabIndex = 3;
            name_machLabel.Text = "name mach:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(43, 200);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(53, 13);
            companyLabel.TabIndex = 5;
            companyLabel.Text = "company:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(43, 226);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(45, 13);
            countryLabel.TabIndex = 7;
            countryLabel.Text = "country:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(43, 252);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(28, 13);
            sizeLabel.TabIndex = 9;
            sizeLabel.Text = "size:";
            // 
            // date_producedLabel
            // 
            date_producedLabel.AutoSize = true;
            date_producedLabel.Location = new System.Drawing.Point(43, 278);
            date_producedLabel.Name = "date_producedLabel";
            date_producedLabel.Size = new System.Drawing.Size(79, 13);
            date_producedLabel.TabIndex = 11;
            date_producedLabel.Text = "date produced:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(43, 304);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "description:";
            // 
            // gEAR_FACTORY_DBDataSet1
            // 
            this.gEAR_FACTORY_DBDataSet1.DataSetName = "GEAR_FACTORY_DBDataSet1";
            this.gEAR_FACTORY_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.gEAR_FACTORY_DBDataSet1;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Log_FileTableAdapter = null;
            this.tableAdapterManager.MachinesTableAdapter = this.machinesTableAdapter;
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
            // machinesBindingNavigator
            // 
            this.machinesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.machinesBindingNavigator.BindingSource = this.machinesBindingSource;
            this.machinesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.machinesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.machinesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.machinesBindingNavigatorSaveItem});
            this.machinesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.machinesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.machinesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.machinesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.machinesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.machinesBindingNavigator.Name = "machinesBindingNavigator";
            this.machinesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.machinesBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.machinesBindingNavigator.TabIndex = 0;
            this.machinesBindingNavigator.Text = "bindingNavigator1";
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
            // machinesBindingNavigatorSaveItem
            // 
            this.machinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.machinesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("machinesBindingNavigatorSaveItem.Image")));
            this.machinesBindingNavigatorSaveItem.Name = "machinesBindingNavigatorSaveItem";
            this.machinesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.machinesBindingNavigatorSaveItem.Text = "Save Data";
            this.machinesBindingNavigatorSaveItem.Click += new System.EventHandler(this.machinesBindingNavigatorSaveItem_Click);
            // 
            // name_machTextBox
            // 
            this.name_machTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "name_mach", true));
            this.name_machTextBox.Location = new System.Drawing.Point(130, 171);
            this.name_machTextBox.Name = "name_machTextBox";
            this.name_machTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_machTextBox.TabIndex = 4;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "company", true));
            this.companyTextBox.Location = new System.Drawing.Point(130, 197);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 6;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(130, 223);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 8;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(130, 249);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 10;
            // 
            // date_producedTextBox
            // 
            this.date_producedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "date_produced", true));
            this.date_producedTextBox.Location = new System.Drawing.Point(130, 275);
            this.date_producedTextBox.Name = "date_producedTextBox";
            this.date_producedTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_producedTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(130, 301);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Gear Factory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GearFactory.Properties.Resources.gear;
            this.pictureBox1.Location = new System.Drawing.Point(28, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 114);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // A_Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GearFactory.Properties.Resources.gear3;
            this.ClientSize = new System.Drawing.Size(527, 435);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(name_machLabel);
            this.Controls.Add(this.name_machTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(date_producedLabel);
            this.Controls.Add(this.date_producedTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.machinesBindingNavigator);
            this.Name = "A_Machines";
            this.Text = "A_Machines";
            this.Load += new System.EventHandler(this.A_Machines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingNavigator)).EndInit();
            this.machinesBindingNavigator.ResumeLayout(false);
            this.machinesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEAR_FACTORY_DBDataSet1 gEAR_FACTORY_DBDataSet1;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private GEAR_FACTORY_DBDataSet1TableAdapters.MachinesTableAdapter machinesTableAdapter;
        private GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator machinesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton machinesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox name_machTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox date_producedTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}