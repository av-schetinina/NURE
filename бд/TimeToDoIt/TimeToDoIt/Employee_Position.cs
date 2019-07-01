using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Employee_Position
    {
        public int empl_pos;
        public int employee_id;
        public int position_id;


        public Employee_Position() {
            empl_pos = 0;
            employee_id = 0;
            position_id = 0;
        }

        public Employee_Position(string info) {
            if (info != null && info != "") {
                string[] val = info.Split('!');
                empl_pos = Convert.ToInt32(val[0]);
                employee_id = Convert.ToInt32(val[1]);
                position_id = Convert.ToInt32(val[2]);
            }
        }
    }
}
