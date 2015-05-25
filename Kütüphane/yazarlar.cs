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
    public partial class yazarlar : Form
    {
        public yazarlar()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public static int yazar_id;
        public void datagrid_doldur()
        {
            DataTable yazarlar = new DataTable();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT yazar_id, (yazar_adi || ' ' || yazar_soyadi) AS ad_soyad FROM yazarlar;", veritabani.baglanti);
            komut.Fill(yazarlar);
            dataGridView1.DataSource = yazarlar;
            veritabani.baglanti.Close();
        }

        private void yazarlar_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            dataGridView1.Columns["yazar_id"].Visible = false;

            dataGridView1.Columns["ad_soyad"].HeaderText = "Yazar Adı Soyadı";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                yazar_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
            
        }

        private void b_ktp_ekle_Click(object sender, EventArgs e)
        {
            yazar_ekle yazar_ekle = new yazar_ekle();
            yazar_ekle.Show();
        }

        private void b_ktp_duzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                yazar_duzenle yazar_duzenle = new yazar_duzenle();
                yazar_duzenle.Show();
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
                DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    veritabani.baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("DELETE FROM yazarlar WHERE yazar_id=" + yazar_id + ";", veritabani.baglanti);
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
                yazar_duzenle yazar_duzenle = new yazar_duzenle();
                yazar_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
