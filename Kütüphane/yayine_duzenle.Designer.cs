namespace Kütüphane
{
    partial class yayine_duzenle
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
            this.b_yyne = new System.Windows.Forms.Button();
            this.t_adres = new System.Windows.Forms.TextBox();
            this.t_eposta = new System.Windows.Forms.TextBox();
            this.t_telefon = new System.Windows.Forms.TextBox();
            this.t_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_yyne
            // 
            this.b_yyne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_yyne.Location = new System.Drawing.Point(11, 124);
            this.b_yyne.Name = "b_yyne";
            this.b_yyne.Size = new System.Drawing.Size(200, 30);
            this.b_yyne.TabIndex = 17;
            this.b_yyne.Text = "Yayin Evi Düzenle";
            this.b_yyne.UseVisualStyleBackColor = true;
            this.b_yyne.Click += new System.EventHandler(this.b_yyne_Click);
            // 
            // t_adres
            // 
            this.t_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_adres.Location = new System.Drawing.Point(79, 96);
            this.t_adres.Name = "t_adres";
            this.t_adres.Size = new System.Drawing.Size(132, 22);
            this.t_adres.TabIndex = 16;
            // 
            // t_eposta
            // 
            this.t_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_eposta.Location = new System.Drawing.Point(79, 68);
            this.t_eposta.Name = "t_eposta";
            this.t_eposta.Size = new System.Drawing.Size(132, 22);
            this.t_eposta.TabIndex = 15;
            // 
            // t_telefon
            // 
            this.t_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_telefon.Location = new System.Drawing.Point(79, 40);
            this.t_telefon.Name = "t_telefon";
            this.t_telefon.Size = new System.Drawing.Size(132, 22);
            this.t_telefon.TabIndex = 14;
            // 
            // t_adi
            // 
            this.t_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_adi.Location = new System.Drawing.Point(79, 12);
            this.t_adi.Name = "t_adi";
            this.t_adi.Size = new System.Drawing.Size(132, 22);
            this.t_adi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-Posta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefonu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı:";
            // 
            // yayine_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 161);
            this.Controls.Add(this.b_yyne);
            this.Controls.Add(this.t_adres);
            this.Controls.Add(this.t_eposta);
            this.Controls.Add(this.t_telefon);
            this.Controls.Add(this.t_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yayine_duzenle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayın Evi Düzenle";
            this.Load += new System.EventHandler(this.yayine_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_yyne;
        private System.Windows.Forms.TextBox t_adres;
        private System.Windows.Forms.TextBox t_eposta;
        private System.Windows.Forms.TextBox t_telefon;
        private System.Windows.Forms.TextBox t_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}