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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Form3_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SQLiteConnection go = new SQLiteConnection(@"Data source=vetdb.db;Version=3;New=false;");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Kayitlar", go);
            DataSet datasetim = new DataSet();
            adapter.Fill(datasetim, "Kayitlar");
            dataGridView1.DataSource = datasetim.Tables[0];
            //setGrid(dataGridView1);
            go.Dispose(); datasetim.Dispose(); adapter.Dispose();
        }
    }
}
