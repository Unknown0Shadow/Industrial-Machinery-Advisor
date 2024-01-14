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
    public partial class UpdateMachine : Form
    {
        private static UpdateMachine um;
        private static String connection = "";
        // connection is a string with the path to the Database1.mdf file in this form:  Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
        private static SqlConnection sqlCon = new SqlConnection(connection);
        private UpdateMachine()
        {
            InitializeComponent();
        }
        public static UpdateMachine getForm(int ID, Dictionary<string ,string> data)
        {
            if (um == null)
            {
                um = new UpdateMachine();
            }
            um.fillInputs(ID, data);
            return um;
        }
        private void fillInputs(int ID, Dictionary<string, string> data)
        {
            this.Text= String.Format("Edit Machine {0}", ID);
            modelBox.Text = data["model"];
            priceBox.Text = data["price"];
            footprintBox.Text = data["footprint"];
            weightBox.Text = data["weight"];
            setTimeBox.Text = data["setTime"];
            reliabilityBox.Text = data["reliability"];
            precisionBox.Text = data["precision"];
            productivityBox.Text = data["productivity"];
            minRevsBox.Text = data["minRevs"];
            maxRevsBox.Text = data["maxRevs"];
            nrOfAxesBox.Text = data["nrOfAxes"];
            workpieceHolderBox.CheckState = (data["holder"] == "Yes") ?
                CheckState.Checked : CheckState.Unchecked;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            float price, footprint, weight, precision;
            int setTime, reliability, productivity, minRevs, maxRevs, nrOfAxes;
            Boolean workpieceHolder;// submit = true;
            String errorsInt = "", errorsReal = "", errors = "";
            String nulls = "";
            String values = "";
            String model = "";
            values+= this.Text.Split(' ')[this.Text.Split(' ').Length - 1] + ",";
            model = modelBox.Text;
            if (model == "")
            {
                MessageBox.Show("Model cannot be null, and must be unique!");
                return;
            }
            values = String.Format("{0} {1},", values, model);
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
                if (reliabilityBox.Text != "") errorsInt += " [reliability]";
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
            values = String.Format("{0} {1},", values, workpieceHolder ? 1 : 0);
            if (errorsInt.Length > 0) errors = String.Format("The following must be whole number:{0}.\n", errorsInt);
            if (errorsReal.Length > 0) errors = String.Format("{0}The following must be real number:{1}", errors, errorsReal);
            if (errors.Length > 0)
            {
                MessageBox.Show(errors, "Format error");
                //submit = false;
            }
            else
            {
                if (nulls.Length > 0)
                {
                    DialogResult dr = MessageBox.Show(String.Format("The following values are empty:{0}, do you wish to submit anyway?", nulls), "Warning", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        String[] vls = null;
                        vls = values.Remove(values.Length - 1).Split(new String[] { ", " },
                            StringSplitOptions.None);

                        DialogResult dr2 = MessageBox.Show(String.Format(
                            "ID:{0}\nModel:{1}\nPrice:{2}\nFootprint:{3}\n" +
                            "Weight:{4}\nSetTime:{5}\nReliability:{6}\nPrecision:{7}\n" +
                            "Productivity:{8}\nMinRevs:{9}\nMaxRevs:{10}\nNrOfAxes:{11}\n" +
                            "Holder:{12}", vls), "Update?", MessageBoxButtons.YesNo);
                        if (dr2 == DialogResult.Yes)
                        {
                            String cmdUpdate = String.Format("UPDATE TableMachines SET Model = '{" +
                            "1}', Price = {2}, Footprint = {3}, Weight = {4}, SetTime = {5" +
                            "}, Reliability = {6}, Precision = {7}, Productivity = {8}, Mi" +
                            "nRevolutions = {9}, MaxRevolutions = {10}, NrOfSimultaneousAxe" +
                            "s = {11}, WorkpieceHolder = {12} WHERE MachineID = {0}", vls);
                            String cmdCheck = String.Format(
                                "SELECT COUNT(*) FROM TableMachines WHERE Model = '{0}' AND"+
                                " MachineID != {1};",
                                model, vls[0]
                            );
                            if (isUnique(cmdCheck))
                            {
                                updateDB(cmdUpdate);
                                UpdateMachinesWindow.getForm().fillTable();
                                um.Close();
                            }
                            else
                            {
                                MessageBox.Show(String.Format(
                                    "Model name <{0}> already exists!", model
                                    ));
                            }
                            //String query = String.Format("IF NOT EXISTS (SELECT * FROM "+
                            //    "TableMachines WHERE Model = '{0}') BEGIN {1} END ELSE "+
                            //    "BEGIN RAISERROR('Model \"%s\" already exists.', 16, 1, '{0}"+
                            //    "') END", model, cmdUpdate);
                            
                            
                            //MessageBox.Show(cmd);
                            
                        }
                    }
                }
            }

        }
        private bool isUnique(String query)
        {
            sqlCon.Open();
            SqlCommand sqlQuery = new SqlCommand(query, sqlCon);
            Int32 count = (Int32) sqlQuery.ExecuteScalar(); ;
            sqlCon.Close();
            if (count > 0)
            {
                return false;
            }
            return true;
        }
        private void updateDB(String query)
        {
            sqlCon.Open();
            SqlCommand sqlQuery = new SqlCommand(query, sqlCon);
            sqlQuery.ExecuteNonQuery();
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
            um = null;
        }
    }
}
