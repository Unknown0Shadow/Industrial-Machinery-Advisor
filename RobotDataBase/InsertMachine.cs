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
    public partial class InsertMachine : Form
    {
        private static InsertMachine im;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private InsertMachine()
        {
            InitializeComponent();
        }
        public static InsertMachine getForm()
        {
            if (im == null)
            {
                im = new InsertMachine();
            }
            return im;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            float price, footprint, weight, precision;
            int setTime, reliability, productivity, minRevs, maxRevs, nrOfAxes;
            Boolean workpieceHolder, submit = true;
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
            try { weight = readFloat(weightBox.Text); values = String.Format("{0} {1},", values, weight); }
            catch (FormatException)
            {
                if (weightBox.Text != "") errorsReal += " [weight]";
                else nulls += " [weight]";
                values = String.Format("{0} NULL,", values);
            }
            try { setTime = readInt(setTimeBox.Text); values = String.Format("{0} {1},", values, setTime); }
            catch (FormatException)
            {
                if (setTimeBox.Text != "") errorsInt += " [set time]";
                else nulls += " [set time]";
                values = String.Format("{0} NULL,", values);
            }
            try { reliability = readInt(reliabilityBox.Text); values = String.Format("{0} {1},", values, reliability); }
            catch (FormatException)
            {
                if (reliabilityBox.Text != "") errorsInt+= " [reliability]";
                else nulls += " [reliability]";
                values = String.Format("{0} NULL,", values);
            }
            try { precision = readFloat(precisionBox.Text); values = String.Format("{0} {1},", values, precision); }
            catch (FormatException)
            {
                if (precisionBox.Text != "") errorsReal += " [precision]";
                else nulls += " [precision]";
                values = String.Format("{0} NULL,", values);
            }
            try { productivity = readInt(productivityBox.Text); values = String.Format("{0} {1},", values, productivity); }
            catch (FormatException)
            {
                if (productivityBox.Text != "") errorsInt += " [productivity]";
                else nulls += " [productivity]";
                values = String.Format("{0} NULL,", values);
            }
            try { minRevs = readInt(minRevsBox.Text); values = String.Format("{0} {1},", values, minRevs); }
            catch (FormatException)
            {
                if (minRevsBox.Text != "") errorsInt += " [min revolutions]";
                else nulls += " [min revolutions]";
                values = String.Format("{0} NULL,", values);
            }
            try { maxRevs = readInt(maxRevsBox.Text); values = String.Format("{0} {1},", values, maxRevs); }
            catch (FormatException)
            {
                if (maxRevsBox.Text != "") errorsInt += " [max revolutions]";
                else nulls += " [max revolutions]";
                values = String.Format("{0} NULL,", values);
            }
            try { nrOfAxes = readInt(nrOfAxesBox.Text); values = String.Format("{0} {1},", values, nrOfAxes); }
            catch (FormatException)
            {
                if (nrOfAxesBox.Text != "") errorsInt += " [nr of simultaneous axes]";
                else nulls += " [nr of simultaneous axes]";
                values = String.Format("{0} NULL,", values);
            }
            workpieceHolder = workpieceHolderBox.Checked;
            values = String.Format("{0} {1},", values, workpieceHolder?1:0);
            if (errorsInt.Length > 0) errors = String.Format("The following must be whole number:{0}.\n", errorsInt);
            if (errorsReal.Length > 0) errors = String.Format("{0}The following must be real number:{1}", errors, errorsReal);
            if (errors.Length > 0)
            {
                MessageBox.Show(errors, "Format error");
                submit = false;
            }
            else{
                submit = true;
                if(nulls.Length > 0){
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
                String cmd = "INSERT INTO TableMachines (Model, Price, Footprint, Weight, SetTime, Reliability, Precision, Productivity, MinRevolutions, MaxRevolutions, NrOfSimultaneousAxes, WorkpieceHolder) VALUES(" + values.Remove(values.Length-1) + ");";

                String cmdCheck = String.Format(
                    "SELECT COUNT(*) FROM TableMachines WHERE Model = '{0}';",
                    model
                );
                if (isUnique(cmdCheck))
                {
                    insertDB(cmd);
                    UpdateMachinesWindow.getForm().fillTable();
                    im.Close();
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            im = null;
        }
    }
}
