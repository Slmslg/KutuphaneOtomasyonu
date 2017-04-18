namespace KütüphaneOtomasyonu
{
    partial class Form1
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
            this.Otomasyon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.basimTarihi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kategoriEkle = new System.Windows.Forms.TextBox();
            this.yayinEviEkle = new System.Windows.Forms.TextBox();
            this.yazarEkle = new System.Windows.Forms.TextBox();
            this.kitapAdiEkle = new System.Windows.Forms.TextBox();
            this.barkodEkle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kategoriSil = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Sil = new System.Windows.Forms.Button();
            this.basimTarihiSil = new System.Windows.Forms.TextBox();
            this.yayinEviSil = new System.Windows.Forms.TextBox();
            this.yazarSil = new System.Windows.Forms.TextBox();
            this.kitapAdiSil = new System.Windows.Forms.TextBox();
            this.barkodAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kategoriGuncelle = new System.Windows.Forms.TextBox();
            this.barkodAraGuncelle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.basimTarihiGuncelle = new System.Windows.Forms.TextBox();
            this.yayinEviGuncelle = new System.Windows.Forms.TextBox();
            this.yazarGuncelle = new System.Windows.Forms.TextBox();
            this.kitapAdiGuncelle = new System.Windows.Forms.TextBox();
            this.barkodGuncelle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Otomasyon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Otomasyon
            // 
            this.Otomasyon.Controls.Add(this.tabPage1);
            this.Otomasyon.Controls.Add(this.tabPage2);
            this.Otomasyon.Controls.Add(this.tabPage3);
            this.Otomasyon.Controls.Add(this.tabPage4);
            this.Otomasyon.Location = new System.Drawing.Point(12, 12);
            this.Otomasyon.Name = "Otomasyon";
            this.Otomasyon.SelectedIndex = 0;
            this.Otomasyon.Size = new System.Drawing.Size(651, 268);
            this.Otomasyon.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.basimTarihi);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.kategoriEkle);
            this.tabPage1.Controls.Add(this.yayinEviEkle);
            this.tabPage1.Controls.Add(this.yazarEkle);
            this.tabPage1.Controls.Add(this.kitapAdiEkle);
            this.tabPage1.Controls.Add(this.barkodEkle);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kitap Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // basimTarihi
            // 
            this.basimTarihi.Location = new System.Drawing.Point(105, 122);
            this.basimTarihi.Name = "basimTarihi";
            this.basimTarihi.Size = new System.Drawing.Size(172, 20);
            this.basimTarihi.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KütüphaneOtomasyonu.Properties.Resources.kitap;
            this.pictureBox1.Location = new System.Drawing.Point(294, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // kategoriEkle
            // 
            this.kategoriEkle.Location = new System.Drawing.Point(105, 150);
            this.kategoriEkle.Name = "kategoriEkle";
            this.kategoriEkle.Size = new System.Drawing.Size(172, 20);
            this.kategoriEkle.TabIndex = 10;
            // 
            // yayinEviEkle
            // 
            this.yayinEviEkle.Location = new System.Drawing.Point(106, 96);
            this.yayinEviEkle.Name = "yayinEviEkle";
            this.yayinEviEkle.Size = new System.Drawing.Size(172, 20);
            this.yayinEviEkle.TabIndex = 9;
            // 
            // yazarEkle
            // 
            this.yazarEkle.Location = new System.Drawing.Point(106, 72);
            this.yazarEkle.Name = "yazarEkle";
            this.yazarEkle.Size = new System.Drawing.Size(172, 20);
            this.yazarEkle.TabIndex = 8;
            // 
            // kitapAdiEkle
            // 
            this.kitapAdiEkle.Location = new System.Drawing.Point(106, 46);
            this.kitapAdiEkle.Name = "kitapAdiEkle";
            this.kitapAdiEkle.Size = new System.Drawing.Size(172, 20);
            this.kitapAdiEkle.TabIndex = 7;
            // 
            // barkodEkle
            // 
            this.barkodEkle.Location = new System.Drawing.Point(106, 20);
            this.barkodEkle.Name = "barkodEkle";
            this.barkodEkle.Size = new System.Drawing.Size(172, 20);
            this.barkodEkle.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayın Evi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kategoriSil);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.Sil);
            this.tabPage2.Controls.Add(this.basimTarihiSil);
            this.tabPage2.Controls.Add(this.yayinEviSil);
            this.tabPage2.Controls.Add(this.yazarSil);
            this.tabPage2.Controls.Add(this.kitapAdiSil);
            this.tabPage2.Controls.Add(this.barkodAra);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitap Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // kategoriSil
            // 
            this.kategoriSil.Location = new System.Drawing.Point(107, 139);
            this.kategoriSil.Name = "kategoriSil";
            this.kategoriSil.Size = new System.Drawing.Size(142, 20);
            this.kategoriSil.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KütüphaneOtomasyonu.Properties.Resources.kitap;
            this.pictureBox2.Location = new System.Drawing.Point(312, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Sil
            // 
            this.Sil.Enabled = false;
            this.Sil.Location = new System.Drawing.Point(107, 170);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(141, 33);
            this.Sil.TabIndex = 27;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // basimTarihiSil
            // 
            this.basimTarihiSil.Location = new System.Drawing.Point(107, 110);
            this.basimTarihiSil.Name = "basimTarihiSil";
            this.basimTarihiSil.Size = new System.Drawing.Size(142, 20);
            this.basimTarihiSil.TabIndex = 25;
            // 
            // yayinEviSil
            // 
            this.yayinEviSil.Location = new System.Drawing.Point(107, 81);
            this.yayinEviSil.Name = "yayinEviSil";
            this.yayinEviSil.Size = new System.Drawing.Size(142, 20);
            this.yayinEviSil.TabIndex = 24;
            // 
            // yazarSil
            // 
            this.yazarSil.Location = new System.Drawing.Point(107, 57);
            this.yazarSil.Name = "yazarSil";
            this.yazarSil.Size = new System.Drawing.Size(142, 20);
            this.yazarSil.TabIndex = 23;
            // 
            // kitapAdiSil
            // 
            this.kitapAdiSil.Location = new System.Drawing.Point(107, 31);
            this.kitapAdiSil.Name = "kitapAdiSil";
            this.kitapAdiSil.Size = new System.Drawing.Size(142, 20);
            this.kitapAdiSil.TabIndex = 22;
            // 
            // barkodAra
            // 
            this.barkodAra.Location = new System.Drawing.Point(107, 5);
            this.barkodAra.Name = "barkodAra";
            this.barkodAra.Size = new System.Drawing.Size(142, 20);
            this.barkodAra.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Basım Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Yayın Evi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Yazarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Kitap Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Barkod";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.kategoriGuncelle);
            this.tabPage3.Controls.Add(this.barkodAraGuncelle);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.Guncelle);
            this.tabPage3.Controls.Add(this.basimTarihiGuncelle);
            this.tabPage3.Controls.Add(this.yayinEviGuncelle);
            this.tabPage3.Controls.Add(this.yazarGuncelle);
            this.tabPage3.Controls.Add(this.kitapAdiGuncelle);
            this.tabPage3.Controls.Add(this.barkodGuncelle);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(643, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kitap Güncelle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // kategoriGuncelle
            // 
            this.kategoriGuncelle.Location = new System.Drawing.Point(100, 139);
            this.kategoriGuncelle.Name = "kategoriGuncelle";
            this.kategoriGuncelle.Size = new System.Drawing.Size(142, 20);
            this.kategoriGuncelle.TabIndex = 47;
            // 
            // barkodAraGuncelle
            // 
            this.barkodAraGuncelle.Location = new System.Drawing.Point(249, 2);
            this.barkodAraGuncelle.Name = "barkodAraGuncelle";
            this.barkodAraGuncelle.Size = new System.Drawing.Size(51, 23);
            this.barkodAraGuncelle.TabIndex = 45;
            this.barkodAraGuncelle.Text = "Ara";
            this.barkodAraGuncelle.UseVisualStyleBackColor = true;
            this.barkodAraGuncelle.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KütüphaneOtomasyonu.Properties.Resources.kitap;
            this.pictureBox3.Location = new System.Drawing.Point(306, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(334, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // Guncelle
            // 
            this.Guncelle.Enabled = false;
            this.Guncelle.Location = new System.Drawing.Point(101, 170);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(141, 33);
            this.Guncelle.TabIndex = 43;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // basimTarihiGuncelle
            // 
            this.basimTarihiGuncelle.Location = new System.Drawing.Point(101, 110);
            this.basimTarihiGuncelle.Name = "basimTarihiGuncelle";
            this.basimTarihiGuncelle.Size = new System.Drawing.Size(142, 20);
            this.basimTarihiGuncelle.TabIndex = 41;
            // 
            // yayinEviGuncelle
            // 
            this.yayinEviGuncelle.Location = new System.Drawing.Point(101, 81);
            this.yayinEviGuncelle.Name = "yayinEviGuncelle";
            this.yayinEviGuncelle.Size = new System.Drawing.Size(142, 20);
            this.yayinEviGuncelle.TabIndex = 40;
            // 
            // yazarGuncelle
            // 
            this.yazarGuncelle.Location = new System.Drawing.Point(101, 57);
            this.yazarGuncelle.Name = "yazarGuncelle";
            this.yazarGuncelle.Size = new System.Drawing.Size(142, 20);
            this.yazarGuncelle.TabIndex = 39;
            // 
            // kitapAdiGuncelle
            // 
            this.kitapAdiGuncelle.Location = new System.Drawing.Point(101, 31);
            this.kitapAdiGuncelle.Name = "kitapAdiGuncelle";
            this.kitapAdiGuncelle.Size = new System.Drawing.Size(142, 20);
            this.kitapAdiGuncelle.TabIndex = 38;
            // 
            // barkodGuncelle
            // 
            this.barkodGuncelle.Location = new System.Drawing.Point(101, 5);
            this.barkodGuncelle.Name = "barkodGuncelle";
            this.barkodGuncelle.Size = new System.Drawing.Size(142, 20);
            this.barkodGuncelle.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Basım Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Yayın Evi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Yazarı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Kitap Adı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Barkod";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(643, 242);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tüm Kitaplar";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 282);
            this.Controls.Add(this.Otomasyon);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Otomasyon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Otomasyon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kategoriEkle;
        private System.Windows.Forms.TextBox yayinEviEkle;
        private System.Windows.Forms.TextBox yazarEkle;
        private System.Windows.Forms.TextBox kitapAdiEkle;
        private System.Windows.Forms.TextBox barkodEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.TextBox basimTarihiSil;
        private System.Windows.Forms.TextBox yayinEviSil;
        private System.Windows.Forms.TextBox yazarSil;
        private System.Windows.Forms.TextBox kitapAdiSil;
        private System.Windows.Forms.TextBox barkodAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button barkodAraGuncelle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.TextBox basimTarihiGuncelle;
        private System.Windows.Forms.TextBox yayinEviGuncelle;
        private System.Windows.Forms.TextBox yazarGuncelle;
        private System.Windows.Forms.TextBox kitapAdiGuncelle;
        private System.Windows.Forms.TextBox barkodGuncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox basimTarihi;
        private System.Windows.Forms.TextBox kategoriSil;
        private System.Windows.Forms.TextBox kategoriGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

