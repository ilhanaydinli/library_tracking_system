namespace Kütüphane
{
    partial class kitap_ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.t_kitab_adi = new System.Windows.Forms.TextBox();
            this.t_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_yazar = new System.Windows.Forms.ComboBox();
            this.combo_yayine = new System.Windows.Forms.ComboBox();
            this.combo_kategori = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // t_kitab_adi
            // 
            this.t_kitab_adi.Location = new System.Drawing.Point(83, 12);
            this.t_kitab_adi.Name = "t_kitab_adi";
            this.t_kitab_adi.Size = new System.Drawing.Size(121, 20);
            this.t_kitab_adi.TabIndex = 1;
            // 
            // t_isbn
            // 
            this.t_isbn.Location = new System.Drawing.Point(83, 38);
            this.t_isbn.Name = "t_isbn";
            this.t_isbn.Size = new System.Drawing.Size(121, 20);
            this.t_isbn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yazar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yayın Evi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 68);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kategori:";
            // 
            // combo_yazar
            // 
            this.combo_yazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_yazar.FormattingEnabled = true;
            this.combo_yazar.Location = new System.Drawing.Point(83, 93);
            this.combo_yazar.Name = "combo_yazar";
            this.combo_yazar.Size = new System.Drawing.Size(121, 21);
            this.combo_yazar.TabIndex = 18;
            // 
            // combo_yayine
            // 
            this.combo_yayine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_yayine.FormattingEnabled = true;
            this.combo_yayine.Location = new System.Drawing.Point(83, 120);
            this.combo_yayine.Name = "combo_yayine";
            this.combo_yayine.Size = new System.Drawing.Size(121, 21);
            this.combo_yayine.TabIndex = 21;
            // 
            // combo_kategori
            // 
            this.combo_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_kategori.FormattingEnabled = true;
            this.combo_kategori.Location = new System.Drawing.Point(83, 147);
            this.combo_kategori.Name = "combo_kategori";
            this.combo_kategori.Size = new System.Drawing.Size(121, 21);
            this.combo_kategori.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Resim Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(235, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Seçilen Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(210, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 198);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // kitap_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 251);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_kategori);
            this.Controls.Add(this.combo_yayine);
            this.Controls.Add(this.combo_yazar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_isbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_kitab_adi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kitap_ekle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kitap_ekle_FormClosed);
            this.Load += new System.EventHandler(this.kitap_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_kitab_adi;
        private System.Windows.Forms.TextBox t_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_yazar;
        private System.Windows.Forms.ComboBox combo_yayine;
        private System.Windows.Forms.ComboBox combo_kategori;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}