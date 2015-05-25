using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kütüphane
{
    public partial class kategoriler : Form
    {
        public kategoriler()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public static int kategori_id;

        public void datagrid_doldur()
        {
            DataTable kategori = new DataTable();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT kategori_id, kategori_adi FROM kategori;", veritabani.baglanti);
            komut.Fill(kategori);
            dataGridView1.DataSource = kategori;
            veritabani.baglanti.Close();
        }

        private void kategoriler_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            dataGridView1.Columns["kategori_id"].Visible = false;
            dataGridView1.Columns["kategori_adi"].HeaderText = "Kategori Adı";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                kategori_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }

        private void b_ktp_ekle_Click(object sender, EventArgs e)
        {
            kategori_ekle kategori_ekle = new kategori_ekle();
            kategori_ekle.Show();
        }

        private void b_ktp_duzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                kategori_duzenle kategori_duzenle = new kategori_duzenle();
                kategori_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_ktp_sil_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    veritabani.baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("DELETE FROM kategori WHERE kategori_id=" + kategori_id + ";", veritabani.baglanti);
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    datagrid_doldur();
                }
                else if (secenek == DialogResult.No) { }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = Color.DarkCyan;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                kategori_duzenle kategori_duzenle = new kategori_duzenle();
                kategori_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
