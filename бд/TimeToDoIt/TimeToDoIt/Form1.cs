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
    public partial class MainForm : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        Random randNumber = new Random();
        List<Train> trains = new List<Train>();
        List<Carriage_type> carriage_types = new List<Carriage_type>();
        List<Carriages> carriages = new List<Carriages>();
        List<Employee_Position> employee_positions  = new List<Employee_Position>();
        List<Employees> employees = new List<Employees>();
        List<Halt> halts = new List<Halt>();
        List<Positions> positions = new List<Positions>();
        List<Routes> routes = new List<Routes>();
        List<Routes> routes_distinct = new List<Routes>();
        List<Stations> stations = new List<Stations>();
        List<Train_Composition> train_compositions = new List<Train_Composition>();
        List<Train_Staff> train_staffs = new List<Train_Staff>();
        Regex numbers = new Regex(@"\b\d{1,9}\b");
        Regex dateTime = new Regex(@"\b\d{1,2}\:\d{1,2}\b");
        Regex words = new Regex(@"\b(\w+?)\b");
        Regex names = new Regex(@"\b(\w+?)\s{1}(\w+?)\b");
        Random rnd = new Random();
        int current_row = 0, current_cell = 0;


        void ShowFromDataGridView(int number)
        {
            int temp = 0;
            current_row = number;
            for (int i = 0; i < train_compositions.Count; i++)
            {
                if (train_compositions[i].train_id == number)
                {
                    //if (Regex.IsMatch(train_compositions[i].carriage_id.ToString(), numbers.ToString(), RegexOptions.IgnoreCase)) { 
                        tbCarriageNumber.Text = train_compositions[i].carriage_id.ToString();
                    //}
                    temp = Convert.ToInt32(train_compositions[i].carriage_id);
                    break;
                }
            }
            for (int i = 0; i < carriages.Count; i++)
            {
                if (Convert.ToInt32(carriages[i].carriage_id) == temp)
                {
                    temp = Convert.ToInt32(carriages[i].type_id);
                    break;
                }
            }
            for (int i = 0; i < carriage_types.Count; i++)
            {
                if (Convert.ToInt32(carriage_types[i].type_id) == temp)
                {
                    tbCarriageType.Text = carriage_types[i].type_name.ToString();
                    break;
                }
            }
            temp = 0;
            for (int i = 0; i < train_staffs.Count; i++)
            {
                if(train_staffs[i].train_id == number)
                {
                    tbStaffNumber.Text = train_staffs[i].employee_id.ToString();
                    temp = Convert.ToInt32(train_staffs[i].employee_id);
                    break;
                }
            }
            for (int i = 0; i < employees.Count; i++)
            {
                if (Convert.ToInt32(employees[i].employee_id) == temp)
                {
                    //if (Regex.IsMatch(employees[i].first_name.ToString() + " " + employees[i].second_name.ToString(), names.ToString(),RegexOptions.IgnoreCase)) {
                        tbStaffName.Text = employees[i].first_name.ToString() + " " + employees[i].second_name.ToString();
                    //}
                    break;
                }
            }
            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].train_id == number)
                {
                    //if (Regex.IsMatch(routes[i].arrival_time.ToString(), dateTime.ToString(), RegexOptions.IgnoreCase)) {
                        tbRouteArrive.Text = routes[i].arrival_time.ToString();
                    //}
                    tbRouteDeparture.Text = routes[i].depature_time.ToString();
                    //if (Regex.IsMatch(routes[i].route_name.ToString(), words.ToString(), RegexOptions.IgnoreCase)) {
                        tbRouteName.Text = routes[i].route_name.ToString();
                    //}
                }
            }
        }

        void LoadData() {
            cbCarriage.Items.Clear();
            cbStaff.Items.Clear();
            cbTrain.Items.Clear();
            trains.Clear();
            carriages.Clear();
            carriage_types.Clear();
            employees.Clear();
            employee_positions.Clear();
            halts.Clear();
            positions.Clear();
            routes.Clear();
            routes_distinct.Clear();
            stations.Clear();
            train_compositions.Clear();
            train_staffs.Clear();
            db.Execute<Train>(ref stp, "Select * from trains", ref trains);
            db.Execute<Carriage_type>(ref stp, "Select * FROM carriage_types", ref carriage_types);
            db.Execute<Carriages>(ref stp, "Select * from carriages", ref carriages);
            db.Execute<Employee_Position>(ref stp, "Select * from employee_positions", ref employee_positions);
            db.Execute<Employees>(ref stp, "Select * from employee", ref employees);
            db.Execute<Halt>(ref stp, "Select * from halt", ref halts);
            db.Execute<Positions>(ref stp, "Select * from positions", ref positions);
            db.Execute<Routes>(ref stp, "Select * from routes", ref routes);
            db.Execute<Routes>(ref stp, "Select distinct * from routes", ref routes_distinct);
            db.Execute<Stations>(ref stp, "Select * from stations", ref stations);
            db.Execute<Train_Composition>(ref stp, "Select * from train_composition", ref train_compositions);
            db.Execute<Train_Staff>(ref stp, "Select * from train_staff", ref train_staffs);
            
        }

        void ShowData() {
            for (int i = 0; i < carriage_types.Count; i++)
            {
                cbCarriage.Items.Add(carriage_types[i].type_name);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                cbStaff.Items.Add(employees[i].first_name + " " + employees[i].second_name);
            }

            for (int i = 0; i < routes_distinct.Count; i++)
            {
                cbTrain.Items.Add(routes_distinct[i].route_name);
            }

            cbCarriage.SelectedIndex = 0;
            cbStaff.SelectedIndex = 0;
            cbTrain.SelectedIndex = 0;

            dgvMain.Rows.Clear();
            if (trains.Count != 0)
            {
                for (int i = 0; i < trains.Count; ++i)
                {
                    dgvMain.Rows.Add(trains[i].train_id, trains[i].train_number);
                }
            }
            else
                MessageBox.Show("Что-то пошло не так. Возможно таблица пуста, либо не существует!", "Dialog", MessageBoxButtons.OK);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }
        

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCarriageNumber.Text = "";
            tbCarriageType.Text = "";
            tbRouteArrive.Text = "";
            tbRouteDeparture.Text = "";
            tbRouteName.Text = "";
            tbStaffName.Text = "";
            tbStaffNumber.Text = "";
            current_cell = dgvMain.CurrentRow.Index;
            ShowFromDataGridView(Convert.ToInt32(dgvMain.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnAdditing_Click(object sender, EventArgs e)
        {
            if (btnAdditing.Text == "Править")
            {
                tbCarriageNumber.ReadOnly = false;
                tbRouteArrive.ReadOnly = false;
                tbRouteDeparture.ReadOnly = false;
                tbRouteName.ReadOnly = false;
                tbStaffNumber.ReadOnly = false;
                dgvMain.CurrentCell = dgvMain.Rows[current_cell].Cells[0];
                btnAdditing.Text = "Сохранить";
                dgvMain.Enabled = false;
                btnAdditing.Enabled = false;
                //MessageBox.Show(current_row.ToString(), "", MessageBoxButtons.OK);
                //string[] val = tbRouteArrive.Text.Trim().ToString().Split(':');
                //MessageBox.Show(int.Parse(val[0]).ToString() + "-" + int.Parse(val[1]).ToString(), "",MessageBoxButtons.OK);
            }
            else
            {
                tbCarriageNumber.ReadOnly = true;
                tbRouteArrive.ReadOnly = true;
                tbRouteDeparture.ReadOnly = true;
                tbRouteName.ReadOnly = true;
                tbStaffNumber.ReadOnly = true;
                dgvMain.Enabled = true;
                btnAdditing.Enabled = true;
                dgvMain.CurrentCell = dgvMain.Rows[current_cell].Cells[0];
                btnAdditing.Text = "Править";
                if (Regex.IsMatch(tbCarriageNumber.Text.Trim().ToString(), numbers.ToString(), RegexOptions.IgnoreCase) &&
                     Regex.IsMatch(tbRouteArrive.Text.Trim().ToString(), dateTime.ToString(), RegexOptions.IgnoreCase) &&
                     Regex.IsMatch(tbRouteDeparture.Text.Trim().ToString(), dateTime.ToString(), RegexOptions.IgnoreCase) &&
                     Regex.IsMatch(tbRouteName.Text.Trim().ToString(), words.ToString(), RegexOptions.IgnoreCase) &&
                     Regex.IsMatch(tbStaffNumber.Text.Trim().ToString(), numbers.ToString(), RegexOptions.IgnoreCase))
                 {
                        string command_tc = "update train_composition set train_composition.carriage_id = " + tbCarriageNumber.Text.Trim().ToString() + " where train_composition.train_id = " + current_row.ToString();
                        string command_staff = "update train_staff set train_staff.employee_id = " + tbStaffNumber.Text.Trim().ToString() + " where train_staff.train_id = " + current_row.ToString();
                        string command_route_name = "update routes set routes.route_name = " + tbRouteName.Text.Trim().ToString() + " where routes.train_id = " + current_row.ToString();
                        string command_route_arrive = "update routes set routes.arrival_time = " + tbRouteArrive.Text.Trim().ToString() + " where routes.train_id = " + current_row.ToString();
                        string command_route_departure = "update routes set routes.depature_time = " + tbRouteDeparture.Text.Trim().ToString() + " where routes.train_id = " + current_row.ToString();


                    string[] val_arival = tbRouteArrive.Text.Trim().ToString().Split(':');
                    string[] val_departure = tbRouteDeparture.Text.Trim().ToString().Split(':');
                    if (int.Parse(val_arival[0]) < 24 && int.Parse(val_departure[0]) < 24 && int.Parse(val_arival[1]) < 60 && int.Parse(val_departure[1]) < 60)
                    {
                        if ((int.Parse(val_arival[0]) > int.Parse(val_departure[0])) || ((int.Parse(val_arival[0]) == int.Parse(val_departure[0])) && (int.Parse(val_arival[1]) > int.Parse(val_departure[1]))))
                        {
                            db.ExecuteNonQuery(ref stp, command_tc);
                            db.ExecuteNonQuery(ref stp, command_staff);
                            db.ExecuteNonQuery(ref stp, command_route_name);
                            db.ExecuteNonQuery(ref stp, command_route_arrive);
                            db.ExecuteNonQuery(ref stp, command_route_departure);
                        }
                        else if (MessageBox.Show("Поезд приходит в следующий день?", "Dialog", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            db.ExecuteNonQuery(ref stp, command_tc);
                            db.ExecuteNonQuery(ref stp, command_staff);
                            db.ExecuteNonQuery(ref stp, command_route_name);
                            db.ExecuteNonQuery(ref stp, command_route_arrive);
                            db.ExecuteNonQuery(ref stp, command_route_departure);
                        }
                        else
                        {
                            MessageBox.Show("Данные не были обновлены!", "Dialog", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные не были обновлены так как формат времени не сохранен!", "Dialog", MessageBoxButtons.OK);
                    }
                 }
                 else
                 {
                     MessageBox.Show("Вы ввели что то не так!","Dialog",MessageBoxButtons.OK);
                 }
            }
        }

        private void btnAdditing_Enter(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }

        private void tbCarriageNumber_Leave(object sender, EventArgs e)
        {
            int temp = 0, counter = 0;
            if (int.TryParse(tbCarriageNumber.Text.Trim().ToString(), out temp))
            {
                for (int i = 0; i < carriages.Count; i++)
                {
                    if (carriages[i].carriage_id == Convert.ToInt32(tbCarriageNumber.Text.Trim().ToString()))
                        counter++;
                }
                if (counter == 0)
                {
                    if (MessageBox.Show("Груза с таким номером не существует! Добавить?", "Dialog", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AddNewCarriage d = new AddNewCarriage();
                        d.Show();
                    }
                    else
                    {
                        tbCarriageNumber.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Номер груза должен быть целым числом!", "Dialog", MessageBoxButtons.OK);
                tbCarriageNumber.Focus();
            }
        }

        private void btnAddCarriage_Click(object sender, EventArgs e)
        {
            AddNewCarriage d = new AddNewCarriage();
            d.Show();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddNewStaff d = new AddNewStaff();
            d.Show();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            AddNewRoute d = new AddNewRoute();
            d.Show();
        }

        private void tbRouteDeparture_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tbRouteArrive_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tbAddDepartureTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tbAddArivalTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }

        private void cbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < routes.Count; i++)
            {
                if (cbTrain.Text == routes[i].route_name)
                {
                    tbAddArivalTime.Text = routes[i].arrival_time;
                    tbAddDepartureTime.Text = routes[i].depature_time;
                }
            }
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            int train_number = rnd.Next(99999);
            int train_id = trains[trains.Count - 1].train_id + 10;

            string command_train = "insert into trains(train_id, train_number) values(" + train_id.ToString() + "," + train_number.ToString() + ")";
            db.ExecuteNonQuery(ref stp, command_train);

            //string all_commans = command_train + '\n';
            int composition_id = (train_compositions[train_compositions.Count - 1].composition_id) + 1;
            int staff_id = (train_staffs[train_staffs.Count - 1].staff_id) + 10;
            int route_id = (routes[routes.Count - 1].route_id) + 1;

            for (int i = 0; i < carriage_types.Count; i++)
            {
                if (carriage_types[i].type_name == cbCarriage.Text)
                {
                    int carriage_id = (carriages[carriages.Count - 1].carriage_id) + 1;
                    string command_cariage = "insert into carriages(carriage_id, carriage_number, type_id) values(" + carriage_id.ToString() + ",'Cariage" + carriage_id.ToString() + "'," + carriage_types[i].type_id.ToString() + ")";
                    db.ExecuteNonQuery(ref stp, command_cariage);
                   // all_commans += command_cariage + '\n';
                    string command_composition = "insert into train_composition(composition_id, train_id, carriage_id) values("+ composition_id.ToString() +","+ train_id.ToString() +","+ carriage_id.ToString() +")";
                    db.ExecuteNonQuery(ref stp, command_composition);
                    //all_commans += command_composition + '\n';
                    break;
                }
            }

            for (int i = 0; i < employees.Count; i++)
            {
                if ((employees[i].first_name + " " + employees[i].second_name) == cbStaff.Text)
                {
                    string command_staff = "insert into train_staff(staff_id, train_id, employee_id) values("+ staff_id.ToString() +","+ train_id.ToString() +","+ employees[i].employee_id.ToString() +")";
                    db.ExecuteNonQuery(ref stp, command_staff);
                    //all_commans += command_staff + '\n';
                    break;
                }
            }

            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].route_name == cbTrain.Text)
                {
                    string command_route = "insert into routes(route_id, route_name, depature_time, arrival_time, train_id) values("+ route_id.ToString() +",'"+ routes[i].route_name.ToString() +"','"+ routes[i].depature_time.ToString() +"','"+ routes[i].arrival_time.ToString() +"',"+ train_id.ToString() +")";
                    db.ExecuteNonQuery(ref stp, command_route);
                   // all_commans += command_route + '\n';
                    break;
                }
            }

            //MessageBox.Show(all_commans,"Dialog",MessageBoxButtons.OK);
        }

        private void tbStaffNumber_Leave(object sender, EventArgs e)
        {
            int temp = 0, counter = 0;
            if (int.TryParse(tbStaffNumber.Text.Trim().ToString(), out temp))
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].employee_id == Convert.ToInt32(tbStaffNumber.Text.Trim().ToString()))
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    if (MessageBox.Show("В базе нет таких сотрудников. Добавить?", "Dialog", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AddNewStaff d = new AddNewStaff();
                        d.Show();
                    }
                    else
                    {
                        tbStaffNumber.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Номер сотрудника должен быть целым числом!", "Dialog", MessageBoxButtons.OK);
                tbStaffNumber.Focus();
            }
        }
    }
}
