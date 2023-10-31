using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Data.SqlClient;

namespace ÖğrenciNotKayıtSistemi
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage(); // mesajım adlı bir nesne oluşturduk
            SmtpClient istemci = new SmtpClient();   // istemci adlı bir nesne oluşturduk
            istemci.Credentials = new System.Net.NetworkCredential("feyzaugz3@gmail.com", "Hugohudojudo+7"); // istemcinin kimlik bilgilerini girdik
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true; // Ssl= sunucu ile istemci arasında doğru adrese gönderene kadar şifreleme yapan komut
            mesajım.To.Add(txtMail.Text);
            mesajım.From = new MailAddress("feyzaugz3@gmail.com"); // Hangi adresten mail gönderilmesini istiyorsak onu yazıyoruz.
            mesajım.Subject = "Şifre Değiştirme";
            Random rnd = new Random();  // Random sınıfı örneği oluşturma
            int sayi = rnd.Next(); // sayi değişkenine rastgele bir sayı atar
            mesajım.Body = sayi.ToString();
            istemci.Send(mesajım);
            MessageBox.Show("Lütfen mailinizi kontrol ediniz!");
        }
    }
}
