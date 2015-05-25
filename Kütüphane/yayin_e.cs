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
    public partial class yayin_e : Form
    {
        public yayin_e()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public static int yayine_id;
        public void datagrid_doldur()
        {
            DataTable yayinevi = new DataTable();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT yayine_id, yayine_adi, yayine_telefon, yayine_adres, yayine_eposta FROM yayin_evi;", veritabani.baglanti);
            komut.Fill(yayinevi);
            dataGridView1.DataSource = yayinevi;
            veritabani.baglanti.Close();
        }

        private void yayin_e_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            dataGridView1.Columns["yayine_id"].Visible = false;

            dataGridView1.Columns["yayine_adi"].HeaderText = "Yayın Evi Adı";
            dataGridView1.Columns["yayine_telefon"].HeaderText = "Telefon";
            dataGridView1.Columns["yayine_adres"].HeaderText = "Adres";
            dataGridView1.Columns["yayine_eposta"].HeaderText = "E-Posta";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                yayine_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
            
        }

        private void b_yyne_ekle_Click(object sender, EventArgs e)
        {
            yayine_ekle yayine_ekle = new yayine_ekle();
            yayine_ekle.Show();
        }

        private void b_yyne_duzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                yayine_duzenle yayine_duzenle = new yayine_duzenle();
                yayine_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_yyne_sil_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    veritabani.baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("DELETE FROM yayin_evi WHERE yayine_id=" + yayine_id + ";", veritabani.baglanti);
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
                yayine_duzenle yayine_duzenle = new yayine_duzenle();
                yayine_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
