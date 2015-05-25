namespace Kütüphane
{
    partial class kategoriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kategoriler));
            this.b_ktp_sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.b_ktp_duzenle = new System.Windows.Forms.Button();
            this.b_ktp_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_ktp_sil
            // 
            this.b_ktp_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ktp_sil.ImageKey = "delete.png";
            this.b_ktp_sil.ImageList = this.ımageList1;
            this.b_ktp_sil.Location = new System.Drawing.Point(10, 214);
            this.b_ktp_sil.Name = "b_ktp_sil";
            this.b_ktp_sil.Size = new System.Drawing.Size(118, 95);
            this.b_ktp_sil.TabIndex = 7;
            this.b_ktp_sil.Text = "Kategori Sil";
            this.b_ktp_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_ktp_sil.UseVisualStyleBackColor = true;
            this.b_ktp_sil.Click += new System.EventHandler(this.b_ktp_sil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "ekle.png");
            this.ımageList1.Images.SetKeyName(2, "Actions-document-edit-icon.png");
            // 
            // b_ktp_duzenle
            // 
            this.b_ktp_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ktp_duzenle.ImageKey = "Actions-document-edit-icon.png";
            this.b_ktp_duzenle.ImageList = this.ımageList1;
            this.b_ktp_duzenle.Location = new System.Drawing.Point(10, 113);
            this.b_ktp_duzenle.Name = "b_ktp_duzenle";
            this.b_ktp_duzenle.Size = new System.Drawing.Size(118, 95);
            this.b_ktp_duzenle.TabIndex = 6;
            this.b_ktp_duzenle.Text = "Kategori Düzenle";
            this.b_ktp_duzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_ktp_duzenle.UseVisualStyleBackColor = true;
            this.b_ktp_duzenle.Click += new System.EventHandler(this.b_ktp_duzenle_Click);
            // 
            // b_ktp_ekle
            // 
            this.b_ktp_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ktp_ekle.ImageKey = "ekle.png";
            this.b_ktp_ekle.ImageList = this.ımageList1;
            this.b_ktp_ekle.Location = new System.Drawing.Point(10, 12);
            this.b_ktp_ekle.Name = "b_ktp_ekle";
            this.b_ktp_ekle.Size = new System.Drawing.Size(118, 95);
            this.b_ktp_ekle.TabIndex = 5;
            this.b_ktp_ekle.Text = "Kategori Ekle";
            this.b_ktp_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_ktp_ekle.UseVisualStyleBackColor = true;
            this.b_ktp_ekle.Click += new System.EventHandler(this.b_ktp_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(613, 407);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 431);
            this.Controls.Add(this.b_ktp_sil);
            this.Controls.Add(this.b_ktp_duzenle);
            this.Controls.Add(this.b_ktp_ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kategoriler";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_ktp_sil;
        private System.Windows.Forms.Button b_ktp_duzenle;
        private System.Windows.Forms.Button b_ktp_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}