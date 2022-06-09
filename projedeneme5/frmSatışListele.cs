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
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=stok_takip; user ID=postgres; password=goldstein");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }

            private void frmSatışListele_Load(object sender, EventArgs e) 
            {
            satışlistele();


            }
       
    }
}
