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
    public partial class uye_ekle : Form
    {
        public uye_ekle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_adi.Text == "" || t_soyadi.Text == "" || t_tcno.Text == "" || t_telefon.Text == "" || t_eposta.Text == "" || t_adres.Text == "")
            {
                MessageBox.Show("Boş yer bırakmayınız !.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "insert into uyeler(uye_adi, uye_soyadi, uye_tc_no, uye_telefon, uye_e_posta, uye_adres) " + "VALUES(@uye_adi, @uye_soyadi, @uye_tc_no, @uye_telefon, @uye_e_posta, @uye_adres)";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@uye_adi", t_adi.Text);
                komut.Parameters.AddWithValue("@uye_soyadi", t_soyadi.Text);
                komut.Parameters.AddWithValue("@uye_tc_no", t_tcno.Text);
                komut.Parameters.AddWithValue("@uye_telefon", t_telefon.Text);
                komut.Parameters.AddWithValue("@uye_e_posta", t_eposta.Text);
                komut.Parameters.AddWithValue("@uye_adres", t_adres.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    //datagird yenileme
                    uyeler uyeler = (uyeler)Application.OpenForms["uyeler"]; ;
                    uyeler.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Üye eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    t_adi.Text = "";
                    t_soyadi.Text = "";
                    t_tcno.Text = "";
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
