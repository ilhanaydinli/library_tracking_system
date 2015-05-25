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
    public partial class uye_duzenle : Form
    {
        public uye_duzenle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public int uye_id = uyeler.uye_id;
        private void uye_duzenle_Load(object sender, EventArgs e)
        {
            veritabani.baglanti.Open();
            DataSet uyeler = new DataSet();
            SQLiteDataAdapter uyeler_t = new SQLiteDataAdapter("SELECT uye_adi, uye_soyadi, uye_tc_no, uye_telefon, uye_e_posta, uye_adres FROM uyeler WHERE uye_id=" + uye_id + ";", veritabani.baglanti);

            uyeler_t.Fill(uyeler, "uyeler");

            veritabani.baglanti.Close();

            t_adi.Text = uyeler.Tables["uyeler"].Rows[0]["uye_adi"].ToString();
            t_soyadi.Text = uyeler.Tables["uyeler"].Rows[0]["uye_soyadi"].ToString();
            t_tcno.Text = uyeler.Tables["uyeler"].Rows[0]["uye_tc_no"].ToString();
            t_telefon.Text = uyeler.Tables["uyeler"].Rows[0]["uye_telefon"].ToString();
            t_eposta.Text = uyeler.Tables["uyeler"].Rows[0]["uye_e_posta"].ToString();
            t_adres.Text = uyeler.Tables["uyeler"].Rows[0]["uye_adres"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_adi.Text == "" || t_soyadi.Text == "" || t_tcno.Text == "" || t_telefon.Text == "" || t_eposta.Text == "" || t_adres.Text == "")
            {
                MessageBox.Show("Üye düzenlenemedi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "UPDATE uyeler SET uye_adi=@uye_adi, uye_soyadi=@uye_soyadi, uye_tc_no=@uye_tc_no, uye_telefon=@uye_telefon, uye_e_posta=@uye_e_posta, uye_adres=@uye_adres WHERE uye_id=" + uye_id + ";";
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
                    uyeler f1 = (uyeler)Application.OpenForms["uyeler"]; ;
                    f1.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Üye düzenlenedi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
