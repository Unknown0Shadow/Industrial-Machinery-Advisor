using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDataBase
{
    public class Robot
    {
        // ID, Model, price, footprint, degreesofmobility, maxjointvelocity, workspace
        // accuracy, repeatability, weight, maxlift, nrofinputs, nrofoutputs
        // offline, online, auto
        public String ID, MODEL, price, footprint, dom, mjv, workspace, accuracy;
        public String repeatability, weight, max_lift, nr_of_inputs, nr_of_outputs;
        public String offline, online, auto, TOTAL;
        public String p_price, p_footprint, p_dom, p_mjv, p_workspace, p_accuracy;
        public String p_repeatability, p_weight, p_max_lift, p_nr_of_inputs, p_nr_of_outputs;
        public String p_offline, p_online, p_auto;
        public Robot()
        {
            ID = "ID"; MODEL = "MODEL";
            price = footprint = dom = mjv = workspace = accuracy = "---";
            repeatability = weight = max_lift = nr_of_inputs = nr_of_outputs = "---";
            offline = online = auto = "No";
            TOTAL = "0";
            
            p_price = p_footprint = p_dom = p_mjv = p_workspace = p_accuracy = "---";
            p_repeatability = p_weight = p_max_lift = p_nr_of_inputs = p_nr_of_outputs = "---";
            p_offline = p_online = p_auto = "---";
        }
    }
}
