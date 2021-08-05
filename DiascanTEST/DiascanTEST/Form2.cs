using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Threading;

namespace DiascanTEST
{
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
        }
        public string[] mass_str;
        private void btn_New_Task_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            int new_task = comboBox_NewTask.SelectedIndex;
            new_task++;
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state)"+
                "ON users.id = task.assign_to WHERE (((state.id)="+
                "1 AND (users.id)=" + "@NT" + "));", pracdb.getcon());
            com.Parameters.AddWithValue("@NT", new_task);
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView_New_Task.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_New_Task.DataSource = DS.Tables[0];
        }

        private void btn_Done_Task_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            int done = comboBox_Done_Task_Users.SelectedIndex;
            done++;
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state)"+
                "ON users.id = task.assign_to WHERE ((state.id)=" + "3" + " AND (users.id)=" + "@DT" + ");", pracdb.getcon());
            com.Parameters.AddWithValue("@DT", done);
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView_Done_Task.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Done_Task.DataSource = DS.Tables[0];
        }

        private void btn_My_Task_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            int my_login = comboBox_My_Login.SelectedIndex;
            my_login++;
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state)"+
                "ON users.id = task.assign_to WHERE (((users.id)=" + "@ML" + "));", pracdb.getcon());
            com.Parameters.AddWithValue("@ML", my_login);
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView_My_Task.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_My_Task.DataSource = DS.Tables[0];
        }

     
        private void btn_Add_Task_Click(object sender, EventArgs e)
        {
            string name_task = textBox2.Text;
            int state = comboBox1.SelectedIndex;
            state++;
            int add = comboBox_Add_Task_Users.SelectedIndex;
            add++;
            pracDB pracdb = new pracDB();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO task (name,state, assign_to) VALUES (@NT, @ST,@AS)", pracdb.getcon());
            command.Parameters.AddWithValue("@NT", name_task);
            command.Parameters.AddWithValue("@ST", state);
            command.Parameters.AddWithValue("@AS", add);
            pracdb.opcon();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Задача успешно добавлена!");
            else
                MessageBox.Show("Задача не добавлена!");

            pracdb.clcon();
        }
        private void select_user()
        {
            pracDB pracdb = new pracDB();
            pracdb.opcon();
            NpgsqlCommand command = new NpgsqlCommand("SELECT  name FROM users", pracdb.getcon());
            command.ExecuteNonQuery();
            NpgsqlDataReader DR = command.ExecuteReader();
            int count = 0;
            while (DR.Read())
            {
                count++;
            }
            DR.Close();
            DR = command.ExecuteReader();
            mass_str=new string[count];
            int i = 0;
            while(DR.Read())
            {
                mass_str[i] = DR[0].ToString();
                i++;

            }
            
        }
        private async void get_users()
        {
            comboBox_My_Login.Items.Clear();
            comboBox_Add_Task_Users.Items.Clear();
            comboBox_NewTask.Items.Clear();
            comboBox_Done_Task_Users.Items.Clear();
            await Task.Run(() => select_user());
            comboBox_NewTask.Items.AddRange(mass_str);
            comboBox_My_Login.Items.AddRange(mass_str);
            comboBox_Add_Task_Users.Items.AddRange(mass_str);
            comboBox_Done_Task_Users.Items.AddRange(mass_str);
        }
        private void User_Form_Activated(object sender, EventArgs e)
        {
            get_users();
        }

        
    }
}
