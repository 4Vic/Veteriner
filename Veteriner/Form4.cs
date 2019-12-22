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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox4.Multiline = true;

            richTextBox4.AppendText(Environment.NewLine + dateTimePicker1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = " ";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection go = new SQLiteConnection(@"Data source=vetdb.db;Version=3;New=false;");

            go.Open();
            string sql = "insert into Tamamlananlar(Kayit_Kodu, Hekim_İsmi, Tedavi_İsmi, Gelecek_Randevular, Tedavi_Ücreti, İşlem_Tarihi ) values(@Kayit_Kodu, @Hekim_İsmi, @Tedavi_İsmi, @Gelecek_Randevular, @Tedavi_Ücreti, @İşlem_Tarihi)";
            SQLiteCommand eklemeyap = new SQLiteCommand(sql, go);

            {
                eklemeyap.Parameters.AddWithValue("@Kayit_Kodu", richTextBox1.Text);
                eklemeyap.Parameters.AddWithValue("@Hekim_İsmi", richTextBox6.Text);
                eklemeyap.Parameters.AddWithValue("@Tedavi_İsmi", richTextBox2.Text);
                eklemeyap.Parameters.AddWithValue("@Gelecek_Randevular", richTextBox4.Text);
                eklemeyap.Parameters.AddWithValue("@Tedavi_Ücreti", richTextBox5.Text);
                eklemeyap.Parameters.AddWithValue("@İşlem_Tarihi", dateTimePicker2.Text);
                
                eklemeyap.ExecuteNonQuery();
                MessageBox.Show("İşlem Kaydedildi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);





                //   this.Hide();
                //  Form2 form8 = new Form2();
                // form2.ShowDialog();

            }
            eklemeyap.Dispose();
            go.Dispose();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox del = (RichTextBox)item;
                    del.Clear();
                }
            }
        }
    }
}
