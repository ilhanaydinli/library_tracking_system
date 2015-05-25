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
    public partial class gizlisoru : Form
    {
        public gizlisoru()
        {
            InitializeComponent();
        }

        veritabani veritabani = new veritabani();

        private void gizlisoru_Load(object sender, EventArgs e)
        {
            DataSet labeller = new DataSet();
            veritabani.baglanti.Close();
            veritabani.baglanti.Open();
            SQLiteDataAdapter gizli = new SQLiteDataAdapter("SELECT gizli_soru, gizli_cevap FROM ayarlar", veritabani.baglanti);

            gizli.Fill(labeller, "gizli");

            label1.Text = labeller.Tables["gizli"].Rows[0]["gizli_soru"].ToString();

            gcevap = labeller.Tables["gizli"].Rows[0]["gizli_cevap"].ToString();
        }
        public static string gcevap;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==gcevap)
            {
                sifre_degistir sifred = new sifre_degistir();
                sifred.Show();
                this.Hide();
            }
        }
    }
}
