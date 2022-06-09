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

namespace projedeneme5
{
    public partial class frmsatis : Form
    {
        public frmsatis()
        {
            InitializeComponent();

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            



        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamfiyat.Text = (int.Parse(txtMiktarı.Text) * int.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmürünekle ekle = new frmürünekle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();


            }
            catch (Exception)
            {

                ;
            }




        }

        private void frmsatis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";

            }
            
            
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from musteri where tc like'"+txtTc.Text+"'",baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from urun where barkodno like'" + txtBarkodNo.Text + "'", baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdı.Text = read["urunadi"].ToString();
                txtSatışFiyatı.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control İtem in groupBox2.Controls)
                {
                    if (İtem is TextBox)
                    {
                        if (İtem != txtMiktarı)
                        {
                            İtem.Text = "";
                        }


                    }


                }

            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from sepet",baglanti);
            NpgsqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text==read["barkodno"].ToString())
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@satisfiyati", int.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", int.Parse(txtToplamfiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

            }

            else
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("update sepet set miktari=miktari+'"+int.Parse(txtMiktarı.Text)+ "'where barkodno='" +txtBarkodNo.Text+ "'", baglanti);
                komut2.ExecuteNonQuery();
                NpgsqlCommand komut3 = new NpgsqlCommand("update sepet set toplamfiyati=miktari*satisfiyati where barkodno='"+txtBarkodNo.Text+"'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            
            
           txtMiktarı.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control İtem in groupBox2.Controls)
                {
                    if (İtem is TextBox)
                    {
                        if (İtem != txtMiktarı)
                        {
                            İtem.Text = "";
                        }


                    } 


                }
            
        }

        private void txtMiktarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamfiyat.Text = (int.Parse (txtMiktarı.Text) * int.Parse (txtSatışFiyatı.Text)).ToString();
            }
            catch(Exception)
            {
                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Ürünler sepetten çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatışListele listele = new frmSatışListele();
            listele.ShowDialog();
        }

        private void btnSatışyap_Click(object sender, EventArgs e)
        {
            for (int i=0;i<dataGridView1.Rows.Count-1;i++)
            {

                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", int.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", int.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                NpgsqlCommand komut2 = new NpgsqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                
            }
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }
    }
}
