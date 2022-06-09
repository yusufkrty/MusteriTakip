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
    public partial class frmürünekle : Form
    {
        public frmürünekle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from urun", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text==read["barkodno"].ToString()|| txtBarkodNo.Text=="")
                {
                    durum = false;


                }
            }
            baglanti.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from markabilgileri where kategori='"+comboKategori.SelectedItem+"'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                comboMarka.Items.Add(read["marka"].ToString());

            }
            baglanti.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
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
        private void frmürünekle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@alisfiyati", int.Parse(txtAlışFiyatı.Text));
                komut.Parameters.AddWithValue("@satisfiyati", int.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }

            else
            {

                MessageBox.Show("Böyle bir barkodno var","Uyarı");
            }
           
            comboMarka.Items.Clear();
            foreach (Control İtem in groupBox1.Controls)
            {
                if (İtem is TextBox)
                {
                    İtem.Text = "";
                }
                if (İtem is ComboBox)
                {
                    İtem.Text = "";
                }
            }
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text=="")
            {
                lblMiktari.Text = "";
                foreach (Control İtem in groupBox2.Controls)
                {
                    if (İtem is TextBox)
                    {
                        İtem.Text = "";
                    }

                }

            }


            
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from urun where barkodno like '"+BarkodNotxt.Text+"'",baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                ÜrünAdıtxt.Text = read["urunadi"].ToString();
                lblMiktari.Text = read["miktari"].ToString();
                AlışFiyatıtxt.Text = read["alisfiyati"].ToString();
                SatışFiyatıtxt.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("update urun set miktari=miktari+'"+int.Parse(Miktarıtxt.Text)+"'where barkodno='"+BarkodNotxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control İtem in groupBox2.Controls)
            {
                if (İtem is TextBox)
                {
                    İtem.Text = "";
                }

            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");

        }
    }
}
