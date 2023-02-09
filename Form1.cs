using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace lab4
{   
    public partial class Form1 : Form
    {
        public static string ConnectionString = "Provider =Microsoft.ACE.OLEDB.12.0;Data Source = lab4.accdb";
        private OleDbConnection Connection;
        public Form1()
        {
            InitializeComponent();
            Connection = new OleDbConnection(ConnectionString);
            Connection.Open();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet1.Банк". При необходимости она может быть перемещена или удалена.
            this.банкTableAdapter.Fill(this.lab4DataSet1.Банк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet1.Фирма". При необходимости она может быть перемещена или удалена.
            this.фирмаTableAdapter.Fill(this.lab4DataSet1.Фирма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet1.Информация_о_клиентах". При необходимости она может быть перемещена или удалена.
            this.информация_о_клиентахTableAdapter.Fill(this.lab4DataSet1.Информация_о_клиентах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab4DataSet.Информация_о_клиентах". При необходимости она может быть перемещена или удалена.
            this.информация_о_клиентахTableAdapter.Fill(this.lab4DataSet.Информация_о_клиентах);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.Close();
        }
        private void банкBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }


        private void срокВкладаНеМенееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        private void групповаяОперацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();

        }

        private void вычислениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void суммаНачислений8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
