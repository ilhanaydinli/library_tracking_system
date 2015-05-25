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
    public partial class kategori_duzenle : Form
    {
        public kategori_duzenle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public int kategori_id = kategoriler.kategori_id;
        private void kategori_duzenle_Load(object sender, EventArgs e)
        {
            veritabani.baglanti.Open();
            DataSet kategoriler = new DataSet();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT kategori_adi FROM kategori WHERE kategori_id=" + kategori_id + ";", veritabani.baglanti);

            komut.Fill(kategoriler, "kategoriler");

            veritabani.baglanti.Close();

            t_kategori.Text = kategoriler.Tables["kategoriler"].Rows[0]["kategori_adi"].ToString();
        }

        private void b_ktgri_duz_Click(object sender, EventArgs e)
        {
            if (t_kategori.Text == "")
            {
                MessageBox.Show("Kategori düzenlenemedi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "UPDATE kategori SET kategori_adi=@kategori_adi WHERE kategori_id=" + kategori_id + ";";
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
                    MessageBox.Show("Kategori düzenlenedi.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
