namespace Kütüphane
{
    partial class kutuphane
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
            this.sifremi_unuttum = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.Boxsifre = new System.Windows.Forms.TextBox();
            this.Boxkullanici_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sifremi_unuttum
            // 
            this.sifremi_unuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremi_unuttum.Location = new System.Drawing.Point(76, 176);
            this.sifremi_unuttum.Name = "sifremi_unuttum";
            this.sifremi_unuttum.Size = new System.Drawing.Size(171, 24);
            this.sifremi_unuttum.TabIndex = 13;
            this.sifremi_unuttum.Text = "Şifremi Unuttum";
            this.sifremi_unuttum.UseVisualStyleBackColor = true;
            this.sifremi_unuttum.Click += new System.EventHandler(this.sifremi_unuttum_Click);
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(76, 146);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(171, 24);
            this.giris.TabIndex = 12;
            this.giris.Text = "Giriş";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // Boxsifre
            // 
            this.Boxsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Boxsifre.Location = new System.Drawing.Point(159, 98);
            this.Boxsifre.Name = "Boxsifre";
            this.Boxsifre.PasswordChar = '*';
            this.Boxsifre.Size = new System.Drawing.Size(100, 22);
            this.Boxsifre.TabIndex = 11;
            this.Boxsifre.Text = "1234";
            // 
            // Boxkullanici_a
            // 
            this.Boxkullanici_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Boxkullanici_a.Location = new System.Drawing.Point(159, 72);
            this.Boxkullanici_a.Name = "Boxkullanici_a";
            this.Boxkullanici_a.Size = new System.Drawing.Size(100, 22);
            this.Boxkullanici_a.TabIndex = 10;
            this.Boxkullanici_a.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yönetici Girişi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sifremi_unuttum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.giris);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Boxsifre);
            this.panel1.Controls.Add(this.Boxkullanici_a);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 220);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane.Properties.Resources.Locked_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // kutuphane
            // 
            this.AcceptButton = this.giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 240);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kutuphane";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kutuphane_FormClosing);
            this.Load += new System.EventHandler(this.kutuphane_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sifremi_unuttum;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox Boxsifre;
        private System.Windows.Forms.TextBox Boxkullanici_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

