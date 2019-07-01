using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Carriages
    {
        public int carriage_id;
        public string carriage_number;
        public int type_id;

        public Carriages() {
            carriage_id = 0;
            carriage_number = "";
            type_id = 0;
        }

        public Carriages(string info) {

            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                carriage_id = Convert.ToInt32(val[0]);
                carriage_number = val[1];
                type_id = Convert.ToInt32(val[2]);
            }
        }
    }
}
