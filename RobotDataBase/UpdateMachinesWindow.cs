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
    public partial class UpdateMachinesWindow : Form
    {
        private static UpdateMachinesWindow umw;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private UpdateMachinesWindow()
        {
            InitializeComponent();
        }
        public static UpdateMachinesWindow getForm(){
            if (umw == null)
            {
                umw = new UpdateMachinesWindow();
            }
            umw.fillTable();
            return umw;
        }
        public void fillTable()
        {
            String query = "select * from TableMachines;";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }
        private void removeById(int ID)
        {
            try
            {
                String query = "delete from TableMachines where MachineID = " + ID +";";
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

        private void button2_Click(object sender, EventArgs e)
        {
            InsertMachine.getForm().Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            umw = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            umw.fillTable();
        }

        private void button4_Click(object sender, EventArgs e)
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

            string id, setTime, reliability, productivity, minRevs,
                maxRevs, nrOfAxes, price, footprint, weight,
                precision, holder, model;
            model = Convert.ToString(row.Cells["Model"].Value);
            try { id = Convert.ToString((int)row.Cells["ID"].Value); }
            catch { id = "Error"; }
            try { setTime = Convert.ToString((int)row.Cells["SetTime"].Value); }
            catch { setTime = "---"; }
            try { reliability = Convert.ToString((int)row.Cells["Reliability"].Value); }
            catch { reliability = "---"; }
            try { productivity = Convert.ToString((int)row.Cells["Productivity"].Value); }
            catch { productivity = "---"; }
            try { minRevs = Convert.ToString((int)row.Cells["MinRevolutions"].Value); }
            catch { minRevs = "---"; }
            try { maxRevs = Convert.ToString((int)row.Cells["MaxRevolutions"].Value); }
            catch { maxRevs = "---"; }
            try { nrOfAxes = Convert.ToString((int)row.Cells["NrOfSimultaneousAxes"].Value); }
            catch { nrOfAxes = "---"; }
            try { price = Convert.ToString((double)row.Cells["Price"].Value); }
            catch { price = "---"; }
            try { footprint = Convert.ToString((double)row.Cells["Footprint"].Value); }
            catch { footprint = "---"; }
            try { weight = Convert.ToString((double)row.Cells["Weight"].Value); }
            catch { weight = "---"; }
            try { precision = Convert.ToString((double)row.Cells["Precision"].Value); }
            catch { precision = "---"; }
            try { holder = ((Boolean)row.Cells["WorkpieceHolder"].Value) ? "Yes" : "No"; }
            catch { holder = "---"; }
            string str = string.Format("ID: {0}\nModel: {12}\nPrice: {1}\n" +
                "Footprint: {2}\nWeight: {3}\nSet Time: {4}\n" +
                "Reliability: {5}\nPrecision: {6}\nProductivi" +
                "ty: {7}\nMin Revolutions: {8}\nMax Revolutio" +
                "ns: {9}\nNr Of Simultaneous Axes: {10}\nWork" +
                "piece Holder: {11}", id, price,
                footprint, weight, setTime, reliability, precision,
                productivity, minRevs, maxRevs, nrOfAxes,
                holder, model);
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

        private void button3_Click(object sender, EventArgs e)
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

            string id, model, setTime, reliability, productivity, minRevs,
                maxRevs, nrOfAxes, price, footprint, weight,
                precision, holder;
            try { id = Convert.ToString((int)row.Cells["ID"].Value); }
            catch { id = "Error"; }
            try { model = Convert.ToString(row.Cells["Model"].Value); }
            catch { model = "";  }
            try { setTime = Convert.ToString((int)row.Cells["SetTime"].Value); }
            catch { setTime = ""; }
            try { reliability = Convert.ToString((int)row.Cells["Reliability"].Value); }
            catch { reliability = ""; }
            try { productivity = Convert.ToString((int)row.Cells["Productivity"].Value); }
            catch { productivity = ""; }
            try { minRevs = Convert.ToString((int)row.Cells["MinRevolutions"].Value); }
            catch { minRevs = ""; }
            try { maxRevs = Convert.ToString((int)row.Cells["MaxRevolutions"].Value); }
            catch { maxRevs = ""; }
            try { nrOfAxes = Convert.ToString((int)row.Cells["NrOfSimultaneousAxes"].Value); }
            catch { nrOfAxes = ""; }
            try { price = Convert.ToString((double)row.Cells["Price"].Value); }
            catch { price = ""; }
            try { footprint = Convert.ToString((double)row.Cells["Footprint"].Value); }
            catch { footprint = ""; }
            try { weight = Convert.ToString((double)row.Cells["Weight"].Value); }
            catch { weight = ""; }
            try { precision = Convert.ToString((double)row.Cells["Precision"].Value); }
            catch { precision = ""; }
            try { holder = ((Boolean)row.Cells["WorkpieceHolder"].Value) ? "Yes" : "No"; }
            catch { holder = ""; }
            if (id != "Error")
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("model", model);
                data.Add("price", price);
                data.Add("footprint", footprint);
                data.Add("weight", weight);
                data.Add("setTime", setTime);
                data.Add("reliability", reliability);
                data.Add("precision", precision);
                data.Add("productivity", productivity);
                data.Add("minRevs", minRevs);
                data.Add("maxRevs", maxRevs);
                data.Add("nrOfAxes", nrOfAxes);
                data.Add("holder", holder);
                UpdateMachine.getForm(int.Parse(id), data).Show();
            }
            else
            {
                MessageBox.Show("The selected line's ID could not be determined.");
            }
        }
    }
}
