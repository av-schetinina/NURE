using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Train_Composition
    {
        public int composition_id;
        public int train_id;
        public int carriage_id;

        public Train_Composition() {
            composition_id = 0;
            train_id = 0;
            carriage_id = 0;
        }

        public Train_Composition(string info) {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                composition_id = Convert.ToInt32(val[0]);
                train_id = Convert.ToInt32(val[1]);
                carriage_id = Convert.ToInt32(val[2]);
            }
        }
    }
}
