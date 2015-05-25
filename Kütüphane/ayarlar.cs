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
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void ayarlar_Load(object sender, EventArgs e)
        {
            DataSet ayarlar = new DataSet();
            veritabani.baglanti.Open();
            SQLiteDataAdapter ayarlar_k = new SQLiteDataAdapter("SELECT kutuphane_adi, e_posta, kullanici_a, gizli_soru, gizli_cevap, ceza_turu, ceza_miktari FROM ayarlar;", veritabani.baglanti);
            ayarlar_k.Fill(ayarlar, "ayarlar");
            t_eposta.Text = ayarlar.Tables["ayarlar"].Rows[0]["e_posta"].ToString();
            t_kadi.Text = ayarlar.Tables["ayarlar"].Rows[0]["kullanici_a"].ToString();
            t_gsoru.Text = ayarlar.Tables["ayarlar"].Rows[0]["gizli_soru"].ToString();
            t_gcevap.Text = ayarlar.Tables["ayarlar"].Rows[0]["gizli_cevap"].ToString();
            t_cturu.Text = ayarlar.Tables["ayarlar"].Rows[0]["ceza_turu"].ToString();
            t_cmiktari.Text = ayarlar.Tables["ayarlar"].Rows[0]["ceza_miktari"].ToString();
            t_ktphaneadi.Text = ayarlar.Tables["ayarlar"].Rows[0]["kutuphane_adi"].ToString();
            veritabani.baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_eposta.Text == "" || t_kadi.Text == "" || t_gsoru.Text == "" || t_gcevap.Text == "" || t_cturu.Text == "" || t_cmiktari.Text=="")
            {
                MessageBox.Show("Alanları boş bırakmayınız.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "UPDATE ayarlar SET kutuphane_adi=@kutuphane_adi, e_posta=@t_eposta, kullanici_a=@t_kadi, gizli_soru=@t_gsoru, gizli_cevap=@t_gcevap, ceza_turu=@t_cturu, ceza_miktari=@t_cmiktari WHERE ayarlar_id=1 ";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@kutuphane_adi", t_ktphaneadi.Text);
                komut.Parameters.AddWithValue("@t_eposta", t_eposta.Text);
                komut.Parameters.AddWithValue("@t_kadi", t_kadi.Text);
                komut.Parameters.AddWithValue("@t_gsoru", t_gsoru.Text);
                komut.Parameters.AddWithValue("@t_gcevap", t_gcevap.Text);
                komut.Parameters.AddWithValue("@t_cturu", t_cturu.Text);
                komut.Parameters.AddWithValue("@t_cmiktari", t_cmiktari.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
                    kutuphane_panel.grafik_yap();
                    kutuphane_panel.ceza_kontrol();
                    MessageBox.Show("Ayarlar kaydedildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifre_degistir sifre_d = new sifre_degistir();
            sifre_d.Show();
        }
    }
}
