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
using System.IO;

namespace Kütüphane
{
    public partial class kitap_duzunle : Form
    {
        public kitap_duzunle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public int kitap_id = kitaplar.kitap_id;

        private void kitap_duzunle_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            veritabani.baglanti.Open();
            DataSet kutuphane = new DataSet();
            SQLiteDataAdapter kitaplar_t = new SQLiteDataAdapter("SELECT yazar_id, yayine_id, kategori_id, kitap_adi, isbn, resim FROM kitaplar WHERE kitap_id=" + kitap_id + ";", veritabani.baglanti);
            
            SQLiteDataAdapter yazarlar = new SQLiteDataAdapter("SELECT yazar_id, (yazar_adi || ' ' || yazar_soyadi) AS ad_soyad FROM yazarlar", veritabani.baglanti);
            SQLiteDataAdapter yayin_evi = new SQLiteDataAdapter("SELECT yayine_id, yayine_adi FROM yayin_evi", veritabani.baglanti);
            SQLiteDataAdapter kategoriler = new SQLiteDataAdapter("SELECT kategori_id, kategori_adi FROM kategori;", veritabani.baglanti);

            kategoriler.Fill(kutuphane, "kategoriler");
            yayin_evi.Fill(kutuphane, "yayin_evi");
            yazarlar.Fill(kutuphane, "yazarlar");
            kitaplar_t.Fill(kutuphane, "kitaplar_t");
            veritabani.baglanti.Close();

            t_kitab_adi.Text = kutuphane.Tables["kitaplar_t"].Rows[0]["kitap_adi"].ToString();
            t_isbn.Text = kutuphane.Tables["kitaplar_t"].Rows[0]["isbn"].ToString();
            pictureBox1.ImageLocation = kutuphane.Tables["kitaplar_t"].Rows[0]["resim"].ToString();

            DataRow row;
            row = kutuphane.Tables["kategoriler"].NewRow();
            row["kategori_adi"] = "";
            kutuphane.Tables["kategoriler"].Rows.InsertAt(row, 0);

            DataRow row2;
            row2 = kutuphane.Tables["yazarlar"].NewRow();
            row2["ad_soyad"] = "";
            kutuphane.Tables["yazarlar"].Rows.InsertAt(row2, 0);

            DataRow row3;
            row3 = kutuphane.Tables["yayin_evi"].NewRow();
            row3["yayine_adi"] = "";
            kutuphane.Tables["yayin_evi"].Rows.InsertAt(row3, 0);

            combo_yazar.ValueMember = "yazar_id";
            combo_yazar.DisplayMember = "ad_soyad";
            combo_yazar.DataSource = kutuphane.Tables["yazarlar"];
            combo_yazar.SelectedValue = Convert.ToInt32(kutuphane.Tables["kitaplar_t"].Rows[0]["yazar_id"].ToString());

            combo_yayine.ValueMember = "yayine_id";
            combo_yayine.DisplayMember = "yayine_adi";
            combo_yayine.DataSource = kutuphane.Tables["yayin_evi"];
            combo_yayine.SelectedValue = Convert.ToInt32(kutuphane.Tables["kitaplar_t"].Rows[0]["yayine_id"].ToString());

            combo_kategori.ValueMember = "kategori_id";
            combo_kategori.DisplayMember = "kategori_adi";
            combo_kategori.DataSource = kutuphane.Tables["kategoriler"];
            combo_kategori.SelectedValue = Convert.ToInt32(kutuphane.Tables["kitaplar_t"].Rows[0]["kategori_id"].ToString());
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (t_kitab_adi.Text == "" || t_isbn.Text == "")
            {
                MessageBox.Show("Kitap düzenlenemedi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Close();
                veritabani.baglanti.Open();
                string sorgu = "UPDATE kitaplar SET yazar_id=@yazar_id, yayine_id=@yayine_id, kategori_id=@kategori_id, isbn=@isbn, resim=@resim WHERE kitap_id=" + kitap_id + ";";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@kitap_adi", t_kitab_adi.Text);
                komut.Parameters.AddWithValue("@isbn", t_isbn.Text);
                komut.Parameters.AddWithValue("@resim", "resimler\\" + kopyalanacakDosyaIsmi1);
                komut.Parameters.AddWithValue("@yazar_id", combo_yazar.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@yayine_id", combo_yayine.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@kategori_id", combo_kategori.SelectedValue.ToString());

                try
                {
                    //resim kopyalama
                    if (dosyanınKopyanacagiKlasor1 != "" && kopyalanacakDosya1 != "")
                    {
                        if (File.Exists(dosyanınKopyanacagiKlasor1 + "\\" + kopyalanacakDosyaIsmi1))
                        {
                            MessageBox.Show("Belirtilen klasörde " + kopyalanacakDosyaIsmi1 + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            File.Copy(kopyalanacakDosya1, dosyanınKopyanacagiKlasor1 + "\\" + kopyalanacakDosyaIsmi1);
                            //resim kopyalama
                            komut.ExecuteNonQuery();
                            veritabani.baglanti.Close();
                            //datagird yenileme
                            kitaplar kitaplar = (kitaplar)Application.OpenForms["kitaplar"]; ;
                            kitaplar.datagrid_doldur();
                            //datagird yenileme
                            MessageBox.Show("Kitap düzenlendi.", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (kopyalanacakDosya1 == "")
                    {
                        MessageBox.Show("Resim seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        string kopyalanacakDosya1 = "", kopyalanacakDosyaIsmi1 = "", dosyanınKopyanacagiKlasor1 = Application.StartupPath.ToString() + "\\resimler";

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "  JPEG Files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.Title = "Kopyalanacak Dosyayı Seçiniz...";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kopyalanacakDosyaIsmi1 = openFileDialog1.SafeFileName.ToString();
                kopyalanacakDosya1 = openFileDialog1.FileName.ToString();
                pictureBox1.ImageLocation = kopyalanacakDosya1;
            }
            else
            {
                MessageBox.Show("Resim Seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
