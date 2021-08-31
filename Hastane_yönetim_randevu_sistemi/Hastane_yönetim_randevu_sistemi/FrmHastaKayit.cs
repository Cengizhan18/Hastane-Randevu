﻿using System;
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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,hastasifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxtc.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxtel.Text);
            komut.Parameters.AddWithValue("@p5", textBoxsifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Yapıldı  Şifreniz: "+textBoxsifre.Text,"Bilig",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
