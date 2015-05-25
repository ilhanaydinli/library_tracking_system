namespace Kütüphane
{
    partial class cezalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cezalar));
            this.b_ktp_sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.b_ceza_odendi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_ktp_sil
            // 
            this.b_ktp_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ktp_sil.ImageKey = "delete.png";
            this.b_ktp_sil.ImageList = this.ımageList1;
            this.b_ktp_sil.Location = new System.Drawing.Point(11, 113);
            this.b_ktp_sil.Name = "b_ktp_sil";
            this.b_ktp_sil.Size = new System.Drawing.Size(118, 95);
            this.b_ktp_sil.TabIndex = 7;
            this.b_ktp_sil.Text = "Ceza Sil";
            this.b_ktp_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_ktp_sil.UseVisualStyleBackColor = true;
            this.b_ktp_sil.Click += new System.EventHandler(this.b_ktp_sil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "odendi.png");
            // 
            // b_ceza_odendi
            // 
            this.b_ceza_odendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_ceza_odendi.ImageKey = "odendi.png";
            this.b_ceza_odendi.ImageList = this.ımageList1;
            this.b_ceza_odendi.Location = new System.Drawing.Point(11, 12);
            this.b_ceza_odendi.Name = "b_ceza_odendi";
            this.b_ceza_odendi.Size = new System.Drawing.Size(118, 95);
            this.b_ceza_odendi.TabIndex = 6;
            this.b_ceza_odendi.Text = "Ceza Ödendi";
            this.b_ceza_odendi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_ceza_odendi.UseVisualStyleBackColor = true;
            this.b_ceza_odendi.Click += new System.EventHandler(this.b_ceza_odendi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(612, 411);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cezalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 431);
            this.Controls.Add(this.b_ktp_sil);
            this.Controls.Add(this.b_ceza_odendi);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cezalar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cezalar";
            this.Load += new System.EventHandler(this.cezalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_ktp_sil;
        private System.Windows.Forms.Button b_ceza_odendi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}