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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Form1.Connection);
            string query = "SELECT * FROM EncLinha FULL JOIN Encomenda ON EncLinha.EncId = Encomenda.EncID WHERE EncLinha.EncId = " + Form2.Id + ";";

            //dataGrid com o resultado da query
            var sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        //butão alterar morada
        private void button1_Click(object sender, EventArgs e)
        {
            string nivel_isolamento = Form2.nivel_isolamento;

            using (SqlConnection connection = new SqlConnection(Form1.Connection))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
            
               
                switch (nivel_isolamento)
                {
                    case "Read Uncommitted":

                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                  
                        break;

                    case "Read Committed":

                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                        break;

                    case "Repeatable Read":

                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                        break;

                    case "Snapshot":

                        transaction = connection.BeginTransaction(IsolationLevel.Snapshot);

                        break;

                    case "Serializable":

                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);

                        break;

                }

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    //altera a morada da encomenda
                    string query = "UPDATE Encomenda SET Morada = '" + morada.Text + "' WHERE Encomenda.EncID = " + Form2.Id + " ;";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("O Commit foi feito com sucesso");
                    connection.Close();

                }catch {
                    try
                    {
                        MessageBox.Show("A transação falhou, foi feito um rollback");
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possivél fazer rollback");
                    }
                }
                //faz registo na base de dados
                connection.Open();

                string user = Form1.user;
                DateTime date_now = DateTime.UtcNow;
                string User_Reference = "G3-" + date_now.ToString("yyMMddHmmss");
                string ínsertRegisterQuery = "INSERT INTO LogOperations (EventType, Objecto, Valor, Referencia) Values('O', '" + user + "'" + " , " + "'" + date_now + "'" + " , " + "'" + User_Reference + "'" + ")";

                SqlCommand insertRegister = new SqlCommand(ínsertRegisterQuery, command.Connection);
                insertRegister.ExecuteNonQuery();

                connection.Close();


                //atualizar a balelazinha
                SqlConnection sqlConnection = new SqlConnection(Form1.Connection);
                string selectAll = "SELECT * FROM EncLinha FULL JOIN Encomenda ON EncLinha.EncId = Encomenda.EncID WHERE EncLinha.EncId = " + Form2.Id + ";";

                //dataGrid com o resultado da query
                var sqlDataAdapter = new SqlDataAdapter(selectAll, sqlConnection);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            SqlConnection connection = new SqlConnection(Form1.Connection);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
               
            command.Connection = connection;
         
                 string query = "SELECT * FROM EncLinha FULL JOIN Encomenda ON EncLinha.EncId = Encomenda.EncID WHERE EncLinha.EncId = " + Form2.Id + ";";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    //dataGrid com o resultado da query
                    var sqlDataAdapter = new SqlDataAdapter(query, Form1.Connection);
                    var dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    connection.Close(); 
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //butão alterar quantidade
        private void button3_Click(object sender, EventArgs e)
        {
            string nivel_isolamento = Form2.nivel_isolamento;

            using (SqlConnection connection = new SqlConnection(Form1.Connection))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();


                switch (nivel_isolamento)
                {
                    case "Read Uncommitted":

                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                        break;

                    case "Read Committed":

                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                        break;

                    case "Repeatable Read":

                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);

                        break;

                    case "Snapshot":

                        transaction = connection.BeginTransaction(IsolationLevel.Snapshot);

                        break;

                    case "Serializable":

                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);

                        break;

                }

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    string query = "UPDATE EncLinha SET Qtd = " + quantidade.Text + " WHERE EncLinha.EncID = " + Form2.Id + "; ";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("O Commit foi feito com sucesso");
                    connection.Close();
                }
                catch
                {

                    try
                    {
                        MessageBox.Show("A trasação falhou, foi feito um rollback");
                        transaction.Rollback();
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Não foi possivél fazer rollback");
                    }
                }

                //faz registo na base de dados
                connection.Open();

                string user = Form1.user;
                DateTime date_now = DateTime.UtcNow;
                string User_Reference = "G3-" + date_now.ToString("yyMMddHmmss");
                string ínsertRegisterQuery = "INSERT INTO LogOperations (EventType, Objecto, Valor, Referencia) Values('O', '" + user + "'" + " , " + "'" + date_now + "'" + " , " + "'" + User_Reference + "'" + ")";

                SqlCommand insertRegister = new SqlCommand(ínsertRegisterQuery, command.Connection);
                insertRegister.ExecuteNonQuery();

                connection.Close();


                //atualizar a balelazinha
                SqlConnection sqlConnection = new SqlConnection(Form1.Connection);
                string selectAll = "SELECT * FROM EncLinha FULL JOIN Encomenda ON EncLinha.EncId = Encomenda.EncID WHERE EncLinha.EncId = " + Form2.Id + ";";

                //dataGrid com o resultado da query
                var sqlDataAdapter = new SqlDataAdapter(selectAll, sqlConnection);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
