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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");

        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from markabilgileri", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString() &&  textBox1.Text == read["marka"].ToString() || comboBox1.Text=="" || textBox1.Text == "")
                {
                    durum = false;


                }
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum==true)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka eklendi");

            }
            else
            {

                MessageBox.Show("Böyle bir kategori ve marka var","Uyarı");
            }
           
            textBox1.Text = "";
            comboBox1.Text = "";
           
        }
        private void kategorigetir()
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from kategoribilgileri", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                comboBox1.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }
        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

       
    }
}
