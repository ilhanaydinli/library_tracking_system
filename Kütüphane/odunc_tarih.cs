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
    public partial class odunc_tarih : Form
    {
        public odunc_tarih()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public int odunc_id = odunc.odunc_id;

        private void odunc_duzenle_Load(object sender, EventArgs e)
        {
            DataSet tarih = new DataSet();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT verecegi_tarihi FROM odunc WHERE odunc_id=" + odunc_id + ";", veritabani.baglanti);

            komut.Fill(tarih, "tarih");

            veritabani.baglanti.Close();

            dateTimePicker1.Text = tarih.Tables["tarih"].Rows[0]["verecegi_tarihi"].ToString();
        }

        private void btn_trharttr_Click(object sender, EventArgs e)
        {
            try
            {
                veritabani.baglanti.Open();
                string sorgu1 = "UPDATE odunc SET verecegi_tarihi=@verecegi_tarihi WHERE odunc_id=" + odunc_id + ";";
                SQLiteCommand komut1 = new SQLiteCommand(sorgu1, veritabani.baglanti);
                komut1.Parameters.AddWithValue("@verecegi_tarihi", dateTimePicker1.Text);
                komut1.ExecuteNonQuery();
                veritabani.baglanti.Close();
            }
            catch (SQLiteException hata)
            {
                MessageBox.Show("Hata oluştu:" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //datagird yenileme
            odunc odunc = (odunc)Application.OpenForms["odunc"]; ;
            odunc.datagrid_doldur();
            //datagird yenileme
            //grafik yenileme
            kutuphane_panel kutuphane_panel = (kutuphane_panel)Application.OpenForms["kutuphane_panel"]; ;
            kutuphane_panel.grafik_yap();
            kutuphane_panel.ceza_kontrol();
            //grafik yenileme
            MessageBox.Show("Tarih arttırıldı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
