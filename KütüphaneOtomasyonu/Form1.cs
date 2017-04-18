using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           public SqlConnection baglanti;
           
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }            
            SqlCommand tumVeriler = new SqlCommand("SELECT * FROM kitapBilgileri",baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(tumVeriler);
            DataTable table = new DataTable();
            adaptor.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO kitapBilgileri(barkod,kitapAdi,yazar,yayinEvi,basimTarihi,kategori) VALUES (@barkod,@kitapAdi,@yazar,@yayinEvi,@basimTarihi,@kategori)", baglanti);
                ekle.Parameters.AddWithValue("@barkod", Convert.ToInt16(barkodEkle.Text.Trim()));
                ekle.Parameters.AddWithValue("@kitapAdi", kitapAdiEkle.Text.Trim());
                ekle.Parameters.AddWithValue("@yazar", yazarEkle.Text.Trim());
                ekle.Parameters.AddWithValue("@yayinEvi", yayinEviEkle.Text.Trim());
                ekle.Parameters.AddWithValue("@basimTarihi", basimTarihi.Text.Trim());
                ekle.Parameters.AddWithValue("@kategori", kategoriEkle.Text.Trim());

                ekle.ExecuteNonQuery();
                
                MessageBox.Show("Ekleme işlemi başarıyla yapılmıştır.");
                baglanti.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Bu Barkod Numarası Başka Bir Kitaba Aittir... !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");
                if (baglanti.State==ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand sil = new SqlCommand("DELETE FROM kitapBilgileri WHERE barkod="+barkodAra.Text.Trim(),baglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarıyla yapılmıştır.");
                baglanti.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Silme işlemi yapılırken bir hata oluştu. Lütfen kitabın olup olmadığını kontrol ediniz...");
            }
            barkodAra.Text = "";
            kitapAdiSil.Text = "";
            yazarSil.Text = "";
            yayinEviSil.Text = "";
            basimTarihiSil.Text = "";
            kategoriSil.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }              
            SqlCommand barkodBul = new SqlCommand("SELECT * FROM kitapBilgileri WHERE barkod="+barkodAra.Text+"",baglanti);
            barkodBul.ExecuteNonQuery();
            SqlDataReader dataReader = barkodBul.ExecuteReader();
            if (dataReader.Read())
            {
                kitapAdiSil.Text = dataReader["kitapAdi"].ToString();
                yazarSil.Text = dataReader["yazar"].ToString();
                yayinEviSil.Text = dataReader["yayinEvi"].ToString();
                basimTarihiSil.Text = dataReader["basimTarihi"].ToString();
                kategoriSil.Text = dataReader["kategori"].ToString();
            }
            baglanti.Dispose();
            baglanti.Close();
            dataReader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Silme Hatası...");
            }
            if (barkodAra.Text != "")
            {
                Sil.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand barkodBul = new SqlCommand("SELECT * FROM kitapBilgileri WHERE barkod=" +barkodGuncelle.Text + "", baglanti);
                barkodBul.ExecuteNonQuery();
                SqlDataReader dataReader = barkodBul.ExecuteReader();
                if (dataReader.Read())
                {
                    kitapAdiGuncelle.Text = dataReader["kitapAdi"].ToString();
                    yazarGuncelle.Text = dataReader["yazar"].ToString();
                    yayinEviGuncelle.Text = dataReader["yayinEvi"].ToString();
                    basimTarihiGuncelle.Text = dataReader["basimTarihi"].ToString();
                    kategoriGuncelle.Text = dataReader["kategori"].ToString();
                }
                baglanti.Dispose();
                baglanti.Close();
                dataReader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Silme Hatası...");
            }
            if (barkodAraGuncelle.Text != "")
            {
                Guncelle.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");
                baglanti.Open();
                SqlCommand kitapAdiBul = new SqlCommand("SELECT * FROM kitapBilgileri WHERE kitapAdi=" + kitapAdiSil.Text.Trim(), baglanti);
                kitapAdiBul.ExecuteNonQuery();
                SqlDataReader dataReader = kitapAdiBul.ExecuteReader();
                if (dataReader.Read())
                {
                    barkodAra.Text = dataReader["barkod"].ToString();
                    yazarSil.Text = dataReader["yazar"].ToString();
                    yayinEviSil.Text = dataReader["yayinEvi"].ToString();
                    basimTarihiSil.Text = dataReader["basimTarihi"].ToString();
                    kategoriSil.Text = dataReader["kategori"].ToString();
                }
                baglanti.Dispose();
                dataReader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Arama Bulunamadı...");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=Kutuphane; Integrated Security=true");

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand guncelle = new SqlCommand("UPDATE kitapBilgileri SET "+
                   "barkod=@barkod,kitapAdi=@kitapAdi,yazar=@yazar,yayinEvi=@yayinEvi,"+
                   "basimTarihi=@basimTarihi,kategori=@kategori WHERE barkod=@barkod",baglanti);
                guncelle.Parameters.AddWithValue("@barkod",barkodGuncelle.Text);
                guncelle.Parameters.AddWithValue("@kitapAdi", kitapAdiGuncelle.Text);
                guncelle.Parameters.AddWithValue("@yazar", yazarGuncelle.Text);
                guncelle.Parameters.AddWithValue("@yayinEvi", yayinEviGuncelle.Text);
                guncelle.Parameters.AddWithValue("@basimTarihi", basimTarihiGuncelle.Text);
                guncelle.Parameters.AddWithValue("@kategori", kategoriGuncelle.Text);

                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi başarıyla yapılmıştır...");

            }
            catch (SqlException)
            {
                MessageBox.Show("Veri bulunamıyor yada hatalı giriş yaptınız...");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
