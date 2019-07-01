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
    public partial class AddNewCarriage : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<Carriage_type> carriage_types = new List<Carriage_type>();
        List<Carriages> carriages = new List<Carriages>();
        Regex type_name = new Regex(@"\b(\w+?)\b");
        Regex value = new Regex(@"\d{1,}");

        void LoadData()
        {
            carriages.Clear();
            carriage_types.Clear();
            db.Execute<Carriage_type>(ref stp, "Select * FROM carriage_types", ref carriage_types);
            db.Execute<Carriages>(ref stp, "Select * from carriages", ref carriages);
        }


        public AddNewCarriage()
        {
            InitializeComponent();
        }

        private void AddNewCarriage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int temp = 0;
            if ((tbCarriageNumber.Text.Trim() != "") && (tbSitsCount.Text.Trim() != "") && (tbTypeName.Text.Trim() != ""))
            {
                if (int.TryParse(tbSitsCount.Text.ToString(), out temp))
                {
                    if (Regex.IsMatch(tbCarriageNumber.Text.Trim().ToString(), type_name.ToString()) &&
                        Regex.IsMatch(tbTypeName.Text.Trim().ToString(), type_name.ToString()) &&
                        Regex.IsMatch(tbSitsCount.Text.Trim().ToString(), value.ToString()))
                    {
                        int type_id = (carriage_types[carriage_types.Count - 1].type_id) + 1;
                        int carriage_id = (carriages[carriages.Count - 1].carriage_id) + 1;
                        string command_types = "insert into carriage_types(type_id, type_name, sits_count) values("+ type_id.ToString() +",'"+ tbTypeName.Text.Trim().ToString() +"',"+ tbSitsCount.Text.Trim().ToString()+")";
                        db.ExecuteNonQuery(ref stp, command_types);
                        string command_carriages = "insert into carriages(carriage_id, carriage_number, type_id) values("+ carriage_id.ToString() +",'"+ tbCarriageNumber.Text.Trim().ToString() +"',"+ type_id.ToString() + ")";
                        db.ExecuteNonQuery(ref stp, command_carriages);

                        if (MessageBox.Show("Добавлен новый груз с номером" + carriage_id.ToString() + "!", "Dialog", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы Ввели что то не так, проверьте информацию!", "Dialog", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Объем должен быть указан целым числом!","Dialog",MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!","Dialog",MessageBoxButtons.OK);
            }
        }

        private void AddNewCarriage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
