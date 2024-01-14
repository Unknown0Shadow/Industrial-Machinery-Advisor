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
using System.Net;

namespace RobotDataBase
{
    public partial class MachinesWindow : Form
    {
        private static MachinesWindow mw;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private static OpenFileDialog ofd;
        private static SaveFileDialog sfd;
        private static List<Machine> machines;
        private static List<int> rs;
        private MachinesWindow()
        {
            InitializeComponent();
            referenceNumeric.Maximum = decimal.MaxValue;
            ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd = new SaveFileDialog();
            sfd.Filter = "txt file|*.txt|Rich Text Document|*.rtf|All Files|*.*";
            // sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            machines = new List<Machine>();
            rs = new List<int>();
        }
        public static MachinesWindow getForm(){
            if (mw == null)
            {
                mw = new MachinesWindow();
            }
            mw.fillTable("select * from TableMachines;");
            mw.imposeHolder.SelectedIndex = 0; mw.setModifiedImposed(false);
            return mw;
        }
        private void fillTable(String query){
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            mw = null;
        }
        private void updateCheckBoxes()
        {
            priceCheck.Text = priceCheck.CheckState == CheckState.Checked ?"Down" : "Up";
            footprintCheck.Text = footprintCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            weightCheck.Text = weightCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            setTimeCheck.Text = setTimeCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            reliabilityCheck.Text = reliabilityCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            precisionCheck.Text = precisionCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            productivityCheck.Text = productivityCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            minRevsCheck.Text = minRevsCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            maxRevsCheck.Text = maxRevsCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            nrOfAxesCheck.Text = nrOfAxesCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            holderCheck.Text = holderCheck.CheckState == CheckState.Checked ? "Down" : "Up";
            setModified(true);
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
            if(found) return index;
            return -1;

        }
        private double percentage(double a, double b, bool direct)
        {
            return direct ? (b * 100.0 / a): (a * 100.0 / b);
        }
        private double percentage(int x, int y, bool direct)
        {
            double a, b;
            a = Convert.ToDouble(x); b = Convert.ToDouble(y);
            return direct ? (b * 100.0 / a) : (a * 100.0 / b);
        }
        private void compute(int index)
        {
            double ref_total = 0, total = 0;
            double ref_price, ref_footprint, ref_weight, ref_precision;
            int ref_setTime, ref_reliability, ref_productivity, ref_minRevs, ref_maxRevs, ref_nrOfAxes;
            int rPrice, rFootprint, rWeight, rSetTime, rReliability, rPrecision, rProductivity, rMinRevs, rMaxRevs, rNrOfAxes, rHolder;
            bool ref_workpieceHolder;
            double price, footprint, weight, precision;
            int setTime, reliability, productivity, minRevs, maxRevs, nrOfAxes;
            bool workpieceHolder;
            ref_price = ref_footprint = ref_weight = ref_precision = -1;
            ref_setTime = ref_reliability = ref_productivity = ref_minRevs = ref_maxRevs = ref_nrOfAxes = -1;
            
            rPrice = Convert.ToInt32(RPrice.Value);
            rFootprint = Convert.ToInt32(RFootprint.Value);
            rWeight = Convert.ToInt32(RWeight.Value);
            rSetTime = Convert.ToInt32(RSetTime.Value);
            rReliability = Convert.ToInt32(RReliability.Value);
            rPrecision = Convert.ToInt32(RPrecision.Value);
            rProductivity = Convert.ToInt32(RProductivity.Value);
            rMinRevs = Convert.ToInt32(RMinRevs.Value);
            rMaxRevs = Convert.ToInt32(RMaxRevs.Value);
            rNrOfAxes = Convert.ToInt32(RNrOfAxes.Value);
            rHolder = Convert.ToInt32(RWorkpieceHolder.Value);

            machines.Clear();
            rs.Clear();
            rs.Add(rPrice); rs.Add(rFootprint); rs.Add(rWeight); rs.Add(rSetTime);
            rs.Add(rReliability); rs.Add(rPrecision); rs.Add(rProductivity);
            rs.Add(rMinRevs); rs.Add(rMaxRevs); rs.Add(rNrOfAxes); rs.Add(rHolder);
            Machine m1 = new Machine();
            m1.ID = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            m1.MODEL = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            try { ref_price = Convert.ToDouble(dataGridView1.Rows[index].Cells[2].Value); ref_total += 100 * rPrice;
                m1.price = Convert.ToString(ref_price); m1.p_price = "100";} catch{}
            try { ref_footprint = Convert.ToDouble(dataGridView1.Rows[index].Cells[3].Value); ref_total += 100 * rFootprint;
                m1.footprint = Convert.ToString(ref_footprint); m1.p_footprint = "100";} catch { }
            try { ref_weight = Convert.ToDouble(dataGridView1.Rows[index].Cells[4].Value); ref_total += 100 * rWeight;
                m1.weight = Convert.ToString(ref_weight); m1.p_weight = "100";} catch { }
            try { ref_setTime = Convert.ToInt32(dataGridView1.Rows[index].Cells[5].Value); ref_total += 100 * rSetTime;
                m1.set_time = Convert.ToString(ref_setTime); m1.p_set_time = "100"; } catch { }
            try { ref_reliability = Convert.ToInt32(dataGridView1.Rows[index].Cells[6].Value); ref_total += 100 * rReliability;
                m1.reliability = Convert.ToString(ref_reliability); m1.p_reliability = "100";}catch { }
            try { ref_precision = Convert.ToDouble(dataGridView1.Rows[index].Cells[7].Value); ref_total += 100 * rPrecision;
                m1.precision = Convert.ToString(ref_precision); m1.p_precision = "100";} catch { }
            try { ref_productivity = Convert.ToInt32(dataGridView1.Rows[index].Cells[8].Value); ref_total += 100 * rProductivity;
                m1.productivity = Convert.ToString(ref_productivity); m1.p_productivity = "100";} catch { }
            try { ref_minRevs = Convert.ToInt32(dataGridView1.Rows[index].Cells[9].Value); ref_total += 100 * rMinRevs;
                m1.min_revs = Convert.ToString(ref_minRevs); m1.p_min_revs = "100";} catch { }
            try { ref_maxRevs = Convert.ToInt32(dataGridView1.Rows[index].Cells[10].Value); ref_total += 100 * rMaxRevs;
                m1.max_revs = Convert.ToString(ref_maxRevs); m1.p_max_revs = "100";} catch { }
            try { ref_nrOfAxes = Convert.ToInt32(dataGridView1.Rows[index].Cells[11].Value); ref_total += 100 * rNrOfAxes;
                m1.nr_of_axes = Convert.ToString(ref_nrOfAxes); m1.p_nr_of_axes = "100";} catch { }
            ref_workpieceHolder = Convert.ToBoolean(dataGridView1.Rows[index].Cells[12].Value);
            if (ref_workpieceHolder != (holderCheck.CheckState == CheckState.Checked)) ref_total += 100 * rHolder;
            m1.holder = ref_workpieceHolder ? "Yes" : "No";
            m1.p_holder = ref_workpieceHolder? "100":"0";
            m1.TOTAL = Convert.ToString(ref_total);
            machines.Add(m1);
            
            // MessageBox.Show(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", index, price, footprint, weight, setTime, reliability, precision, productivity, minRevs, maxRevs, nrOfAxes, workpieceHolder));
            dataGridView1.Rows[index].Cells[13].Value = ref_total;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row == dataGridView1.Rows[index]) continue;
                Machine m2 = new Machine();
                m2.ID = Convert.ToString(row.Cells[0].Value); m2.MODEL = Convert.ToString(row.Cells[1].Value);
                double ptc = 0;

                total = 0; price = footprint = weight = precision = -1;
                setTime = reliability = productivity = minRevs = maxRevs = nrOfAxes = -1;
                try
                {
                    price = Convert.ToDouble(row.Cells[2].Value);
                    if (ref_price > 0)
                    {
                        ptc = percentage(price, ref_price, priceCheck.CheckState == CheckState.Checked);
                        total += ptc * rPrice;
                        m2.price = Convert.ToString(price); m2.p_price = String.Format("{0:n2}", ptc);
                    }
                        
                } catch { }
                try
                {
                    footprint = Convert.ToDouble(row.Cells[3].Value);
                    if (ref_footprint > 0)
                    {
                        ptc = percentage(footprint, ref_footprint, footprintCheck.CheckState == CheckState.Checked);
                        total += ptc * rFootprint;
                        m2.footprint = Convert.ToString(footprint); m2.p_footprint = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    weight = Convert.ToDouble(row.Cells[4].Value);
                    if (ref_weight > 0)
                    {
                        ptc = percentage(weight, ref_weight, weightCheck.CheckState == CheckState.Checked);
                        total += ptc * rWeight;
                        m2.weight = Convert.ToString(weight); m2.p_weight = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    setTime = Convert.ToInt32(row.Cells[5].Value);
                    if (ref_setTime > 0)
                    {
                        ptc = percentage(setTime, ref_setTime, setTimeCheck.CheckState == CheckState.Checked);
                        total += ptc * rSetTime;
                        m2.set_time = Convert.ToString(setTime); m2.p_set_time = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    reliability = Convert.ToInt32(row.Cells[6].Value);
                    if (ref_reliability > 0)
                    {
                        ptc = percentage(reliability, ref_reliability, reliabilityCheck.CheckState == CheckState.Checked);
                        total += ptc * rReliability;
                        m2.reliability = Convert.ToString(reliability); m2.p_reliability = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    precision = Convert.ToDouble(row.Cells[7].Value);
                    if (ref_precision > 0)
                    {
                        ptc = percentage(precision, ref_precision, precisionCheck.CheckState == CheckState.Checked);
                        total += ptc * rPrecision;
                        m2.precision = Convert.ToString(precision); m2.p_precision = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    productivity = Convert.ToInt32(row.Cells[8].Value);
                    if (ref_productivity > 0)
                    {
                        ptc = percentage(productivity, ref_productivity, productivityCheck.CheckState == CheckState.Checked);
                        total += ptc * rProductivity;
                        m2.productivity = Convert.ToString(productivity); m2.p_productivity = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    minRevs = Convert.ToInt32(row.Cells[9].Value);
                    if (ref_minRevs > 0)
                    {
                        ptc = percentage(minRevs, ref_minRevs, minRevsCheck.CheckState == CheckState.Checked);
                        total += ptc * rMinRevs;
                        m2.min_revs = Convert.ToString(minRevs); m2.p_min_revs = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    maxRevs = Convert.ToInt32(row.Cells[10].Value);
                    if (ref_maxRevs > 0)
                    {
                        ptc = percentage(maxRevs, ref_maxRevs, maxRevsCheck.CheckState == CheckState.Checked);
                        total += ptc * rMaxRevs;
                        m2.max_revs = Convert.ToString(maxRevs); m2.p_max_revs = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                try
                {
                    nrOfAxes = Convert.ToInt32(row.Cells[11].Value);
                    if (ref_nrOfAxes > 0)
                    {
                        ptc = percentage(nrOfAxes, ref_nrOfAxes, nrOfAxesCheck.CheckState == CheckState.Checked);
                        total += ptc * rNrOfAxes;
                        m2.nr_of_axes = Convert.ToString(nrOfAxes); m2.p_nr_of_axes = String.Format("{0:n2}", ptc);
                    }
                } catch { }
                workpieceHolder = Convert.ToBoolean(row.Cells[12].Value);
                if (workpieceHolder != (holderCheck.CheckState == CheckState.Checked))
                {
                    ptc = 100;
                    total += ptc * rHolder;
                    m2.holder = workpieceHolder ? "Yes" : "No"; m2.p_holder = String.Format("{0:n2}", ptc);
                }
                row.Cells[13].Value = total;
                m2.TOTAL = String.Format("{0:n2}", total);
                machines.Add(m2);
            }
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
            cmd = getIntCommand(imposeMinSetTime.Text, multi, "SetTime >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxSetTime.Text, multi, "SetTime <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinReliability.Text, multi, "Reliability >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxReliability.Text, multi, "Reliability <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMinPrecision.Text, multi, "Precision >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getFloatCommand(imposeMaxPrecision.Text, multi, "Precision <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsReal += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinProd.Text, multi, "Productivity >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxProd.Text, multi, "Productivity <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinMinRevs.Text, multi, "MinRevolutions >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxMinRevs.Text, multi, "MinRevolutions <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinMaxRevs.Text, multi, "MaxRevolutions >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxMaxRevs.Text, multi, "MaxRevolutions <=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMinNrOfAxes.Text, multi, "NrOfSimultaneousAxes >=");
            if (cmd != "")
            {
                if (cmd[0] == '-') { errorsInt += " " + cmd.Split(' ')[1]; cmd = ""; }
                else multi = true;
            }
            query += cmd;
            cmd = getIntCommand(imposeMaxNrOfAxes.Text, multi, "NrOfSimultaneousAxes <=");
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
                if (imposeHolder.SelectedIndex == 1) cmd = "WorkpieceHolder = 1";
                else if (imposeHolder.SelectedIndex == 2) cmd = "WorkpieceHolder = 0";
                if (cmd != "") cmd = multi ? String.Format(" and {0}", cmd) : String.Format(" {0}", cmd);
                query += cmd;
                query = String.Format("select * from TableMachines" + ((query == "") ? ";" : (" where" + query + ";")));
                //MessageBox.Show(query);
                fillTable(query);
                setModifiedImposed(false);
            }
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
        private void setModified(bool modified)
        {
            modifiedLabel.Text = modified ? "*" : "";
        }

        private void setModifiedImposed(bool modified)
        {
            modifiedLabelImposed.Text = modified ? "*" : "";
        }
        private float readFloat(String text)
        {
            return float.Parse(text);
        }
        private int readInt(String text)
        {
            return int.Parse(text);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.FilterIndex = 1;
            String layout_data = "";
            layout_data += "M:";
            layout_data += priceCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += footprintCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += weightCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += setTimeCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += reliabilityCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += precisionCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += productivityCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += minRevsCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += maxRevsCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += nrOfAxesCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += holderCheck.CheckState == CheckState.Checked ? " 1" : " 0";
            layout_data += "\nR:";
            layout_data += " " + RPrice.Value;
            layout_data += " " + RFootprint.Value;
            layout_data += " " + RWeight.Value;
            layout_data += " " + RSetTime.Value;
            layout_data += " " + RReliability.Value;
            layout_data += " " + RPrecision.Value;
            layout_data += " " + RProductivity.Value;
            layout_data += " " + RMinRevs.Value;
            layout_data += " " + RMaxRevs.Value;
            layout_data += " " + RNrOfAxes.Value;
            layout_data += " " + RWorkpieceHolder.Value;
            layout_data += "\nIL:";
            layout_data += " " + (imposeMinPrice.Text == "" ? "." : imposeMinPrice.Text);
            layout_data += " " + (imposeMinFootprint.Text == ""?"." : imposeMinFootprint.Text);
            layout_data += " " + (imposeMinWeight.Text == "" ? "." : imposeMinWeight.Text);
            layout_data += " " + (imposeMinSetTime.Text == "" ? "." : imposeMinSetTime.Text);
            layout_data += " " + (imposeMinReliability.Text==""?".":imposeMinReliability.Text);
            layout_data += " " + (imposeMinPrecision.Text == ""?"." : imposeMinPrecision.Text);
            layout_data += " " + (imposeMinProd.Text == "" ? "." : imposeMinProd.Text);
            layout_data += " " + (imposeMinMinRevs.Text == "" ? "." : imposeMinMinRevs.Text);
            layout_data += " " + (imposeMinMaxRevs.Text == "" ? "." : imposeMinMaxRevs.Text);
            layout_data += " " + (imposeMinNrOfAxes.Text == "" ? "." : imposeMinNrOfAxes.Text);
            layout_data += "\nIH:";
            layout_data += " " + (imposeMaxPrice.Text == "" ? "." : imposeMaxPrice.Text);
            layout_data += " " + (imposeMaxFootprint.Text == ""?"." : imposeMaxFootprint.Text);
            layout_data += " " + (imposeMaxWeight.Text == "" ? "." : imposeMaxWeight.Text);
            layout_data += " " + (imposeMaxSetTime.Text == "" ? "." : imposeMaxSetTime.Text);
            layout_data += " " + (imposeMaxReliability.Text ==""?".":imposeMaxReliability.Text);
            layout_data += " " + (imposeMaxPrecision.Text == ""?"." : imposeMaxPrecision.Text);
            layout_data += " " + (imposeMaxProd.Text == "" ? "." : imposeMaxProd.Text);
            layout_data += " " + (imposeMaxMinRevs.Text == "" ? "." : imposeMaxMinRevs.Text);
            layout_data += " " + (imposeMaxMaxRevs.Text == "" ? "." : imposeMaxMaxRevs.Text);
            layout_data += " " + (imposeMaxNrOfAxes.Text == "" ? "." : imposeMaxNrOfAxes.Text);
            layout_data += " " + imposeHolder.SelectedIndex;
            sfd.InitialDirectory = System.IO.Path.GetFullPath(
                System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\layouts"));
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                MemoryStream userInput = new MemoryStream();
                System.IO.FileStream fileStream = (System.IO.FileStream)sfd.OpenFile();;
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (String line in layout_data.Split('\n')){
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
                            weightCheck.CheckState = line.Split(' ')[3] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            setTimeCheck.CheckState = line.Split(' ')[4] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            reliabilityCheck.CheckState = line.Split(' ')[5] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            precisionCheck.CheckState = line.Split(' ')[6] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            productivityCheck.CheckState = line.Split(' ')[7] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            minRevsCheck.CheckState = line.Split(' ')[8] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            maxRevsCheck.CheckState = line.Split(' ')[9] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            nrOfAxesCheck.CheckState = line.Split(' ')[10] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            holderCheck.CheckState = line.Split(' ')[11] == "1" ?
                                CheckState.Checked : CheckState.Unchecked;
                            updateCheckBoxes();
                            break;
                        case "R:":
                            try
                            {
                                RPrice.Value = readInt(line.Split(' ')[1]);
                                RFootprint.Value = readInt(line.Split(' ')[2]);
                                RWeight.Value = readInt(line.Split(' ')[3]);
                                RSetTime.Value = readInt(line.Split(' ')[4]);
                                RReliability.Value = readInt(line.Split(' ')[5]);
                                RPrecision.Value = readInt(line.Split(' ')[6]);
                                RProductivity.Value = readInt(line.Split(' ')[7]);
                                RMinRevs.Value = readInt(line.Split(' ')[8]);
                                RMaxRevs.Value = readInt(line.Split(' ')[9]);
                                RNrOfAxes.Value = readInt(line.Split(' ')[10]);
                                RWorkpieceHolder.Value = readInt(line.Split(' ')[11]);
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
                            imposeMinWeight.Text = line.Split(' ')[3] == "." ?
                                "" : line.Split(' ')[3];
                            imposeMinSetTime.Text = line.Split(' ')[4] == "." ?
                                "" : line.Split(' ')[4];
                            imposeMinReliability.Text = line.Split(' ')[5] == "." ?
                                "" : line.Split(' ')[5];
                            imposeMinPrecision.Text = line.Split(' ')[6] == "." ?
                                "" : line.Split(' ')[6];
                            imposeMinProd.Text = line.Split(' ')[7] == "." ?
                                "" : line.Split(' ')[7];
                            imposeMinMinRevs.Text = line.Split(' ')[8] == "." ?
                                "" : line.Split(' ')[8];
                            imposeMinMaxRevs.Text = line.Split(' ')[9] == "." ?
                                "" : line.Split(' ')[9];
                            imposeMinNrOfAxes.Text = line.Split(' ')[10] == "." ?
                                "" : line.Split(' ')[10];
                            break;
                        case "IH:":
                            imposeMaxPrice.Text = line.Split(' ')[1] == "." ?
                                "" : line.Split(' ')[1];
                            imposeMaxFootprint.Text = line.Split(' ')[2] == "." ?
                                "" : line.Split(' ')[2];
                            imposeMaxWeight.Text = line.Split(' ')[3] == "." ?
                                "" : line.Split(' ')[3];
                            imposeMaxSetTime.Text = line.Split(' ')[4] == "." ?
                                "" : line.Split(' ')[4];
                            imposeMaxReliability.Text = line.Split(' ')[5] == "." ?
                                "" : line.Split(' ')[5];
                            imposeMaxPrecision.Text = line.Split(' ')[6] == "." ?
                                "" : line.Split(' ')[6];
                            imposeMaxProd.Text = line.Split(' ')[7] == "." ?
                                "" : line.Split(' ')[7];
                            imposeMaxMinRevs.Text = line.Split(' ')[8] == "." ?
                                "" : line.Split(' ')[8];
                            imposeMaxMaxRevs.Text = line.Split(' ')[9] == "." ?
                                "" : line.Split(' ')[9];
                            imposeMaxNrOfAxes.Text = line.Split(' ')[10] == "." ?
                                "" : line.Split(' ')[10];
                            try
                            {
                                imposeHolder.SelectedIndex = readInt(line.Split(' ')[11]);
                            }
                            catch {
                                MessageBox.Show("The WorpieceHolder Imposed Limit couldn't load, so it was set to the default value.");
                            imposeHolder.SelectedIndex = 1;
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
                              + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}\n", "MachineID", "Model",
                              "Price", "Footprint", "Weight", "SetTime", "Reliability", "Precision", "Productivity",
                              "MinRevs", "MaxRevs", "NrOfAxes", "Holder", "Total");
                            export_data += String.Format("\n{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                              + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}\n", "R", "---",
                                rs[0], rs[1], rs[2], rs[3], rs[4], rs[5], rs[6],
                              rs[7], rs[8], rs[9], rs[10], "---");

                            foreach (Machine m in machines)
                            {
                                export_data += "\n------------|------------|------------|------------|------------|" +
                                "------------|------------|------------|------------|------------|------------|" +
                                "------------|------------|------------|\n";

                                export_data += String.Format("\n{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                              + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|\n", m.ID, m.MODEL,
                              (m.price == "---" ? m.price : String.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C}", Convert.ToDouble(m.price))),
                              m.footprint, m.weight, m.set_time, m.reliability, m.precision, m.productivity,
                              m.min_revs, m.max_revs, m.nr_of_axes, m.holder);
                                export_data += "\n------------|------------|------------|------------|------------|" +
                                "------------|------------|------------|------------|------------|------------|" +
                                "------------|------------|------------|\n";
                                export_data += String.Format("\n{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|"
                              + "{7,12}|{8,12}|{9,12}|{10,12}|{11,12}|{12,12}|{13,12}\n", "---", "---",
                              m.p_price, m.p_footprint, m.p_weight, m.p_set_time, m.p_reliability, m.p_precision, m.p_productivity,
                              m.p_min_revs, m.p_max_revs, m.p_nr_of_axes, m.p_holder, m.TOTAL);
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

        private void weightCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void setTimeCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void reliabilityCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void precisionCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void productivityCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void minRevCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void maxRevCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void nrOfAxesCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void holderCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
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

        private void imposeMinWeight_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxWeight_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinSetTime_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxSetTime_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinReliability_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxReliabiliry_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinPrecision_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxPrecision_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinProd_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxProd_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinMinRevs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxMinRevs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinMaxRevs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxMaxRevs_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMinNrOfAxes_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeMaxNrOfAxes_TextChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }

        private void imposeHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            setModifiedImposed(true);
        }
    }
}
