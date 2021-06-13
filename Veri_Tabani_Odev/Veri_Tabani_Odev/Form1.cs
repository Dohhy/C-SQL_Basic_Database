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

namespace Veri_Tabani_Odev
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Server = Your computer's name; Initial Catalog = denemeproje; Integrated Security = SSPI");
        SqlCommand komut;
        SqlDataAdapter verial;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        //Form Başlangıcında Yazıları ComboBoxlara Aktarıyoruz
        private void Form1_Load(object sender, EventArgs e)
        {
            HastaSiralama();
            HastaneSiralamaCombo();
            PoliklinikSiralamaCombo();
        }

        //Hastaları Tabloda Sıralama Fonksiyonu
        public void HastaSiralama()
        {
            baglanti.Open();
            verial = new SqlDataAdapter("SELECT * FROM Hastalar", baglanti);
            ds = new DataSet();
            verial.Fill(ds); //Data Set'i dolduruyoruz
            hastalartablosu.DataSource = ds.Tables[0]; //Hastalar Tablosuna Verileri Ekliyoruz
            baglanti.Close();
        }

        //Hastaneleri Tabloda Sıralama Fonksiyonu
        public void HastaneSiralama()
        {
            baglanti.Open();
            SqlDataAdapter verial2 = new SqlDataAdapter("SELECT * FROM Hastaneler", baglanti);
            DataSet ds2 = new DataSet();
            verial2.Fill(ds2);
            hastanelertablosu.DataSource = ds2.Tables[0];
            baglanti.Close();
        }

        //Poliklinikleri Tabloda Sıralama Fonksiyonu
        public void PoliklinikSiralama()
        {
            baglanti.Open();
            SqlDataAdapter verial3 = new SqlDataAdapter("SELECT * FROM Poliklinikler", baglanti);
            DataSet ds3 = new DataSet();
            verial3.Fill(ds3);
            polikliniklertablosu.DataSource = ds3.Tables[0];
            baglanti.Close();
        }

        //ComboBoxlar
        public void HastaneSiralamaCombo()
        {
            baglanti.Open();
            SqlDataAdapter veriAl4 = new SqlDataAdapter("select distinct HastaneAdi from Hastaneler", baglanti);
            DataSet ds4 = new DataSet();
            veriAl4.Fill(ds4);
            comboBox1.DataSource = ds4.Tables[0];
            comboBox1.DisplayMember = "HastaneAdi";
            comboBox1.ValueMember = "HastaneAdi";
            baglanti.Close();
        }

        public void PoliklinikSiralamaCombo()
        {
            baglanti.Open();
            SqlDataAdapter veriAl5 = new SqlDataAdapter("select distinct PoliklinikAdi from Poliklinikler", baglanti);
            DataSet ds5 = new DataSet();
            veriAl5.Fill(ds5);
            comboBox2.DataSource = ds5.Tables[0];
            comboBox2.DisplayMember = "PoliklinikAdi";
            comboBox2.ValueMember = "PoliklinikAdi";
            baglanti.Close();
        }

        //İlk Sayfa İşlemleri
        //Randevu Oluştur Butonu
        private void randevuolusturbutonu_Click(object sender, EventArgs e) 
        {
            //Hasta Ekleme İşlemi
            komut = new SqlCommand("INSERT INTO Hastalar(HastaAdiSoyadi, Poliklinik, HastaneAdi) VALUES(@hastaadisoyadi, @poliklinik, @hastaneadi)", baglanti);
            komut.Parameters.AddWithValue("@hastaadisoyadi", textBox1.Text);
            komut.Parameters.AddWithValue("@poliklinik", comboBox2.Text);
            komut.Parameters.AddWithValue("@hastaneadi", comboBox1.Text);
            //Bağlantı Kontrolü
            try
            {
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bağlantı Hatası");
            }
            HastaSiralama();
        }

        //Randevu İptal Et Butonu
        private void randevuiptalbutonu_Click(object sender, EventArgs e) 
        {
            komut = new SqlCommand("DELETE FROM Hastalar WHERE hastaid=@hastaid", baglanti);
            komut.Parameters.AddWithValue("@hastaid", hastaidlabel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            HastaSiralama();
        }

        //Hastalar Tablosuna Çift Tıklama
        private void hastalartablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            hastaidlabel.Text = hastalartablosu.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = hastalartablosu.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = hastalartablosu.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = hastalartablosu.CurrentRow.Cells[2].Value.ToString();
        }

        //Hastane Kaydet Butonu
        private void hastanekaydetbutonu_Click(object sender, EventArgs e)
        {
            //Hastane Ekleme İşlemi
            komut = new SqlCommand("INSERT INTO Hastaneler(HastaneAdi) VALUES(@hastaneadi)", baglanti);
            komut.Parameters.AddWithValue("@hastaneadi", textBox2.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            HastaneSiralama();
            HastaneSiralamaCombo();
        }

        //Hastane Sil Butonu
        private void hastanesil_Click(object sender, EventArgs e)
        {
            //Hastane Silme İşlemi
            komut = new SqlCommand("DELETE FROM Hastaneler WHERE hastaneid=@hastaneid", baglanti);
            komut.Parameters.AddWithValue("@hastaneid", hastaneidlabel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            HastaneSiralama();
            HastaneSiralamaCombo();
        }

        //Hastane Listele Butonu
        private void hastanelistelebutonu_Click(object sender, EventArgs e)
        {
            HastaneSiralama();
        }

        //Hastane Güncelle Butonu
        private void hastaneguncellebutonu_Click(object sender, EventArgs e)
        {
            //Tablodaki Hastane Verilerini id ye Göre Güncelleme İşlemi
            komut = new SqlCommand("UPDATE Hastaneler SET HastaneAdi=@hastaneadi WHERE hastaneid=@hastaneid", baglanti);
            komut.Parameters.AddWithValue("@hastaneadi", textBox2.Text);
            komut.Parameters.AddWithValue("@hastaneid", hastaneidlabel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            HastaneSiralama();
            HastaneSiralamaCombo();
        }

        //Hastaneler Tablosuna Çift Tıklama
        private void hastanelertablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hastaneidlabel.Text = hastanelertablosu.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = hastanelertablosu.CurrentRow.Cells[1].Value.ToString();
        }


        //Poliklinik Ekleme Butonu
        private void poliklinikkaydetbutonu_Click(object sender, EventArgs e)
        {
            //Tabloya Poliklinik Ekleme İşlemi
            komut = new SqlCommand("INSERT INTO Poliklinikler(PoliklinikAdi) VALUES(@poliklinikadi)", baglanti);
            komut.Parameters.AddWithValue("@poliklinikadi", textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PoliklinikSiralama();
            PoliklinikSiralamaCombo();
        }

        //Poliklinik Sil Butonu
        private void polikliniksilbuton_Click(object sender, EventArgs e)
        {
            //Tablodan Poliklinik Silme İşlemi
            komut = new SqlCommand("DELETE FROM Poliklinikler WHERE poliklinikid=@poliklinikid", baglanti);
            komut.Parameters.AddWithValue("@poliklinikid", poliklinikidlabel.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PoliklinikSiralama();
            PoliklinikSiralamaCombo();
        }

        //Poliklinik Güncelle Butonu
        private void poliklinikguncellebutonu_Click(object sender, EventArgs e)
        {
            //Poliklinik Verilerini id ye Göre Güncelleme İşlemi
            komut = new SqlCommand("UPDATE Poliklinikler SET PoliklinikAdi=@poliklinikadi WHERE poliklinikid=@poliklinikid", baglanti);
            komut.Parameters.AddWithValue("@poliklinikid", poliklinikidlabel.Text);
            komut.Parameters.AddWithValue("@poliklinikadi", textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PoliklinikSiralama();
            PoliklinikSiralamaCombo();
        }

        //Poliklinik Listele Butonu
        private void polikliniklistelebutonu_Click(object sender, EventArgs e)
        {
            PoliklinikSiralama();
        }

        //Poliklinikler Tablosuna Çift Tıklama
        private void polikliniklertablosu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            poliklinikidlabel.Text = polikliniklertablosu.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = polikliniklertablosu.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
