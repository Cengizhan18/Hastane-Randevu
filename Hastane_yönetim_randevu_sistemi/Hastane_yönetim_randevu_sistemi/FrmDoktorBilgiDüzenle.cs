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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tcno;

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxtc.Text = tcno;

            SqlCommand komut = new SqlCommand("select * from Tbl_doktorlar where doktortc= @p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxad.Text = dr[1].ToString();
                textBoxsoyad.Text = dr[2].ToString();
                comboBoxbrans.Text = dr[3].ToString();
                textBoxsifre.Text = dr[5].ToString();

            }
            bgl.baglanti().Close();



        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p5 where doktortc=@p4 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxtc.Text);
            komut.Parameters.AddWithValue("@p5", textBoxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }
    }
}
