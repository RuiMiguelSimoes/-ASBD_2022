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

namespace logTempo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Form1.Connection);
            string query = "SELECT LO1.UserId, LO1.Objecto as EncId, DATEDIFF(SS,LO1.Valor, LO2.Valor) as Tempo FROM LogOperations LO1, LogOperations LO2 WHERE LO1.Referencia = LO2.Referencia and LO1.DCriacao < LO2.DCRiacao and LO1.Referencia = 'G1-20191001101356321' ";

            var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
