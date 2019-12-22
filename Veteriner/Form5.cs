using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Veteriner
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SQLiteConnection go = new SQLiteConnection(@"Data source=vetdb.db;Version=3;New=false;");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Tamamlananlar", go);
            DataSet datasetim = new DataSet();
            adapter.Fill(datasetim, "Tamamlananlar");
            dataGridView1.DataSource = datasetim.Tables[0];
            //setGrid(dataGridView1);
            go.Dispose(); datasetim.Dispose(); adapter.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
