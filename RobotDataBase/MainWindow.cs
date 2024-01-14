using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotDataBase
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void robotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MachinesWindow.getForm().Show();
        }

        private void robotsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RobotsWindow.getForm().Show();
        }

        private void insertMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMachinesWindow.getForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void insertRobotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRobotsWindow.getForm().Show();
        }
    }
}
