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
    public partial class Form1 : Form
    {
       public static string Connection = "", user="";
        public Form1()
        {
            InitializeComponent();
            database_name.Text = "ABD_TRAB1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = user_name.Text;
            Connection = "Data Source="+host_name.Text+"; Network Library=DBMSSOCN; Initial Catalog=ABD_TRAB1;User ID="+user_name.Text+";Password="+password.Text+"";

            SqlConnection Connections = new SqlConnection(Connection);

            try
            {
                Connections.Open(); 
                MessageBox.Show("Success.......");
                Connections.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }
            catch
            {
                MessageBox.Show("Erro.......");
            }
            
        }
    }
}
