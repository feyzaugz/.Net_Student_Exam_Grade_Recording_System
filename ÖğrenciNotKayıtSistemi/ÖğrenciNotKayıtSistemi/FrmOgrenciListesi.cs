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
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet3.OGRENCI_KUTUK' table. You can move, or remove it, as needed.
            this.oGRENCI_KUTUKTableAdapter.Fill(this.dbNotKayıtDataSet3.OGRENCI_KUTUK);

        }

        private void editFormUserControl1_Load(object sender, EventArgs e)
        {
                    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
