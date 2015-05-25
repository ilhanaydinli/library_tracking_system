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
    public partial class odunc : Form
    {
        public odunc()
        {
            InitializeComponent();
        }
        veritabani veritabani = new veritabani();
        public static int odunc_id;
        public static int kitap_id;
        public void datagrid_doldur()
        {
            DataTable uyeler = new DataTable();
            veritabani.baglanti.Open();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT odunc.odunc_id, odunc.kitap_id, odunc.ceza_durumu, (uyeler.uye_adi || ' ' || uyeler.uye_soyadi) AS uye_adsoyad, kitaplar.kitap_adi, odunc.alim_tarihi,  strftime('%d-%m-%Y', odunc.verecegi_tarihi) as verecegi_tarihi, odunc.ceza_durumu FROM odunc INNER JOIN kitaplar ON odunc.kitap_id=kitaplar.kitap_id INNER JOIN uyeler ON odunc.uye_id=uyeler.uye_id", veritabani.baglanti);
            komut.Fill(uyeler);
            int odunc_s = Convert.ToInt32(uyeler.Rows.Count.ToString());
            
            

            for (int j = 0; j < odunc_s;j++ )
            {
               int cezad= Convert.ToInt32(uyeler.Rows[j]["ceza_durumu1"].ToString());
                if(cezad==0)
                {
                    uyeler.Rows[j]["ceza_durumu1"] = "Normal";
                }
                else if(cezad==1)
                {
                    uyeler.Rows[j]["ceza_durumu1"] = "Cezalı";
                }
                else if(cezad==2)
                {
                    uyeler.Rows[j]["ceza_durumu1"] = "Ceza Ödenmiş";
                }
            }

            dataGridView1.DataSource = uyeler;
            veritabani.baglanti.Close();
      
        }

        public void ceza_ver()
        {   
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                try
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells["ceza_durumu"].Value.ToString()) == 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    }
                }
                catch { }
        }

        private void odunc_Load(object sender, EventArgs e)
        {
            datagrid_doldur();
            ceza_ver();
            dataGridView1.Columns["odunc_id"].Visible = false;
            dataGridView1.Columns["kitap_id"].Visible = false;
            dataGridView1.Columns["ceza_durumu"].Visible = false;

            dataGridView1.Columns["uye_adsoyad"].HeaderText = "Üye Ad Soyad";
            dataGridView1.Columns["kitap_adi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["alim_tarihi"].HeaderText = "Ödünç Alım Tarihi";
            dataGridView1.Columns["verecegi_tarihi"].HeaderText = "Ödünç Verim Tarihi";
            dataGridView1.Columns["ceza_durumu1"].HeaderText = "Ceza Durumu";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                odunc_id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                kitap_id = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
            catch { }
        }

        private void b_ktp_ekle_Click(object sender, EventArgs e)
        {
            odunc_ver odunc_ver = new odunc_ver();
            odunc_ver.Show();
        }

        private void b_ktp_duzenle_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                odunc_tarih odunc_duzenle = new odunc_tarih();
                odunc_duzenle.Show();
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
                try
                {
                    veritabani.baglanti.Open();
                    string sorgu = "UPDATE odunc SET teslim_edildimi=@teslim_edildimi WHERE odunc_id=" + odunc_id + ";";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                    komut.Parameters.AddWithValue("@teslim_edildimi", "1");
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    try
                    {
                        veritabani.baglanti.Open();
                        string sorgu1 = "UPDATE kitaplar SET kitap_durumu=@kitap_durumu WHERE kitap_id=" + kitap_id + ";";
                        SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                        komut1.Parameters.AddWithValue("@kitap_durumu", "0");
                        komut1.ExecuteNonQuery();
                        veritabani.baglanti.Close();
                    }
                    catch (SQLiteException hata)
                    {
                        MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    datagrid_doldur();
                    //grafik yenileme
                    kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
                    kutuphane_panel.grafik_yap();
                    kutuphane_panel.ceza_kontrol();
                    //grafik yenileme
                    ceza_ver();
                    MessageBox.Show("Ödünç geri alındı.","Bildiri",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_odncsil_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                veritabani.baglanti.Open();
                DataTable ceza_durumu = new DataTable();
                SQLiteDataAdapter komut2 = new SQLiteDataAdapter("SELECT odunc.ceza_durumu FROM odunc WHERE odunc.odunc_id=" + odunc_id + ";", veritabani.baglanti);
                komut2.Fill(ceza_durumu);
                veritabani.baglanti.Close();
                int ceza_d = Convert.ToInt32(ceza_durumu.Rows[0]["ceza_durumu"]);

                if (ceza_d == 2 || ceza_d == 0)
                {
                    DialogResult secenek = MessageBox.Show("Kaydı veritabanından silmek istiyor musunuz?", "Bildiri", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (secenek == DialogResult.Yes)
                    {
                        veritabani.baglanti.Open();
                        SQLiteCommand komut = new SQLiteCommand("DELETE FROM odunc WHERE odunc_id=" + odunc_id + ";", veritabani.baglanti);
                        komut.ExecuteNonQuery();
                        veritabani.baglanti.Close();
                        try
                        {
                            veritabani.baglanti.Open();
                            string sorgu1 = "UPDATE kitaplar SET kitap_durumu=@kitap_durumu WHERE kitap_id=" + kitap_id + ";";
                            SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                            komut1.Parameters.AddWithValue("@kitap_durumu", "0");
                            komut1.ExecuteNonQuery();
                            veritabani.baglanti.Close();
                            datagrid_doldur();
                            //grafik yenileme
                            kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
                            kutuphane_panel.grafik_yap();
                            kutuphane_panel.ceza_kontrol();
                            //grafik yenileme
                        }
                        catch (SQLiteException hata)
                        {
                            MessageBox.Show("Hata oluştu:"+hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else if (secenek == DialogResult.No)
                    {
                    }
                datagrid_doldur();
                ceza_ver();
                }
                else
                {
                    MessageBox.Show("Bu ödünçün cezası var, ilk önce cezayı ödemesi gerekli.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                odunc_tarih odunc_duzenle = new odunc_tarih();
                odunc_duzenle.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
