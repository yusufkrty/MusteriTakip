using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;


namespace projedeneme5
{
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();


        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into musteri(tc,adsoyad,telefon,adres,email) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtTc.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtAdres.Text);
            komut.Parameters.AddWithValue("@p5", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
