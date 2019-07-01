using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Halt
    {
        public int halt_id;
        public int route_id;
        public int train_id;
        public string depture_time;

        public Halt() {
            halt_id = 0;
            route_id = 0;
            train_id = 0;
            depture_time = "";
        }

        public Halt(string info) {
            if (info != null && info != "") {
                string[] val = info.Split('!');
                halt_id = Convert.ToInt32(val[0]);
                route_id = Convert.ToInt32(val[1]);
                depture_time = val[2];
            }
        }

    }
}
