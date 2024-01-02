using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=otel; user ID=postgres; password=123456");
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from oda";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();

            baglanti.Open();
            da.Fill(ds);
            baglanti.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into oda(odano,fiyat,odatipi,kati,rezervasyonu) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            komut1.Parameters.AddWithValue("@p3", textBox4.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(textBox3.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(textBox5.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Basariyla eklendi!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From oda where odano=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oda silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut3 = new NpgsqlCommand("update oda set fiyat=@p2,odatipi=@p3,kati=@p4,rezervasyonu=@p5 where odano=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            komut3.Parameters.AddWithValue("@p3", textBox4.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(textBox3.Text));
            komut3.Parameters.AddWithValue("@p5", int.Parse(textBox5.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "Select*From oda Where odano=@p1";
            NpgsqlCommand komut4 = new NpgsqlCommand(kayit, baglanti);

            komut4.Parameters.AddWithValue("@p1", int.Parse(textBox6.Text));

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
