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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_branslar (bransad) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ;

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_branslar where bransid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");

        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPdate Tbl_branslar set bransad=@p1 where bransid=@p2  ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxad.Text);
            komut.Parameters.AddWithValue("@p2", textBoxid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
