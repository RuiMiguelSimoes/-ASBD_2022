using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            encID.Text = "3";
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            // importar string con. da base de dados 
            string conString = Form1.conString;
            SqlConnection DataBaseConnection = new SqlConnection(conString);
            DataBaseConnection.Open();

            string query = "SELECT * FROM Encomenda WHERE EncID = " + encID.Text + " ORDER BY EncID DESC;"; //query sql
            string query2 = "SELECT * FROM EncLinha WHERE EncId = " + encID.Text + " ORDER BY EncId DESC ;"; //query sql

            //dataGrid com o resultado da query
            var sqlDataAdapter = new SqlDataAdapter(query, DataBaseConnection);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //dataGrid2 com o resultado da query2
            var sqlDataAdapter2 = new SqlDataAdapter(query2, DataBaseConnection);
            var dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }
    }
}
