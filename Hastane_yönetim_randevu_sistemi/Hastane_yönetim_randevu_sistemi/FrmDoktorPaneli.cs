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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;



            //branslarıcombox aktarma
            SqlCommand komut2 = new SqlCommand("Select bransad from Tbl_branslar   ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbrans.Items.Add(dr2[0]);



            }
            bgl.baglanti().Close();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_doktorlar (doktorad,doktorsoyad,doktorbrans,doktortc,doktorsifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxtc.Text);
            komut.Parameters.AddWithValue("@p5", textBoxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxtc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
           textBoxsifre .Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  Tbl_doktorlar set doktorad=@p1,doktorsoyad=@p1,doktorbrans=@p3,doktorsifre=@p5 where doktortc=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxtc.Text);
            komut.Parameters.AddWithValue("@p5", textBoxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
