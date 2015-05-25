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
    public partial class kitap_ekle : Form
    {
        public kitap_ekle()
        {
            InitializeComponent();
        }
        veritabani veritabani = new veritabani();
        private void button2_Click(object sender, EventArgs e)
        {
            if (t_kitab_adi.Text == ""/* || t_isbn.Text == "" || t_basim_tar.Text == "" || t_yazar.Text == "" || t_yayin_evi.Text == "" || t_kategori.Text == ""*/)
            {
                MessageBox.Show("Boş yer bırakmayınız !.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Close();
                veritabani.baglanti.Open();
                string sorgu = "INSERT INTO kitaplar(yazar_id, yayine_id, kategori_id, kitap_adi, isbn, resim, kitap_durumu) " + "VALUES(@yazar_id, @yayine_id, @kategori_id, @kitap_adi, @isbn, @resim, @kitap_durumu)";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@kitap_adi", t_kitab_adi.Text);
                komut.Parameters.AddWithValue("@isbn", t_isbn.Text);
                komut.Parameters.AddWithValue("@resim", "resimler\\" + kopyalanacakDosyaIsmi);
                komut.Parameters.AddWithValue("@yazar_id", combo_yazar.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@yayine_id", combo_yayine.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@kategori_id", combo_kategori.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@kitap_durumu", "0");
                try
                {
                    //resim kopyalama
                    if (dosyanınKopyanacagiKlasor != "" && kopyalanacakDosya != "")
                    {
                        if (File.Exists(dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi))
                        {
                            MessageBox.Show("Belirtilen klasörde " + kopyalanacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi);
                            //resim kopyalama
                            komut.ExecuteNonQuery();
                            veritabani.baglanti.Close();
                            //datagird yenileme
                            kitaplar kitaplar = (kitaplar)Application.OpenForms["kitaplar"]; ;
                            kitaplar.datagrid_doldur();
                            //datagird yenileme
                            MessageBox.Show("Kitap eklendi.", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            t_kitab_adi.Text = "";
                            t_isbn.Text = "";
                        }
                    }
                    else if (kopyalanacakDosya == "")
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

        private void kitap_ekle_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            try
            {
                veritabani.baglanti.Open();
                DataSet kutuphane = new DataSet();
                SQLiteDataAdapter yazarlar = new SQLiteDataAdapter("SELECT yazar_id, (yazar_adi || ' ' || yazar_soyadi) AS ad_soyad FROM yazarlar", veritabani.baglanti);
                SQLiteDataAdapter yayin_evi = new SQLiteDataAdapter("SELECT yayine_id, yayine_adi FROM yayin_evi", veritabani.baglanti);
                SQLiteDataAdapter kategoriler = new SQLiteDataAdapter("SELECT kategori_id, kategori_adi FROM kategori;", veritabani.baglanti);

                kategoriler.Fill(kutuphane, "kategoriler");
                yayin_evi.Fill(kutuphane, "yayin_evi");
                yazarlar.Fill(kutuphane, "yazarlar");
                veritabani.baglanti.Close();

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

                combo_yayine.ValueMember = "yayine_id";
                combo_yayine.DisplayMember = "yayine_adi";
                combo_yayine.DataSource = kutuphane.Tables["yayin_evi"];

                combo_kategori.ValueMember = "kategori_id";
                combo_kategori.DisplayMember = "kategori_adi";
                combo_kategori.DataSource = kutuphane.Tables["kategoriler"];

            }
            catch (SQLiteException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void kitap_ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "  JPEG Files (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.Title = "Kopyalanacak Dosyayı Seçiniz...";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kopyalanacakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
                kopyalanacakDosya = openFileDialog1.FileName.ToString();
                pictureBox1.ImageLocation = kopyalanacakDosya;
            }
            else
            {
                MessageBox.Show("Resim Seçmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        string kopyalanacakDosya = "", kopyalanacakDosyaIsmi = "", dosyanınKopyanacagiKlasor = Application.StartupPath.ToString() + "\\resimler";
    }
}