using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Positions
    {
        public int position_id;
        public string position_name;
        public int salary;


        public Positions() {
            position_id = 0;
            position_name = "";
            salary = 0;
        }

        public Positions(string info) {
            if (info != null && info != "") {
                string[] val = info.Split('!');
                position_id = Convert.ToInt32(val[0]);
                position_name = val[1];
                salary = Convert.ToInt32(val[2]);
            }
        }
    }
}
