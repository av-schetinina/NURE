using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Train
    {
        public int train_id;
        public int train_number;

        public Train() {
            train_id = 0;
            train_number = 0;
        }

        public Train(string info) {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                train_id = Convert.ToInt32(val[0]);
                train_number = Convert.ToInt32(val[1]);
            }
        }
    }
}
