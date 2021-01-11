
namespace MarketOtamasyon.Forms
{
    partial class TedarikciIslemleri
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
            this.grpboxOdeme = new System.Windows.Forms.GroupBox();
            this.txtÖdeme = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblÖdeme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblKayit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTAdı = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpboxOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxOdeme
            // 
            this.grpboxOdeme.Controls.Add(this.txtÖdeme);
            this.grpboxOdeme.Controls.Add(this.txtAd);
            this.grpboxOdeme.Controls.Add(this.txtID);
            this.grpboxOdeme.Controls.Add(this.lblÖdeme);
            this.grpboxOdeme.Controls.Add(this.label2);
            this.grpboxOdeme.Controls.Add(this.btnOdeme);
            this.grpboxOdeme.Controls.Add(this.label1);
            this.grpboxOdeme.Location = new System.Drawing.Point(43, 280);
            this.grpboxOdeme.Name = "grpboxOdeme";
            this.grpboxOdeme.Size = new System.Drawing.Size(222, 199);
            this.grpboxOdeme.TabIndex = 15;
            this.grpboxOdeme.TabStop = false;
            this.grpboxOdeme.Text = "Ödeme Paneli";
            // 
            // txtÖdeme
            // 
            this.txtÖdeme.Location = new System.Drawing.Point(121, 110);
            this.txtÖdeme.Name = "txtÖdeme";
            this.txtÖdeme.Size = new System.Drawing.Size(84, 22);
            this.txtÖdeme.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 69);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(84, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(84, 22);
            this.txtID.TabIndex = 3;
            // 
            // lblÖdeme
            // 
            this.lblÖdeme.AutoSize = true;
            this.lblÖdeme.Location = new System.Drawing.Point(7, 113);
            this.lblÖdeme.Name = "lblÖdeme";
            this.lblÖdeme.Size = new System.Drawing.Size(101, 17);
            this.lblÖdeme.TabIndex = 2;
            this.lblÖdeme.Text = "Ödenen Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(114, 152);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(90, 35);
            this.btnOdeme.TabIndex = 8;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(399, 62);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(84, 22);
            this.txtAra.TabIndex = 11;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged_1);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(285, 62);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(96, 17);
            this.lblAra.TabIndex = 10;
            this.lblAra.Text = "Tedarikçi Ara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 371);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Location = new System.Drawing.Point(639, 498);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(0, 17);
            this.lblKayit.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad:";
            // 
            // txtTAdı
            // 
            this.txtTAdı.Location = new System.Drawing.Point(121, 41);
            this.txtTAdı.Name = "txtTAdı";
            this.txtTAdı.Size = new System.Drawing.Size(84, 22);
            this.txtTAdı.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtTAdı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(43, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 152);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Ekle";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(123, 97);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 35);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(10, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 35);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // TedarikciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(996, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.grpboxOdeme);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TedarikciIslemleri";
            this.Text = "Tedarikçi İşlemleri";
            this.Load += new System.EventHandler(this.TedarikciIslemleri_Load);
            this.grpboxOdeme.ResumeLayout(false);
            this.grpboxOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxOdeme;
        private System.Windows.Forms.TextBox txtÖdeme;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblÖdeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTAdı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}