using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form5 : Form
    {
        public static string ConnectionString = "Provider =Microsoft.ACE.OLEDB.12.0;Data Source = lab4.accdb";
        private OleDbConnection Connection;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(ConnectionString);
            Connection.Open();
            string query = "Select [Сумма вклада], ([Сумма вклада] +(.08*[Сумма вклада])) FROM Фирма";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }
    }
}
