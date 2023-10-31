using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL kütüphanesini ekledik, verileri oradan çekeceğiz.

namespace ÖğrenciNotKayıtSistemi
{
    public partial class FrmÖğrenciDetay : Form
    {
        public FrmÖğrenciDetay()
        {
            InitializeComponent();
        }

        public string öğrencino;  // Başka yerlerden görüntülemek için public kullandık. Numara adında yeni bir değişken tanımladık.
        SqlConnection baglanti = new SqlConnection(@"Data Source=FEYZA;Initial Catalog=dbNotKayıt;Integrated Security=True"); // SQL'den çektiğimiz datayı bağladık.
        private void FrmÖğrenciDetay_Load(object sender, EventArgs e)
        {
            lblÖğrenciNo.Text = öğrencino;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti); // baglanti komutuyla, TBLDERS'ten OGRNUMARA verilerini seçtik. Hangi bağlantıyı işleyeceğimizi belirlemek için böyle bir kod yazdık.OGRNUMARA'yı p1 adlı komuta kaydettik. Öğrenci no ile giriş yaptığımız için OGRNUMARA bağlantısını kullandık.
            komut.Parameters.AddWithValue("@p1", öğrencino); // p1 komutuna öğrencino'yu atadık.
            SqlDataReader dr = komut.ExecuteReader(); // dr adlı okuma komutu oluşturduk
            while (dr.Read()) // dr komutu okunduğu sürece döndürecek
            {
                lblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString(); // dr[2] = sql server'da 2.indeks'te "ad" olduğu için dr[2] şeklinde yazdık ve string dönüşümü yaptık. İndeksler 0-1-2 şeklinde gider.
                lblVize.Text = dr[4].ToString();
                lblFinal.Text = dr[5].ToString();
                lblBüt.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
            }
            baglanti.Close();

            if (lblDurum.Text == "True")

            {

                lblDurum.Text = "Gecti";

            }

            else

            {

                lblDurum.Text = "Kaldi";

            }

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }
    }
}
