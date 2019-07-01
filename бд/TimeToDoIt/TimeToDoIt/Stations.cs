using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Stations
    {
        public int station_id;
        public string station_name;
        public string stop_time;


        public Stations() {
            station_id = 0;
            station_name = "";
            stop_time = "";
        }

        public Stations(string info) {
            if (info != null && info != "") {
                string[] val = info.Split('!');
                station_id = Convert.ToInt32(val[0]);
                station_name = val[1];
                stop_time = val[2];
            }
        }
    }
}
