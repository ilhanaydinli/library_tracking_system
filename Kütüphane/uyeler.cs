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
    public partial class uyeler : Form
    {
        public uyeler()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public static int uye_id;
        public void datagrid_doldur()
        {
            DataSet uyeler = new DataSet();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT uye_id, (uye_adi || ' ' || uye_soyadi) AS uye_adsoyad, uye_tc_no, uye_telefon, uye_e_posta, uye_adres FROM uyeler;", veritabani.baglanti);
            komut.Fill(uyeler, "uyeler");
            dataGridView1.DataSource = uyeler.Tables["uyeler"];
            veritabani.baglanti.Close();
        }

        private void uyeler_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            dataGridView1.Columns["uye_id"].Visible = false;

            dataGridView1.Columns["uye_adsoyad"].HeaderText = "Üye Ad Soyad";
            dataGridView1.Columns["uye_tc_no"].HeaderText = "TC NO";
            dataGridView1.Columns["uye_telefon"].HeaderText = "Telefon";
            dataGridView1.Columns["uye_e_posta"].HeaderText = "E-Posta";
            dataGridView1.Columns["uye_adres"].HeaderText = "Adres";
        }

        private void b_uye_ekle_Click(object sender, EventArgs e)
        {
            uye_ekle uye_ekle = new uye_ekle();
            uye_ekle.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           try
           {
               uye_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
           }
           catch { }
        }

        private void b_uye_duzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                uye_duzenle uye_duzenle = new uye_duzenle();
                uye_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_uye_sil_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    veritabani.baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("DELETE FROM uyeler WHERE uye_id=" + uye_id + ";", veritabani.baglanti);
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
                uye_duzenle uye_duzenle = new uye_duzenle();
                uye_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
