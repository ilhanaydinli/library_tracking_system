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
    public partial class yazar_duzenle : Form
    {
        public yazar_duzenle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public int yazar_id = yazarlar.yazar_id;

        private void yazar_duzenle_Load(object sender, EventArgs e)
        {
            veritabani.baglanti.Open();
            DataSet yazarlar = new DataSet();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT yazar_adi, yazar_soyadi FROM yazarlar WHERE yazar_id=" + yazar_id + ";", veritabani.baglanti);

            komut.Fill(yazarlar, "yazarlar");

            veritabani.baglanti.Close();

            t_adi.Text = yazarlar.Tables["yazarlar"].Rows[0]["yazar_adi"].ToString();
            t_soyadi.Text = yazarlar.Tables["yazarlar"].Rows[0]["yazar_soyadi"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_adi.Text == "" || t_soyadi.Text == "")
            {
                MessageBox.Show("Yayın evi düzenlenemedi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "UPDATE yazarlar SET yazar_adi=@yazar_adi, yazar_soyadi=@yazar_soyadi WHERE yazar_id=" + yazar_id + ";";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@yazar_adi", t_adi.Text);
                komut.Parameters.AddWithValue("@yazar_soyadi", t_soyadi.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    //datagird yenileme
                    yazarlar yazarlar = (yazarlar)Application.OpenForms["yazarlar"]; ;
                    yazarlar.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Yayın evi düzenlenedi.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
