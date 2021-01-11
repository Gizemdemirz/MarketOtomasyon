
namespace MarketOtamasyon.Forms
{
    partial class OdemeIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblÖdeme = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtÖdeme = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblBorc = new System.Windows.Forms.Label();
            this.grpboxOdeme = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblKayit = new System.Windows.Forms.Label();
            this.lblKytsyi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpboxOdeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // lblÖdeme
            // 
            this.lblÖdeme.AutoSize = true;
            this.lblÖdeme.Location = new System.Drawing.Point(10, 159);
            this.lblÖdeme.Name = "lblÖdeme";
            this.lblÖdeme.Size = new System.Drawing.Size(101, 17);
            this.lblÖdeme.TabIndex = 2;
            this.lblÖdeme.Text = "Ödenen Tutar:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(124, 77);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(84, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(124, 118);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(84, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtÖdeme
            // 
            this.txtÖdeme.Location = new System.Drawing.Point(124, 159);
            this.txtÖdeme.Name = "txtÖdeme";
            this.txtÖdeme.Size = new System.Drawing.Size(84, 22);
            this.txtÖdeme.TabIndex = 3;
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(271, 35);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(84, 17);
            this.lblAra.TabIndex = 2;
            this.lblAra.Text = "Müşteri Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(385, 35);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(84, 22);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(27, 201);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(89, 47);
            this.btnOdeme.TabIndex = 1;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(88, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(725, 465);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 17);
            this.lblToplam.TabIndex = 5;
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Location = new System.Drawing.Point(824, 465);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(0, 17);
            this.lblBorc.TabIndex = 5;
            // 
            // grpboxOdeme
            // 
            this.grpboxOdeme.Controls.Add(this.txtId);
            this.grpboxOdeme.Controls.Add(this.btnListele);
            this.grpboxOdeme.Controls.Add(this.txtÖdeme);
            this.grpboxOdeme.Controls.Add(this.txtSoyad);
            this.grpboxOdeme.Controls.Add(this.txtAd);
            this.grpboxOdeme.Controls.Add(this.lblÖdeme);
            this.grpboxOdeme.Controls.Add(this.lblId);
            this.grpboxOdeme.Controls.Add(this.label2);
            this.grpboxOdeme.Controls.Add(this.label1);
            this.grpboxOdeme.Controls.Add(this.btnOdeme);
            this.grpboxOdeme.Location = new System.Drawing.Point(29, 141);
            this.grpboxOdeme.Name = "grpboxOdeme";
            this.grpboxOdeme.Size = new System.Drawing.Size(222, 262);
            this.grpboxOdeme.TabIndex = 6;
            this.grpboxOdeme.TabStop = false;
            this.grpboxOdeme.Text = "Ödeme Paneli";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(124, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(84, 22);
            this.txtId.TabIndex = 9;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(124, 201);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(89, 47);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Borç Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Location = new System.Drawing.Point(725, 482);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(0, 17);
            this.lblKayit.TabIndex = 7;
            // 
            // lblKytsyi
            // 
            this.lblKytsyi.AutoSize = true;
            this.lblKytsyi.Location = new System.Drawing.Point(824, 482);
            this.lblKytsyi.Name = "lblKytsyi";
            this.lblKytsyi.Size = new System.Drawing.Size(0, 17);
            this.lblKytsyi.TabIndex = 8;
            // 
            // OdemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1002, 537);
            this.Controls.Add(this.lblKytsyi);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.grpboxOdeme);
            this.Controls.Add(this.lblBorc);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OdemeIslemleri";
            this.Text = "Ödeme işlemleri";
            this.Load += new System.EventHandler(this.OdemeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpboxOdeme.ResumeLayout(false);
            this.grpboxOdeme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblÖdeme;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtÖdeme;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.GroupBox grpboxOdeme;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.Label lblKytsyi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtId;
    }
}