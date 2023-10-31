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
    public partial class FrmÖğretmenDetay : Form
    {
        public FrmÖğretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=FEYZA;Initial Catalog=dbNotKayıt;Integrated Security=True"); // SQL'den çektiğimiz datayı bağladık.
        private void FrmÖğretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", baglanti); // insert into= kaydet
            komut.Parameters.AddWithValue("@P1", mskNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery(); // Sorguyu çalıştır, sorguyu gerçekleştir anlamında bu komutu kullanıyoruz
            baglanti.Close();
            MessageBox.Show("Öğrenci sisteme eklendi!");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS); // Otomatik doldurma komutu, yeni eklenen öğrencinin listede olup olmadığını görüntüleriz.

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtVize.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString(); // txtVize, sql server'da 4. indekste, seçilen satırı görüntüleme işlemi..
            txtFinal.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtBüt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtVize.Text);
            s2 = Convert.ToDouble(txtFinal.Text);
            s3 = Convert.ToDouble(txtBüt.Text);
            if ( txtBüt.Text == "0") 
            {
                ortalama = (s1 + s2) / 2;
                lblOrtalama.Text = ortalama.ToString();
            }
            else
            {              
                ortalama = (s1 + s2 + s3) / 3;
                lblOrtalama.Text = ortalama.ToString();

            }
            if (ortalama >= 50)
            {
                durum = "TRUE";
            }
            else
            {
                durum = "FALSE";
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1 = @P1, OGRS2= @P2, OGRS3 = @P3, ORTALAMA= @P4, DURUM = @P5 WHERE OGRNUMARA= @P6", baglanti);

            komut.Parameters.AddWithValue("@P1", txtVize.Text);
            komut.Parameters.AddWithValue("@P2", txtFinal.Text);
            komut.Parameters.AddWithValue("@P3", txtBüt.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblOrtalama.Text)); // SQL tabanında decimal old. için dönüştürdük.
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci notları güncellendi!");

                baglanti.Open();
                SqlCommand gecen = new SqlCommand("select count(*) as say from TBLDERS  WHERE durum = 'True'", baglanti);
                gecen.ExecuteNonQuery();
                SqlDataReader dr = gecen.ExecuteReader();
                if (dr.Read())
                {
                    lblGeçenSayısı.Text = dr["say"].ToString();
                }
                else
                {
                    lblGeçenSayısı.Text = "Veri cekilemedi!";
                }
                baglanti.Close();
                this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

            baglanti.Open();
            SqlCommand kalan = new SqlCommand("select count (*) as say from TBLDERS WHERE durum = 'false'", baglanti);
            kalan.ExecuteNonQuery();
            SqlDataReader sdr = kalan.ExecuteReader();
            if (sdr.Read())
            {
                lblKalanSayısı.Text = sdr["say"].ToString();
            }
            else
            {
                lblKalanSayısı.Text = "Veri çekilemedi!";
            }
            baglanti.Close();
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
        }

        private void btnÖğrenciSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand sil = new SqlCommand( " DELETE from TBLDERS where OGRID = @a " , baglanti);
            sil.Parameters.AddWithValue("@a", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci silindi!!");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);        
        }
    }
}
