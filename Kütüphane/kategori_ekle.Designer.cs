namespace Kütüphane
{
    partial class kategori_ekle
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
            this.t_kategori = new System.Windows.Forms.TextBox();
            this.b_ktgri_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // t_kategori
            // 
            this.t_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_kategori.Location = new System.Drawing.Point(99, 12);
            this.t_kategori.Name = "t_kategori";
            this.t_kategori.Size = new System.Drawing.Size(128, 22);
            this.t_kategori.TabIndex = 1;
            // 
            // b_ktgri_ekle
            // 
            this.b_ktgri_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ktgri_ekle.Location = new System.Drawing.Point(12, 40);
            this.b_ktgri_ekle.Name = "b_ktgri_ekle";
            this.b_ktgri_ekle.Size = new System.Drawing.Size(215, 26);
            this.b_ktgri_ekle.TabIndex = 2;
            this.b_ktgri_ekle.Text = "Kategori Ekle";
            this.b_ktgri_ekle.UseVisualStyleBackColor = true;
            this.b_ktgri_ekle.Click += new System.EventHandler(this.b_ktgri_ekle_Click);
            // 
            // kategori_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 74);
            this.Controls.Add(this.b_ktgri_ekle);
            this.Controls.Add(this.t_kategori);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kategori_ekle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_kategori;
        private System.Windows.Forms.Button b_ktgri_ekle;
    }
}