namespace RobotDataBase
{
    partial class RobotsWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Footprint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DegreesOfMobility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxJointVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workspace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeatability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrOfInputs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrOfOutputs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfflineProgramming = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OnlineProgramming = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AutoProgramming = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.referenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.modifiedLabelImposed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.imposeMinPrice = new System.Windows.Forms.TextBox();
            this.imposeMaxPrice = new System.Windows.Forms.TextBox();
            this.imposeMinFootprint = new System.Windows.Forms.TextBox();
            this.imposeMaxFootprint = new System.Windows.Forms.TextBox();
            this.imposeMinDOM = new System.Windows.Forms.TextBox();
            this.imposeMaxDOM = new System.Windows.Forms.TextBox();
            this.imposeMinMJV = new System.Windows.Forms.TextBox();
            this.imposeMaxMJV = new System.Windows.Forms.TextBox();
            this.imposeMinAccuracy = new System.Windows.Forms.TextBox();
            this.imposeMaxAccuracy = new System.Windows.Forms.TextBox();
            this.imposeMinRepeatability = new System.Windows.Forms.TextBox();
            this.imposeMaxRepeatability = new System.Windows.Forms.TextBox();
            this.imposeMinWeight = new System.Windows.Forms.TextBox();
            this.imposeMaxWeight = new System.Windows.Forms.TextBox();
            this.imposeMinMaxLift = new System.Windows.Forms.TextBox();
            this.imposeMaxMaxLift = new System.Windows.Forms.TextBox();
            this.imposeMinNrOfInputs = new System.Windows.Forms.TextBox();
            this.imposeMaxNrOfInputs = new System.Windows.Forms.TextBox();
            this.imposeMinNrOfOutputs = new System.Windows.Forms.TextBox();
            this.imposeMaxNrOfOutputs = new System.Windows.Forms.TextBox();
            this.imposeOffline = new System.Windows.Forms.ComboBox();
            this.imposeOnline = new System.Windows.Forms.ComboBox();
            this.imposeAuto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.priceCheck = new System.Windows.Forms.CheckBox();
            this.footprintCheck = new System.Windows.Forms.CheckBox();
            this.domCheck = new System.Windows.Forms.CheckBox();
            this.mjvCheck = new System.Windows.Forms.CheckBox();
            this.workspaceCheck = new System.Windows.Forms.CheckBox();
            this.accuracyCheck = new System.Windows.Forms.CheckBox();
            this.repeatabilityCheck = new System.Windows.Forms.CheckBox();
            this.weightCheck = new System.Windows.Forms.CheckBox();
            this.maxLiftCheck = new System.Windows.Forms.CheckBox();
            this.nrOfInputsCheck = new System.Windows.Forms.CheckBox();
            this.nrOfOutputsCheck = new System.Windows.Forms.CheckBox();
            this.offlineCheck = new System.Windows.Forms.CheckBox();
            this.onlineCheck = new System.Windows.Forms.CheckBox();
            this.autoCheck = new System.Windows.Forms.CheckBox();
            this.RPrice = new System.Windows.Forms.NumericUpDown();
            this.RFootprint = new System.Windows.Forms.NumericUpDown();
            this.RDOM = new System.Windows.Forms.NumericUpDown();
            this.RMJV = new System.Windows.Forms.NumericUpDown();
            this.RWorkspace = new System.Windows.Forms.NumericUpDown();
            this.RAccuracy = new System.Windows.Forms.NumericUpDown();
            this.RRepeatability = new System.Windows.Forms.NumericUpDown();
            this.RWeight = new System.Windows.Forms.NumericUpDown();
            this.RMaxLift = new System.Windows.Forms.NumericUpDown();
            this.RNrOfInputs = new System.Windows.Forms.NumericUpDown();
            this.RNrOfOutputs = new System.Windows.Forms.NumericUpDown();
            this.ROffline = new System.Windows.Forms.NumericUpDown();
            this.ROnline = new System.Windows.Forms.NumericUpDown();
            this.RAuto = new System.Windows.Forms.NumericUpDown();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceNumeric)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RFootprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RMJV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RWorkspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRepeatability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RMaxLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNrOfInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNrOfOutputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROffline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Model,
            this.Price,
            this.Footprint,
            this.DegreesOfMobility,
            this.MaxJointVelocity,
            this.Workspace,
            this.Accuracy,
            this.Repeatability,
            this.Weight,
            this.MaxLift,
            this.NrOfInputs,
            this.NrOfOutputs,
            this.OfflineProgramming,
            this.OnlineProgramming,
            this.AutoProgramming,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(14, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 439);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RobotID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price ($)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 90;
            // 
            // Footprint
            // 
            this.Footprint.DataPropertyName = "Footprint";
            this.Footprint.HeaderText = "Footprint (m^2)";
            this.Footprint.Name = "Footprint";
            this.Footprint.ReadOnly = true;
            this.Footprint.Width = 60;
            // 
            // DegreesOfMobility
            // 
            this.DegreesOfMobility.DataPropertyName = "DegreesOfMobility";
            this.DegreesOfMobility.HeaderText = "Degrees Of Mobility";
            this.DegreesOfMobility.Name = "DegreesOfMobility";
            this.DegreesOfMobility.ReadOnly = true;
            this.DegreesOfMobility.Width = 50;
            // 
            // MaxJointVelocity
            // 
            this.MaxJointVelocity.DataPropertyName = "MaxJointVelocity";
            this.MaxJointVelocity.HeaderText = "Max Joint Velocity (deg/s)";
            this.MaxJointVelocity.Name = "MaxJointVelocity";
            this.MaxJointVelocity.ReadOnly = true;
            this.MaxJointVelocity.Width = 75;
            // 
            // Workspace
            // 
            this.Workspace.DataPropertyName = "Workspace";
            this.Workspace.HeaderText = "Workspace (mm x mm x mm)";
            this.Workspace.Name = "Workspace";
            this.Workspace.ReadOnly = true;
            // 
            // Accuracy
            // 
            this.Accuracy.DataPropertyName = "Accuracy";
            this.Accuracy.HeaderText = "Accuracy (mm)";
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            this.Accuracy.Width = 60;
            // 
            // Repeatability
            // 
            this.Repeatability.DataPropertyName = "Repeatability";
            this.Repeatability.HeaderText = "Repeatability (mm)";
            this.Repeatability.Name = "Repeatability";
            this.Repeatability.ReadOnly = true;
            this.Repeatability.Width = 70;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight (Kg)";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 60;
            // 
            // MaxLift
            // 
            this.MaxLift.DataPropertyName = "MaxLift";
            this.MaxLift.HeaderText = "Max Lift (daN)";
            this.MaxLift.Name = "MaxLift";
            this.MaxLift.ReadOnly = true;
            this.MaxLift.Width = 40;
            // 
            // NrOfInputs
            // 
            this.NrOfInputs.DataPropertyName = "NrOfInputs";
            this.NrOfInputs.HeaderText = "Nr Of Inputs";
            this.NrOfInputs.Name = "NrOfInputs";
            this.NrOfInputs.ReadOnly = true;
            this.NrOfInputs.Width = 40;
            // 
            // NrOfOutputs
            // 
            this.NrOfOutputs.DataPropertyName = "NrOfOutputs";
            this.NrOfOutputs.HeaderText = "Nr Of Outputs";
            this.NrOfOutputs.Name = "NrOfOutputs";
            this.NrOfOutputs.ReadOnly = true;
            this.NrOfOutputs.Width = 45;
            // 
            // OfflineProgramming
            // 
            this.OfflineProgramming.DataPropertyName = "OfflineProgramming";
            this.OfflineProgramming.HeaderText = "Offline Programming";
            this.OfflineProgramming.Name = "OfflineProgramming";
            this.OfflineProgramming.ReadOnly = true;
            this.OfflineProgramming.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OfflineProgramming.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OfflineProgramming.Width = 70;
            // 
            // OnlineProgramming
            // 
            this.OnlineProgramming.DataPropertyName = "OnlineProgramming";
            this.OnlineProgramming.HeaderText = "Online Programming";
            this.OnlineProgramming.Name = "OnlineProgramming";
            this.OnlineProgramming.ReadOnly = true;
            this.OnlineProgramming.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OnlineProgramming.Width = 70;
            // 
            // AutoProgramming
            // 
            this.AutoProgramming.DataPropertyName = "AutoProgramming";
            this.AutoProgramming.HeaderText = "Auto Programming";
            this.AutoProgramming.Name = "AutoProgramming";
            this.AutoProgramming.ReadOnly = true;
            this.AutoProgramming.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AutoProgramming.Width = 70;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total (%)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Reference ID";
            // 
            // referenceNumeric
            // 
            this.referenceNumeric.Location = new System.Drawing.Point(144, 519);
            this.referenceNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.referenceNumeric.Name = "referenceNumeric";
            this.referenceNumeric.Size = new System.Drawing.Size(117, 20);
            this.referenceNumeric.TabIndex = 17;
            // 
            // modifiedLabelImposed
            // 
            this.modifiedLabelImposed.AutoSize = true;
            this.modifiedLabelImposed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedLabelImposed.Location = new System.Drawing.Point(1075, 513);
            this.modifiedLabelImposed.Name = "modifiedLabelImposed";
            this.modifiedLabelImposed.Size = new System.Drawing.Size(0, 25);
            this.modifiedLabelImposed.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 15;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 13, 0);
            this.tableLayoutPanel1.Controls.Add(this.label18, 14, 0);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinFootprint, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxFootprint, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinDOM, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxDOM, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinMJV, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxMJV, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinAccuracy, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxAccuracy, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinRepeatability, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxRepeatability, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinWeight, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxWeight, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinMaxLift, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxMaxLift, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinNrOfInputs, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxNrOfInputs, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeMinNrOfOutputs, 11, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeMaxNrOfOutputs, 11, 2);
            this.tableLayoutPanel1.Controls.Add(this.imposeOffline, 12, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeOnline, 13, 1);
            this.tableLayoutPanel1.Controls.Add(this.imposeAuto, 14, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 545);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 88);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "price\r\n(real)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "footprint\r\n(real)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(871, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "nr of outputs (whole)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "deg of mobility (whole)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "max joint velocity (whole)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "workspace (whole x whole x whole)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(796, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "nr of inputs (whole)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "accuracy \n(real)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "weight (real)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(736, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "max lift (whole)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "repeatability \r\n(real)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(946, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 26);
            this.label16.TabIndex = 6;
            this.label16.Text = "offline progr.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1006, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "online progr.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1066, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 26);
            this.label18.TabIndex = 6;
            this.label18.Text = "auto progr.";
            // 
            // imposeMinPrice
            // 
            this.imposeMinPrice.Location = new System.Drawing.Point(35, 33);
            this.imposeMinPrice.Name = "imposeMinPrice";
            this.imposeMinPrice.Size = new System.Drawing.Size(106, 20);
            this.imposeMinPrice.TabIndex = 7;
            this.imposeMinPrice.TextChanged += new System.EventHandler(this.imposeMinPrice_TextChanged);
            // 
            // imposeMaxPrice
            // 
            this.imposeMaxPrice.Location = new System.Drawing.Point(35, 61);
            this.imposeMaxPrice.Name = "imposeMaxPrice";
            this.imposeMaxPrice.Size = new System.Drawing.Size(106, 20);
            this.imposeMaxPrice.TabIndex = 7;
            this.imposeMaxPrice.TextChanged += new System.EventHandler(this.imposeMaxPrice_TextChanged);
            // 
            // imposeMinFootprint
            // 
            this.imposeMinFootprint.Location = new System.Drawing.Point(147, 33);
            this.imposeMinFootprint.Name = "imposeMinFootprint";
            this.imposeMinFootprint.Size = new System.Drawing.Size(106, 20);
            this.imposeMinFootprint.TabIndex = 7;
            this.imposeMinFootprint.TextChanged += new System.EventHandler(this.imposeMinFootprint_TextChanged);
            // 
            // imposeMaxFootprint
            // 
            this.imposeMaxFootprint.Location = new System.Drawing.Point(147, 61);
            this.imposeMaxFootprint.Name = "imposeMaxFootprint";
            this.imposeMaxFootprint.Size = new System.Drawing.Size(106, 20);
            this.imposeMaxFootprint.TabIndex = 7;
            this.imposeMaxFootprint.TextChanged += new System.EventHandler(this.imposeMaxFootprint_TextChanged);
            // 
            // imposeMinDOM
            // 
            this.imposeMinDOM.Location = new System.Drawing.Point(259, 33);
            this.imposeMinDOM.Name = "imposeMinDOM";
            this.imposeMinDOM.Size = new System.Drawing.Size(74, 20);
            this.imposeMinDOM.TabIndex = 7;
            this.imposeMinDOM.TextChanged += new System.EventHandler(this.imposeMinDOM_TextChanged);
            // 
            // imposeMaxDOM
            // 
            this.imposeMaxDOM.Location = new System.Drawing.Point(259, 61);
            this.imposeMaxDOM.Name = "imposeMaxDOM";
            this.imposeMaxDOM.Size = new System.Drawing.Size(74, 20);
            this.imposeMaxDOM.TabIndex = 7;
            this.imposeMaxDOM.TextChanged += new System.EventHandler(this.imposeMaxDOM_TextChanged);
            // 
            // imposeMinMJV
            // 
            this.imposeMinMJV.Location = new System.Drawing.Point(339, 33);
            this.imposeMinMJV.Name = "imposeMinMJV";
            this.imposeMinMJV.Size = new System.Drawing.Size(84, 20);
            this.imposeMinMJV.TabIndex = 7;
            this.imposeMinMJV.TextChanged += new System.EventHandler(this.imposeMinMJV_TextChanged);
            // 
            // imposeMaxMJV
            // 
            this.imposeMaxMJV.Location = new System.Drawing.Point(339, 61);
            this.imposeMaxMJV.Name = "imposeMaxMJV";
            this.imposeMaxMJV.Size = new System.Drawing.Size(84, 20);
            this.imposeMaxMJV.TabIndex = 7;
            this.imposeMaxMJV.TextChanged += new System.EventHandler(this.imposeMaxMJV_TextChanged);
            // 
            // imposeMinAccuracy
            // 
            this.imposeMinAccuracy.Location = new System.Drawing.Point(541, 33);
            this.imposeMinAccuracy.Name = "imposeMinAccuracy";
            this.imposeMinAccuracy.Size = new System.Drawing.Size(54, 20);
            this.imposeMinAccuracy.TabIndex = 7;
            this.imposeMinAccuracy.TextChanged += new System.EventHandler(this.imposeMinAccuracy_TextChanged);
            // 
            // imposeMaxAccuracy
            // 
            this.imposeMaxAccuracy.Location = new System.Drawing.Point(541, 61);
            this.imposeMaxAccuracy.Name = "imposeMaxAccuracy";
            this.imposeMaxAccuracy.Size = new System.Drawing.Size(54, 20);
            this.imposeMaxAccuracy.TabIndex = 7;
            this.imposeMaxAccuracy.TextChanged += new System.EventHandler(this.imposeMaxAccuracy_TextChanged);
            // 
            // imposeMinRepeatability
            // 
            this.imposeMinRepeatability.Location = new System.Drawing.Point(601, 33);
            this.imposeMinRepeatability.Name = "imposeMinRepeatability";
            this.imposeMinRepeatability.Size = new System.Drawing.Size(69, 20);
            this.imposeMinRepeatability.TabIndex = 7;
            this.imposeMinRepeatability.TextChanged += new System.EventHandler(this.imposeMinRepeatability_TextChanged);
            // 
            // imposeMaxRepeatability
            // 
            this.imposeMaxRepeatability.Location = new System.Drawing.Point(601, 61);
            this.imposeMaxRepeatability.Name = "imposeMaxRepeatability";
            this.imposeMaxRepeatability.Size = new System.Drawing.Size(69, 20);
            this.imposeMaxRepeatability.TabIndex = 7;
            this.imposeMaxRepeatability.TextChanged += new System.EventHandler(this.imposeMaxRepeatability_TextChanged);
            // 
            // imposeMinWeight
            // 
            this.imposeMinWeight.Location = new System.Drawing.Point(676, 33);
            this.imposeMinWeight.Name = "imposeMinWeight";
            this.imposeMinWeight.Size = new System.Drawing.Size(54, 20);
            this.imposeMinWeight.TabIndex = 7;
            this.imposeMinWeight.TextChanged += new System.EventHandler(this.imposeMinWeight_TextChanged);
            // 
            // imposeMaxWeight
            // 
            this.imposeMaxWeight.Location = new System.Drawing.Point(676, 61);
            this.imposeMaxWeight.Name = "imposeMaxWeight";
            this.imposeMaxWeight.Size = new System.Drawing.Size(54, 20);
            this.imposeMaxWeight.TabIndex = 7;
            this.imposeMaxWeight.TextChanged += new System.EventHandler(this.imposeMaxWeight_TextChanged);
            // 
            // imposeMinMaxLift
            // 
            this.imposeMinMaxLift.Location = new System.Drawing.Point(736, 33);
            this.imposeMinMaxLift.Name = "imposeMinMaxLift";
            this.imposeMinMaxLift.Size = new System.Drawing.Size(54, 20);
            this.imposeMinMaxLift.TabIndex = 7;
            this.imposeMinMaxLift.TextChanged += new System.EventHandler(this.imposeMinMaxLift_TextChanged);
            // 
            // imposeMaxMaxLift
            // 
            this.imposeMaxMaxLift.Location = new System.Drawing.Point(736, 61);
            this.imposeMaxMaxLift.Name = "imposeMaxMaxLift";
            this.imposeMaxMaxLift.Size = new System.Drawing.Size(54, 20);
            this.imposeMaxMaxLift.TabIndex = 7;
            this.imposeMaxMaxLift.TextChanged += new System.EventHandler(this.imposeMaxMaxLift_TextChanged);
            // 
            // imposeMinNrOfInputs
            // 
            this.imposeMinNrOfInputs.Location = new System.Drawing.Point(796, 33);
            this.imposeMinNrOfInputs.Name = "imposeMinNrOfInputs";
            this.imposeMinNrOfInputs.Size = new System.Drawing.Size(69, 20);
            this.imposeMinNrOfInputs.TabIndex = 7;
            this.imposeMinNrOfInputs.TextChanged += new System.EventHandler(this.imposeMinNrOfInputs_TextChanged);
            // 
            // imposeMaxNrOfInputs
            // 
            this.imposeMaxNrOfInputs.Location = new System.Drawing.Point(796, 61);
            this.imposeMaxNrOfInputs.Name = "imposeMaxNrOfInputs";
            this.imposeMaxNrOfInputs.Size = new System.Drawing.Size(69, 20);
            this.imposeMaxNrOfInputs.TabIndex = 7;
            this.imposeMaxNrOfInputs.TextChanged += new System.EventHandler(this.imposeMaxNrOfInputs_TextChanged);
            // 
            // imposeMinNrOfOutputs
            // 
            this.imposeMinNrOfOutputs.Location = new System.Drawing.Point(871, 33);
            this.imposeMinNrOfOutputs.Name = "imposeMinNrOfOutputs";
            this.imposeMinNrOfOutputs.Size = new System.Drawing.Size(69, 20);
            this.imposeMinNrOfOutputs.TabIndex = 7;
            this.imposeMinNrOfOutputs.TextChanged += new System.EventHandler(this.imposeMinNrOfOutputs_TextChanged);
            // 
            // imposeMaxNrOfOutputs
            // 
            this.imposeMaxNrOfOutputs.Location = new System.Drawing.Point(871, 61);
            this.imposeMaxNrOfOutputs.Name = "imposeMaxNrOfOutputs";
            this.imposeMaxNrOfOutputs.Size = new System.Drawing.Size(69, 20);
            this.imposeMaxNrOfOutputs.TabIndex = 7;
            this.imposeMaxNrOfOutputs.TextChanged += new System.EventHandler(this.imposeMaxNrOfOutputs_TextChanged);
            // 
            // imposeOffline
            // 
            this.imposeOffline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imposeOffline.FormattingEnabled = true;
            this.imposeOffline.Items.AddRange(new object[] {
            "Either",
            "Yes",
            "No"});
            this.imposeOffline.Location = new System.Drawing.Point(946, 33);
            this.imposeOffline.Name = "imposeOffline";
            this.imposeOffline.Size = new System.Drawing.Size(54, 21);
            this.imposeOffline.TabIndex = 8;
            this.imposeOffline.SelectedIndexChanged += new System.EventHandler(this.imposeOffline_SelectedIndexChanged);
            // 
            // imposeOnline
            // 
            this.imposeOnline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imposeOnline.FormattingEnabled = true;
            this.imposeOnline.Items.AddRange(new object[] {
            "Either",
            "Yes",
            "No"});
            this.imposeOnline.Location = new System.Drawing.Point(1006, 33);
            this.imposeOnline.Name = "imposeOnline";
            this.imposeOnline.Size = new System.Drawing.Size(54, 21);
            this.imposeOnline.TabIndex = 8;
            this.imposeOnline.SelectedIndexChanged += new System.EventHandler(this.imposeOnline_SelectedIndexChanged);
            // 
            // imposeAuto
            // 
            this.imposeAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imposeAuto.FormattingEnabled = true;
            this.imposeAuto.Items.AddRange(new object[] {
            "Either",
            "Yes",
            "No"});
            this.imposeAuto.Location = new System.Drawing.Point(1066, 33);
            this.imposeAuto.Name = "imposeAuto";
            this.imposeAuto.Size = new System.Drawing.Size(54, 21);
            this.imposeAuto.TabIndex = 8;
            this.imposeAuto.SelectedIndexChanged += new System.EventHandler(this.imposeAuto_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(491, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Imposed Limits";
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedLabel.Location = new System.Drawing.Point(1075, 41);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(0, 25);
            this.modifiedLabel.TabIndex = 16;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(51, 31);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(75, 23);
            this.computeButton.TabIndex = 18;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // priceCheck
            // 
            this.priceCheck.AutoSize = true;
            this.priceCheck.Location = new System.Drawing.Point(181, 27);
            this.priceCheck.Name = "priceCheck";
            this.priceCheck.Size = new System.Drawing.Size(40, 17);
            this.priceCheck.TabIndex = 19;
            this.priceCheck.Text = "Up";
            this.priceCheck.UseVisualStyleBackColor = true;
            this.priceCheck.CheckedChanged += new System.EventHandler(this.priceCheck_CheckedChanged);
            // 
            // footprintCheck
            // 
            this.footprintCheck.AutoSize = true;
            this.footprintCheck.Location = new System.Drawing.Point(252, 27);
            this.footprintCheck.Name = "footprintCheck";
            this.footprintCheck.Size = new System.Drawing.Size(40, 17);
            this.footprintCheck.TabIndex = 19;
            this.footprintCheck.Text = "Up";
            this.footprintCheck.UseVisualStyleBackColor = true;
            this.footprintCheck.CheckedChanged += new System.EventHandler(this.footprintCheck_CheckedChanged);
            // 
            // domCheck
            // 
            this.domCheck.AutoSize = true;
            this.domCheck.Location = new System.Drawing.Point(312, 27);
            this.domCheck.Name = "domCheck";
            this.domCheck.Size = new System.Drawing.Size(40, 17);
            this.domCheck.TabIndex = 19;
            this.domCheck.Text = "Up";
            this.domCheck.UseVisualStyleBackColor = true;
            this.domCheck.CheckedChanged += new System.EventHandler(this.domCheck_CheckedChanged);
            // 
            // mjvCheck
            // 
            this.mjvCheck.AutoSize = true;
            this.mjvCheck.Location = new System.Drawing.Point(372, 27);
            this.mjvCheck.Name = "mjvCheck";
            this.mjvCheck.Size = new System.Drawing.Size(40, 17);
            this.mjvCheck.TabIndex = 19;
            this.mjvCheck.Text = "Up";
            this.mjvCheck.UseVisualStyleBackColor = true;
            this.mjvCheck.CheckedChanged += new System.EventHandler(this.mjvCheck_CheckedChanged);
            // 
            // workspaceCheck
            // 
            this.workspaceCheck.AutoSize = true;
            this.workspaceCheck.Location = new System.Drawing.Point(454, 27);
            this.workspaceCheck.Name = "workspaceCheck";
            this.workspaceCheck.Size = new System.Drawing.Size(40, 17);
            this.workspaceCheck.TabIndex = 19;
            this.workspaceCheck.Text = "Up";
            this.workspaceCheck.UseVisualStyleBackColor = true;
            this.workspaceCheck.CheckedChanged += new System.EventHandler(this.workspaceCheck_CheckedChanged);
            // 
            // accuracyCheck
            // 
            this.accuracyCheck.AutoSize = true;
            this.accuracyCheck.Location = new System.Drawing.Point(540, 27);
            this.accuracyCheck.Name = "accuracyCheck";
            this.accuracyCheck.Size = new System.Drawing.Size(40, 17);
            this.accuracyCheck.TabIndex = 19;
            this.accuracyCheck.Text = "Up";
            this.accuracyCheck.UseVisualStyleBackColor = true;
            this.accuracyCheck.CheckedChanged += new System.EventHandler(this.accuracyCheck_CheckedChanged);
            // 
            // repeatabilityCheck
            // 
            this.repeatabilityCheck.AutoSize = true;
            this.repeatabilityCheck.Location = new System.Drawing.Point(599, 27);
            this.repeatabilityCheck.Name = "repeatabilityCheck";
            this.repeatabilityCheck.Size = new System.Drawing.Size(40, 17);
            this.repeatabilityCheck.TabIndex = 19;
            this.repeatabilityCheck.Text = "Up";
            this.repeatabilityCheck.UseVisualStyleBackColor = true;
            this.repeatabilityCheck.CheckedChanged += new System.EventHandler(this.repeatabilityCheck_CheckedChanged);
            // 
            // weightCheck
            // 
            this.weightCheck.AutoSize = true;
            this.weightCheck.Location = new System.Drawing.Point(659, 27);
            this.weightCheck.Name = "weightCheck";
            this.weightCheck.Size = new System.Drawing.Size(40, 17);
            this.weightCheck.TabIndex = 19;
            this.weightCheck.Text = "Up";
            this.weightCheck.UseVisualStyleBackColor = true;
            this.weightCheck.CheckedChanged += new System.EventHandler(this.weightCheck_CheckedChanged);
            // 
            // maxLiftCheck
            // 
            this.maxLiftCheck.AutoSize = true;
            this.maxLiftCheck.Location = new System.Drawing.Point(719, 27);
            this.maxLiftCheck.Name = "maxLiftCheck";
            this.maxLiftCheck.Size = new System.Drawing.Size(40, 17);
            this.maxLiftCheck.TabIndex = 19;
            this.maxLiftCheck.Text = "Up";
            this.maxLiftCheck.UseVisualStyleBackColor = true;
            this.maxLiftCheck.CheckedChanged += new System.EventHandler(this.maxLiftCheck_CheckedChanged);
            // 
            // nrOfInputsCheck
            // 
            this.nrOfInputsCheck.AutoSize = true;
            this.nrOfInputsCheck.Location = new System.Drawing.Point(767, 27);
            this.nrOfInputsCheck.Name = "nrOfInputsCheck";
            this.nrOfInputsCheck.Size = new System.Drawing.Size(40, 17);
            this.nrOfInputsCheck.TabIndex = 19;
            this.nrOfInputsCheck.Text = "Up";
            this.nrOfInputsCheck.UseVisualStyleBackColor = true;
            this.nrOfInputsCheck.CheckedChanged += new System.EventHandler(this.nrOfInputsCheck_CheckedChanged);
            // 
            // nrOfOutputsCheck
            // 
            this.nrOfOutputsCheck.AutoSize = true;
            this.nrOfOutputsCheck.Location = new System.Drawing.Point(815, 27);
            this.nrOfOutputsCheck.Name = "nrOfOutputsCheck";
            this.nrOfOutputsCheck.Size = new System.Drawing.Size(40, 17);
            this.nrOfOutputsCheck.TabIndex = 19;
            this.nrOfOutputsCheck.Text = "Up";
            this.nrOfOutputsCheck.UseVisualStyleBackColor = true;
            this.nrOfOutputsCheck.CheckedChanged += new System.EventHandler(this.nrOfOutputsCheck_CheckedChanged);
            // 
            // offlineCheck
            // 
            this.offlineCheck.AutoSize = true;
            this.offlineCheck.Location = new System.Drawing.Point(875, 27);
            this.offlineCheck.Name = "offlineCheck";
            this.offlineCheck.Size = new System.Drawing.Size(40, 17);
            this.offlineCheck.TabIndex = 19;
            this.offlineCheck.Text = "Up";
            this.offlineCheck.UseVisualStyleBackColor = true;
            this.offlineCheck.CheckedChanged += new System.EventHandler(this.offlineCheck_CheckedChanged);
            // 
            // onlineCheck
            // 
            this.onlineCheck.AutoSize = true;
            this.onlineCheck.Location = new System.Drawing.Point(941, 27);
            this.onlineCheck.Name = "onlineCheck";
            this.onlineCheck.Size = new System.Drawing.Size(40, 17);
            this.onlineCheck.TabIndex = 19;
            this.onlineCheck.Text = "Up";
            this.onlineCheck.UseVisualStyleBackColor = true;
            this.onlineCheck.CheckedChanged += new System.EventHandler(this.onlineCheck_CheckedChanged);
            // 
            // autoCheck
            // 
            this.autoCheck.AutoSize = true;
            this.autoCheck.Location = new System.Drawing.Point(1001, 27);
            this.autoCheck.Name = "autoCheck";
            this.autoCheck.Size = new System.Drawing.Size(40, 17);
            this.autoCheck.TabIndex = 19;
            this.autoCheck.Text = "Up";
            this.autoCheck.UseVisualStyleBackColor = true;
            this.autoCheck.CheckedChanged += new System.EventHandler(this.autoCheck_CheckedChanged);
            // 
            // RPrice
            // 
            this.RPrice.Location = new System.Drawing.Point(181, 46);
            this.RPrice.Name = "RPrice";
            this.RPrice.Size = new System.Drawing.Size(41, 20);
            this.RPrice.TabIndex = 20;
            this.RPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RPrice.ValueChanged += new System.EventHandler(this.RPrice_ValueChanged);
            // 
            // RFootprint
            // 
            this.RFootprint.Location = new System.Drawing.Point(252, 46);
            this.RFootprint.Name = "RFootprint";
            this.RFootprint.Size = new System.Drawing.Size(41, 20);
            this.RFootprint.TabIndex = 20;
            this.RFootprint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RFootprint.ValueChanged += new System.EventHandler(this.RFootprint_ValueChanged);
            // 
            // RDOM
            // 
            this.RDOM.Location = new System.Drawing.Point(311, 46);
            this.RDOM.Name = "RDOM";
            this.RDOM.Size = new System.Drawing.Size(41, 20);
            this.RDOM.TabIndex = 20;
            this.RDOM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RDOM.ValueChanged += new System.EventHandler(this.RDOM_ValueChanged);
            // 
            // RMJV
            // 
            this.RMJV.Location = new System.Drawing.Point(371, 46);
            this.RMJV.Name = "RMJV";
            this.RMJV.Size = new System.Drawing.Size(41, 20);
            this.RMJV.TabIndex = 20;
            this.RMJV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RMJV.ValueChanged += new System.EventHandler(this.RMJV_ValueChanged);
            // 
            // RWorkspace
            // 
            this.RWorkspace.Location = new System.Drawing.Point(453, 46);
            this.RWorkspace.Name = "RWorkspace";
            this.RWorkspace.Size = new System.Drawing.Size(41, 20);
            this.RWorkspace.TabIndex = 20;
            this.RWorkspace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RWorkspace.ValueChanged += new System.EventHandler(this.RWorkspace_ValueChanged);
            // 
            // RAccuracy
            // 
            this.RAccuracy.Location = new System.Drawing.Point(539, 46);
            this.RAccuracy.Name = "RAccuracy";
            this.RAccuracy.Size = new System.Drawing.Size(41, 20);
            this.RAccuracy.TabIndex = 20;
            this.RAccuracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RAccuracy.ValueChanged += new System.EventHandler(this.RAccuracy_ValueChanged);
            // 
            // RRepeatability
            // 
            this.RRepeatability.Location = new System.Drawing.Point(599, 46);
            this.RRepeatability.Name = "RRepeatability";
            this.RRepeatability.Size = new System.Drawing.Size(41, 20);
            this.RRepeatability.TabIndex = 20;
            this.RRepeatability.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RRepeatability.ValueChanged += new System.EventHandler(this.RRepeatability_ValueChanged);
            // 
            // RWeight
            // 
            this.RWeight.Location = new System.Drawing.Point(668, 46);
            this.RWeight.Name = "RWeight";
            this.RWeight.Size = new System.Drawing.Size(41, 20);
            this.RWeight.TabIndex = 20;
            this.RWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RWeight.ValueChanged += new System.EventHandler(this.RWeight_ValueChanged);
            // 
            // RMaxLift
            // 
            this.RMaxLift.Location = new System.Drawing.Point(719, 46);
            this.RMaxLift.Name = "RMaxLift";
            this.RMaxLift.Size = new System.Drawing.Size(41, 20);
            this.RMaxLift.TabIndex = 20;
            this.RMaxLift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RMaxLift.ValueChanged += new System.EventHandler(this.RMaxLift_ValueChanged);
            // 
            // RNrOfInputs
            // 
            this.RNrOfInputs.Location = new System.Drawing.Point(766, 46);
            this.RNrOfInputs.Name = "RNrOfInputs";
            this.RNrOfInputs.Size = new System.Drawing.Size(41, 20);
            this.RNrOfInputs.TabIndex = 20;
            this.RNrOfInputs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RNrOfInputs.ValueChanged += new System.EventHandler(this.RNrOfInputs_ValueChanged);
            // 
            // RNrOfOutputs
            // 
            this.RNrOfOutputs.Location = new System.Drawing.Point(810, 46);
            this.RNrOfOutputs.Name = "RNrOfOutputs";
            this.RNrOfOutputs.Size = new System.Drawing.Size(41, 20);
            this.RNrOfOutputs.TabIndex = 20;
            this.RNrOfOutputs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RNrOfOutputs.ValueChanged += new System.EventHandler(this.RNrOfOutputs_ValueChanged);
            // 
            // ROffline
            // 
            this.ROffline.Location = new System.Drawing.Point(857, 46);
            this.ROffline.Name = "ROffline";
            this.ROffline.Size = new System.Drawing.Size(41, 20);
            this.ROffline.TabIndex = 20;
            this.ROffline.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ROffline.ValueChanged += new System.EventHandler(this.ROffline_ValueChanged);
            // 
            // ROnline
            // 
            this.ROnline.Location = new System.Drawing.Point(922, 46);
            this.ROnline.Name = "ROnline";
            this.ROnline.Size = new System.Drawing.Size(41, 20);
            this.ROnline.TabIndex = 20;
            this.ROnline.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ROnline.ValueChanged += new System.EventHandler(this.ROnline_ValueChanged);
            // 
            // RAuto
            // 
            this.RAuto.Location = new System.Drawing.Point(1000, 46);
            this.RAuto.Name = "RAuto";
            this.RAuto.Size = new System.Drawing.Size(41, 20);
            this.RAuto.TabIndex = 20;
            this.RAuto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RAuto.ValueChanged += new System.EventHandler(this.RAuto_ValueChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(906, 517);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // RobotsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 641);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.RAuto);
            this.Controls.Add(this.ROnline);
            this.Controls.Add(this.ROffline);
            this.Controls.Add(this.RNrOfOutputs);
            this.Controls.Add(this.RNrOfInputs);
            this.Controls.Add(this.RMaxLift);
            this.Controls.Add(this.RWeight);
            this.Controls.Add(this.RRepeatability);
            this.Controls.Add(this.RAccuracy);
            this.Controls.Add(this.RWorkspace);
            this.Controls.Add(this.RMJV);
            this.Controls.Add(this.RDOM);
            this.Controls.Add(this.RFootprint);
            this.Controls.Add(this.RPrice);
            this.Controls.Add(this.autoCheck);
            this.Controls.Add(this.onlineCheck);
            this.Controls.Add(this.offlineCheck);
            this.Controls.Add(this.nrOfOutputsCheck);
            this.Controls.Add(this.nrOfInputsCheck);
            this.Controls.Add(this.maxLiftCheck);
            this.Controls.Add(this.weightCheck);
            this.Controls.Add(this.repeatabilityCheck);
            this.Controls.Add(this.accuracyCheck);
            this.Controls.Add(this.workspaceCheck);
            this.Controls.Add(this.mjvCheck);
            this.Controls.Add(this.domCheck);
            this.Controls.Add(this.footprintCheck);
            this.Controls.Add(this.priceCheck);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.referenceNumeric);
            this.Controls.Add(this.modifiedLabel);
            this.Controls.Add(this.modifiedLabelImposed);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RobotsWindow";
            this.Text = "Robots";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceNumeric)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RFootprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RMJV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RWorkspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRepeatability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RMaxLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNrOfInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNrOfOutputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROffline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown referenceNumeric;
        private System.Windows.Forms.Label modifiedLabelImposed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.CheckBox priceCheck;
        private System.Windows.Forms.CheckBox footprintCheck;
        private System.Windows.Forms.CheckBox domCheck;
        private System.Windows.Forms.CheckBox mjvCheck;
        private System.Windows.Forms.CheckBox workspaceCheck;
        private System.Windows.Forms.CheckBox accuracyCheck;
        private System.Windows.Forms.CheckBox repeatabilityCheck;
        private System.Windows.Forms.CheckBox weightCheck;
        private System.Windows.Forms.CheckBox maxLiftCheck;
        private System.Windows.Forms.CheckBox nrOfInputsCheck;
        private System.Windows.Forms.CheckBox nrOfOutputsCheck;
        private System.Windows.Forms.CheckBox offlineCheck;
        private System.Windows.Forms.CheckBox onlineCheck;
        private System.Windows.Forms.CheckBox autoCheck;
        private System.Windows.Forms.NumericUpDown RPrice;
        private System.Windows.Forms.NumericUpDown RFootprint;
        private System.Windows.Forms.NumericUpDown RDOM;
        private System.Windows.Forms.NumericUpDown RMJV;
        private System.Windows.Forms.NumericUpDown RWorkspace;
        private System.Windows.Forms.NumericUpDown RAccuracy;
        private System.Windows.Forms.NumericUpDown RRepeatability;
        private System.Windows.Forms.NumericUpDown RWeight;
        private System.Windows.Forms.NumericUpDown RMaxLift;
        private System.Windows.Forms.NumericUpDown RNrOfInputs;
        private System.Windows.Forms.NumericUpDown RNrOfOutputs;
        private System.Windows.Forms.NumericUpDown ROffline;
        private System.Windows.Forms.NumericUpDown ROnline;
        private System.Windows.Forms.NumericUpDown RAuto;
        private System.Windows.Forms.TextBox imposeMinPrice;
        private System.Windows.Forms.TextBox imposeMaxPrice;
        private System.Windows.Forms.TextBox imposeMinFootprint;
        private System.Windows.Forms.TextBox imposeMaxFootprint;
        private System.Windows.Forms.TextBox imposeMinDOM;
        private System.Windows.Forms.TextBox imposeMaxDOM;
        private System.Windows.Forms.TextBox imposeMinMJV;
        private System.Windows.Forms.TextBox imposeMaxMJV;
        private System.Windows.Forms.TextBox imposeMinAccuracy;
        private System.Windows.Forms.TextBox imposeMaxAccuracy;
        private System.Windows.Forms.TextBox imposeMinRepeatability;
        private System.Windows.Forms.TextBox imposeMaxRepeatability;
        private System.Windows.Forms.TextBox imposeMinWeight;
        private System.Windows.Forms.TextBox imposeMaxWeight;
        private System.Windows.Forms.TextBox imposeMinMaxLift;
        private System.Windows.Forms.TextBox imposeMaxMaxLift;
        private System.Windows.Forms.TextBox imposeMinNrOfInputs;
        private System.Windows.Forms.TextBox imposeMaxNrOfInputs;
        private System.Windows.Forms.TextBox imposeMinNrOfOutputs;
        private System.Windows.Forms.TextBox imposeMaxNrOfOutputs;
        private System.Windows.Forms.ComboBox imposeOffline;
        private System.Windows.Forms.ComboBox imposeOnline;
        private System.Windows.Forms.ComboBox imposeAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Footprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DegreesOfMobility;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxJointVelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workspace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeatability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxLift;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrOfInputs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrOfOutputs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OfflineProgramming;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnlineProgramming;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AutoProgramming;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}