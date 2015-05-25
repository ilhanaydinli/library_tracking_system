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
    public partial class yayine_ekle : Form
    {
        public yayine_ekle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void b_yyne_Click(object sender, EventArgs e)
        {
            if (t_adi.Text == "" || t_telefon.Text == "" || t_eposta.Text == "" || t_adres.Text == "")
            {
                MessageBox.Show("Boş yer bırakmayınız !.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "insert into yayin_evi(yayine_adi, yayine_telefon, yayine_eposta, yayine_adres) " + "VALUES(@yayine_adi, @yayine_telefon, @yayine_eposta, @yayine_adres);";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@yayine_adi", t_adi.Text);
                komut.Parameters.AddWithValue("@yayine_telefon", t_telefon.Text);
                komut.Parameters.AddWithValue("@yayine_eposta", t_eposta.Text);
                komut.Parameters.AddWithValue("@yayine_adres", t_adres.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    //datagird yenileme
                    yayin_e yayin_e = (yayin_e)Application.OpenForms["yayin_e"]; ;
                    yayin_e.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Yayınevi eklendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    t_adi.Text = "";
                    t_telefon.Text = "";
                    t_telefon.Text = "";
                    t_eposta.Text = "";
                    t_adres.Text = "";
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
