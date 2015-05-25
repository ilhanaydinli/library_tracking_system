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
    public partial class sifre_degistir : Form
    {
        public sifre_degistir()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_sifre.Text == "" || t_sifretekrari.Text == "")
            {
                MessageBox.Show("Kutuları boş bırakmayınız.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (t_sifre.Text == t_sifretekrari.Text)
                {
                    try
                    {
                        veritabani.baglanti.Open();
                        string sorgu = "UPDATE ayarlar SET sifre=@sifre WHERE ayarlar_id=1;";
                        SQLiteCommand komut = new SQLiteCommand(sorgu, veritabani.baglanti);
                        komut.Parameters.AddWithValue("@sifre", t_sifre.Text);
                        komut.ExecuteNonQuery();
                        veritabani.baglanti.Close();
                        MessageBox.Show("Şifre değiştirildi.","Bildiri",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                        kutuphane kutuphane = new kutuphane();
                        kutuphane.Show();
                    }
                    catch (SQLiteException hata)
                    {
                        MessageBox.Show("Hata oluştu:"+hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
            }
        }

        private void sifre_degistir_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
