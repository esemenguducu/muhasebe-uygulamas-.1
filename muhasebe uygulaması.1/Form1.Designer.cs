namespace muhasebe_uygulaması._1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPersonelAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnOlusturListele = new System.Windows.Forms.Button();
            this.btnToplamMaas = new System.Windows.Forms.Button();
            this.btnSonPersonel = new System.Windows.Forms.Button();
            this.btn300Arttır = new System.Windows.Forms.Button();
            this.btn4BindenAz = new System.Windows.Forms.Button();
            this.bnt5Bin7Bin = new System.Windows.Forms.Button();
            this.btnListeTemizle = new System.Windows.Forms.Button();
            this.btnToplamPersonel = new System.Windows.Forms.Button();
            this.btnDusukMaas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbGoster = new System.Windows.Forms.ListBox();
            this.btnYuksekMaasPers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPersonelAra
            // 
            this.tbPersonelAra.Location = new System.Drawing.Point(451, 30);
            this.tbPersonelAra.Name = "tbPersonelAra";
            this.tbPersonelAra.Size = new System.Drawing.Size(217, 22);
            this.tbPersonelAra.TabIndex = 1;
            this.tbPersonelAra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(401, 520);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(48, 16);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "Sonuç:";
            this.lblSonuc.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOlusturListele
            // 
            this.btnOlusturListele.Location = new System.Drawing.Point(95, 469);
            this.btnOlusturListele.Name = "btnOlusturListele";
            this.btnOlusturListele.Size = new System.Drawing.Size(151, 23);
            this.btnOlusturListele.TabIndex = 4;
            this.btnOlusturListele.Text = "Oluştur ve Listele";
            this.btnOlusturListele.UseVisualStyleBackColor = true;
            this.btnOlusturListele.Click += new System.EventHandler(this.btnOlusturListele_Click);
            // 
            // btnToplamMaas
            // 
            this.btnToplamMaas.Location = new System.Drawing.Point(387, 376);
            this.btnToplamMaas.Name = "btnToplamMaas";
            this.btnToplamMaas.Size = new System.Drawing.Size(104, 106);
            this.btnToplamMaas.TabIndex = 5;
            this.btnToplamMaas.Text = "Listedeki toplam maaşı göster";
            this.btnToplamMaas.UseVisualStyleBackColor = true;
            this.btnToplamMaas.Click += new System.EventHandler(this.btnToplamMaas_Click);
            // 
            // btnSonPersonel
            // 
            this.btnSonPersonel.Location = new System.Drawing.Point(681, 376);
            this.btnSonPersonel.Name = "btnSonPersonel";
            this.btnSonPersonel.Size = new System.Drawing.Size(104, 106);
            this.btnSonPersonel.TabIndex = 6;
            this.btnSonPersonel.Text = "Son personelin adını göster";
            this.btnSonPersonel.UseVisualStyleBackColor = true;
            this.btnSonPersonel.Click += new System.EventHandler(this.btnSonPersonel_Click);
            // 
            // btn300Arttır
            // 
            this.btn300Arttır.Location = new System.Drawing.Point(534, 376);
            this.btn300Arttır.Name = "btn300Arttır";
            this.btn300Arttır.Size = new System.Drawing.Size(104, 106);
            this.btn300Arttır.TabIndex = 7;
            this.btn300Arttır.Text = "Listedeki 3. personelin maaşını 300 TL arttır";
            this.btn300Arttır.UseVisualStyleBackColor = true;
            this.btn300Arttır.Click += new System.EventHandler(this.btn300Arttır_Click);
            // 
            // btn4BindenAz
            // 
            this.btn4BindenAz.Location = new System.Drawing.Point(534, 237);
            this.btn4BindenAz.Name = "btn4BindenAz";
            this.btn4BindenAz.Size = new System.Drawing.Size(104, 106);
            this.btn4BindenAz.TabIndex = 8;
            this.btn4BindenAz.Text = "Maaşı 4 binden az olan personelleri göster";
            this.btn4BindenAz.UseVisualStyleBackColor = true;
            this.btn4BindenAz.Click += new System.EventHandler(this.btn4BindenAz_Click);
            // 
            // bnt5Bin7Bin
            // 
            this.bnt5Bin7Bin.Location = new System.Drawing.Point(681, 237);
            this.bnt5Bin7Bin.Name = "bnt5Bin7Bin";
            this.bnt5Bin7Bin.Size = new System.Drawing.Size(104, 106);
            this.bnt5Bin7Bin.TabIndex = 9;
            this.bnt5Bin7Bin.Text = "Maaşı 5 bin ile 7 bin arasında olan personel sayısı";
            this.bnt5Bin7Bin.UseVisualStyleBackColor = true;
            this.bnt5Bin7Bin.Click += new System.EventHandler(this.bnt5Bin7Bin_Click);
            // 
            // btnListeTemizle
            // 
            this.btnListeTemizle.Location = new System.Drawing.Point(387, 100);
            this.btnListeTemizle.Name = "btnListeTemizle";
            this.btnListeTemizle.Size = new System.Drawing.Size(104, 106);
            this.btnListeTemizle.TabIndex = 10;
            this.btnListeTemizle.Text = "Listeyi temizle";
            this.btnListeTemizle.UseVisualStyleBackColor = true;
            this.btnListeTemizle.Click += new System.EventHandler(this.btnListeTemizle_Click);
            // 
            // btnToplamPersonel
            // 
            this.btnToplamPersonel.Location = new System.Drawing.Point(534, 100);
            this.btnToplamPersonel.Name = "btnToplamPersonel";
            this.btnToplamPersonel.Size = new System.Drawing.Size(104, 106);
            this.btnToplamPersonel.TabIndex = 11;
            this.btnToplamPersonel.Text = "Toplam personel sayısını göter";
            this.btnToplamPersonel.UseVisualStyleBackColor = true;
            this.btnToplamPersonel.Click += new System.EventHandler(this.btnToplamPersonel_Click);
            // 
            // btnDusukMaas
            // 
            this.btnDusukMaas.Location = new System.Drawing.Point(681, 100);
            this.btnDusukMaas.Name = "btnDusukMaas";
            this.btnDusukMaas.Size = new System.Drawing.Size(104, 106);
            this.btnDusukMaas.TabIndex = 12;
            this.btnDusukMaas.Text = "En düşük maaşı göster";
            this.btnDusukMaas.UseVisualStyleBackColor = true;
            this.btnDusukMaas.Click += new System.EventHandler(this.btnDusukMaas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button10_Click);
            // 
            // lbGoster
            // 
            this.lbGoster.FormattingEnabled = true;
            this.lbGoster.ItemHeight = 16;
            this.lbGoster.Location = new System.Drawing.Point(12, 13);
            this.lbGoster.Name = "lbGoster";
            this.lbGoster.Size = new System.Drawing.Size(328, 436);
            this.lbGoster.TabIndex = 14;
            this.lbGoster.SelectedIndexChanged += new System.EventHandler(this.lbGoster_SelectedIndexChanged);
            // 
            // btnYuksekMaasPers
            // 
            this.btnYuksekMaasPers.Location = new System.Drawing.Point(387, 237);
            this.btnYuksekMaasPers.Name = "btnYuksekMaasPers";
            this.btnYuksekMaasPers.Size = new System.Drawing.Size(104, 106);
            this.btnYuksekMaasPers.TabIndex = 16;
            this.btnYuksekMaasPers.Text = "En yüksek maaş alan personeli göster";
            this.btnYuksekMaasPers.UseVisualStyleBackColor = true;
            this.btnYuksekMaasPers.Click += new System.EventHandler(this.btnYuksekMaasPers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 556);
            this.Controls.Add(this.btnYuksekMaasPers);
            this.Controls.Add(this.lbGoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDusukMaas);
            this.Controls.Add(this.btnToplamPersonel);
            this.Controls.Add(this.btnListeTemizle);
            this.Controls.Add(this.bnt5Bin7Bin);
            this.Controls.Add(this.btn4BindenAz);
            this.Controls.Add(this.btn300Arttır);
            this.Controls.Add(this.btnSonPersonel);
            this.Controls.Add(this.btnToplamMaas);
            this.Controls.Add(this.btnOlusturListele);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPersonelAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPersonelAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnOlusturListele;
        private System.Windows.Forms.Button btnToplamMaas;
        private System.Windows.Forms.Button btnSonPersonel;
        private System.Windows.Forms.Button btn300Arttır;
        private System.Windows.Forms.Button btn4BindenAz;
        private System.Windows.Forms.Button bnt5Bin7Bin;
        private System.Windows.Forms.Button btnListeTemizle;
        private System.Windows.Forms.Button btnToplamPersonel;
        private System.Windows.Forms.Button btnDusukMaas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbGoster;
        private System.Windows.Forms.Button btnYuksekMaasPers;
    }
}

