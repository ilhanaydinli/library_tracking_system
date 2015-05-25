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
    public partial class yayine_duzenle : Form
    {
        public yayine_duzenle()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();
        public int yayine_id = yayin_e.yayine_id;
        private void yayine_duzenle_Load(object sender, EventArgs e)
        {
            veritabani.baglanti.Open();
            DataSet yayine = new DataSet();
            SQLiteDataAdapter komut = new SQLiteDataAdapter("SELECT yayine_adi, yayine_telefon, yayine_eposta, yayine_adres FROM yayin_evi WHERE yayine_id=" + yayine_id + ";", veritabani.baglanti);

            komut.Fill(yayine, "yayine");

            veritabani.baglanti.Close();

            t_adi.Text = yayine.Tables["yayine"].Rows[0]["yayine_adi"].ToString();
            t_telefon.Text = yayine.Tables["yayine"].Rows[0]["yayine_telefon"].ToString();
            t_eposta.Text = yayine.Tables["yayine"].Rows[0]["yayine_eposta"].ToString();
            t_adres.Text = yayine.Tables["yayine"].Rows[0]["yayine_adres"].ToString();
        }

        private void b_yyne_Click(object sender, EventArgs e)
        {
            if (t_adi.Text == "" || t_telefon.Text == "")
            {
                MessageBox.Show("Yayin evi düzenlenemedi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                veritabani.baglanti.Open();
                string sorgu = "UPDATE yayin_evi SET yayine_adi=@yayine_adi, yayine_telefon=@yayine_telefon, yayine_eposta=@yayine_eposta, yayine_adres=@yayine_adres WHERE yayine_id=" + yayine_id + ";";
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
                    yayin_e yazarlar = (yayin_e)Application.OpenForms["yayin_e"]; ;
                    yazarlar.datagrid_doldur();
                    //datagird yenileme
                    MessageBox.Show("Yayin evi düzenlenedi.", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (SQLiteException hata)
                {
                    MessageBox.Show("Hata oluştu:"+hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}
