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
    public partial class kategori_ekle : Form
    {
        public kategori_ekle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void b_ktgri_ekle_Click(object sender, EventArgs e)
        {
            if (t_kategori.Text == "")
            {
                MessageBox.Show("Boş yer bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "insert into kategori(kategori_adi) " + "VALUES(@kategori_adi)";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@kategori_adi", t_kategori.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    //datagird yenileme
                    kategoriler kategoriler = (kategoriler)Application.OpenForms["kategoriler"]; ;
                    kategoriler.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Kategori eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    t_kategori.Text = "";
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
