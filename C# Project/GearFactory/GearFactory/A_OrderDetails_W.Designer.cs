namespace GearFactory
{
    partial class A_OrderDetails_W
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_OrderDetails_W));
            System.Windows.Forms.Label o_idLabel;
            System.Windows.Forms.Label p_idLabel;
            System.Windows.Forms.Label measuresLabel;
            System.Windows.Forms.Label unitpriceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label notesLabel;
            this.gEAR_FACTORY_DBDataSet1 = new GearFactory.GEAR_FACTORY_DBDataSet1();
            this.orderDetaileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetaileTableAdapter = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.OrderDetaileTableAdapter();
            this.tableAdapterManager = new GearFactory.GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager();
            this.orderDetaileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orderDetaileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.o_idTextBox = new System.Windows.Forms.TextBox();
            this.p_idTextBox = new System.Windows.Forms.TextBox();
            this.measuresTextBox = new System.Windows.Forms.TextBox();
            this.unitpriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            o_idLabel = new System.Windows.Forms.Label();
            p_idLabel = new System.Windows.Forms.Label();
            measuresLabel = new System.Windows.Forms.Label();
            unitpriceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetaileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetaileBindingNavigator)).BeginInit();
            this.orderDetaileBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gEAR_FACTORY_DBDataSet1
            // 
            this.gEAR_FACTORY_DBDataSet1.DataSetName = "GEAR_FACTORY_DBDataSet1";
            this.gEAR_FACTORY_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetaileBindingSource
            // 
            this.orderDetaileBindingSource.DataMember = "OrderDetaile";
            this.orderDetaileBindingSource.DataSource = this.gEAR_FACTORY_DBDataSet1;
            // 
            // orderDetaileTableAdapter
            // 
            this.orderDetaileTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OrderDetaileTableAdapter = this.orderDetaileTableAdapter;
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
            // orderDetaileBindingNavigator
            // 
            this.orderDetaileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderDetaileBindingNavigator.BindingSource = this.orderDetaileBindingSource;
            this.orderDetaileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderDetaileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderDetaileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderDetaileBindingNavigatorSaveItem});
            this.orderDetaileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderDetaileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderDetaileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderDetaileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderDetaileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderDetaileBindingNavigator.Name = "orderDetaileBindingNavigator";
            this.orderDetaileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderDetaileBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.orderDetaileBindingNavigator.TabIndex = 0;
            this.orderDetaileBindingNavigator.Text = "bindingNavigator1";
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
            // orderDetaileBindingNavigatorSaveItem
            // 
            this.orderDetaileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderDetaileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderDetaileBindingNavigatorSaveItem.Image")));
            this.orderDetaileBindingNavigatorSaveItem.Name = "orderDetaileBindingNavigatorSaveItem";
            this.orderDetaileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orderDetaileBindingNavigatorSaveItem.Text = "Save Data";
            this.orderDetaileBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderDetaileBindingNavigatorSaveItem_Click);
            // 
            // o_idLabel
            // 
            o_idLabel.AutoSize = true;
            o_idLabel.Location = new System.Drawing.Point(57, 82);
            o_idLabel.Name = "o_idLabel";
            o_idLabel.Size = new System.Drawing.Size(46, 13);
            o_idLabel.TabIndex = 3;
            o_idLabel.Text = "OrderID";
            // 
            // o_idTextBox
            // 
            this.o_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "o_id", true));
            this.o_idTextBox.Location = new System.Drawing.Point(120, 79);
            this.o_idTextBox.Name = "o_idTextBox";
            this.o_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.o_idTextBox.TabIndex = 4;
            // 
            // p_idLabel
            // 
            p_idLabel.AutoSize = true;
            p_idLabel.Location = new System.Drawing.Point(57, 108);
            p_idLabel.Name = "p_idLabel";
            p_idLabel.Size = new System.Drawing.Size(55, 13);
            p_idLabel.TabIndex = 5;
            p_idLabel.Text = "ProductID";
            // 
            // p_idTextBox
            // 
            this.p_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "p_id", true));
            this.p_idTextBox.Location = new System.Drawing.Point(120, 105);
            this.p_idTextBox.Name = "p_idTextBox";
            this.p_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_idTextBox.TabIndex = 6;
            // 
            // measuresLabel
            // 
            measuresLabel.AutoSize = true;
            measuresLabel.Location = new System.Drawing.Point(57, 134);
            measuresLabel.Name = "measuresLabel";
            measuresLabel.Size = new System.Drawing.Size(66, 13);
            measuresLabel.TabIndex = 7;
            measuresLabel.Text = "Measurment";
            // 
            // measuresTextBox
            // 
            this.measuresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "measures", true));
            this.measuresTextBox.Location = new System.Drawing.Point(120, 131);
            this.measuresTextBox.Name = "measuresTextBox";
            this.measuresTextBox.Size = new System.Drawing.Size(100, 20);
            this.measuresTextBox.TabIndex = 8;
            // 
            // unitpriceLabel
            // 
            unitpriceLabel.AutoSize = true;
            unitpriceLabel.Location = new System.Drawing.Point(57, 160);
            unitpriceLabel.Name = "unitpriceLabel";
            unitpriceLabel.Size = new System.Drawing.Size(30, 13);
            unitpriceLabel.TabIndex = 9;
            unitpriceLabel.Text = "Price";
            // 
            // unitpriceTextBox
            // 
            this.unitpriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "unitprice", true));
            this.unitpriceTextBox.Location = new System.Drawing.Point(120, 157);
            this.unitpriceTextBox.Name = "unitpriceTextBox";
            this.unitpriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitpriceTextBox.TabIndex = 10;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(57, 186);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(41, 13);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quality";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(120, 183);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 12;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(57, 212);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(48, 13);
            discountLabel.TabIndex = 13;
            discountLabel.Text = "Discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(120, 209);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 14;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(57, 238);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(35, 13);
            notesLabel.TabIndex = 15;
            notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetaileBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(120, 235);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(100, 20);
            this.notesTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // A_OrderDetails_W
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 344);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(o_idLabel);
            this.Controls.Add(this.o_idTextBox);
            this.Controls.Add(p_idLabel);
            this.Controls.Add(this.p_idTextBox);
            this.Controls.Add(measuresLabel);
            this.Controls.Add(this.measuresTextBox);
            this.Controls.Add(unitpriceLabel);
            this.Controls.Add(this.unitpriceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.orderDetaileBindingNavigator);
            this.Name = "A_OrderDetails_W";
            this.Text = "A_OrderDetails_W";
            this.Load += new System.EventHandler(this.A_OrderDetails_W_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEAR_FACTORY_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetaileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetaileBindingNavigator)).EndInit();
            this.orderDetaileBindingNavigator.ResumeLayout(false);
            this.orderDetaileBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEAR_FACTORY_DBDataSet1 gEAR_FACTORY_DBDataSet1;
        private System.Windows.Forms.BindingSource orderDetaileBindingSource;
        private GEAR_FACTORY_DBDataSet1TableAdapters.OrderDetaileTableAdapter orderDetaileTableAdapter;
        private GEAR_FACTORY_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderDetaileBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderDetaileBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox o_idTextBox;
        private System.Windows.Forms.TextBox p_idTextBox;
        private System.Windows.Forms.TextBox measuresTextBox;
        private System.Windows.Forms.TextBox unitpriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}