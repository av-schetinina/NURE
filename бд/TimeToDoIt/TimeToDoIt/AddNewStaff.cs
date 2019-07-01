using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TimeToDoIt
{
    public partial class AddNewStaff : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<Employee_Position> employee_positions = new List<Employee_Position>();
        List<Employees> employees = new List<Employees>();
        List<Positions> positions = new List<Positions>();
        Regex phone = new Regex(@"\b\d{10}\b");
        Regex names = new Regex(@"\b(\w+?)\b");
        Regex salary = new Regex(@"\b\d{3,}\b");
        Regex date = new Regex(@"\b\d{1,2}\/\d{1,2}\/\d{4}\b");
        

        void LoadData()
        {
            employees.Clear();
            employee_positions.Clear();
            positions.Clear();
            db.Execute<Employee_Position>(ref stp, "Select * from employee_positions", ref employee_positions);
            db.Execute<Employees>(ref stp, "Select * from employee", ref employees);
            db.Execute<Positions>(ref stp, "Select * from positions", ref positions);
        }

        public AddNewStaff()
        {
            InitializeComponent();
        }

        private void AddNewStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if ((tbFirstName.Text.Trim().ToString() != "") &&
                (tbSecondName.Text.Trim().ToString() != "") &&
                (tbTelephone.Text.Trim().ToString() != "") &&
                (tbSalary.Text.Trim().ToString() != "") &&
                (tbPositionName.Text.Trim().ToString() != ""))
            {
                    if (Regex.IsMatch(tbFirstName.Text.Trim().ToString(), names.ToString()) &&
                          Regex.IsMatch(tbSecondName.Text.Trim().ToString(), names.ToString()) &&
                          Regex.IsMatch(tbTelephone.Text.Trim().ToString(), phone.ToString()) &&
                          Regex.IsMatch(tbSalary.Text.Trim().ToString(), salary.ToString()) &&
                          Regex.IsMatch(tbPositionName.Text.Trim().ToString(), names.ToString()))
                    {
                        if (dtpHireDate.Value.Year < 2019)
                        {

                            int position_id = (positions[positions.Count - 1].position_id) + 1;
                            int employee_id = (employees[employees.Count - 1].employee_id) + 1;
                            int emp_pos_id = (employee_positions[employee_positions.Count - 1].empl_pos) + 1;

                            string command_position = "insert into positions(position_id, position_name, salary) values(" + position_id.ToString() + ",'" + tbPositionName.Text.Trim().ToString() + "'," + tbSalary.Text.Trim().ToString() + ")";
                            db.ExecuteNonQuery(ref stp, command_position);

                            string command_employee = "insert into employee(employee_id, first_name, last_name, telephone, hire_date) values(" + employee_id.ToString() + ",'" + tbFirstName.Text.Trim().ToString() + "','" + tbSecondName.Text.Trim().ToString() + "','" + tbTelephone.Text.Trim().ToString() + "','" + dtpHireDate.Value.Day.ToString() + '-' + dtpHireDate.Value.Month.ToString() + '-' + dtpHireDate.Value.Year.ToString() + "')";
                            db.ExecuteNonQuery(ref stp, command_employee);

                            string command_employee_position = "insert into employee_positions(id_ep, employee_id, position_id) values(" + emp_pos_id.ToString() + "," + employee_id.ToString() + "," + position_id.ToString() + ")";
                            db.ExecuteNonQuery(ref stp, command_employee_position);

                            if (MessageBox.Show("Запись добавлена. Номер сотрудника " + employee_id.ToString() + "!", "Dialog", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите дату верно!", "Dialog", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля правильно!", "Dialog", MessageBoxButtons.OK);
                    }
            }
            else
            {
                MessageBox.Show("Заполните все поля!","Dialog",MessageBoxButtons.OK);
            }
        }
    }
}
