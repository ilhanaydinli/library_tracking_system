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
    public partial class cezalar : Form
    {
        public cezalar()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public static int ceza_id;
        public static int odunc_id;

        public void datagrid_doldur()
        {
            DataSet kitaplar = new DataSet();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT  ceza.odunc_id, ceza.ceza_id, kitaplar.kitap_adi, (uyeler.uye_adi || ' ' || uyeler.uye_soyadi) AS uye_adsoyad, ceza.ceza_miktari, ceza_durumu FROM ceza INNER JOIN kitaplar ON ceza.kitap_id=kitaplar.kitap_id INNER JOIN uyeler ON ceza.uye_id=uyeler.uye_id", veritabani.baglanti);
            komut.Fill(kitaplar, "kitaplar");
            
            veritabani.baglanti.Close();


            DataTable cezalar = new DataTable();
            veritabani.baglanti.Close();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut1 = new SQLiteDataAdapter("SELECT COUNT(*) as satir FROM ceza;", veritabani.baglanti);
            komut1.Fill(cezalar);
            int ceza_satir = Convert.ToInt32(cezalar.Rows[0]["satir"].ToString());
            veritabani.baglanti.Close();


            for (int j = 0; j < ceza_satir; j++)
            {
                int cezad = Convert.ToInt32(kitaplar.Tables["kitaplar"].Rows[j]["ceza_durumu"].ToString());
                if (cezad == 0)
                {
                    kitaplar.Tables["kitaplar"].Rows[j]["ceza_durumu"] = "Ceza Ödenmemiş";
                }
                else if (cezad == 1)
                {
                    kitaplar.Tables["kitaplar"].Rows[j]["ceza_durumu"] = "Ceza Ödemiş";
                }
            }

            dataGridView1.DataSource = kitaplar.Tables["kitaplar"];
        }

        private void cezalar_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            dataGridView1.Columns["odunc_id"].Visible = false;
            dataGridView1.Columns["ceza_id"].Visible = false;

            dataGridView1.Columns["kitap_adi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["uye_adsoyad"].HeaderText = "Üye Ad Soyad";
            dataGridView1.Columns["ceza_miktari"].HeaderText = "Ceza Miktarı";
            dataGridView1.Columns["ceza_durumu"].HeaderText = "Ceza Durumu";

            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                odunc_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ceza_id = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
            catch { }
            
        }

        private void b_ceza_odendi_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    veritabani.baglanti.Close();
                    veritabani.baglanti.Open();
                    string sorgu = "UPDATE ceza SET ceza_durumu=1 WHERE ceza_id=" + ceza_id + ";";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();

                    veritabani.baglanti.Open();
                    string sorgu1 = "UPDATE odunc SET ceza_durumu=2 WHERE odunc_id=" + odunc_id + ";";
                    SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                    komut1.ExecuteNonQuery();
                    veritabani.baglanti.Close();

                    datagrid_doldur();
                    //grafik yenileme
                    kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
                    kutuphane_panel.grafik_yap();
                    kutuphane_panel.ceza_kontrol();
                    datagrid_doldur();
                    //grafik yenileme
                    MessageBox.Show("Ödeme alındı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SQLiteException hata)
            {
                MessageBox.Show(hata.Message);
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
                    string sorgu1 = "UPDATE odunc SET ceza_durumu=2 WHERE odunc_id=" + odunc_id + ";";
                    SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                    komut1.ExecuteNonQuery();
                    veritabani.baglanti.Close();

                        veritabani.baglanti.Open();
                        SQLiteCommand komut = new SQLiteCommand("DELETE FROM ceza WHERE ceza_id=" + ceza_id + ";", veritabani.baglanti);
                        komut.ExecuteNonQuery();
                        veritabani.baglanti.Close();
                        datagrid_doldur();
                        //grafik yenileme
                        kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
                        kutuphane_panel.grafik_yap();
                        kutuphane_panel.ceza_kontrol();
                        //grafik yenileme
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
    }
}
