namespace AracKiralama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAracBilgisi = new System.Windows.Forms.TextBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.txtMusteriBilgisi = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.cmbSure = new System.Windows.Forms.ComboBox();
            this.lblSüre = new System.Windows.Forms.Label();
            this.lstGunSonu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAracBilgisi
            // 
            this.txtAracBilgisi.Location = new System.Drawing.Point(17, 17);
            this.txtAracBilgisi.Name = "txtAracBilgisi";
            this.txtAracBilgisi.Size = new System.Drawing.Size(172, 20);
            this.txtAracBilgisi.TabIndex = 0;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(197, 17);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(64, 20);
            this.btnAracEkle.TabIndex = 1;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // lstAraclar
            // 
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(17, 52);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(245, 82);
            this.lstAraclar.TabIndex = 2;
            // 
            // txtMusteriBilgisi
            // 
            this.txtMusteriBilgisi.Location = new System.Drawing.Point(17, 156);
            this.txtMusteriBilgisi.Name = "txtMusteriBilgisi";
            this.txtMusteriBilgisi.Size = new System.Drawing.Size(172, 20);
            this.txtMusteriBilgisi.TabIndex = 3;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(197, 156);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(64, 20);
            this.btnMusteriEkle.TabIndex = 4;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.Location = new System.Drawing.Point(17, 191);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(245, 82);
            this.lstMusteriler.TabIndex = 5;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(103, 286);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(64, 20);
            this.btnKirala.TabIndex = 6;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // cmbSure
            // 
            this.cmbSure.FormattingEnabled = true;
            this.cmbSure.Items.AddRange(new object[] {
            "1 Gün",
            "1 Hafta",
            "1 Ay",
            "3 Ay",
            "6 Ay",
            "1 Yıl"});
            this.cmbSure.Location = new System.Drawing.Point(226, 285);
            this.cmbSure.Name = "cmbSure";
            this.cmbSure.Size = new System.Drawing.Size(172, 21);
            this.cmbSure.TabIndex = 7;
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Location = new System.Drawing.Point(417, 293);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(29, 13);
            this.lblSüre.TabIndex = 8;
            this.lblSüre.Text = "Süre";
            // 
            // lstGunSonu
            // 
            this.lstGunSonu.FormattingEnabled = true;
            this.lstGunSonu.Location = new System.Drawing.Point(373, 12);
            this.lstGunSonu.Name = "lstGunSonu";
            this.lstGunSonu.Size = new System.Drawing.Size(225, 160);
            this.lstGunSonu.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.lstGunSonu);
            this.Controls.Add(this.lblSüre);
            this.Controls.Add(this.cmbSure);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.lstMusteriler);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.txtMusteriBilgisi);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.txtAracBilgisi);
            this.Name = "Form1";
            this.Text = "Araç Kiralama Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtAracBilgisi;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.TextBox txtMusteriBilgisi;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ComboBox cmbSure;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.ListBox lstGunSonu;
    }
}
