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

namespace proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=otel; user ID=postgres; password=123456");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from otel";
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
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into otel(otelno,adi,yildizsayisi,adresi) values (@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", textBox4.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(textBox5.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(textBox6.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Basariyla eklendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From otel where otelno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut3 = new NpgsqlCommand("update otel set adi=@p2,yildizsayisi=@p3,adresi=@p4 where otelno=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut3.Parameters.AddWithValue("@p2", textBox4.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(textBox5.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(textBox6.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "Select*From otel Where adi=@p2";
            NpgsqlCommand komut4 = new NpgsqlCommand(kayit, baglanti);

            komut4.Parameters.AddWithValue("@p2", textBox8.Text);

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
