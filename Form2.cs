using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        public static string ConnectionString = "Provider =Microsoft.ACE.OLEDB.12.0;Data Source = lab4.accdb";
        private OleDbConnection Connection;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet.Информация_о_клиентах". При необходимости она может быть перемещена или удалена.
            this.информация_о_клиентахTableAdapter.Fill(this.lab4DataSet.Информация_о_клиентах);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(ConnectionString);
            Connection.Open();
           // string firma = textBox1.Text;
            string query = "Select * FROM фирма WHERE [Срок(мес)] > 3";
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
