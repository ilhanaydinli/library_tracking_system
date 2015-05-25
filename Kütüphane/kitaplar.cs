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
    public partial class kitaplar : Form
    {
        public kitaplar()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public static int kitap_id;

        public void datagrid_doldur()
        {
            DataTable kitaplar = new DataTable();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT kitaplar.kitap_id, kitaplar.kitap_adi, kitaplar.isbn, (yazarlar.yazar_adi || ' ' || yazarlar.yazar_soyadi) AS yazar_adsoyad, yayin_evi.yayine_adi, kategori.kategori_adi, kitaplar.resim FROM kitaplar INNER JOIN yazarlar ON kitaplar.yazar_id=yazarlar.yazar_id INNER JOIN kategori ON kitaplar.kategori_id=kategori.kategori_id INNER JOIN yayin_evi ON yayin_evi.yayine_id=kitaplar.yayine_id;", veritabani.baglanti);
            komut.Fill(kitaplar);
            dataGridView1.DataSource = kitaplar;
            veritabani.baglanti.Close();
        }

        private void kitaplar_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            datagrid_doldur();
            dataGridView1.Columns["kitap_id"].Visible = false;
            dataGridView1.Columns["resim"].Visible = false;

            dataGridView1.Columns["kitap_adi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["isbn"].HeaderText = "ISBN";
            dataGridView1.Columns["yazar_adsoyad"].HeaderText = "Yazar Ad Soyad";
            dataGridView1.Columns["yayine_adi"].HeaderText = "Yayın Evi Adı";
            dataGridView1.Columns["kategori_adi"].HeaderText = "Kategori Adı";
        }

        private void b_ktp_ekle_Click(object sender, EventArgs e)
        {
            kitap_ekle kitap_ekle = new kitap_ekle();
            kitap_ekle.Show();
        }

        private void b_ktp_sil_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    veritabani.baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("DELETE FROM kitaplar WHERE kitap_id=" + kitap_id + ";", veritabani.baglanti);
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
        private void b_ktp_duzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                kitap_duzunle kitap_duzenle = new kitap_duzunle();
                kitap_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kitap_duzunle kitap_duzenle = new kitap_duzunle();
            kitap_duzenle.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                kitap_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[6].Value.ToString() != "")
                {
                    pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                }
                else
                {
                    this.pictureBox1.Image = Kütüphane.Resource1.resimyok;
                }
            }
            catch { }
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                kitap_duzunle kitap_duzenle = new kitap_duzunle();
                kitap_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
