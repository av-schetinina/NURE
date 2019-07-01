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
    public partial class AddNewRoute : Form
    {

        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<Train> trains = new List<Train>();
        List<Routes> routes = new List<Routes>();

        Regex time = new Regex(@"\b\d{1,2}\:\d{1,2}\b");
        Regex name = new Regex(@"\b(\w+?)\b");

        Random rnd = new Random();


        void LoadData()
        {
            trains.Clear();
            routes.Clear();
            db.Execute<Train>(ref stp, "Select * from trains", ref trains);
            db.Execute<Routes>(ref stp, "Select * from routes", ref routes);
        }

        public AddNewRoute()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < routes.Count; i++)
            {
                if (routes[i].route_name == tbRouteName.Text)
                {
                    counter++;
                }
            }
            if (tbArrivalTime.Text.Trim().ToString() != "" && tbDepatureTime.Text.Trim().ToString() != "" && tbRouteName.Text.Trim().ToString() != "")
            {
                if (counter == 0)
                {
                    if (Regex.IsMatch(tbRouteName.Text.Trim().ToString(), name.ToString()) && Regex.IsMatch(tbArrivalTime.Text.Trim().ToString(), time.ToString()) && Regex.IsMatch(tbDepatureTime.Text.Trim().ToString(), time.ToString()))
                    {
                        string[] val_arival = tbArrivalTime.Text.Trim().ToString().Split(':');
                        string[] val_departure = tbDepatureTime.Text.Trim().ToString().Split(':');
                        if (int.Parse(val_arival[0]) < 24 && int.Parse(val_departure[0]) < 24 && int.Parse(val_arival[1]) < 60 && int.Parse(val_departure[1]) < 60)
                        {
                            if ((int.Parse(val_arival[0]) > int.Parse(val_departure[0])) || ((int.Parse(val_arival[0]) == int.Parse(val_departure[0])) && (int.Parse(val_arival[1]) > int.Parse(val_departure[1]))))
                            {
                                string command = "insert into routes(route_id, route_name, depature_time, arrival_time, train_id) values(" + (((routes[routes.Count - 1].route_id) + 1).ToString()) + ",'" + tbRouteName.Text.Trim().ToString() + "','" + tbDepatureTime.Text.Trim().ToString() + "','" + tbArrivalTime.Text.Trim().ToString() + "'," + trains[rnd.Next(trains.Count - 1)].train_id.ToString() + ")";
                                db.ExecuteNonQuery(ref stp, command);
                            }
                            else
                            {
                                if (MessageBox.Show("Состав прибывает на следующий день?", "Dialog", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    string command = "insert into routes(route_id, route_name, depature_time, arrival_time, train_id) values(" + (((routes[routes.Count - 1].route_id) + 1).ToString()) + ",'" + tbRouteName.Text.Trim().ToString() + "','" + tbDepatureTime.Text.Trim().ToString() + "','" + tbArrivalTime.Text.Trim().ToString() + "'," + trains[rnd.Next(trains.Count - 1)].train_id.ToString() + ")";
                                    db.ExecuteNonQuery(ref stp, command);
                                }
                                else
                                {
                                    MessageBox.Show("Проверьте введенные данные!", "Dialog", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Проверьте введенные данные!", "Dialog", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите все данные правильно!", "Dialog", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Направление с таким именем уже существует!", "Dialog", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!","Dialog",MessageBoxButtons.OK);
            }
        }

        private void tbDepatureTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tbArrivalTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void AddNewRoute_Load(object sender, EventArgs e)
        {

        }
    }
}
