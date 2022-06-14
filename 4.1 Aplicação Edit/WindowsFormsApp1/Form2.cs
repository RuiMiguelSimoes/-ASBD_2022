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
    public partial class Form2 : Form
    {
        public static string nivel_isolamento = "";
        public static string Id = "";

        public Form2() 
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
        
    
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("Read Uncommitted");
            collection.Add("Read Committed");
            collection.Add("Repeatable Read");
            collection.Add("Snapshot");
            collection.Add("Serializable");

            this.domainUpDown1.Text = "Read Uncomitted";
        }

        private void button1_Click(object sender, EventArgs e)
        {     
                
            //grava o registo de acesso á base de dados
            using (SqlConnection connection = new SqlConnection(Form1.Connection))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                string user = Form1.user;

                DateTime date_now = DateTime.UtcNow;
                string User_Reference = "G3-" + date_now.ToString("yyMMddHmmss");

                string logReguisterQuery = "INSERT INTO LogOperations (EventType, Objecto, Valor, Referencia) Values('O', '" + user + "'" + " , " + "'" + date_now + "'" + " , " + "'" + User_Reference + "'" + ")";
                command.CommandText = logReguisterQuery;
                command.ExecuteNonQuery();

                connection.Close();
            }

            Id = id.Text;
            
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
