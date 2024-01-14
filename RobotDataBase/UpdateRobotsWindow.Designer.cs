namespace RobotDataBase
{
    partial class UpdateRobotsWindow
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 439);
            this.dataGridView1.TabIndex = 5;
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
            this.OnlineProgramming.Width = 70;
            // 
            // AutoProgramming
            // 
            this.AutoProgramming.DataPropertyName = "AutoProgramming";
            this.AutoProgramming.HeaderText = "Auto Programming";
            this.AutoProgramming.Name = "AutoProgramming";
            this.AutoProgramming.ReadOnly = true;
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
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 52);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 58);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 52);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 58);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(174, 52);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 58);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(255, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UpdateRobotsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 652);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateRobotsWindow";
            this.Text = "Update Robot Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;

    }
}