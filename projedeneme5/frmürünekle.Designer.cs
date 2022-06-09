
namespace projedeneme5
{
    partial class frmürünekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtAlışFiyatı = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnVarOlanaEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.SatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıtxt = new System.Windows.Forms.TextBox();
            this.AlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.Miktarıtxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnYeniEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboMarka);
            this.groupBox1.Controls.Add(this.comboKategori);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Controls.Add(this.txtAlışFiyatı);
            this.groupBox1.Controls.Add(this.txtSatışFiyatı);
            this.groupBox1.Controls.Add(this.txtMiktarı);
            this.groupBox1.Controls.Add(this.txtÜrünAdı);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BarkodNo";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(153, 283);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 1;
            this.btnYeniEkle.Text = "Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kategori";
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(126, 95);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(102, 23);
            this.comboMarka.TabIndex = 8;
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(126, 63);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(102, 23);
            this.comboKategori.TabIndex = 9;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(126, 29);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAlışFiyatı
            // 
            this.txtAlışFiyatı.Location = new System.Drawing.Point(126, 194);
            this.txtAlışFiyatı.Name = "txtAlışFiyatı";
            this.txtAlışFiyatı.Size = new System.Drawing.Size(102, 23);
            this.txtAlışFiyatı.TabIndex = 3;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(126, 227);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(102, 23);
            this.txtSatışFiyatı.TabIndex = 2;
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Location = new System.Drawing.Point(126, 161);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(102, 23);
            this.txtMiktarı.TabIndex = 1;
            this.txtMiktarı.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(126, 131);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 23);
            this.txtÜrünAdı.TabIndex = 0;
            this.txtÜrünAdı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMiktari);
            this.groupBox2.Controls.Add(this.btnVarOlanaEkle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.BarkodNotxt);
            this.groupBox2.Controls.Add(this.SatışFiyatıtxt);
            this.groupBox2.Controls.Add(this.ÜrünAdıtxt);
            this.groupBox2.Controls.Add(this.AlışFiyatıtxt);
            this.groupBox2.Controls.Add(this.Miktarıtxt);
            this.groupBox2.Controls.Add(this.Kategoritxt);
            this.groupBox2.Controls.Add(this.Markatxt);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 349);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Var Olan Ürün";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(48, 312);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 15);
            this.lblMiktari.TabIndex = 1;
            // 
            // btnVarOlanaEkle
            // 
            this.btnVarOlanaEkle.Location = new System.Drawing.Point(207, 304);
            this.btnVarOlanaEkle.Name = "btnVarOlanaEkle";
            this.btnVarOlanaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnVarOlanaEkle.TabIndex = 2;
            this.btnVarOlanaEkle.Text = "Ekle";
            this.btnVarOlanaEkle.UseVisualStyleBackColor = true;
            this.btnVarOlanaEkle.Click += new System.EventHandler(this.btnVarOlanaEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "BarkodNo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Satış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Alış Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Miktarı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ürün Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Marka";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "Kategori";
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(165, 35);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 23);
            this.BarkodNotxt.TabIndex = 1;
            this.BarkodNotxt.TextChanged += new System.EventHandler(this.BarkodNotxt_TextChanged);
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(165, 251);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(100, 23);
            this.SatışFiyatıtxt.TabIndex = 6;
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(165, 143);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(100, 23);
            this.ÜrünAdıtxt.TabIndex = 7;
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(165, 215);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(100, 23);
            this.AlışFiyatıtxt.TabIndex = 2;
            this.AlışFiyatıtxt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(165, 179);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(100, 23);
            this.Miktarıtxt.TabIndex = 3;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(165, 71);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.Size = new System.Drawing.Size(100, 23);
            this.Kategoritxt.TabIndex = 4;
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(165, 107);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.Size = new System.Drawing.Size(100, 23);
            this.Markatxt.TabIndex = 5;
            // 
            // frmürünekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmürünekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmürünekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAlışFiyatı;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.TextBox Miktarıtxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.TextBox AlışFiyatıtxt;
        private System.Windows.Forms.TextBox SatışFiyatıtxt;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVarOlanaEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label lblMiktari;
    }
}