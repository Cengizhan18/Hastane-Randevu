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

namespace Hastane_yönetim_randevu_sistemi
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.tc = maskedTextBoxTC.Text;

                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı & şifre ");

            }
            bgl.baglanti().Close();

        }
    }
}
