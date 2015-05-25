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
    public partial class odunc_ver : Form
    {
        public odunc_ver()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void odunc_ver_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            
            combo_kitapadi.Enabled = false;
            combo_uye.Enabled = false;
            combo_yayine.Enabled = false;
            combo_yazar.Enabled = false;
            try
            {
                veritabani.baglanti.Open();
                DataSet kutuphane = new DataSet();
                SQLiteDataAdapter kategoriler = new SQLiteDataAdapter("SELECT kategori_id, kategori_adi FROM kategori;", veritabani.baglanti);

                kategoriler.Fill(kutuphane, "kategoriler");
                veritabani.baglanti.Close();

                DataRow row;
                row = kutuphane.Tables[0].NewRow();
                row["kategori_adi"] = "";
                kutuphane.Tables[0].Rows.InsertAt(row, 0);

                combo_kategori.ValueMember = "kategori_id";
                combo_kategori.DisplayMember = "kategori_adi";
                combo_kategori.DataSource = kutuphane.Tables["kategoriler"];

            }
            catch (SQLiteException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_oduncver_Click(object sender, EventArgs e)
        {
            if (combo_kategori.Text != "" && combo_yayine.Text != "" && combo_uye.Text != "" && combo_kitapadi.Text != "" && combo_yazar.Text != "")
            {
                try
                {
                    veritabani.baglanti.Open();
                    string sorgu = "INSERT INTO odunc(uye_id, kitap_id, alim_tarihi, verecegi_tarihi, teslim_edildimi, ceza_durumu) " + "VALUES(@uye_id, @kitap_id, @alim_tarihi, @verecegi_tarihi, @teslim_edildimi, @ceza_durumu)";
                    SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                    komut.Parameters.AddWithValue("@uye_id", combo_uye.SelectedValue.ToString());
                    komut.Parameters.AddWithValue("@kitap_id", combo_kitapadi.SelectedValue.ToString());
                    komut.Parameters.AddWithValue("@alim_tarihi", DateTime.Now.ToString("dd-MM-yyyy"));
                    komut.Parameters.AddWithValue("@verecegi_tarihi", dateTimePicker2.Text);
                    komut.Parameters.AddWithValue("@teslim_edildimi", "0");
                    komut.Parameters.AddWithValue("@ceza_durumu", "0");
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                }

                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                try
                {
                    veritabani.baglanti.Open();
                    string sorgu1 = "UPDATE kitaplar SET kitap_durumu=1 WHERE kitap_id=@kitap_id;";
                    SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                    komut1.Parameters.AddWithValue("@kitap_id", combo_kitapadi.SelectedValue.ToString());
                    komut1.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    
                    
                    //datagird yenileme
                    odunc odunc = (odunc)Application.OpenForms["odunc"]; ;
                    odunc.datagrid_doldur();
                    odunc.ceza_ver();
                    odunc.datagrid_doldur();
                    //datagird yenileme
                    //grafik yenileme
                    kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
                    kutuphane_panel.grafik_yap();
                    kutuphane_panel.ceza_kontrol();
                    //grafik yenileme
                    MessageBox.Show("Ödünç verildi.", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 }
                 catch (SQLiteException hata)
                 {
                    MessageBox.Show("Hata Oluştu:"+hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 }
            }
            else
            {
                MessageBox.Show("Boş Bırakmayınız.");
            }
            
        }

        private void combo_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_kategori.Text != "")
            {
                combo_yayine.Enabled = true;

                try
                {
                    veritabani.baglanti.Open();
                    DataSet kutuphane = new DataSet();
                    SQLiteDataAdapter yayin_evi = new SQLiteDataAdapter("SELECT yayine_id, yayine_adi FROM yayin_evi;", veritabani.baglanti);
                    yayin_evi.Fill(kutuphane, "yayin_evi");
                    veritabani.baglanti.Close();

                    DataRow row;
                    row = kutuphane.Tables[0].NewRow();
                    row["yayine_adi"] = "";
                    kutuphane.Tables[0].Rows.InsertAt(row, 0);

                    combo_yayine.ValueMember = "yayine_id";
                    combo_yayine.DisplayMember = "yayine_adi";
                    combo_yayine.DataSource = kutuphane.Tables["yayin_evi"];

                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                combo_yayine.Enabled = false;
                combo_yazar.Enabled = false;
            }

        }

        private void combo_yayine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_yayine.Text != "")
            {
                combo_yazar.Enabled = true;
                try
                {
                    veritabani.baglanti.Open();
                    DataSet kutuphane = new DataSet();
                    SQLiteDataAdapter yazarlar = new SQLiteDataAdapter("SELECT yazar_id, (yazar_adi || ' ' || yazar_soyadi) AS ad_soyad FROM yazarlar", veritabani.baglanti);
                    yazarlar.Fill(kutuphane, "yazarlar");
                    veritabani.baglanti.Close();

                    DataRow row;
                    row = kutuphane.Tables[0].NewRow();
                    row["ad_soyad"] = "";
                    kutuphane.Tables[0].Rows.InsertAt(row, 0);

                    combo_yazar.ValueMember = "yazar_id";
                    combo_yazar.DisplayMember = "ad_soyad";
                    combo_yazar.DataSource = kutuphane.Tables["yazarlar"];
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                combo_yazar.Enabled = false;
            }
        }

        private void combo_yazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_yazar.Text != "")
            {
                try
                {
                    veritabani.baglanti.Close();
                    veritabani.baglanti.Open();
                    DataSet kutuphane = new DataSet();
                    SQLiteDataAdapter kitaplar = new SQLiteDataAdapter("SELECT kitap_id, kitap_adi FROM kitaplar WHERE yazar_id=" + combo_yazar.SelectedValue.ToString() + " AND kategori_id=" + combo_kategori.SelectedValue.ToString() + " AND yayine_id=" + combo_yayine.SelectedValue.ToString() + " AND kitap_durumu=0;", veritabani.baglanti);
                    SQLiteDataAdapter uyeler = new SQLiteDataAdapter("SELECT uye_id, (uye_adi || ' ' || uye_soyadi) AS ad_soyad FROM uyeler;", veritabani.baglanti);


                    kitaplar.Fill(kutuphane, "kitaplar");
                    uyeler.Fill(kutuphane, "uyeler");

                    combo_uye.Enabled = true;
                    combo_uye.ValueMember = "uye_id";
                    combo_uye.DisplayMember = "ad_soyad";
                    combo_uye.DataSource = kutuphane.Tables["uyeler"];

                    combo_kitapadi.Enabled = true;
                    combo_kitapadi.ValueMember = "kitap_id";
                    combo_kitapadi.DisplayMember = "kitap_adi";
                    combo_kitapadi.DataSource = kutuphane.Tables["kitaplar"];


                    veritabani.baglanti.Close();
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                combo_uye.Enabled = false;
                combo_kitapadi.Enabled = false;
            }

        }

        private void combo_kitapadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                veritabani.baglanti.Close();
                veritabani.baglanti.Open();
                DataSet kutuphane = new DataSet();
                SQLiteDataAdapter kitaplar_res = new SQLiteDataAdapter("SELECT resim FROM kitaplar WHERE kitap_id=" + combo_kitapadi.SelectedValue.ToString() + " AND kitap_durumu=0;", veritabani.baglanti);
                kitaplar_res.Fill(kutuphane, "kitapalar_res");

                string kitap_res = kutuphane.Tables["kitapalar_res"].Rows[0]["resim"].ToString();

                if (kitap_res != "")
                {
                    pictureBox1.Image = Image.FromFile(kitap_res);
                }
                else
                {
                    this.pictureBox1.Image = Kütüphane.Resource1.resimyok;
                }
            }
            catch(SQLiteException hata)
            {
                MessageBox.Show("hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
