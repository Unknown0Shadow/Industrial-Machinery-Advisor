using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDataBase
{
    public class Machine
    {
        // ID, Model, price, footprint, weight, settime, reliability, precision
        // productivity, minrevs, maxrevs, nrofaxes, holder, total
        public String ID, MODEL, price, footprint, weight, set_time, reliability, precision;
        public String productivity, min_revs, max_revs, nr_of_axes, holder, TOTAL;
        public String p_price, p_footprint, p_weight, p_set_time, p_reliability,p_precision;
        public String p_productivity,p_min_revs, p_max_revs, p_nr_of_axes, p_holder;
        public Machine()
        {
            ID = "ID"; MODEL = "MODEL";
            set_time = reliability = productivity = min_revs = max_revs = nr_of_axes = "---";
            price = footprint = weight = precision = "---";
            holder = "No"; TOTAL = "0";
            p_price = p_footprint = p_weight = p_set_time = p_reliability = p_precision = "---";
            p_productivity = p_min_revs = p_max_revs = p_nr_of_axes = p_holder = "---";
        }
    }
}
