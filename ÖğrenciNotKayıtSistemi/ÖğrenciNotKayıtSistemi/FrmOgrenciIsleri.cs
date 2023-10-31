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

namespace ÖğrenciNotKayıtSistemi
{
    public partial class FrmOgrenciIsleri : Form
    {
        public FrmOgrenciIsleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=FEYZA;Initial Catalog=dbNotKayıt;Integrated Security=True"); // SQL'den veri çektik
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into OGRENCI_KUTUK (ADI,SOYADI,NO,TCKIMLIK,MAIL,ADRESI,SIFRESI,BOLUMU,SINIFI) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", baglanti); // insert into = kaydet
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", txtNo.Text);
            komut.Parameters.AddWithValue("@P4", txtKimlik.Text);
            komut.Parameters.AddWithValue("@P5", txtMail.Text);
            komut.Parameters.AddWithValue("@P6", txtAdres.Text);
            komut.Parameters.AddWithValue("@P7", txtSifre.Text);
            komut.Parameters.AddWithValue("@P8", txtBolum.Text);
            komut.Parameters.AddWithValue("@P9", txtSinif.Text);
            komut.ExecuteNonQuery(); // Sorguyu çalıştırır
            baglanti.Close();
            MessageBox.Show("Öğrenci başarıyla kaydedildi!");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("DELETE from OGRENCI_KUTUK where NO = @P1", baglanti);
            sil.Parameters.AddWithValue("@P1", Convert.ToInt64(txtNo.Text));
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci başarıyla silindi!");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
