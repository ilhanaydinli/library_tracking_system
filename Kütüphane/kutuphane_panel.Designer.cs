namespace Kütüphane
{
    partial class kutuphane_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kutuphane_panel));
            this.button_kitaplar = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_uyeler = new System.Windows.Forms.Button();
            this.button_cazalar = new System.Windows.Forms.Button();
            this.button_yazarlar = new System.Windows.Forms.Button();
            this.button_yayine = new System.Windows.Forms.Button();
            this.button_kategoriler = new System.Windows.Forms.Button();
            this.button_ayarlar = new System.Windows.Forms.Button();
            this.button_ogeri_verildi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tplmkitap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_odnckitap = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_blnnkitap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_isim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_cbulunmayanu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_cbulunan = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_toplamuye = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_kitaplar
            // 
            this.button_kitaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_kitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kitaplar.ImageKey = "kitaplar.png";
            this.button_kitaplar.ImageList = this.ımageList1;
            this.button_kitaplar.Location = new System.Drawing.Point(12, 324);
            this.button_kitaplar.Name = "button_kitaplar";
            this.button_kitaplar.Size = new System.Drawing.Size(105, 98);
            this.button_kitaplar.TabIndex = 2;
            this.button_kitaplar.Text = "Kitaplar";
            this.button_kitaplar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_kitaplar.UseVisualStyleBackColor = true;
            this.button_kitaplar.Click += new System.EventHandler(this.button_kitaplar_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "settings-icon.png");
            this.ımageList1.Images.SetKeyName(1, "authors.png");
            this.ımageList1.Images.SetKeyName(2, "home-icon.png");
            this.ımageList1.Images.SetKeyName(3, "kitaplar.png");
            this.ımageList1.Images.SetKeyName(4, "users.png");
            this.ımageList1.Images.SetKeyName(5, "coins.png");
            this.ımageList1.Images.SetKeyName(6, "ref.png");
            this.ımageList1.Images.SetKeyName(7, "kategori.png");
            // 
            // button_uyeler
            // 
            this.button_uyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_uyeler.ImageKey = "users.png";
            this.button_uyeler.ImageList = this.ımageList1;
            this.button_uyeler.Location = new System.Drawing.Point(12, 220);
            this.button_uyeler.Name = "button_uyeler";
            this.button_uyeler.Size = new System.Drawing.Size(105, 98);
            this.button_uyeler.TabIndex = 3;
            this.button_uyeler.Text = "Üyeler";
            this.button_uyeler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_uyeler.UseVisualStyleBackColor = true;
            this.button_uyeler.Click += new System.EventHandler(this.button_uyeler_Click);
            // 
            // button_cazalar
            // 
            this.button_cazalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cazalar.ImageKey = "coins.png";
            this.button_cazalar.ImageList = this.ımageList1;
            this.button_cazalar.Location = new System.Drawing.Point(12, 116);
            this.button_cazalar.Name = "button_cazalar";
            this.button_cazalar.Size = new System.Drawing.Size(105, 98);
            this.button_cazalar.TabIndex = 4;
            this.button_cazalar.Text = "Cezalar";
            this.button_cazalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_cazalar.UseVisualStyleBackColor = true;
            this.button_cazalar.Click += new System.EventHandler(this.button_cazalar_Click);
            // 
            // button_yazarlar
            // 
            this.button_yazarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yazarlar.ImageKey = "authors.png";
            this.button_yazarlar.ImageList = this.ımageList1;
            this.button_yazarlar.Location = new System.Drawing.Point(479, 116);
            this.button_yazarlar.Name = "button_yazarlar";
            this.button_yazarlar.Size = new System.Drawing.Size(105, 98);
            this.button_yazarlar.TabIndex = 5;
            this.button_yazarlar.Text = "Yazarlar";
            this.button_yazarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_yazarlar.UseVisualStyleBackColor = true;
            this.button_yazarlar.Click += new System.EventHandler(this.button_yazarlar_Click);
            // 
            // button_yayine
            // 
            this.button_yayine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yayine.ImageKey = "home-icon.png";
            this.button_yayine.ImageList = this.ımageList1;
            this.button_yayine.Location = new System.Drawing.Point(479, 12);
            this.button_yayine.Name = "button_yayine";
            this.button_yayine.Size = new System.Drawing.Size(105, 98);
            this.button_yayine.TabIndex = 6;
            this.button_yayine.Text = "Yayın Evleri";
            this.button_yayine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_yayine.UseVisualStyleBackColor = true;
            this.button_yayine.Click += new System.EventHandler(this.button_yayine_Click);
            // 
            // button_kategoriler
            // 
            this.button_kategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kategoriler.ImageKey = "kategori.png";
            this.button_kategoriler.ImageList = this.ımageList1;
            this.button_kategoriler.Location = new System.Drawing.Point(479, 220);
            this.button_kategoriler.Name = "button_kategoriler";
            this.button_kategoriler.Size = new System.Drawing.Size(105, 98);
            this.button_kategoriler.TabIndex = 7;
            this.button_kategoriler.Text = "Kategoriler";
            this.button_kategoriler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_kategoriler.UseVisualStyleBackColor = true;
            this.button_kategoriler.Click += new System.EventHandler(this.button_kategoriler_Click);
            // 
            // button_ayarlar
            // 
            this.button_ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ayarlar.ImageKey = "settings-icon.png";
            this.button_ayarlar.ImageList = this.ımageList1;
            this.button_ayarlar.Location = new System.Drawing.Point(479, 324);
            this.button_ayarlar.Name = "button_ayarlar";
            this.button_ayarlar.Size = new System.Drawing.Size(105, 98);
            this.button_ayarlar.TabIndex = 8;
            this.button_ayarlar.Text = "Ayarlar";
            this.button_ayarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ayarlar.UseVisualStyleBackColor = true;
            this.button_ayarlar.Click += new System.EventHandler(this.button_ayarlar_Click);
            // 
            // button_ogeri_verildi
            // 
            this.button_ogeri_verildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ogeri_verildi.ImageKey = "ref.png";
            this.button_ogeri_verildi.ImageList = this.ımageList1;
            this.button_ogeri_verildi.Location = new System.Drawing.Point(12, 12);
            this.button_ogeri_verildi.Name = "button_ogeri_verildi";
            this.button_ogeri_verildi.Size = new System.Drawing.Size(105, 98);
            this.button_ogeri_verildi.TabIndex = 12;
            this.button_ogeri_verildi.Text = "Ödünç";
            this.button_ogeri_verildi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ogeri_verildi.UseVisualStyleBackColor = true;
            this.button_ogeri_verildi.Click += new System.EventHandler(this.button_ogeri_verildi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(288, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "K. Toplam Kitap Sayısı:";
            // 
            // label_tplmkitap
            // 
            this.label_tplmkitap.AutoSize = true;
            this.label_tplmkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tplmkitap.Location = new System.Drawing.Point(438, 189);
            this.label_tplmkitap.Name = "label_tplmkitap";
            this.label_tplmkitap.Size = new System.Drawing.Size(21, 13);
            this.label_tplmkitap.TabIndex = 14;
            this.label_tplmkitap.Text = "tks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(288, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ödünç Alınınan Kitap Sayısı:";
            // 
            // label_odnckitap
            // 
            this.label_odnckitap.AutoSize = true;
            this.label_odnckitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_odnckitap.Location = new System.Drawing.Point(438, 131);
            this.label_odnckitap.Name = "label_odnckitap";
            this.label_odnckitap.Size = new System.Drawing.Size(13, 13);
            this.label_odnckitap.TabIndex = 16;
            this.label_odnckitap.Text = "ö";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(288, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Şuan K. Bulunan Kitap Sayısı";
            // 
            // label_blnnkitap
            // 
            this.label_blnnkitap.AutoSize = true;
            this.label_blnnkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_blnnkitap.Location = new System.Drawing.Point(438, 107);
            this.label_blnnkitap.Name = "label_blnnkitap";
            this.label_blnnkitap.Size = new System.Drawing.Size(12, 13);
            this.label_blnnkitap.TabIndex = 20;
            this.label_blnnkitap.Text = "ş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hoş Geldiniz";
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_isim.Location = new System.Drawing.Point(288, 12);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(96, 16);
            this.label_isim.TabIndex = 22;
            this.label_isim.Text = "Hoş Geldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(207, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kütüphane Kitap Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(270, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(270, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(270, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(270, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(207, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Kütüphane Üye Durumu";
            // 
            // label_cbulunmayanu
            // 
            this.label_cbulunmayanu.AutoSize = true;
            this.label_cbulunmayanu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_cbulunmayanu.Location = new System.Drawing.Point(448, 305);
            this.label_cbulunmayanu.Name = "label_cbulunmayanu";
            this.label_cbulunmayanu.Size = new System.Drawing.Size(12, 13);
            this.label_cbulunmayanu.TabIndex = 31;
            this.label_cbulunmayanu.Text = "ş";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(288, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Cezası Bulunmayan Üye Sayısı:";
            // 
            // label_cbulunan
            // 
            this.label_cbulunan.AutoSize = true;
            this.label_cbulunan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_cbulunan.Location = new System.Drawing.Point(448, 329);
            this.label_cbulunan.Name = "label_cbulunan";
            this.label_cbulunan.Size = new System.Drawing.Size(13, 13);
            this.label_cbulunan.TabIndex = 29;
            this.label_cbulunan.Text = "ö";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(288, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Cezası Bulunan Üye Sayısı:";
            // 
            // label_toplamuye
            // 
            this.label_toplamuye.AutoSize = true;
            this.label_toplamuye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_toplamuye.Location = new System.Drawing.Point(448, 387);
            this.label_toplamuye.Name = "label_toplamuye";
            this.label_toplamuye.Size = new System.Drawing.Size(17, 13);
            this.label_toplamuye.TabIndex = 27;
            this.label_toplamuye.Text = "şş";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(288, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "K. Toplam Üye Sayısı:";
            // 
            // kutuphane_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 426);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_cbulunmayanu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_cbulunan);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_toplamuye);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_isim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_blnnkitap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_odnckitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_tplmkitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ogeri_verildi);
            this.Controls.Add(this.button_ayarlar);
            this.Controls.Add(this.button_kategoriler);
            this.Controls.Add(this.button_yayine);
            this.Controls.Add(this.button_yazarlar);
            this.Controls.Add(this.button_cazalar);
            this.Controls.Add(this.button_uyeler);
            this.Controls.Add(this.button_kitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "kutuphane_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kutuphane_panel_FormClosing);
            this.Load += new System.EventHandler(this.kutuphane_panel_Load);
            this.Shown += new System.EventHandler(this.kutuphane_panel_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kitaplar;
        private System.Windows.Forms.Button button_uyeler;
        private System.Windows.Forms.Button button_cazalar;
        private System.Windows.Forms.Button button_yazarlar;
        private System.Windows.Forms.Button button_yayine;
        private System.Windows.Forms.Button button_kategoriler;
        private System.Windows.Forms.Button button_ayarlar;
        private System.Windows.Forms.Button button_ogeri_verildi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tplmkitap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_odnckitap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_blnnkitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_cbulunmayanu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_cbulunan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_toplamuye;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ImageList ımageList1;
    }
}