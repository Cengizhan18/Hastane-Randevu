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
    public partial class FrmSekretrDetay : Form
    {
        public FrmSekretrDetay()
        {
            InitializeComponent();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_randevular (RandevuTarih, RandevuSaat,RandevuBrans,RandevuDoktor)values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", maskedTextBoxtarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", maskedTextBoxsaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", comboBoxbrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", comboBoxdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }
        public string tcnumara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmSekretrDetay_Load(object sender, EventArgs e)
        {
            labeltc.Text = tcnumara;

            //ad soyad çekme
            SqlCommand komut1 = new SqlCommand("select sekreteradsoyad from Tbl_sekreter where sekretertc= @p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", labeltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                labeladsoyad.Text = dr1[0].ToString();


            }
            bgl.baglanti().Close();

            //branşları datagride cekme

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_branslar ",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //doktroları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktorad+ ' '+doktorsoyad) as 'Doktorlar ',Doktorbrans from Tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı combobox a aktarma
            SqlCommand komut2 = new SqlCommand("Select bransad from Tbl_branslar   ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbrans.Items.Add(dr2[0]);



            }
            bgl.baglanti().Close();


          
        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxdoktor.Items.Clear();


            SqlCommand komut = new SqlCommand("Select doktorad,doktorsoyad from Tbl_doktorlar where doktorbrans= @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxdoktor.Items.Add(dr[0] + " " + dr[1]);

            }
            bgl.baglanti().Close();

        }

        private void buttonolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBoxduyuruolustru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void buttondocpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();

        }

        private void buttonbranspanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();

        }

        private void buttonrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();

        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
        }

        private void buttonduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();

        }
    }
}
