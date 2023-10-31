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
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }
        private void öğrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrenciekle = new FrmOgrenciIsleri();
            ogrenciekle.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ogrencilistesi = new FrmOgrenciListesi();
            ogrencilistesi.Show();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
