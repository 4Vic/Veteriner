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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQLiteConnection go = new SQLiteConnection(@"Data source=vetdb.db;Version=3;New=false;");

            go.Open();
            string sql = "insert into Notlar(Notlar) values (@Notlar) ";
            SQLiteCommand eklemeyap = new SQLiteCommand(sql, go);

            {
                eklemeyap.Parameters.AddWithValue("@Notlar", richTextBox1.Text);
                eklemeyap.ExecuteNonQuery();
                MessageBox.Show("Yeni kayıt başarıyla eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            eklemeyap.Dispose();
            go.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection go = new SQLiteConnection(@"Data source=vetdb.db;Version=3;New=false;");  // Form1 açılırken kayıtlı notları direkt ekrana getirecek.
            go.Open();
            SQLiteCommand komut1 = new SQLiteCommand("select * from Notlar", go);
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(komut1);
            komut1.Connection = go;
            SQLiteDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {
                richTextBox1.Text = read1["Notlar"].ToString();
            }
            komut1.Dispose();
            adapter1.Dispose();
            go.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
