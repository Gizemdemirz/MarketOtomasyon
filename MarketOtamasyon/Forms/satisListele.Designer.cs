
namespace MarketOtamasyon.Forms
{
    partial class satisListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnCariSatis = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.btnCokSatan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSatislar
            // 
            this.btnSatislar.Location = new System.Drawing.Point(834, 107);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(109, 61);
            this.btnSatislar.TabIndex = 1;
            this.btnSatislar.Text = "Satışları Listele";
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnCariSatis
            // 
            this.btnCariSatis.Location = new System.Drawing.Point(834, 189);
            this.btnCariSatis.Name = "btnCariSatis";
            this.btnCariSatis.Size = new System.Drawing.Size(109, 61);
            this.btnCariSatis.TabIndex = 2;
            this.btnCariSatis.Text = "Cari Satışlar";
            this.btnCariSatis.UseVisualStyleBackColor = true;
            this.btnCariSatis.Click += new System.EventHandler(this.btnCariSatis_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(834, 362);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(109, 61);
            this.btnSatisIptal.TabIndex = 3;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.btnSatisIptal_Click);
            // 
            // btnCokSatan
            // 
            this.btnCokSatan.Location = new System.Drawing.Point(834, 271);
            this.btnCokSatan.Name = "btnCokSatan";
            this.btnCokSatan.Size = new System.Drawing.Size(109, 61);
            this.btnCokSatan.TabIndex = 5;
            this.btnCokSatan.Text = "Çok Satanlar";
            this.btnCokSatan.UseVisualStyleBackColor = true;
            this.btnCokSatan.Click += new System.EventHandler(this.btnCokSatan_Click);
            // 
            // satisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(977, 523);
            this.Controls.Add(this.btnCokSatan);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.btnCariSatis);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "satisListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.satisListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnCariSatis;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Button btnCokSatan;
    }
}