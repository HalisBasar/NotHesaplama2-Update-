namespace DoğruYanlışSayısınaGöreNetHesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtTrhDogru = new System.Windows.Forms.TextBox();
            this.txtTrhYanlis = new System.Windows.Forms.TextBox();
            this.txtTrhNet = new System.Windows.Forms.TextBox();
            this.txtFizDogru = new System.Windows.Forms.TextBox();
            this.txtFizYanlis = new System.Windows.Forms.TextBox();
            this.txtFizNet = new System.Windows.Forms.TextBox();
            this.lblTürkce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.Btntemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtKimyaDogru = new System.Windows.Forms.TextBox();
            this.txtKimyaYanlis = new System.Windows.Forms.TextBox();
            this.txtKimyaNet = new System.Windows.Forms.TextBox();
            this.lblKimya = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatDogru = new System.Windows.Forms.TextBox();
            this.txtMatYanlis = new System.Windows.Forms.TextBox();
            this.txtMatNet = new System.Windows.Forms.TextBox();
            this.btnKırmızı = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnSari = new System.Windows.Forms.Button();
            this.btnMor = new System.Windows.Forms.Button();
            this.btnKahverengi = new System.Windows.Forms.Button();
            this.btnRenktmz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(311, 82);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(100, 23);
            this.txtTurkceDogru.TabIndex = 0;
            this.txtTurkceDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTurkceDogru_KeyPress);
            // 
            // txtTurkceYanlis
            // 
            this.txtTurkceYanlis.Location = new System.Drawing.Point(454, 82);
            this.txtTurkceYanlis.Name = "txtTurkceYanlis";
            this.txtTurkceYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtTurkceYanlis.TabIndex = 1;
            this.txtTurkceYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTurkceYanlis_KeyPress);
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Enabled = false;
            this.txtTurkceNet.Location = new System.Drawing.Point(586, 82);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.Size = new System.Drawing.Size(100, 23);
            this.txtTurkceNet.TabIndex = 2;
            // 
            // txtTrhDogru
            // 
            this.txtTrhDogru.Location = new System.Drawing.Point(311, 128);
            this.txtTrhDogru.Name = "txtTrhDogru";
            this.txtTrhDogru.Size = new System.Drawing.Size(100, 23);
            this.txtTrhDogru.TabIndex = 2;
            this.txtTrhDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrhDogru_KeyPress);
            // 
            // txtTrhYanlis
            // 
            this.txtTrhYanlis.Location = new System.Drawing.Point(454, 128);
            this.txtTrhYanlis.Name = "txtTrhYanlis";
            this.txtTrhYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtTrhYanlis.TabIndex = 3;
            this.txtTrhYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrhYanlis_KeyPress);
            // 
            // txtTrhNet
            // 
            this.txtTrhNet.Enabled = false;
            this.txtTrhNet.Location = new System.Drawing.Point(586, 128);
            this.txtTrhNet.Name = "txtTrhNet";
            this.txtTrhNet.Size = new System.Drawing.Size(100, 23);
            this.txtTrhNet.TabIndex = 5;
            // 
            // txtFizDogru
            // 
            this.txtFizDogru.Location = new System.Drawing.Point(311, 175);
            this.txtFizDogru.Name = "txtFizDogru";
            this.txtFizDogru.Size = new System.Drawing.Size(100, 23);
            this.txtFizDogru.TabIndex = 4;
            this.txtFizDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFizDogru_KeyPress);
            // 
            // txtFizYanlis
            // 
            this.txtFizYanlis.Location = new System.Drawing.Point(454, 175);
            this.txtFizYanlis.Name = "txtFizYanlis";
            this.txtFizYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtFizYanlis.TabIndex = 5;
            this.txtFizYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFizYanlis_KeyPress);
            // 
            // txtFizNet
            // 
            this.txtFizNet.Enabled = false;
            this.txtFizNet.Location = new System.Drawing.Point(586, 175);
            this.txtFizNet.Name = "txtFizNet";
            this.txtFizNet.Size = new System.Drawing.Size(100, 23);
            this.txtFizNet.TabIndex = 8;
            // 
            // lblTürkce
            // 
            this.lblTürkce.AutoSize = true;
            this.lblTürkce.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTürkce.Location = new System.Drawing.Point(238, 85);
            this.lblTürkce.Name = "lblTürkce";
            this.lblTürkce.Size = new System.Drawing.Size(67, 20);
            this.lblTürkce.TabIndex = 9;
            this.lblTürkce.Text = "Türkçe : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(246, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarih : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(253, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fizik : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(332, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Doğru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(476, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yanlış";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(613, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Net";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.BackColor = System.Drawing.Color.Gray;
            this.BtnHesapla.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHesapla.Location = new System.Drawing.Point(253, 331);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(188, 47);
            this.BtnHesapla.TabIndex = 15;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseVisualStyleBackColor = false;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // Btntemizle
            // 
            this.Btntemizle.BackColor = System.Drawing.Color.Gray;
            this.Btntemizle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btntemizle.Location = new System.Drawing.Point(556, 331);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(196, 47);
            this.Btntemizle.TabIndex = 16;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.UseVisualStyleBackColor = false;
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Gray;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKapat.Location = new System.Drawing.Point(613, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(339, 47);
            this.btnKapat.TabIndex = 17;
            this.btnKapat.Text = "Programı Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtKimyaDogru
            // 
            this.txtKimyaDogru.Location = new System.Drawing.Point(311, 216);
            this.txtKimyaDogru.Name = "txtKimyaDogru";
            this.txtKimyaDogru.Size = new System.Drawing.Size(100, 23);
            this.txtKimyaDogru.TabIndex = 6;
            this.txtKimyaDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKimyaDogru_KeyPress);
            // 
            // txtKimyaYanlis
            // 
            this.txtKimyaYanlis.Location = new System.Drawing.Point(454, 218);
            this.txtKimyaYanlis.Name = "txtKimyaYanlis";
            this.txtKimyaYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtKimyaYanlis.TabIndex = 7;
            this.txtKimyaYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKimyaYanlis_KeyPress);
            // 
            // txtKimyaNet
            // 
            this.txtKimyaNet.Enabled = false;
            this.txtKimyaNet.Location = new System.Drawing.Point(586, 218);
            this.txtKimyaNet.Name = "txtKimyaNet";
            this.txtKimyaNet.Size = new System.Drawing.Size(100, 23);
            this.txtKimyaNet.TabIndex = 20;
            // 
            // lblKimya
            // 
            this.lblKimya.AutoSize = true;
            this.lblKimya.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKimya.Location = new System.Drawing.Point(228, 214);
            this.lblKimya.Name = "lblKimya";
            this.lblKimya.Size = new System.Drawing.Size(66, 21);
            this.lblKimya.TabIndex = 21;
            this.lblKimya.Text = "Kimya :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(200, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Matematik :";
            // 
            // txtMatDogru
            // 
            this.txtMatDogru.Location = new System.Drawing.Point(311, 260);
            this.txtMatDogru.Name = "txtMatDogru";
            this.txtMatDogru.Size = new System.Drawing.Size(100, 23);
            this.txtMatDogru.TabIndex = 8;
            this.txtMatDogru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatDogru_KeyPress);
            // 
            // txtMatYanlis
            // 
            this.txtMatYanlis.Location = new System.Drawing.Point(454, 260);
            this.txtMatYanlis.Name = "txtMatYanlis";
            this.txtMatYanlis.Size = new System.Drawing.Size(100, 23);
            this.txtMatYanlis.TabIndex = 9;
            this.txtMatYanlis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatYanlis_KeyPress);
            // 
            // txtMatNet
            // 
            this.txtMatNet.Enabled = false;
            this.txtMatNet.Location = new System.Drawing.Point(586, 260);
            this.txtMatNet.Name = "txtMatNet";
            this.txtMatNet.Size = new System.Drawing.Size(100, 23);
            this.txtMatNet.TabIndex = 25;
            // 
            // btnKırmızı
            // 
            this.btnKırmızı.BackColor = System.Drawing.Color.Red;
            this.btnKırmızı.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKırmızı.ForeColor = System.Drawing.Color.White;
            this.btnKırmızı.Location = new System.Drawing.Point(12, 496);
            this.btnKırmızı.Name = "btnKırmızı";
            this.btnKırmızı.Size = new System.Drawing.Size(140, 23);
            this.btnKırmızı.TabIndex = 26;
            this.btnKırmızı.Text = "Arka Planı Kırmızı yap";
            this.btnKırmızı.UseVisualStyleBackColor = false;
            this.btnKırmızı.Click += new System.EventHandler(this.btnKırmızı_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.BackColor = System.Drawing.Color.Green;
            this.btnYesil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYesil.ForeColor = System.Drawing.Color.White;
            this.btnYesil.Location = new System.Drawing.Point(158, 496);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(136, 23);
            this.btnYesil.TabIndex = 27;
            this.btnYesil.Text = "Arka Planı Yeşil Yap";
            this.btnYesil.UseVisualStyleBackColor = false;
            this.btnYesil.Click += new System.EventHandler(this.btnYesil_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.Blue;
            this.btnMavi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMavi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMavi.Location = new System.Drawing.Point(300, 496);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(150, 23);
            this.btnMavi.TabIndex = 28;
            this.btnMavi.Text = "Arka Planı Mavi Yap";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnSari
            // 
            this.btnSari.BackColor = System.Drawing.Color.Yellow;
            this.btnSari.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSari.ForeColor = System.Drawing.Color.Black;
            this.btnSari.Location = new System.Drawing.Point(454, 496);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(141, 23);
            this.btnSari.TabIndex = 29;
            this.btnSari.Text = "Arka Planı Sarı Yap";
            this.btnSari.UseVisualStyleBackColor = false;
            this.btnSari.Click += new System.EventHandler(this.btnSari_Click);
            // 
            // btnMor
            // 
            this.btnMor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMor.ForeColor = System.Drawing.Color.White;
            this.btnMor.Location = new System.Drawing.Point(601, 496);
            this.btnMor.Name = "btnMor";
            this.btnMor.Size = new System.Drawing.Size(151, 24);
            this.btnMor.TabIndex = 30;
            this.btnMor.Text = "Arka Planı Mor Yap";
            this.btnMor.UseVisualStyleBackColor = false;
            this.btnMor.Click += new System.EventHandler(this.btnMor_Click);
            // 
            // btnKahverengi
            // 
            this.btnKahverengi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKahverengi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKahverengi.ForeColor = System.Drawing.Color.White;
            this.btnKahverengi.Location = new System.Drawing.Point(758, 497);
            this.btnKahverengi.Name = "btnKahverengi";
            this.btnKahverengi.Size = new System.Drawing.Size(184, 23);
            this.btnKahverengi.TabIndex = 31;
            this.btnKahverengi.Text = "Arka Planı Kahverengi Yap";
            this.btnKahverengi.UseVisualStyleBackColor = false;
            this.btnKahverengi.Click += new System.EventHandler(this.btnKahverengi_Click);
            // 
            // btnRenktmz
            // 
            this.btnRenktmz.BackColor = System.Drawing.Color.Gray;
            this.btnRenktmz.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRenktmz.Location = new System.Drawing.Point(376, 547);
            this.btnRenktmz.Name = "btnRenktmz";
            this.btnRenktmz.Size = new System.Drawing.Size(228, 36);
            this.btnRenktmz.TabIndex = 32;
            this.btnRenktmz.Text = "Rengi İlk Haline Getir";
            this.btnRenktmz.UseVisualStyleBackColor = false;
            this.btnRenktmz.Click += new System.EventHandler(this.btnRenktmz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(955, 605);
            this.Controls.Add(this.btnRenktmz);
            this.Controls.Add(this.btnKahverengi);
            this.Controls.Add(this.btnMor);
            this.Controls.Add(this.btnSari);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnKırmızı);
            this.Controls.Add(this.txtMatNet);
            this.Controls.Add(this.txtMatYanlis);
            this.Controls.Add(this.txtMatDogru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKimya);
            this.Controls.Add(this.txtKimyaNet);
            this.Controls.Add(this.txtKimyaYanlis);
            this.Controls.Add(this.txtKimyaDogru);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.Btntemizle);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTürkce);
            this.Controls.Add(this.txtFizNet);
            this.Controls.Add(this.txtFizYanlis);
            this.Controls.Add(this.txtFizDogru);
            this.Controls.Add(this.txtTrhNet);
            this.Controls.Add(this.txtTrhYanlis);
            this.Controls.Add(this.txtTrhDogru);
            this.Controls.Add(this.txtTurkceNet);
            this.Controls.Add(this.txtTurkceYanlis);
            this.Controls.Add(this.txtTurkceDogru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.TextBox txtTurkceYanlis;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.TextBox txtTrhDogru;
        private System.Windows.Forms.TextBox txtTrhYanlis;
        private System.Windows.Forms.TextBox txtTrhNet;
        private System.Windows.Forms.TextBox txtFizDogru;
        private System.Windows.Forms.TextBox txtFizYanlis;
        private System.Windows.Forms.TextBox txtFizNet;
        private System.Windows.Forms.Label lblTürkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button Btntemizle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtKimyaDogru;
        private System.Windows.Forms.TextBox txtKimyaYanlis;
        private System.Windows.Forms.TextBox txtKimyaNet;
        private System.Windows.Forms.Label lblKimya;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatDogru;
        private System.Windows.Forms.TextBox txtMatYanlis;
        private System.Windows.Forms.TextBox txtMatNet;
        private System.Windows.Forms.Button btnKırmızı;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.Button btnMor;
        private System.Windows.Forms.Button btnKahverengi;
        private System.Windows.Forms.Button btnRenktmz;
    }
}
