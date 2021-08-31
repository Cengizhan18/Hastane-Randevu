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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = tc;

            //doktro ad soyad cekme

            SqlCommand komut = new SqlCommand("Select doktorad,doktorsoyad  from Tbl_doktorlar where doktortc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTc.Text);
            SqlDataReader dr = komut.ExecuteReader();


            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] +" "+ dr[1];

            }
            bgl.baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where randevudoktor='"+labelAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void buttonbilgidüzen_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.tcno = labelTc.Text;

            fr.Show();

        }

        private void buttonduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();

        }

        private void buttoncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBoxsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


        }
    }
}
