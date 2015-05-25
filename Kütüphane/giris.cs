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
    public partial class kutuphane : Form
    {
        public kutuphane()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void giris_Click(object sender, EventArgs e)
        {
            string kullanici_a = "", sifre = "";

            veritabani.baglanti.Close();
            veritabani.baglanti.Open();
            DataTable ayar = new DataTable();
            SQLiteDataAdapter veri = new SQLiteDataAdapter("SELECT kullanici_a, sifre FROM ayarlar", veritabani.baglanti);
            veri.Fill(ayar);


            kullanici_a = ayar.Rows[0]["kullanici_a"].ToString();
            sifre = ayar.Rows[0]["sifre"].ToString();

            veritabani.baglanti.Close();

            if (Boxkullanici_a.Text == kullanici_a && Boxsifre.Text == sifre)
            {
                kutuphane_panel kutuphane_panel = new kutuphane_panel();
                kutuphane_panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen doğru bilgiler giriniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Boxkullanici_a.Text = "";
                Boxsifre.Text = "";
            }

        }

        private void sifremi_unuttum_Click(object sender, EventArgs e)
        {
            sifremi_unuttum sifremi_unuttum = new sifremi_unuttum();
            sifremi_unuttum.Show();
            this.Hide();
        }

        private void kutuphane_Load(object sender, EventArgs e)
        {
            
        }

        private void kutuphane_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
