using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_yönetim_randevu_sistemi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void buttonhastagirisi_Click(object sender, EventArgs e)
        {
            fRMHASTAgİRİS fr = new fRMHASTAgİRİS();
            fr.Show();
            this.Hide();
        }

        private void buttondoktorgirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
            this.Hide();

        }

        private void buttonsekretergirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();

        }
    }
}
