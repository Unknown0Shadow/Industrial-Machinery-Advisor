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
using System.IO;
using System.Globalization;

namespace RobotDataBase
{
    public partial class RobotsWindow : Form
    {
        private static RobotsWindow rw;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private static OpenFileDialog ofd;
        private static SaveFileDialog sfd;
        private static List<Robot> robots;
        private static List<int> rs;
        private RobotsWindow()
        {
            InitializeComponent();
            referenceNumeric.Maximum = decimal.MaxValue;
            ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd = new SaveFileDialog();
            sfd.Filter = "txt file|*.txt|Rich Text Document|*.rtf|All Files|*.*";
            // sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            robots = new List<Robot>();
            rs = new List<int>();
        }
        public static RobotsWindow getForm()
        {
            if (rw == null)
            {
                rw = new RobotsWindow();
            }
            rw.fillTable("select * from TableRobots;");
            rw.imposeOffline.SelectedIndex = 0;
            rw.imposeOnline.SelectedIndex = 0;
            rw.imposeAuto.SelectedIndex = 0;
            rw.setModifiedImposed(false);
            return rw;
        }
        private void fillTable(String query)
        {
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }
        private void updateCheckBoxes()
        {
            priceCheck.Text = priceCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            footprintCheck.Text = footprintCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            domCheck.Text = domCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            mjvCheck.Text = mjvCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            workspaceCheck.Text = workspaceCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            accuracyCheck.Text = accuracyCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            repeatabilityCheck.Text = repeatabilityCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            weightCheck.Text = weightCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            maxLiftCheck.Text = maxLiftCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            nrOfInputsCheck.Text = nrOfInputsCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            nrOfOutputsCheck.Text = nrOfOutputsCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            offlineCheck.Text = offlineCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            onlineCheck.Text = onlineCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            autoCheck.Text = autoCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            setModified(true);
        }
        private void setModified(bool modified)
        {
            modifiedLabel.Text = modified ? "*" : "";
        }

        private void setModifiedImposed(bool modified)
        {
            modifiedLabelImposed.Text = modified ? "*" : "";
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            rw = null;
        }
        private int findByID(int id)
        {
            int index = -1;
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    index = row.Index;
                    found = true;
                    break;
                }
            }
            if (found) return index;
            return -1;

        }
        private double percentage(double a, double b, bool direct)
        {
            return direct ? (b * 100.0 / a) : (a * 100.0 / b);
        }
        private double percentage(int x, int y, bool direct)
        {
            double a, b;
            a = Convert.ToDouble(x); b = Convert.ToDouble(y);
            return direct ? (b * 100.0 / a) : (a * 100.0 / b);
        }
        private void computeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(referenceNumeric.Value);
            int index = findByID(id);
            if (index == -1)
            {
                MessageBox.Show("Could not find id " + id + "!");
            }
            else
            {
                compute(index);
                setModified(false);
            }
        }
        private float readFloat(String text)
        {
            return float.Parse(text);
        }
        private int readInt(String text)
        {
            return int.Parse(text);
        }
        private String getFloatCommand(String text, bool multi, String name)
        {
            String command = "";
            float value;
            try
            {
                value = readFloat(text);
                if (multi) command = " and";
                command = String.Format("{0} {1} {2}", command, name, value);
            }
            catch (FormatException) { if (text != "") command = String.Format("- [{0}]", name.Split(' ')[0]); }
            return command;
        }
        private String getIntCommand(String text, bool multi, String name)
        {
            String command = "";
            int value;
            try
            {
                value = readInt(text);
                if (multi) command = " and";
                command = String.Format("{0} {1} {2}", command, name, value);
            }
            catch (FormatException) { if (text != "") command = String.Format("- [{0}]", name.Split(' ')[0]); }
            return command;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            bool multi;
            multi = false;
            String query = "";
            String errorsInt = "", errorsReal = "", errors = "";
            String cmd = "";
            cmd = getFloatCommand(imposeMinPrice.Text, multi, "Price >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMaxPrice.Text, multi, "Price <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMinFootprint.Text, multi, "Footprint >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMaxFootprint.Text, multi, "Footprint <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinDOM.Text, multi, "DegreesOfMobility >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxDOM.Text, multi, "DegreesOfMobility <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinMJV.Text, multi, "MaxJointVelocity >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxMJV.Text, multi, "MaxJointVelocity <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMinAccuracy.Text, multi, "Accuracy >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMaxAccuracy.Text, multi, "Accuracy <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMinRepeatability.Text, multi, "Repeatability >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMaxRepeatability.Text, multi, "Repeatability <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMinWeight.Text, multi, "Weight >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMaxWeight.Text, multi, "Weight <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinMaxLift.Text, multi, "MaxLift >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxMaxLift.Text, multi, "MaxLift <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinNrOfInputs.Text, multi, "NrOfInputs >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxNrOfInputs.Text, multi, "NrOfInputs <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinNrOfOutputs.Text, multi, "NrOfOutputs >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxNrOfOutputs.Text, multi, "NrOfOutputs <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;

            if (errorsInt.Length > 0) errors = String.Format("The following must be whole number:{0}.\n", errorsInt);
            if (errorsReal.Length > 0) errors = String.Format("{0}The following must be real number:{1}", errors, errorsReal);
            if (errors.Length > 0) MessageBox.Show(errors, "Format error");
            else
            {
                cmd = "";
                if (imposeOffline.SelectedIndex == 1) cmd = "OfflineProgramming = 1";
                else if (imposeOffline.SelectedIndex == 2) cmd = "OfflineProgramming = 0";
                if (cmd != "") cmd = multi ? String.Format(" and {0}", cmd) : String.Format(" {0}", cmd);
                query += cmd;
                cmd = "";
                if (imposeOnline.SelectedIndex == 1) cmd = "OnlineProgramming = 1";
                else if (imposeOnline.SelectedIndex == 2) cmd = "OnlineProgramming = 0";
                if (cmd != "") cmd = multi ? String.Format(" and {0}", cmd) : String.Format(" {0}", cmd);
                query += cmd;
                cmd = "";
                if (imposeAuto.SelectedIndex == 1) cmd = "AutoProgramming = 1";
                else if (imposeAuto.SelectedIndex == 2) cmd = "AutoProgramming = 0";
                if (cmd != "") cmd = multi ? String.Format(" and {0}", cmd) : String.Format(" {0}", cmd);
                query += cmd;
                query = String.Format("select * from TableRobots" + ((query == "") ? ";" : (" where" + query + ";")));
                //MessageBox.Show(query);
                fillTable(query);
                setModifiedImposed(false);
            }
        }
        private void compute(int index)
        {
            double ref_total = 0, total = 0;
           
            double ref_price, ref_footprint, ref_accuracy, ref_repeatability, ref_weight;
            int ref_dom, ref_mjv, ref_workspace, ref_maxLift, ref_noi, ref_noo;
            bool ref_offline, ref_online, ref_auto;
            
            double price, footprint, accuracy, repeatability, weight;
            int dom, mjv, workspace, maxLift, noi, noo;
            bool offline, online, auto;

            int rPrice, rFootprint, rDOM, rMJV, rWorkspace, rAccuracy, rRepeatability, rWeight, rMaxLift, rNOI, rNOO, rOffline, rOnline, rAuto;

            ref_price = ref_footprint = ref_accuracy = ref_repeatability = ref_weight = -1;
            ref_dom = ref_mjv = ref_workspace = ref_maxLift = ref_noi = ref_noo = -1;

            rPrice = Convert.ToInt32(RPrice.Value);
            rFootprint = Convert.ToInt32(RFootprint.Value);
            rDOM = Convert.ToInt32(RDOM.Value);
            rMJV = Convert.ToInt32(RMJV.Value);
            rWorkspace = Convert.ToInt32(RWorkspace.Value);
            rAccuracy = Convert.ToInt32(RAccuracy.Value);
            rRepeatability = Convert.ToInt32(RRepeatability.Value);
            rWeight = Convert.ToInt32(RWeight.Value);
            rMaxLift = Convert.ToInt32(RMaxLift.Value);
            rNOI = Convert.ToInt32(RNrOfInputs.Value);
            rNOO = Convert.ToInt32(RNrOfOutputs.Value);
            rOffline = Convert.ToInt32(ROffline.Value);
            rOnline = Convert.ToInt32(ROnline.Value);
            rAuto = Convert.ToInt32(RAuto.Value);

            robots.Clear();
            rs.Clear();
            rs.Add(rPrice); rs.Add(rFootprint); rs.Add(rDOM); rs.Add(rMJV);
            rs.Add(rWorkspace); rs.Add(rAccuracy); rs.Add(rRepeatability);
            rs.Add(rWeight); rs.Add(rMaxLift); rs.Add(rNOI); rs.Add(rNOO);
            rs.Add(rOffline); rs.Add(rOnline); rs.Add(rAuto);
            Robot r1 = new Robot();
            r1.ID = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            r1.MODEL = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            try { ref_price = Convert.ToDouble(dataGridView1.Rows[index].Cells[2].Value); ref_total += 100 * rPrice; 
                r1.price = Convert.ToString(ref_price); r1.p_price = "100";} catch{}
            try { ref_footprint = Convert.ToDouble(dataGridView1.Rows[index].Cells[3].Value); ref_total += 100 * rFootprint;
                r1.footprint = Convert.ToString(ref_footprint); r1.p_footprint = "100";} catch { }
            try { ref_dom = Convert.ToInt32(dataGridView1.Rows[index].Cells[4].Value); ref_total += 100 * rDOM;
                r1.dom = Convert.ToString(ref_dom); r1.p_dom = "100";} catch { }
            try { ref_mjv = Convert.ToInt32(dataGridView1.Rows[index].Cells[5].Value); ref_total += 100 * rMJV;
                r1.mjv = Convert.ToString(ref_mjv); r1.p_mjv = "100";} catch { }
            try { String wxyz = Convert.ToString(dataGridView1.Rows[index].Cells[6].Value).Replace(" ", "");
                int wx = Convert.ToInt32(wxyz.Split('x')[0]);
                int wy = Convert.ToInt32(wxyz.Split('x')[1]);
                int wz = Convert.ToInt32(wxyz.Split('x')[2]);
                ref_workspace = wx*wy*wz; ref_total += 100 * rWorkspace;
                r1.workspace = wxyz; r1.p_workspace = "100";} catch { }
            try { ref_accuracy = Convert.ToDouble(dataGridView1.Rows[index].Cells[7].Value); ref_total += 100 * rAccuracy;
                r1.accuracy = Convert.ToString(ref_accuracy); r1.p_accuracy = "100";} catch { }
            try { ref_repeatability = Convert.ToDouble(dataGridView1.Rows[index].Cells[8].Value); ref_total += 100 * rRepeatability;
                r1.repeatability = Convert.ToString(ref_repeatability); r1.p_repeatability = "100";} catch { }
            try { ref_weight = Convert.ToDouble(dataGridView1.Rows[index].Cells[9].Value); ref_total += 100 * rWeight;
                r1.weight = Convert.ToString(ref_weight); r1.p_weight = "100";} catch { }
            try { ref_maxLift = Convert.ToInt32(dataGridView1.Rows[index].Cells[10].Value); ref_total += 100 * rMaxLift;
                r1.max_lift = Convert.ToString(ref_maxLift); r1.p_max_lift = "100";} catch { }
            try { ref_noi = Convert.ToInt32(dataGridView1.Rows[index].Cells[11].Value); ref_total += 100 * rNOI;
                r1.nr_of_inputs = Convert.ToString(ref_noi); r1.p_nr_of_inputs = "100";} catch { }
            try { ref_noo = Convert.ToInt32(dataGridView1.Rows[index].Cells[12].Value); ref_total += 100 * rNOO;
                r1.nr_of_outputs = Convert.ToString(ref_noo); r1.p_nr_of_outputs = "100";} catch { }
            
            ref_offline = Convert.ToBoolean(dataGridView1.Rows[index].Cells[13].Value);
            ref_online = Convert.ToBoolean(dataGridView1.Rows[index].Cells[14].Value);
            ref_auto = Convert.ToBoolean(dataGridView1.Rows[index].Cells[15].Value);

            if (ref_offline != (offlineCheck.CheckState == CheckState.Checked)) ref_total += 100 * rOffline;
            if (ref_online != (onlineCheck.CheckState == CheckState.Checked)) ref_total += 100 * rOnline;
            if (ref_auto != (autoCheck.CheckState == CheckState.Checked)) ref_total += 100 * rAuto;
            r1.offline = ref_offline ? "Yes" : "No";
            r1.p_offline = ref_offline ? "100" : "0";
            r1.online = ref_online ? "Yes" : "No";
            r1.p_online = ref_online ? "100" : "0";
            r1.auto = ref_auto ? "Yes" : "No";
            r1.p_auto = ref_auto ? "100" : "0";
            r1.TOTAL = Convert.ToString(ref_total);
            robots.Add(r1);

            dataGridView1.Rows[index].Cells[16].Value = ref_total;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row == dataGridView1.Rows[index]) continue;

                Robot r2 = new Robot();
                r2.ID = Convert.ToString(row.Cells[0].Value); r2.MODEL = Convert.ToString(row.Cells[1].Value);
                double ptc = 0;
                price = footprint = accuracy = repeatability = weight = -1;
                dom = mjv = workspace = maxLift = noi = noo = -1;

                try
                {
                    price = Convert.ToDouble(row.Cells[2].Value);
                    if (ref_price > 0)
                    {
                        ptc = percentage(price, ref_price, priceCheck.CheckState == CheckState.Checked);
                        total += ptc * rPrice;
                        r2.price = Convert.ToString(price); r2.p_price = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    footprint = Convert.ToDouble(row.Cells[3].Value);
                    if (ref_footprint > 0)
                    {
                        ptc = percentage(footprint, ref_footprint, footprintCheck.CheckState == CheckState.Checked);
                        total += ptc * rFootprint;
                        r2.footprint = Convert.ToString(footprint); r2.p_footprint = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    dom = Convert.ToInt32(row.Cells[4].Value);
                    if (ref_dom > 0)
                    {
                        ptc = percentage(dom, ref_dom, domCheck.CheckState == CheckState.Checked);
                        total += ptc * rDOM;
                        r2.dom = Convert.ToString(dom); r2.p_dom = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    mjv = Convert.ToInt32(row.Cells[5].Value);
                    if (ref_mjv > 0)
                    {
                        ptc = percentage(mjv, ref_mjv, mjvCheck.CheckState == CheckState.Checked);
                        total += ptc * rMJV;
                        r2.mjv = Convert.ToString(mjv); r2.p_mjv = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    String wxyz = Convert.ToString(row.Cells[6].Value).Replace(" ", "");
                    int wx = Convert.ToInt32(wxyz.Split('x')[0]);
                    int wy = Convert.ToInt32(wxyz.Split('x')[1]);
                    int wz = Convert.ToInt32(wxyz.Split('x')[2]);
                    workspace = wx * wy * wz;
                    if (ref_workspace > 0)
                    {
                        ptc = percentage(workspace, ref_workspace, workspaceCheck.CheckState == CheckState.Checked);
                        total += ptc * rWorkspace;
                        r2.workspace = wxyz; r2.p_workspace = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    accuracy = Convert.ToDouble(row.Cells[7].Value);
                    if (ref_accuracy > 0)
                    {
                        ptc = percentage(accuracy, ref_accuracy, accuracyCheck.CheckState == CheckState.Checked);
                        total += ptc * rAccuracy;
                        r2.accuracy = Convert.ToString(accuracy); r2.p_accuracy = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try 
                { 
                    repeatability = Convert.ToDouble(row.Cells[8].Value);
                    if (ref_repeatability > 0)
                    {
                        ptc = percentage(repeatability, ref_repeatability, repeatabilityCheck.CheckState == CheckState.Checked);
                        total += ptc * rRepeatability;
                        r2.repeatability = Convert.ToString(repeatability); r2.p_repeatability = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    weight = Convert.ToDouble(row.Cells[9].Value);
                    if (ref_weight > 0)
                    {
                        ptc = percentage(weight, ref_weight, weightCheck.CheckState == CheckState.Checked);
                        total += ptc * rWeight;
                        r2.weight = Convert.ToString(weight); r2.p_weight = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    maxLift = Convert.ToInt32(row.Cells[10].Value);
                    if (ref_maxLift > 0)
                    {
                        ptc = percentage(maxLift, ref_maxLift, maxLiftCheck.CheckState == CheckState.Checked);
                        total += ptc * rMaxLift;
                        r2.max_lift = Convert.ToString(maxLift); r2.p_max_lift = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    noi = Convert.ToInt32(row.Cells[11].Value);
                    if (ref_noi > 0)
                    {
                        ptc = percentage(noi, ref_noi, nrOfInputsCheck.CheckState == CheckState.Checked);
                        total += ptc * rNOI;
                        r2.nr_of_inputs = Convert.ToString(noi); r2.p_nr_of_inputs = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }
                try
                {
                    noo = Convert.ToInt32(row.Cells[12].Value);
                    if (ref_noo > 0)
                    {
                        ptc = percentage(noo, ref_noo, nrOfOutputsCheck.CheckState == CheckState.Checked);
                        total += ptc * rNOO;
                        r2.nr_of_outputs = Convert.ToString(noo); r2.p_nr_of_outputs = String.Format("{0:n2}", ptc);
                    }
                }
                catch { }

                offline = Convert.ToBoolean(row.Cells[13].Value);
                online = Convert.ToBoolean(row.Cells[14].Value);
                auto = Convert.ToBoolean(row.Cells[15].Value);
                ptc = 100 * Convert.ToInt32(offline);
                total += ptc * rOffline;
                r2.offline = offline ? "Yes" : "No"; r2.p_offline = String.Format("{0:n2}", ptc);
                if (ref_online != (onlineCheck.CheckState == CheckState.Checked))
                {
                    ptc = 250 * Convert.ToInt32(online);
                    total += ptc * rOnline;
                    r2.online = online ? "Yes" : "No"; r2.p_online = String.Format("{0:n2}", ptc);
                }
                else
                {
                    ptc = 40 * Convert.ToInt32(online);
                    total += ptc * rOnline;
                    r2.online = online ? "Yes" : "No"; r2.p_online = String.Format("{0:n2}", ptc);
                }
                if (ref_auto != (autoCheck.CheckState == CheckState.Checked))
                {
                    ptc = 500 * Convert.ToInt32(auto);
                    total += ptc * rAuto;
                    r2.auto = auto ? "Yes" : "No"; r2.p_auto = String.Format("{0:n2}", ptc);
                }
                else
                {
                    ptc = 20 * Convert.ToInt32(auto);
                    total += ptc * rAuto;
                    r2.auto = auto ? "Yes" : "No"; r2.p_auto = String.Format("{0:n2}", ptc);
                }
                row.Cells[16].Value = total;

                r2.TOTAL = String.Format("{0:n2}", total);
                robots.Add(r2);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String layout_data = "";
            layout_data += "M:";
            layout_data += priceCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += footprintCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += domCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += mjvCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += workspaceCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += accuracyCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += repeatabilityCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += weightCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += maxLiftCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += nrOfInputsCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += nrOfOutputsCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += offlineCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += onlineCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += autoCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += "\nR:";
            layout_data += " " + RPrice.Value;
            layout_data += " " + RFootprint.Value;
            layout_data += " " + RDOM.Value;
            layout_data += " " + RMJV.Value;
            layout_data += " " + RWorkspace.Value;
            layout_data += " " + RAccuracy.Value;
            layout_data += " " + RRepeatability.Value;
            layout_data += " " + RWeight.Value;
            layout_data += " " + RMaxLift.Value;
            layout_data += " " + RNrOfInputs.Value;
            layout_data += " " + RNrOfOutputs.Value;
            layout_data += " " + ROffline.Value;
            layout_data += " " + ROnline.Value;
            layout_data += " " + RAuto.Value;
            layout_data += "\nIL:";
            layout_data += " " + (imposeMinPrice.Text == "" ? "." : imposeMinPrice.Text);
            layout_data += " " + (imposeMinFootprint.Text == "" ? "." : imposeMinFootprint.Text);
            layout_data += " " + (imposeMinDOM.Text == "" ? "." : imposeMinDOM.Text);
            layout_data += " " + (imposeMinMJV.Text == "" ? "." : imposeMinMJV.Text);
            layout_data += " " + (imposeMinAccuracy.Text == "" ? "." : imposeMinAccuracy.Text);
            layout_data += " " + (imposeMinRepeatability.Text == "" ? "." : imposeMinRepeatability.Text);
            layout_data += " " + (imposeMinWeight.Text == "" ? "." : imposeMinWeight.Text);
            layout_data += " " + (imposeMinMaxLift.Text == "" ? "." : imposeMinMaxLift.Text);
            layout_data += " " + (imposeMinNrOfInputs.Text == "" ? "." : imposeMinNrOfInputs.Text);
            layout_data += " " + (imposeMinNrOfOutputs.Text == "" ? "." : imposeMinNrOfOutputs.Text);
            layout_data += "\nIH:";
            layout_data += " " + (imposeMaxPrice.Text == "" ? "." : imposeMaxPrice.Text);
            layout_data += " " + (imposeMaxFootprint.Text == "" ? "." : imposeMaxFootprint.Text);
            layout_data += " " + (imposeMaxDOM.Text == "" ? "." : imposeMaxDOM.Text);
            layout_data += " " + (imposeMaxMJV.Text == "" ? "." : imposeMaxMJV.Text);
            layout_data += " " + (imposeMaxAccuracy.Text == "" ? "." : imposeMaxAccuracy.Text);
            layout_data += " " + (imposeMaxRepeatability.Text == "" ? "." : imposeMaxRepeatability.Text);
            layout_data += " " + (imposeMaxWeight.Text == "" ? "." : imposeMaxWeight.Text);
            layout_data += " " + (imposeMaxMaxLift.Text == "" ? "." : imposeMaxMaxLift.Text);
            layout_data += " " + (imposeMaxNrOfInputs.Text == "" ? "." : imposeMaxNrOfInputs.Text);
            layout_data += " " + (imposeMaxNrOfOutputs.Text == "" ? "." : imposeMaxNrOfOutputs.Text);
            layout_data += " " + imposeOffline.SelectedIndex;
            layout_data += " " + imposeOnline.SelectedIndex;
            layout_data += " " + imposeAuto.SelectedIndex;
            sfd.InitialDirectory = System.IO.Path.GetFullPath(
                System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\layouts"));
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                MemoryStream userInput = new MemoryStream();
                System.IO.FileStream fileStream = (System.IO.FileStream)sfd.OpenFile(); ;
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (String line in layout_data.Split('\n'))
                    {
                        writer.Write(String.Format("{0}{1}", line, Environment.NewLine));
                    }
                }
                MessageBox.Show(String.Format("File {0} successfully saved!", Path.GetFileName(sfd.FileName)));
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = System.IO.Path.GetFullPath(
                System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\layouts"));
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String filePath = ofd.FileName;
                String fileContent;
                var fileStream = ofd.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                MessageBox.Show(fileContent);
                foreach (String l in fileContent.Split('\n'))
                {
                    String line = l.TrimEnd('\r');
                    switch (line.Split(' ')[0])
                    {
                        case "M:":
                            priceCheck.CheckState = line.Split(' ')[1] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            footprintCheck.CheckState = line.Split(' ')[2] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            domCheck.CheckState = line.Split(' ')[3] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            mjvCheck.CheckState = line.Split(' ')[4] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            workspaceCheck.CheckState = line.Split(' ')[5] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            accuracyCheck.CheckState = line.Split(' ')[6] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            repeatabilityCheck.CheckState = line.Split(' ')[7] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            weightCheck.CheckState = line.Split(' ')[8] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            maxLiftCheck.CheckState = line.Split(' ')[9] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            nrOfInputsCheck.CheckState = line.Split(' ')[10] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            nrOfOutputsCheck.CheckState = line.Split(' ')[11] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            offlineCheck.CheckState = line.Split(' ')[12] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            onlineCheck.CheckState = line.Split(' ')[13] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            autoCheck.CheckState = line.Split(' ')[14] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            updateCheckBoxes();
                            break;
                        case "R:":
                            try
                            {
                                RPrice.Value = readInt(line.Split(' ')[1]);
                                RFootprint.Value = readInt(line.Split(' ')[2]);
                                RDOM.Value = readInt(line.Split(' ')[3]);
                                RMJV.Value = readInt(line.Split(' ')[4]);
                                RWorkspace.Value = readInt(line.Split(' ')[5]);
                                RAccuracy.Value = readInt(line.Split(' ')[6]);
                                RRepeatability.Value = readInt(line.Split(' ')[7]);
                                RWeight.Value = readInt(line.Split(' ')[8]);
                                RMaxLift.Value = readInt(line.Split(' ')[9]);
                                RNrOfInputs.Value = readInt(line.Split(' ')[10]);
                                RNrOfOutputs.Value = readInt(line.Split(' ')[11]);
                                ROffline.Value = readInt(line.Split(' ')[12]);
                                ROnline.Value = readInt(line.Split(' ')[13]);
                                RAuto.Value = readInt(line.Split(' ')[14]);
                            }
                            catch
                            {
                                MessageBox.Show("Somethign went wrong loading \"{0}\"!",
                                    Path.GetFileName(ofd.FileName));
                            }
                            setModified(true);
                            break;
                        case "IL:":
                            imposeMinPrice.Text = line.Split(' ')[1] == "." ?
                                "" : line.Split(' ')[1];
                            imposeMinFootprint.Text = line.Split(' ')[2] == "." ?
                                "" : line.Split(' ')[2];
                            imposeMinDOM.Text = line.Split(' ')[3] == "." ?
                                "" : line.Split(' ')[3];
                            imposeMinMJV.Text = line.Split(' ')[4] == "." ?
                                "" : line.Split(' ')[4];
                            imposeMinAccuracy.Text = line.Split(' ')[5] == "." ?
                                "" : line.Split(' ')[5];
                            imposeMinRepeatability.Text = line.Split(' ')[6] == "." ?
                                "" : line.Split(' ')[6];
                            imposeMinWeight.Text = line.Split(' ')[7] == "." ?
                                "" : line.Split(' ')[7];
                            imposeMinMaxLift.Text = line.Split(' ')[8] == "." ?
                                "" : line.Split(' ')[8];
                            imposeMinNrOfInputs.Text = line.Split(' ')[9] == "." ?
                                "" : line.Split(' ')[9];
                            imposeMinNrOfOutputs.Text = line.Split(' ')[10] == "." ?
                                "" : line.Split(' ')[10];
                            break;
                        case "IH:":
                            imposeMaxPrice.Text = line.Split(' ')[1] == "." ?
                                "" : line.Split(' ')[1];
                            imposeMaxFootprint.Text = line.Split(' ')[2] == "." ?
                                "" : line.Split(' ')[2];
                            imposeMaxDOM.Text = line.Split(' ')[3] == "." ?
                                "" : line.Split(' ')[3];
                            imposeMaxMJV.Text = line.Split(' ')[4] == "." ?
                                "" : line.Split(' ')[4];
                            imposeMaxAccuracy.Text = line.Split(' ')[5] == "." ?
                                "" : line.Split(' ')[5];
                            imposeMaxRepeatability.Text = line.Split(' ')[6] == "." ?
                                "" : line.Split(' ')[6];
                            imposeMaxWeight.Text = line.Split(' ')[7] == "." ?
                                "" : line.Split(' ')[7];
                            imposeMaxMaxLift.Text = line.Split(' ')[8] == "." ?
                                "" : line.Split(' ')[8];
                            imposeMaxNrOfInputs.Text = line.Split(' ')[9] == "." ?
                                "" : line.Split(' ')[9];
                            imposeMaxNrOfOutputs.Text = line.Split(' ')[10] == "." ?
                                "" : line.Split(' ')[10];
                            try{imposeOffline.SelectedIndex = readInt(line.Split(' ')[11]);}
                            catch
                            {
                                MessageBox.Show("The OfflineProgramming Imposed Limit couldn't load, so it was set to the default value.");
                                imposeOffline.SelectedIndex = 1;
                            }
                            try { imposeOnline.SelectedIndex = readInt(line.Split(' ')[11]); }
                            catch
                            {
                                MessageBox.Show("The OnlineProgramming Imposed Limit couldn't load, so it was set to the default value.");
                                imposeOnline.SelectedIndex = 1;
                            }
                            try { imposeAuto.SelectedIndex = readInt(line.Split(' ')[11]); }
                            catch
                            {
                                MessageBox.Show("The AutoProgramming Imposed Limit couldn't load, so it was set to the default value.");
                                imposeAuto.SelectedIndex = 1;
                            }
                            setModifiedImposed(true);
                            break;
                    }
                }
            }
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String export_data = "";
            sfd.InitialDirectory = System.IO.Path.GetFullPath(
                System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\data"));
            sfd.Title = "Export Computed Data";
            sfd.FilterIndex = 3;
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    MemoryStream userInput = new MemoryStream();
                    System.IO.FileStream fileStream = (System.IO.FileStream)sfd.OpenFile(); ;


                    switch (sfd.FilterIndex)
                    {
                        case 1:
                        case 2:
                        default:
                            export_data = String.Format("{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                              + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}|{14,12}|{15,12}|{16,12}\n",
                                "RobotID", "Model", "Price", "Footprint", "Deg.Mobility","Joint Speed","Workspace",
                                "Accuracy", "Repeat.", "Weight", "MaxLift", "NrOfInputs", "NrOfOutputs","OfflineProg",
                                "OnlineProg", "AutoProg", "Total");
                            export_data += String.Format("{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                              + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}|{14,12}|{15,12}|{16,12}\n",
                                "R", "---", rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6], rs[7], rs[8],
                                rs[9], rs[10], rs[11], rs[12], rs[13], "---");

                            foreach (Robot r in robots)
                            {
                                export_data += "\n------------|------------|------------|------------|------------|" +
                                    "------------|------------|------------|------------|------------|------------|" +
                                    "------------|------------|------------|------------|------------|------------|\n";
                                export_data += String.Format("{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                                  + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}|{14,12}|{15,12}|\n",
                                    r.ID, r.MODEL,
                                    (r.price == "---" ? r.price : String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C}", Convert.ToDouble(r.price))),
                                    r.footprint, r.dom, r.mjv, r.workspace, r.accuracy, r.repeatability, r.weight,
                                    r.max_lift, r.nr_of_inputs, r.nr_of_outputs, r.offline, r.online, r.auto);

                                export_data += "\n------------|------------|------------|------------|------------|" +
                                    "------------|------------|------------|------------|------------|------------|" +
                                    "------------|------------|------------|------------|------------|------------|\n";
                                export_data += String.Format("{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                                  + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}|{14,12}|{15,12}|{16,12}\n",
                                     "---", "---",r.p_price, r.p_footprint, r.p_dom, r.p_mjv, r.p_workspace, r.p_accuracy,
                                     r.p_repeatability, r.p_weight, r.p_max_lift, r.p_nr_of_inputs, r.p_nr_of_outputs,
                                     r.p_offline, r.p_online, r.p_auto, r.TOTAL);
                            }
                            using (StreamWriter writer = new StreamWriter(fileStream))
                            {
                                foreach (String line in export_data.Split('\n'))
                                {
                                    writer.Write(String.Format("{0}{1}", line, Environment.NewLine));
                                }
                            }
                            break;
                    }
                }
                MessageBox.Show(String.Format("File {0} successfully saved!", Path.GetFileName(sfd.FileName)));
            }
        }

        private void priceCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void footprintCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void domCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void mjvCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void workspaceCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void accuracyCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void repeatabilityCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void weightCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void maxLiftCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void nrOfInputsCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void nrOfOutputsCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void offlineCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void onlineCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void autoCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void RPrice_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RFootprint_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RDOM_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RMJV_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RWorkspace_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RAccuracy_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RRepeatability_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RWeight_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RMaxLift_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RNrOfInputs_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RNrOfOutputs_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void ROffline_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void ROnline_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void RAuto_ValueChanged(object sender, EventArgs e)
        {
            setModified(true);
        }

        private void imposeMinPrice_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxPrice_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinFootprint_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxFootprint_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinDOM_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxDOM_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinMJV_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxMJV_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinWorkspace_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxWorkspace_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinAccuracy_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxAccuracy_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinRepeatability_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxRepeatability_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinWeight_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxWeight_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinMaxLift_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxMaxLift_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinNrOfInputs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxNrOfInputs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinNrOfOutputs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxNrOfOutputs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeOffline_SelectedIndexChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

    }
}
