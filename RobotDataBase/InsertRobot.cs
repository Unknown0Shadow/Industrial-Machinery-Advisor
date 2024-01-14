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
    public partial class InsertRobot : Form
    {
        private static InsertRobot ir;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private InsertRobot()
        {
            InitializeComponent();
        }
        public static InsertRobot getForm()
        {
            if (ir == null)
            {
                ir = new InsertRobot();
            }
            return ir;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ir = null;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            float price, footprint, accuracy, repeatability, weight;
            int dom, mjv, wx, wy, wz, maxLift, nrOfInputs, nrOfOutputs;
            Boolean offline, online, auto, submit = true;
            String errorsInt = "", errorsReal = "", errors = "";
            String nulls = "";
            String values = "";
            String model = "";
            model = modelBox.Text;
            if (model == "")
            {
                MessageBox.Show("Model cannot be null, and must be unique!");
                return;
            }
            values = String.Format("{0} '{1}',", values, model);
            try { price = readFloat(priceBox.Text); values = String.Format("{0} {1},", values, price); }
            catch (FormatException)
            {
                if (priceBox.Text != "") errorsReal += " [price]";
                else nulls += " [price]";
                values = String.Format("{0} NULL,", values);
            }
            try { footprint = readFloat(footprintBox.Text); values = String.Format("{0} {1},", values, footprint); }
            catch (FormatException)
            {
                if (footprintBox.Text != "") errorsReal += " [footprint]";
                else nulls += " [footprint]";
                values = String.Format("{0} NULL,", values);
            }
            try { dom = readInt(domBox.Text); values = String.Format("{0} {1},", values, dom); }
            catch (FormatException)
            {
                if (domBox.Text != "") errorsInt += " [deg. of mobility]";
                else nulls += " [deg. of mobility]";
                values = String.Format("{0} NULL,", values);
            }
            try { mjv = readInt(mjvBox.Text); values = String.Format("{0} {1},", values, mjv); }
            catch (FormatException)
            {
                if (mjvBox.Text != "") errorsInt += " [max joint velocity]";
                else nulls += " [max joint velocity]";
                values = String.Format("{0} NULL,", values);
            }
            try {
                wx = readInt(workspaceBox.Text.Split('x')[0]); wy = readInt(workspaceBox.Text.Split('x')[1]);
                wz = readInt(workspaceBox.Text.Split('x')[2]);
                values = String.Format("{0} '{1} x {2} x {3}',", values, wx, wy, wz); }
            catch
            {
                if (workspaceBox.Text != "") errorsInt += " [workspace]";
                else nulls += " [workspace]";
                values = String.Format("{0} NULL,", values);
            }
            try { accuracy = readFloat(accuracyBox.Text); values = String.Format("{0} {1},", values, accuracy); }
            catch (FormatException)
            {
                if (accuracyBox.Text != "") errorsReal += " [accuracy]";
                else nulls += " [accuracy]";
                values = String.Format("{0} NULL,", values);
            }
            try { repeatability = readFloat(repeatabilityBox.Text); values = String.Format("{0} {1},", values, repeatability); }
            catch (FormatException)
            {
                if (repeatabilityBox.Text != "") errorsReal += " [repeatability]";
                else nulls += " [repeatability]";
                values = String.Format("{0} NULL,", values);
            }
            try { weight = readFloat(weightBox.Text); values = String.Format("{0} {1},", values, weight); }
            catch (FormatException)
            {
                if (weightBox.Text != "") errorsReal += " [weight]";
                else nulls += " [weight]";
                values = String.Format("{0} NULL,", values);
            }
            try { maxLift = readInt(maxLiftBox.Text); values = String.Format("{0} {1},", values, maxLift); }
            catch (FormatException)
            {
                if (maxLiftBox.Text != "") errorsInt += " [maxLift]";
                else nulls += " [maxLift]";
                values = String.Format("{0} NULL,", values);
            }
            try { nrOfInputs = readInt(nrOfInputsBox.Text); values = String.Format("{0} {1},", values, nrOfInputs); }
            catch (FormatException)
            {
                if (nrOfInputsBox.Text != "") errorsInt += " [nrOfInputs]";
                else nulls += " [nrOfInputs]";
                values = String.Format("{0} NULL,", values);
            }
            try { nrOfOutputs = readInt(nrOfOutputsBox.Text); values = String.Format("{0} {1},", values, nrOfOutputs); }
            catch (FormatException)
            {
                if (nrOfOutputsBox.Text != "") errorsInt += " [nrOfOutputs]";
                else nulls += " [nrOfOutputs]";
                values = String.Format("{0} NULL,", values);
            }
            offline = offlineCheck.Checked;
            values = String.Format("{0} {1},", values, offline ? 1 : 0);
            online = onlineCheck.Checked;
            values = String.Format("{0} {1},", values, online ? 1 : 0);
            auto = autoCheck.Checked;
            values = String.Format("{0} {1},", values, auto ? 1 : 0);
            
            if (errorsInt.Length > 0) errors = String.Format("The following must be whole number:{0}.\n", errorsInt);
            if (errorsReal.Length > 0) errors = String.Format("{0}The following must be real number:{1}", errors, errorsReal);
            if (errors.Length > 0)
            {
                MessageBox.Show(errors, "Format error");
                submit = false;
            }
            else
            {
                submit = true;
                if (nulls.Length > 0)
                {
                    DialogResult dr = MessageBox.Show(String.Format("The following values are empty:{0}, do you wish to submit anyway?", nulls), "Warning", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        submit = true;
                    }
                    else
                    {
                        submit = false;
                    }
                }
            }
            if (submit)
            {
                String cmd = "INSERT INTO TableRobots (Model, Price, Footprint, DegreesOfMobility, MaxJointVelocity, Workspace, Accuracy, Repeatability, Weight, MaxLift, NrOfInputs, NrOfOutputs, OfflineProgramming, OnlineProgramming, AutoProgramming) VALUES(" + values.Remove(values.Length - 1) + ");";

                String cmdCheck = String.Format(
                    "SELECT COUNT(*) FROM TableRobots WHERE Model = '{0}';",
                    model
                );
                if (isUnique(cmdCheck))
                {
                    insertDB(cmd);
                    UpdateRobotsWindow.getForm().fillTable();
                    ir.Close();
                }
                else
                {
                    MessageBox.Show(String.Format(
                        "Model name <{0}> already exists!", model
                    ));
                }
            }
        }
        private bool isUnique(String query)
        {
            sqlCon.Open();
            SqlCommand sqlQuery = new SqlCommand(query, sqlCon);
            Int32 count = (Int32)sqlQuery.ExecuteScalar(); ;
            sqlCon.Close();
            if (count > 0)
            {
                return false;
            }
            return true;
        }
        private void insertDB(String cmd)
        {
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand(cmd, sqlCon);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        private float readFloat(String text)
        {
            return float.Parse(text);
        }
        private int readInt(String text)
        {
            return int.Parse(text);
        }
    }
}
