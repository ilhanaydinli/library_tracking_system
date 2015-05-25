namespace Kütüphane
{
    partial class kategori_duzenle
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
            this.b_ktgri_duz = new System.Windows.Forms.Button();
            this.t_kategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_ktgri_duz
            // 
            this.b_ktgri_duz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ktgri_duz.Location = new System.Drawing.Point(12, 40);
            this.b_ktgri_duz.Name = "b_ktgri_duz";
            this.b_ktgri_duz.Size = new System.Drawing.Size(215, 26);
            this.b_ktgri_duz.TabIndex = 5;
            this.b_ktgri_duz.Text = "Kategori Düzenle";
            this.b_ktgri_duz.UseVisualStyleBackColor = true;
            this.b_ktgri_duz.Click += new System.EventHandler(this.b_ktgri_duz_Click);
            // 
            // t_kategori
            // 
            this.t_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t_kategori.Location = new System.Drawing.Point(99, 12);
            this.t_kategori.Name = "t_kategori";
            this.t_kategori.Size = new System.Drawing.Size(128, 22);
            this.t_kategori.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı:";
            // 
            // kategori_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 74);
            this.Controls.Add(this.b_ktgri_duz);
            this.Controls.Add(this.t_kategori);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kategori_duzenle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Düzenle";
            this.Load += new System.EventHandler(this.kategori_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_ktgri_duz;
        private System.Windows.Forms.TextBox t_kategori;
        private System.Windows.Forms.Label label1;
    }
}