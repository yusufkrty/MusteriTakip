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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from kategoribilgileri",baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text==read["kategori"].ToString()|| textBox1.Text=="")
                {
                    durum = false;


                }
            }
            baglanti.Close();

        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            kategorikontrol();
            if (durum==true)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into kategoribilgileri(kategori) values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
               
                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori var","Uyarı");
            }
            textBox1.Text = "";
        }
    }
}
