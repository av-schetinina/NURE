using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Train_Staff
    {
        public int staff_id;
        public int train_id;
        public int employee_id;

        public Train_Staff()
        {
            staff_id = 0;
            train_id = 0;
            employee_id = 0;
        }

        public Train_Staff(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                staff_id = Convert.ToInt32(val[0]);
                train_id = Convert.ToInt32(val[1]);
                employee_id = Convert.ToInt32(val[2]);
            }
        }
    }
}
