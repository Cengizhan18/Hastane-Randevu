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
    public partial class Frm_Bilgi_Düzenle : Form
    {
        public Frm_Bilgi_Düzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Frm_Bilgi_Düzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxtc.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where hastatc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                textBoxad.Text = dr[1].ToString();
                textBoxsoyad.Text = dr[2].ToString();
                maskedTextBoxtel.Text = dr[4].ToString();
                textBoxsifre.Text = dr[5].ToString();
                comboBoxcinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();

        }

        private void buttonbilggüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_hastalar set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBoxtel.Text);
            komut2.Parameters.AddWithValue("@p4", textBoxsifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboBoxcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", maskedTextBoxtc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
