
namespace MarketOtamasyon.Forms
{
    partial class urunIslemleri
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
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.lblÜrünAdı = new System.Windows.Forms.Label();
            this.txtSatıs = new System.Windows.Forms.TextBox();
            this.lblSatıs = new System.Windows.Forms.Label();
            this.lblSayı = new System.Windows.Forms.Label();
            this.lblMiktarSayı = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlıs = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblAlıs = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(293, 35);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(83, 17);
            this.lblAra.TabIndex = 28;
            this.lblAra.Text = "Barkod Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(395, 35);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(124, 22);
            this.txtAra.TabIndex = 27;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(133, 256);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 41);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(23, 33);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(79, 17);
            this.lblBarkod.TabIndex = 19;
            this.lblBarkod.Text = "Barkod No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 376);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(119, 74);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(103, 22);
            this.txtÜrünAdı.TabIndex = 33;
            // 
            // lblÜrünAdı
            // 
            this.lblÜrünAdı.AutoSize = true;
            this.lblÜrünAdı.Location = new System.Drawing.Point(23, 75);
            this.lblÜrünAdı.Name = "lblÜrünAdı";
            this.lblÜrünAdı.Size = new System.Drawing.Size(67, 17);
            this.lblÜrünAdı.TabIndex = 32;
            this.lblÜrünAdı.Text = "Ürün Adı:";
            // 
            // txtSatıs
            // 
            this.txtSatıs.Location = new System.Drawing.Point(119, 197);
            this.txtSatıs.Name = "txtSatıs";
            this.txtSatıs.Size = new System.Drawing.Size(103, 22);
            this.txtSatıs.TabIndex = 35;
            // 
            // lblSatıs
            // 
            this.lblSatıs.AutoSize = true;
            this.lblSatıs.Location = new System.Drawing.Point(23, 201);
            this.lblSatıs.Name = "lblSatıs";
            this.lblSatıs.Size = new System.Drawing.Size(80, 17);
            this.lblSatıs.TabIndex = 34;
            this.lblSatıs.Text = "Satış Fiyatı:";
            // 
            // lblSayı
            // 
            this.lblSayı.AutoSize = true;
            this.lblSayı.Location = new System.Drawing.Point(838, 23);
            this.lblSayı.Name = "lblSayı";
            this.lblSayı.Size = new System.Drawing.Size(0, 17);
            this.lblSayı.TabIndex = 40;
            // 
            // lblMiktarSayı
            // 
            this.lblMiktarSayı.AutoSize = true;
            this.lblMiktarSayı.Location = new System.Drawing.Point(838, 40);
            this.lblMiktarSayı.Name = "lblMiktarSayı";
            this.lblMiktarSayı.Size = new System.Drawing.Size(0, 17);
            this.lblMiktarSayı.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.txtAlıs);
            this.groupBox1.Controls.Add(this.txtSatıs);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Controls.Add(this.lblAlıs);
            this.groupBox1.Controls.Add(this.lblSatıs);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtÜrünAdı);
            this.groupBox1.Controls.Add(this.lblMiktar);
            this.groupBox1.Controls.Add(this.lblÜrünAdı);
            this.groupBox1.Controls.Add(this.lblBarkod);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 318);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // txtAlıs
            // 
            this.txtAlıs.Enabled = false;
            this.txtAlıs.Location = new System.Drawing.Point(119, 156);
            this.txtAlıs.Name = "txtAlıs";
            this.txtAlıs.Size = new System.Drawing.Size(103, 22);
            this.txtAlıs.TabIndex = 35;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Enabled = false;
            this.txtBarkodNo.Location = new System.Drawing.Point(119, 33);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(103, 22);
            this.txtBarkodNo.TabIndex = 43;
            // 
            // lblAlıs
            // 
            this.lblAlıs.AutoSize = true;
            this.lblAlıs.Location = new System.Drawing.Point(23, 159);
            this.lblAlıs.Name = "lblAlıs";
            this.lblAlıs.Size = new System.Drawing.Size(71, 17);
            this.lblAlıs.TabIndex = 34;
            this.lblAlıs.Text = "Alış Fiyatı:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Enabled = false;
            this.txtMiktar.Location = new System.Drawing.Point(119, 115);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(103, 22);
            this.txtMiktar.TabIndex = 33;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(23, 117);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblMiktar.TabIndex = 32;
            this.lblMiktar.Text = "Miktar:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(21, 256);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(99, 41);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // urunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1186, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMiktarSayı);
            this.Controls.Add(this.lblSayı);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "urunIslemleri";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.urunIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.Label lblÜrünAdı;
        private System.Windows.Forms.TextBox txtSatıs;
        private System.Windows.Forms.Label lblSatıs;
        private System.Windows.Forms.Label lblSayı;
        private System.Windows.Forms.Label lblMiktarSayı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtAlıs;
        private System.Windows.Forms.Label lblAlıs;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Button btnTemizle;
    }
}