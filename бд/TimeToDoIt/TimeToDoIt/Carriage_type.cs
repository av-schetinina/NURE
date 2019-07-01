using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Carriage_type
    {
        public int type_id;
        public string type_name;
        public int sits_count;


        public Carriage_type() {
            type_id = 0;
            type_name = "";
            sits_count = 0;
        }

        public Carriage_type(string info) {
            if (info != null && info != "") {
                string[] val = info.Split('!');
                type_id = Convert.ToInt32(val[0]);
                type_name = val[1];
                sits_count = Convert.ToInt32(val[2]);
            }
        }
    }
}
