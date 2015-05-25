namespace Kütüphane
{
    partial class yayin_e
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yayin_e));
            this.b_yyne_sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.b_yyne_duzenle = new System.Windows.Forms.Button();
            this.b_yyne_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_yyne_sil
            // 
            this.b_yyne_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_yyne_sil.ImageKey = "delete.png";
            this.b_yyne_sil.ImageList = this.ımageList1;
            this.b_yyne_sil.Location = new System.Drawing.Point(11, 214);
            this.b_yyne_sil.Name = "b_yyne_sil";
            this.b_yyne_sil.Size = new System.Drawing.Size(118, 95);
            this.b_yyne_sil.TabIndex = 7;
            this.b_yyne_sil.Text = "Yayin Evi Sil";
            this.b_yyne_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_yyne_sil.UseVisualStyleBackColor = true;
            this.b_yyne_sil.Click += new System.EventHandler(this.b_yyne_sil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "ekle.png");
            this.ımageList1.Images.SetKeyName(2, "Actions-document-edit-icon.png");
            // 
            // b_yyne_duzenle
            // 
            this.b_yyne_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_yyne_duzenle.ImageKey = "Actions-document-edit-icon.png";
            this.b_yyne_duzenle.ImageList = this.ımageList1;
            this.b_yyne_duzenle.Location = new System.Drawing.Point(11, 113);
            this.b_yyne_duzenle.Name = "b_yyne_duzenle";
            this.b_yyne_duzenle.Size = new System.Drawing.Size(118, 95);
            this.b_yyne_duzenle.TabIndex = 6;
            this.b_yyne_duzenle.Text = "Yayin Evi Düzenle";
            this.b_yyne_duzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_yyne_duzenle.UseVisualStyleBackColor = true;
            this.b_yyne_duzenle.Click += new System.EventHandler(this.b_yyne_duzenle_Click);
            // 
            // b_yyne_ekle
            // 
            this.b_yyne_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_yyne_ekle.ImageKey = "ekle.png";
            this.b_yyne_ekle.ImageList = this.ımageList1;
            this.b_yyne_ekle.Location = new System.Drawing.Point(11, 12);
            this.b_yyne_ekle.Name = "b_yyne_ekle";
            this.b_yyne_ekle.Size = new System.Drawing.Size(118, 95);
            this.b_yyne_ekle.TabIndex = 5;
            this.b_yyne_ekle.Text = "Yayin Evi Ekle";
            this.b_yyne_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_yyne_ekle.UseVisualStyleBackColor = true;
            this.b_yyne_ekle.Click += new System.EventHandler(this.b_yyne_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(612, 407);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // yayin_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 431);
            this.Controls.Add(this.b_yyne_sil);
            this.Controls.Add(this.b_yyne_duzenle);
            this.Controls.Add(this.b_yyne_ekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yayin_e";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayın Evleri";
            this.Load += new System.EventHandler(this.yayin_e_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_yyne_sil;
        private System.Windows.Forms.Button b_yyne_duzenle;
        private System.Windows.Forms.Button b_yyne_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}