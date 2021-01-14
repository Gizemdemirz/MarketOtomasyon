
namespace MarketOtamasyon.Forms
{
    partial class SatısSil
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
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(165, 92);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(123, 22);
            this.txtSifre.TabIndex = 0;
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOnay.Location = new System.Drawing.Point(165, 158);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(103, 48);
            this.btnOnay.TabIndex = 1;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre giriniz:";
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Location = new System.Drawing.Point(176, 129);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 17);
            this.lblHata.TabIndex = 3;
            // 
            // SatısSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(340, 260);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtSifre);
            this.Name = "SatısSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblHata;
    }
}