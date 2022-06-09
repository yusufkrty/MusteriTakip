using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projedeneme5
{
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");
        DataSet daset = new DataSet();
        private void kategorigetir()
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from kategoribilgileri", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                comboKategori.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select *from urun where barkodno like'%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update urun set urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadi", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse (Miktarıtxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", int.Parse (AlışFiyatıtxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", int.Parse (SatışFiyatıtxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Güncelleme yapıldı");
            foreach (Control İtem in this.Controls)
            {
                if (İtem is TextBox)
                {
                    İtem.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text!="")
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme yapıldı");
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("Barkodno yazılı değil");

            }
            
            foreach (Control İtem in this.Controls)
            {
                if (İtem is ComboBox)
                {
                    İtem.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                comboMarka.Items.Add(read["marka"].ToString());

            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");
        }
    }
}
