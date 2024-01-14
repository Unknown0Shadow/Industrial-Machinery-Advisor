namespace RobotDataBase
{
    partial class UpdateMachinesWindow
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
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reliability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinRevolutions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxRevolutions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrOfSimultaneousAxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkpieceHolder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.Weight,
            this.SetTime,
            this.Reliability,
            this.Precision,
            this.Productivity,
            this.MinRevolutions,
            this.MaxRevolutions,
            this.NrOfSimultaneousAxes,
            this.WorkpieceHolder,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(923, 348);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MachineID";
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
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight (Kg)";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 60;
            // 
            // SetTime
            // 
            this.SetTime.DataPropertyName = "SetTime";
            this.SetTime.HeaderText = "Set Time (s)";
            this.SetTime.Name = "SetTime";
            this.SetTime.ReadOnly = true;
            this.SetTime.Width = 40;
            // 
            // Reliability
            // 
            this.Reliability.DataPropertyName = "Reliability";
            this.Reliability.HeaderText = "Reliability (h)";
            this.Reliability.Name = "Reliability";
            this.Reliability.ReadOnly = true;
            this.Reliability.Width = 60;
            // 
            // Precision
            // 
            this.Precision.DataPropertyName = "Precision";
            this.Precision.HeaderText = "Precision (micro m)";
            this.Precision.Name = "Precision";
            this.Precision.ReadOnly = true;
            this.Precision.Width = 60;
            // 
            // Productivity
            // 
            this.Productivity.DataPropertyName = "Productivity";
            this.Productivity.HeaderText = "Productivity (part/h)";
            this.Productivity.Name = "Productivity";
            this.Productivity.ReadOnly = true;
            this.Productivity.Width = 65;
            // 
            // MinRevolutions
            // 
            this.MinRevolutions.DataPropertyName = "MinRevolutions";
            this.MinRevolutions.HeaderText = "Min Revolutions (rev/m)";
            this.MinRevolutions.Name = "MinRevolutions";
            this.MinRevolutions.ReadOnly = true;
            this.MinRevolutions.Width = 65;
            // 
            // MaxRevolutions
            // 
            this.MaxRevolutions.DataPropertyName = "MaxRevolutions";
            this.MaxRevolutions.HeaderText = "Max Revolutions (rev/m)";
            this.MaxRevolutions.Name = "MaxRevolutions";
            this.MaxRevolutions.ReadOnly = true;
            this.MaxRevolutions.Width = 65;
            // 
            // NrOfSimultaneousAxes
            // 
            this.NrOfSimultaneousAxes.DataPropertyName = "NrOfSimultaneousAxes";
            this.NrOfSimultaneousAxes.HeaderText = "Nr Of Simultaneous Axes";
            this.NrOfSimultaneousAxes.Name = "NrOfSimultaneousAxes";
            this.NrOfSimultaneousAxes.ReadOnly = true;
            this.NrOfSimultaneousAxes.Width = 75;
            // 
            // WorkpieceHolder
            // 
            this.WorkpieceHolder.DataPropertyName = "WorkpieceHolder";
            this.WorkpieceHolder.HeaderText = "Workpiece Holder";
            this.WorkpieceHolder.Name = "WorkpieceHolder";
            this.WorkpieceHolder.ReadOnly = true;
            this.WorkpieceHolder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkpieceHolder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WorkpieceHolder.Width = 60;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total (%)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UpdateMachinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 544);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateMachinesWindow";
            this.Text = "Update Machine Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Footprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reliability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRevolutions;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxRevolutions;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrOfSimultaneousAxes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WorkpieceHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;

    }
}