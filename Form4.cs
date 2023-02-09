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
    public partial class Form4 : Form
    {
        public static string ConnectionString = "Provider =Microsoft.ACE.OLEDB.12.0;Data Source = lab4.accdb";
        private OleDbConnection Connection;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(ConnectionString);
            Connection.Open();
            string query = "Select [Банк], SUM ([Сумма вклада]) AS ВсегоВклад FROM [информация о клиентах] GROUP BY Банк";
            OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
