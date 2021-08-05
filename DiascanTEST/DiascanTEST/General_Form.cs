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


namespace DiascanTEST
{
    public partial class General_Form : Form
    {
        public User_Form Form2 = new User_Form();
         
        public General_Form()
        {


            InitializeComponent();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string log = logtext.Text;
            string pass = passtext.Text;
            pracDB pracdb = new pracDB();
            pracdb.opcon();
            DataTable DTab = new DataTable();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM Users WHERE Name=(@LG) AND pass=(@PS)", pracdb.getcon());
            com.Parameters.AddWithValue("@LG", log);
            com.Parameters.AddWithValue("@PS", pass);
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DTab);

            if (DTab.Rows.Count > 0)
                Form2.Show(this);
            else
                MessageBox.Show("Вы неавторизованы! Пройдите регистрацию.");
        }

        private void btnAllTask_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state) ON users.id = task.assign_to;", pracdb.getcon());
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView_All_Task.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_All_Task.DataSource = DS.Tables[0];

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            string reglog = logtext.Text;
            string regpass = passtext.Text;
            pracDB pracdb = new pracDB();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO users (name, pass) VALUES (@RL, @RP)", pracdb.getcon());
            command.Parameters.AddWithValue("@RL", reglog);
            command.Parameters.AddWithValue("@RP", regpass);
            pracdb.opcon();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Регистрация пройдена успешно!");
            else
                MessageBox.Show("Регистрация не выполнена!");

            pracdb.clcon();
        }
    }
}
