using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RobotDataBase
{
    public partial class UpdateRobotsWindow : Form
    {
        private static UpdateRobotsWindow urw;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private UpdateRobotsWindow()
        {
            InitializeComponent();
        }
        public static UpdateRobotsWindow getForm()
        {
            if (urw == null)
            {
                urw = new UpdateRobotsWindow();
            }
            urw.fillTable();
            return urw;
        }
        public void fillTable()
        {
            String query = "select * from TableRobots;";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InsertRobot.getForm().Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowid = dataGridView1.SelectedCells[0].RowIndex;
                row = dataGridView1.Rows[rowid];
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                row = dataGridView1.SelectedRows[0];
            }
            else return;

            String id, price, footprint, accuracy, repeatability, weight,
                dom, mjv, workspace, maxLift, nrOfInputs, nrOfOutputs,
                offline, online, auto;
            String model = "";
            model = Convert.ToString(row.Cells["Model"].Value);
            try { id = Convert.ToString((int)row.Cells["ID"].Value); }
            catch { id = "Error"; }
            try { accuracy = Convert.ToString((double)row.Cells["Accuracy"].Value); }
            catch { accuracy = ""; }
            try { price = Convert.ToString((double)row.Cells["Price"].Value); }
            catch { price = ""; }
            try { footprint = Convert.ToString((double)row.Cells["Footprint"].Value); }
            catch { footprint = ""; }
            try { weight = Convert.ToString((double)row.Cells["Weight"].Value); }
            catch { weight = ""; }
            try { repeatability = Convert.ToString((double)row.Cells["Repeatability"].Value); }
            catch { repeatability = ""; }
            try { dom = Convert.ToString((int)row.Cells["DegreesOfMobility"].Value); }
            catch { dom = ""; }
            try { mjv = Convert.ToString((int)row.Cells["MaxJointVelocity"].Value); }
            catch { mjv = ""; }
            try { workspace = Convert.ToString(row.Cells["Workspace"].Value); }
            catch { workspace = ""; }
            try { maxLift = Convert.ToString((int)row.Cells["MaxLift"].Value); }
            catch { maxLift = ""; }
            try { nrOfInputs = Convert.ToString((int)row.Cells["NrOfInputs"].Value); }
            catch { nrOfInputs = ""; }
            try { nrOfOutputs = Convert.ToString((int)row.Cells["NrOfOutputs"].Value); }
            catch { nrOfOutputs = ""; }
            try { offline = ((Boolean)row.Cells["OfflineProgramming"].Value) ? "Yes" : "No"; }
            catch { offline = ""; }
            try { online = ((Boolean)row.Cells["OnlineProgramming"].Value) ? "Yes" : "No"; }
            catch { online = ""; }
            try { auto = ((Boolean)row.Cells["AutoProgramming"].Value) ? "Yes" : "No"; }
            catch { auto = ""; }
            if (id != "Error")
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("model", model);
                data.Add("price", price);
                data.Add("footprint", footprint);
                data.Add("dom", dom);
                data.Add("mjv", mjv);
                data.Add("workspace",workspace);
                data.Add("accuracy", accuracy);
                data.Add("repeatability", repeatability);
                data.Add("weight", weight);
                data.Add("maxLift", maxLift);
                data.Add("nrOfInputs", nrOfInputs);
                data.Add("nrOfOutputs", nrOfOutputs);
                data.Add("offline", offline);
                data.Add("online", online);
                data.Add("auto", auto);
                UpdateRobot.getForm(int.Parse(id), data).Show();
            }
            else
            {
                MessageBox.Show("The selected line's ID could not be determined.");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            urw = null;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            urw.fillTable();
        }
        private void removeById(int ID)
        {
            try
            {
                String query = "delete from TableRobots where RobotID = " + ID + ";";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show(String.Format("Data at ID = {0} has been deleted!", ID));
            }
            catch
            {
                MessageBox.Show(String.Format("Data at ID = {0} does not exist", ID));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowid = dataGridView1.SelectedCells[0].RowIndex;
                row = dataGridView1.Rows[rowid];
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                row = dataGridView1.SelectedRows[0];
            }
            else return;

            String id, price, footprint, accuracy, repeatability, weight,
                dom, mjv, workspace, maxLift, nrOfInputs, nrOfOutputs,
                offline, online, auto;
            String model = "";
            model = Convert.ToString(row.Cells["Model"].Value);
            try { id = Convert.ToString((int)row.Cells["ID"].Value); }
            catch { id = "Error"; }
            try { accuracy = Convert.ToString((double)row.Cells["Accuracy"].Value); }
            catch { accuracy = "---"; }
            try { price = Convert.ToString((double)row.Cells["Price"].Value); }
            catch { price = "---"; }
            try { footprint = Convert.ToString((double)row.Cells["Footprint"].Value); }
            catch { footprint = "---"; }
            try { weight = Convert.ToString((double)row.Cells["Weight"].Value); }
            catch { weight = "---"; }
            try { repeatability = Convert.ToString((double)row.Cells["Repeatability"].Value); }
            catch { repeatability = "---"; }
            try { dom = Convert.ToString((int)row.Cells["DegreesOfMobility"].Value); }
            catch { dom = "---"; }
            try { mjv = Convert.ToString((int)row.Cells["MaxJointVelocity"].Value); }
            catch { mjv = "---"; }
            try { workspace = Convert.ToString(row.Cells["Workspace"].Value); }
            catch { workspace = "---"; }
            try { maxLift = Convert.ToString((int)row.Cells["MaxLift"].Value); }
            catch { maxLift = "---"; }
            try { nrOfInputs = Convert.ToString((int)row.Cells["NrOfInputs"].Value); }
            catch { nrOfInputs = "---"; }
            try { nrOfOutputs = Convert.ToString((int)row.Cells["NrOfOutputs"].Value); }
            catch { nrOfOutputs = "---"; }
            try { offline = ((Boolean)row.Cells["OfflineProgramming"].Value) ? "Yes" : "No" ; }
            catch { offline = "---"; }
            try { online = ((Boolean)row.Cells["OnlineProgramming"].Value) ? "Yes" : "No"; }
            catch { online = "---"; }
            try { auto = ((Boolean)row.Cells["AutoProgramming"].Value) ? "Yes" : "No"; }
            catch { auto = "---"; }
            String str = String.Format("ID: {0}\nModel: {15}\nPrice: {1}\n" +
                "Footprint: {2}\nDegrees Of Mobility: {3}\nMax J" +
                "oint Velocity: {4}\nWorkspace: {5}\nAccuracy:" +
                " {6}\nRepeatability: {7}\nWeight: {8}\nMax Li" +
                "ft: {9}\nNr Of Inputs: {10}\nNr Of Outputs: {11}" +
                "\nOffline Programming: {12}\nOnline Programming:" +
                " {13}\nAuto Programming: {14}",
                id, price, footprint, dom, mjv, workspace, accuracy,
                repeatability, weight, maxLift, nrOfInputs,
                nrOfOutputs, offline, online, auto, model);
            DialogResult dr = MessageBox.Show(String.Format("Delete this entry?\n\n{0}", str), "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    removeById(int.Parse(id));
                    fillTable();
                }
                catch { MessageBox.Show("Something wrong happened while deleting data"); }
            }
            
        }
    }
}
