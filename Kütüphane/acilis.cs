using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }
        
        private void acilis_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                kutuphane k = new kutuphane();
                k.Show();
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
