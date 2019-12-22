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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection go = new SQLiteConnection(@"Data source=vetdb.db;Version=3;New=false;");

            go.Open();
            string sql = "insert into Kayitlar(Kayit_Kodu, Sahip_Ad_Soyad ,Sahip_Telefon, Sahip_Adres, Hayvan_Türü, Hayvan_Irkı, Hayvan_Cinsiyet, Hayvan_İsim, Doğum_Tarihi, Kimlik_No, Kulak_No, Sahip_E_Posta, Aşı_Adı, Kayıt_Tarihi) values(@Kayit_Kodu ,@Sahip_Ad_Soyad, @Sahip_Telefon, @Sahip_Adres, @Hayvan_Türü, @Hayvan_Irkı, @Hayvan_Cinsiyet, @Hayvan_İsim, @Doğum_Tarihi, @Kimlik_No, @Kulak_No, @Sahip_E_Posta, @Aşı_Adı, @Kayıt_Tarihi)";
            SQLiteCommand eklemeyap = new SQLiteCommand(sql, go);

            {
                eklemeyap.Parameters.AddWithValue("@Kayit_Kodu", richTextBox1.Text);
                eklemeyap.Parameters.AddWithValue("@Sahip_Ad_Soyad", richTextBox2.Text);
                eklemeyap.Parameters.AddWithValue("@Sahip_Telefon", richTextBox3.Text);
              //  eklemeyap.Parameters.AddWithValue("@Sahip_E-Posta", richTextBox4.Text);
                eklemeyap.Parameters.AddWithValue("@Sahip_Adres", richTextBox6.Text);
                eklemeyap.Parameters.AddWithValue("@Hayvan_Türü", comboBox1.Text);
                eklemeyap.Parameters.AddWithValue("@Hayvan_Irkı", richTextBox7.Text);
                eklemeyap.Parameters.AddWithValue("@Hayvan_Cinsiyet", comboBox2.Text);
                eklemeyap.Parameters.AddWithValue("@Hayvan_İsim", richTextBox5.Text);
                eklemeyap.Parameters.AddWithValue("@Doğum_Tarihi", dateTimePicker1.Text);
                eklemeyap.Parameters.AddWithValue("@Kimlik_No", richTextBox11.Text);
                eklemeyap.Parameters.AddWithValue("@Kulak_No", richTextBox10.Text);
                eklemeyap.Parameters.AddWithValue("@Sahip_E_Posta", richTextBox9.Text);
                eklemeyap.Parameters.AddWithValue("@Aşı_Adı", richTextBox12.Text);
                eklemeyap.Parameters.AddWithValue("@Kayıt_Tarihi", dateTimePicker2.Text);
                     
                eklemeyap.ExecuteNonQuery();
                MessageBox.Show("Yeni kayıt başarıyla eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);





             //   this.Hide();
              //  Form2 form8 = new Form2();
               // form2.ShowDialog();

            }
            eklemeyap.Dispose();
            go.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
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
