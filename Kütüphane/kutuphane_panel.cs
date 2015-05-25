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
    public partial class kutuphane_panel : Form
    {
        public kutuphane_panel()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void kutuphane_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ceza_kontrol()
        {
            veritabani.baglanti.Close();
            veritabani.baglanti.Open();
            SQLiteDataAdapter tarihig = new SQLiteDataAdapter("SELECT odunc_id, uye_id, kitap_id, ceza_durumu FROM odunc WHERE date('now') > verecegi_tarihi;", veritabani.baglanti);
            SQLiteDataAdapter cezali = new SQLiteDataAdapter("SELECT uye_id, kitap_id FROM ceza;", veritabani.baglanti);
            SQLiteDataAdapter ayarlar = new SQLiteDataAdapter("SELECT ceza_turu, ceza_miktari FROM ayarlar;", veritabani.baglanti);

            DataSet verim = new DataSet();
            tarihig.Fill(verim, "tarihi_g");
            cezali.Fill(verim, "cezali");
            ayarlar.Fill(verim, "ayarlar");
            string ceza = verim.Tables["ayarlar"].Rows[0]["ceza_miktari"].ToString() + " " + verim.Tables["ayarlar"].Rows[0]["ceza_turu"].ToString();
            int satirs = Convert.ToInt32(verim.Tables["tarihi_g"].Rows.Count.ToString());

            for (int i = 0; i < satirs; i++)
            {
                int uye_id = Convert.ToInt32(verim.Tables["tarihi_g"].Rows[i]["uye_id"].ToString());
                int kitap_id = Convert.ToInt32(verim.Tables["tarihi_g"].Rows[i]["kitap_id"].ToString());
                int odunc_id = Convert.ToInt32(verim.Tables["tarihi_g"].Rows[i]["odunc_id"].ToString());
                int ceza_durumu = Convert.ToInt32(verim.Tables["tarihi_g"].Rows[i]["ceza_durumu"].ToString());


                if (ceza_durumu == 0)
                {
                    string sorgu1 = "UPDATE odunc SET ceza_durumu=1 WHERE odunc_id=" + odunc_id + ";";
                    SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                    komut1.Parameters.AddWithValue("@kitap_id", kitap_id);
                    komut1.Parameters.AddWithValue("@uye_id", uye_id);
                    komut1.Parameters.AddWithValue("@ceza_miktari", ceza);
                    komut1.ExecuteNonQuery();

                    string sorgu = "INSERT INTO ceza(kitap_id, uye_id, ceza_miktari, ceza_durumu, odunc_id) " + "VALUES(@kitap_id, @uye_id, @ceza_miktari, @ceza_durumu, @odunc_id)";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                    komut.Parameters.AddWithValue("@kitap_id", kitap_id);
                    komut.Parameters.AddWithValue("@uye_id", uye_id);
                    komut.Parameters.AddWithValue("@ceza_miktari", ceza);
                    komut.Parameters.AddWithValue("@ceza_durumu", "0");
                    komut.Parameters.AddWithValue("@odunc_id", odunc_id);
                    komut.ExecuteNonQuery();
                }
            }
        }
        public static int toplam_k, alinan_k, uye_s, cezali_uyes;

        private void kutuphane_panel_Load(object sender, EventArgs e)
        {
            ceza_kontrol();
            grafik_yap();
        }

        private void button_kitaplar_Click(object sender, EventArgs e)
        {
            kitaplar kitaplar = new kitaplar();
            kitaplar.Show();
        }

        private void button_uyeler_Click(object sender, EventArgs e)
        {
            uyeler uyeler = new uyeler();
            uyeler.Show();
        }

        private void button_yazarlar_Click(object sender, EventArgs e)
        {
            yazarlar yazarlar = new yazarlar();
            yazarlar.Show();
        }

        private void button_yayine_Click(object sender, EventArgs e)
        {
            yayin_e yayin_e = new yayin_e();
            yayin_e.Show();
        }

        private void button_kategoriler_Click(object sender, EventArgs e)
        {
            kategoriler kategoriler = new kategoriler();
            kategoriler.Show();
        }

        private void button_cazalar_Click(object sender, EventArgs e)
        {
            cezalar cezalar = new cezalar();
            cezalar.Show();
        }

        private void button_ogeri_verildi_Click(object sender, EventArgs e)
        {
            odunc odunc = new odunc();
            odunc.Show();
        }

        private void button_ayarlar_Click(object sender, EventArgs e)
        {
            ayarlar ayarlar = new ayarlar();
            ayarlar.Show();
        }

        public void grafik_yap()
        {
            ceza_kontrol();
            //label doldur
            DataSet labeller = new DataSet();
            veritabani.baglanti.Close();
            veritabani.baglanti.Open();
            SQLiteDataAdapter toplam_kitap = new SQLiteDataAdapter("SELECT COUNT(*) AS satir FROM kitaplar", veritabani.baglanti);
            SQLiteDataAdapter alinan_kitap = new SQLiteDataAdapter("SELECT COUNT(*) AS satir FROM odunc WHERE teslim_edildimi=0", veritabani.baglanti);
            SQLiteDataAdapter cezali_uye = new SQLiteDataAdapter("SELECT COUNT(*) AS satir FROM ceza WHERE ceza_durumu=0;", veritabani.baglanti);
            SQLiteDataAdapter uyeler = new SQLiteDataAdapter("SELECT COUNT(*) AS satir FROM uyeler;", veritabani.baglanti);
            SQLiteDataAdapter ayarlar = new SQLiteDataAdapter("SELECT kutuphane_adi FROM ayarlar;", veritabani.baglanti);

            uyeler.Fill(labeller, "uye_s");
            ayarlar.Fill(labeller, "ayarlar");
            cezali_uye.Fill(labeller, "cezali_uye");
            toplam_kitap.Fill(labeller, "toplam_kitap");
            alinan_kitap.Fill(labeller, "alinan_kitap");

            toplam_k = Convert.ToInt32(labeller.Tables["toplam_kitap"].Rows[0]["satir"].ToString());
            alinan_k = Convert.ToInt32(labeller.Tables["alinan_kitap"].Rows[0]["satir"].ToString());
            uye_s = Convert.ToInt32(labeller.Tables["uye_s"].Rows[0]["satir"].ToString());
            cezali_uyes = Convert.ToInt32(labeller.Tables["cezali_uye"].Rows[0]["satir"].ToString());

            label_tplmkitap.Text = Convert.ToString(toplam_k);
            label_blnnkitap.Text = Convert.ToString(toplam_k - alinan_k);
            label_odnckitap.Text = Convert.ToString(alinan_k);

            label_cbulunan.Text = Convert.ToString(cezali_uyes);
            label_cbulunmayanu.Text = Convert.ToString(uye_s - cezali_uyes);
            label_toplamuye.Text = Convert.ToString(uye_s);

            label_isim.Text = labeller.Tables["ayarlar"].Rows[0]["kutuphane_adi"].ToString();
            veritabani.baglanti.Close();



            //kitap  sayısı grafik
            float d1, d2, toplamD;
            d1 = int.Parse(Convert.ToString(toplam_k - alinan_k));
            d2 = int.Parse(Convert.ToString(alinan_k));
            // d3 = int.Parse(textBox3.Text);

            toplamD = d1 + d2;//;+ d3;

            float pd1, pd2;
            pd1 = (d1 / toplamD) * 360;
            pd2 = (d2 / toplamD) * 360;
            // pd3 = (d3 / toplamD) * 360;

            Pen p = new Pen(Color.White, 2);

            Graphics g = this.CreateGraphics();

            Rectangle rec = new Rectangle(130, 90, 130, 130);

            Brush b1 = new SolidBrush(Color.Blue);
            Brush b2 = new SolidBrush(Color.Red);

            g.Clear(kutuphane_panel.DefaultBackColor);
            g.DrawPie(p, rec, 0, pd1);
            g.FillPie(b1, rec, 0, pd1);
            g.DrawPie(p, rec, pd1, pd2);
            g.FillPie(b2, rec, pd1, pd2);



            //cezalı uye grafik
            float d11, d21, toplamD1;
            d11 = int.Parse(Convert.ToString(uye_s - cezali_uyes));
            d21 = int.Parse(Convert.ToString(cezali_uyes));

            toplamD1 = d11 + d21;

            float pd11, pd21;
            pd11 = (d11 / toplamD1) * 360;
            pd21 = (d21 / toplamD1) * 360;

            Pen p1 = new Pen(Color.White, 2);

            Graphics g1 = this.CreateGraphics();

            Rectangle rec1 = new Rectangle(130, 270, 130, 130);

            Brush b11 = new SolidBrush(Color.Blue);
            Brush b21 = new SolidBrush(Color.Red);

            //g1.Clear(kutuphane_panel.DefaultBackColor);
            g1.DrawPie(p1, rec1, 0, pd11);
            g1.FillPie(b11, rec1, 0, pd11);
            g1.DrawPie(p1, rec1, pd11, pd21);
            g1.FillPie(b21, rec1, pd11, pd21);
        }
        private void kutuphane_panel_Shown(object sender, EventArgs e)
        {
            grafik_yap();
        }
    }
}

