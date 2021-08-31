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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = tc;

            // ad soyad cekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HAstaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labeladsoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC= " + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();



        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxdoctor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBoxbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                comboBoxdoctor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();

        }

        private void comboBoxdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_randevular where Randevubrans='" + comboBoxbrans.Text + "'"+" and Randevudoktor='" +comboBoxdoctor.Text+"' and RandevuDurum=0", bgl.baglanti()) ;
            da.Fill(dt);
            dataGridView2.DataSource = dt;




        }

        private void linkLabelbilgdüz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Bilgi_Düzenle fr = new Frm_Bilgi_Düzenle();
            fr.tcno = labelTc.Text;

            fr.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void buttonrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            komut.Parameters.AddWithValue("@p2", richTextBoxsikayet.Text);
            komut.Parameters.AddWithValue("@p3", textBoxid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
