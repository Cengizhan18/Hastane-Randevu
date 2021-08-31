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
    public partial class fRMHASTAgİRİS : Form
    {
        public fRMHASTAgİRİS()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void linkLabelüyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_hastalar where hastaTC=@p1 and HAstasifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = maskedTextBoxTC.Text;

                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Şifre ya da TC");

            }
            bgl.baglanti().Close();


        }
    }
}
