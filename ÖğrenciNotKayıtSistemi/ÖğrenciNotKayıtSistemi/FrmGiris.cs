using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciNotKayıtSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     
                FrmÖğrenciDetay frm = new FrmÖğrenciDetay(); // frmöğrencidetay formunda frm isminde yeni bir nesne ürettik.
                frm.öğrencino = maskedTextBox1.Text; // maskedtextbox1'deki değeri frm isminde ürettiğimiz nesneye atadık. Frmm komutuyla frmöğrencidetay formundaki özelliklere ve public olan komutlara ulaşabiliyoruz.                                    
                frm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
               FrmÖğretmenGiriş fr = new FrmÖğretmenGiriş();
                fr.Show();
        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum frm = new FrmSifremiUnuttum();
            frm.Show();
        }
    }
}
