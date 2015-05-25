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
    public partial class sifremi_unuttum : Form
    {
        public sifremi_unuttum()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void button1_Click(object sender, EventArgs e)
        {
            veritabani.baglanti.Open();
            string kullanici_a = "", eposta = "";
            DataTable ayarlar = new DataTable();
            SQLiteDataAdapter veri = new SQLiteDataAdapter("SELECT kullanici_a, e_posta FROM ayarlar", veritabani.baglanti);

            veri.Fill(ayarlar);
            kullanici_a = ayarlar.Rows[0]["kullanici_a"].ToString();
            eposta = ayarlar.Rows[0]["e_posta"].ToString();

            veritabani.baglanti.Close();

            if (t_kullaniciadi.Text == kullanici_a && t_eposta.Text == eposta)
            {
                gizlisoru gizlisoru = new gizlisoru();
                gizlisoru.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre Yanlış");
                t_kullaniciadi.Text = "";
                t_eposta.Text = "";
            }
        }

        private void sifremi_unuttum_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
