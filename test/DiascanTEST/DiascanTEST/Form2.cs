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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state)"+
                "ON users.id = task.assign_to WHERE (((state.id)="+
                "1));", pracdb.getcon());
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state)"+
                "ON users.id = task.assign_to WHERE ((state.id)=" + "3" + ");", pracdb.getcon());
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DataSource = DS.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pracDB pracdb = new pracDB();
            pracdb.opcon();
            DataSet DS = new DataSet();
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter();
            NpgsqlCommand com = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state)"+
                "ON users.id = task.assign_to WHERE (((users.id)=" + "1" + "));", pracdb.getcon());
            com.ExecuteNonQuery();
            adapt.SelectCommand = com;
            adapt.Fill(DS);
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.DataSource = DS.Tables[0];
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            string name_task = textBox2.Text;
            string state = comboBox1.Text;
            string ass = comboBox2.Text;
            pracDB pracdb = new pracDB();
            NpgsqlCommand command = new NpgsqlCommand("SELECT task.id, task.name, state.name AS state, users.name as assign_to FROM users INNER JOIN(state INNER JOIN task ON state.id = task.state) ON users.id = task.assign_to" +
                "INSERT INTO task (name,state, assign_to) VALUES (@NT, @ST,@AS)", pracdb.getcon());
            command.Parameters.AddWithValue("@NT", name_task);
            command.Parameters.AddWithValue("@ST", state);
            command.Parameters.AddWithValue("@AS", ass);
            pracdb.opcon();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Задача успешно добавлена!");
            else
                MessageBox.Show("Задача не добавлена!");

            pracdb.clcon();
        }

        
    }
}
