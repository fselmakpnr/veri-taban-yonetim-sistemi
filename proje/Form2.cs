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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=otel; user ID=postgres; password=123456");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select* from müsteri";
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
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into müsteri(müsterino,müsterisoyadi,iletisim,oteli,müsteriadi) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.Parameters.AddWithValue("@p3", textBox3.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            komut1.Parameters.AddWithValue("@p5", textBox5.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Basariyla eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut3 = new NpgsqlCommand("update müsteri set müsterisoyadi=@p2,iletisim=@p3,oteli=@p4,müsteriadi=@p5 where müsterino=@p1 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut3.Parameters.AddWithValue("@p2", textBox2.Text);
            komut3.Parameters.AddWithValue("@p3", textBox3.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            komut3.Parameters.AddWithValue("@p5", textBox5.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "Select*From müsteri Where müsteriadi=@p5";
            NpgsqlCommand komut4 = new NpgsqlCommand(kayit, baglanti);

            komut4.Parameters.AddWithValue("@p5", textBox6.Text);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From müsteri where müsterino=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müsteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
