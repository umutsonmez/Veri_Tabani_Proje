namespace VYS_Proje
{
    partial class satis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.adSoyadTextBox = new System.Windows.Forms.TextBox();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toplamFiyatTextBox = new System.Windows.Forms.TextBox();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.satisFiyatiTextBox = new System.Windows.Forms.TextBox();
            this.miktarTextBox = new System.Windows.Forms.TextBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.satisİptalButton = new System.Windows.Forms.Button();
            this.satisYapButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.musteriListeleButton = new System.Windows.Forms.Button();
            this.musteriEkleButton = new System.Windows.Forms.Button();
            this.genelToplamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.telefonTextBox);
            this.groupBox1.Controls.Add(this.adSoyadTextBox);
            this.groupBox1.Controls.Add(this.tcTextBox);
            this.groupBox1.Location = new System.Drawing.Point(97, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(116, 111);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefonTextBox.TabIndex = 2;
            // 
            // adSoyadTextBox
            // 
            this.adSoyadTextBox.Location = new System.Drawing.Point(116, 73);
            this.adSoyadTextBox.Name = "adSoyadTextBox";
            this.adSoyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.adSoyadTextBox.TabIndex = 1;
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(116, 35);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(100, 22);
            this.tcTextBox.TabIndex = 0;
            this.tcTextBox.TextChanged += new System.EventHandler(this.tcTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.toplamFiyatTextBox);
            this.groupBox2.Controls.Add(this.barkodTextBox);
            this.groupBox2.Controls.Add(this.urunAdiTextBox);
            this.groupBox2.Controls.Add(this.satisFiyatiTextBox);
            this.groupBox2.Controls.Add(this.miktarTextBox);
            this.groupBox2.Location = new System.Drawing.Point(97, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod No";
            // 
            // toplamFiyatTextBox
            // 
            this.toplamFiyatTextBox.Location = new System.Drawing.Point(116, 129);
            this.toplamFiyatTextBox.Name = "toplamFiyatTextBox";
            this.toplamFiyatTextBox.Size = new System.Drawing.Size(100, 22);
            this.toplamFiyatTextBox.TabIndex = 5;
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Location = new System.Drawing.Point(116, 21);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(100, 22);
            this.barkodTextBox.TabIndex = 4;
            this.barkodTextBox.TextChanged += new System.EventHandler(this.barkodTextBox_TextChanged_1);
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Location = new System.Drawing.Point(116, 48);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(100, 22);
            this.urunAdiTextBox.TabIndex = 3;
            // 
            // satisFiyatiTextBox
            // 
            this.satisFiyatiTextBox.Location = new System.Drawing.Point(116, 102);
            this.satisFiyatiTextBox.Name = "satisFiyatiTextBox";
            this.satisFiyatiTextBox.Size = new System.Drawing.Size(100, 22);
            this.satisFiyatiTextBox.TabIndex = 2;
            this.satisFiyatiTextBox.TextChanged += new System.EventHandler(this.satisFiyatiTextBox_TextChanged);
            // 
            // miktarTextBox
            // 
            this.miktarTextBox.Location = new System.Drawing.Point(116, 75);
            this.miktarTextBox.Name = "miktarTextBox";
            this.miktarTextBox.Size = new System.Drawing.Size(100, 22);
            this.miktarTextBox.TabIndex = 1;
            this.miktarTextBox.Text = "1";
            this.miktarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miktarTextBox.TextChanged += new System.EventHandler(this.miktarTextBox_TextChanged);
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(380, 463);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(109, 38);
            this.ekleButton.TabIndex = 3;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(1001, 161);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(109, 38);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // satisİptalButton
            // 
            this.satisİptalButton.Location = new System.Drawing.Point(1001, 225);
            this.satisİptalButton.Name = "satisİptalButton";
            this.satisİptalButton.Size = new System.Drawing.Size(109, 38);
            this.satisİptalButton.TabIndex = 5;
            this.satisİptalButton.Text = "Satış İptal";
            this.satisİptalButton.UseVisualStyleBackColor = true;
            this.satisİptalButton.Click += new System.EventHandler(this.satisİptalButton_Click);
            // 
            // satisYapButton
            // 
            this.satisYapButton.Location = new System.Drawing.Point(868, 461);
            this.satisYapButton.Name = "satisYapButton";
            this.satisYapButton.Size = new System.Drawing.Size(109, 38);
            this.satisYapButton.TabIndex = 6;
            this.satisYapButton.Text = "Satış Yap";
            this.satisYapButton.UseVisualStyleBackColor = true;
            this.satisYapButton.Click += new System.EventHandler(this.satisYapButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.musteriListeleButton);
            this.panel1.Controls.Add(this.musteriEkleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 100);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Marka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kategori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(674, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 56);
            this.button9.TabIndex = 4;
            this.button9.Text = "Satışları Listeleme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(518, 24);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 56);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ürün Listeleme";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(362, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 56);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ürün Ekleme";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // musteriListeleButton
            // 
            this.musteriListeleButton.Location = new System.Drawing.Point(206, 24);
            this.musteriListeleButton.Name = "musteriListeleButton";
            this.musteriListeleButton.Size = new System.Drawing.Size(146, 56);
            this.musteriListeleButton.TabIndex = 1;
            this.musteriListeleButton.Text = "Müşteri Listeleme";
            this.musteriListeleButton.UseVisualStyleBackColor = true;
            this.musteriListeleButton.Click += new System.EventHandler(this.musteriListeleButton_Click);
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.Location = new System.Drawing.Point(50, 24);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(146, 56);
            this.musteriEkleButton.TabIndex = 0;
            this.musteriEkleButton.Text = "Müşteri Ekleme";
            this.musteriEkleButton.UseVisualStyleBackColor = true;
            this.musteriEkleButton.Click += new System.EventHandler(this.musteriEkleButton_Click);
            // 
            // genelToplamLabel
            // 
            this.genelToplamLabel.AutoSize = true;
            this.genelToplamLabel.Location = new System.Drawing.Point(791, 474);
            this.genelToplamLabel.Name = "genelToplamLabel";
            this.genelToplamLabel.Size = new System.Drawing.Size(0, 17);
            this.genelToplamLabel.TabIndex = 10;
            // 
            // satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1193, 550);
            this.Controls.Add(this.genelToplamLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.satisYapButton);
            this.Controls.Add(this.satisİptalButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox adSoyadTextBox;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox toplamFiyatTextBox;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.TextBox satisFiyatiTextBox;
        private System.Windows.Forms.TextBox miktarTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button satisİptalButton;
        private System.Windows.Forms.Button satisYapButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button musteriListeleButton;
        private System.Windows.Forms.Button musteriEkleButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label genelToplamLabel;
    }
}

