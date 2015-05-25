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
    public partial class yazar_ekle : Form
    {
        public yazar_ekle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_adi.Text == "" || t_soyadi.Text == "")
            {
                MessageBox.Show("Yayın evi eklenemedi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "INSERT INTO yazarlar(yazar_adi, yazar_soyadi) " + "VALUES(@yazar_adi, @yazar_soyadi);";
                SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                komut.Parameters.AddWithValue("@yazar_adi", t_adi.Text);
                komut.Parameters.AddWithValue("@yazar_soyadi", t_soyadi.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    veritabani.baglanti.Close();
                    //datagird yenileme
                    yazarlar uyeler = (yazarlar)Application.OpenForms["yazarlar"]; ;
                    uyeler.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Yayın evi eklendi.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    t_adi.Text = "";
                    t_soyadi.Text = "";
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
