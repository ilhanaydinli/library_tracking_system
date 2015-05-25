namespace Kütüphane
{
    partial class uyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeler));
            this.b_uye_sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.b_uye_duzenle = new System.Windows.Forms.Button();
            this.b_uye_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_uye_sil
            // 
            this.b_uye_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_uye_sil.ImageKey = "delete.png";
            this.b_uye_sil.ImageList = this.ımageList1;
            this.b_uye_sil.Location = new System.Drawing.Point(7, 214);
            this.b_uye_sil.Name = "b_uye_sil";
            this.b_uye_sil.Size = new System.Drawing.Size(118, 95);
            this.b_uye_sil.TabIndex = 7;
            this.b_uye_sil.Text = "Üye Sil";
            this.b_uye_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_uye_sil.UseVisualStyleBackColor = true;
            this.b_uye_sil.Click += new System.EventHandler(this.b_uye_sil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "ekle.png");
            this.ımageList1.Images.SetKeyName(2, "Actions-document-edit-icon.png");
            // 
            // b_uye_duzenle
            // 
            this.b_uye_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_uye_duzenle.ImageKey = "Actions-document-edit-icon.png";
            this.b_uye_duzenle.ImageList = this.ımageList1;
            this.b_uye_duzenle.Location = new System.Drawing.Point(7, 113);
            this.b_uye_duzenle.Name = "b_uye_duzenle";
            this.b_uye_duzenle.Size = new System.Drawing.Size(118, 95);
            this.b_uye_duzenle.TabIndex = 6;
            this.b_uye_duzenle.Text = "Üye Düzenle";
            this.b_uye_duzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_uye_duzenle.UseVisualStyleBackColor = true;
            this.b_uye_duzenle.Click += new System.EventHandler(this.b_uye_duzenle_Click);
            // 
            // b_uye_ekle
            // 
            this.b_uye_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_uye_ekle.ImageKey = "ekle.png";
            this.b_uye_ekle.ImageList = this.ımageList1;
            this.b_uye_ekle.Location = new System.Drawing.Point(7, 12);
            this.b_uye_ekle.Name = "b_uye_ekle";
            this.b_uye_ekle.Size = new System.Drawing.Size(118, 95);
            this.b_uye_ekle.TabIndex = 5;
            this.b_uye_ekle.Text = "Üye Ekle";
            this.b_uye_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_uye_ekle.UseVisualStyleBackColor = true;
            this.b_uye_ekle.Click += new System.EventHandler(this.b_uye_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(616, 407);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // uyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 431);
            this.Controls.Add(this.b_uye_sil);
            this.Controls.Add(this.b_uye_duzenle);
            this.Controls.Add(this.b_uye_ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uyeler";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.uyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_uye_sil;
        private System.Windows.Forms.Button b_uye_duzenle;
        private System.Windows.Forms.Button b_uye_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}