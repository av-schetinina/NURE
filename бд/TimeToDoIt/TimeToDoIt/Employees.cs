using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToDoIt
{
    class Employees
    {

        public int employee_id;
        public string first_name;
        public string second_name;
        public string telephone;
        public string hire_date;

        public Employees() {
            employee_id = 0;
            first_name = "";
            second_name = "";
            telephone = "";
            hire_date = "";
        }

        public Employees(string info) {
            if (info != null && info != "") {
                string[] val = info.Split('!');
                employee_id = Convert.ToInt32(val[0]);
                first_name = val[1];
                second_name = val[2];
                telephone = val[3];
                hire_date = val[4];
            }
        }
    }
}
