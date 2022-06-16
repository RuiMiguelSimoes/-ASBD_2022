using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log
{
    public partial class Form2 : Form
    {
        public string n = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(Form1.Connection);
            string query = "SELECT TOP "+nLinhas.Text+" * FROM LogOperations WHERE EventType = 'I' OR  EventType = 'U' OR  EventType = 'D' ;";

            //dataGrid com o resultado da query
            var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            n = nLinhas.Text;
        }

        private void nLinhas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Form1.Connection);
            string query = "SELECT * FROM LogOperations WHERE EventType = 'I' OR  EventType = 'U' OR  EventType = 'D' LIMIT ;";

            //dataGrid com o resultado da query
            var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
