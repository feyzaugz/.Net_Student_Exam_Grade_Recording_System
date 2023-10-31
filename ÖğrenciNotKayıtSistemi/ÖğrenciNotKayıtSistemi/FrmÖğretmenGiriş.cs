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
    public partial class FrmÖğretmenGiriş : Form
    {
        public FrmÖğretmenGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox2.Text == "1111")
            {
                FrmÖğretmenDetay öğretmengiriş = new FrmÖğretmenDetay();
                öğretmengiriş.Show();
                Hide();
            }
        }
    }
}
