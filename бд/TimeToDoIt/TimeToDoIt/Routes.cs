using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Routes
    {
        public int route_id;
        public string route_name;
        public string depature_time;
        public string arrival_time;
        public int train_id;
        

        public Routes()
        {
            route_id = 0;
            route_name = "";
            depature_time = "";
            arrival_time = "";
            train_id = 0;
        }

        public Routes(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                route_id = Convert.ToInt32(val[0]);
                route_name = val[1];
                depature_time = val[2];
                arrival_time = val[3];
                train_id = Convert.ToInt32(val[4]);
            }
        }
    }
}
