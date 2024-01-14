namespace RobotDataBase
{
    partial class MainWindow
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.machinesToolStripMenuItem,
            this.robotsToolStripMenuItem,
            this.robotsToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(470, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertMachineToolStripMenuItem,
            this.insertRobotToolStripMenuItem});
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.machinesToolStripMenuItem.Text = "Data";
            // 
            // insertMachineToolStripMenuItem
            // 
            this.insertMachineToolStripMenuItem.Name = "insertMachineToolStripMenuItem";
            this.insertMachineToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.insertMachineToolStripMenuItem.Text = "Update Machines";
            this.insertMachineToolStripMenuItem.Click += new System.EventHandler(this.insertMachineToolStripMenuItem_Click);
            // 
            // insertRobotToolStripMenuItem
            // 
            this.insertRobotToolStripMenuItem.Name = "insertRobotToolStripMenuItem";
            this.insertRobotToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.insertRobotToolStripMenuItem.Text = "Update Robots";
            this.insertRobotToolStripMenuItem.Click += new System.EventHandler(this.insertRobotToolStripMenuItem_Click);
            // 
            // robotsToolStripMenuItem
            // 
            this.robotsToolStripMenuItem.Name = "robotsToolStripMenuItem";
            this.robotsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.robotsToolStripMenuItem.Text = "Machines";
            this.robotsToolStripMenuItem.Click += new System.EventHandler(this.robotsToolStripMenuItem_Click);
            // 
            // robotsToolStripMenuItem1
            // 
            this.robotsToolStripMenuItem1.Name = "robotsToolStripMenuItem1";
            this.robotsToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.robotsToolStripMenuItem1.Text = "Robots";
            this.robotsToolStripMenuItem1.Click += new System.EventHandler(this.robotsToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 267);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainWindow";
            this.Text = "Equipment Selector";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertRobotToolStripMenuItem;
    }
}