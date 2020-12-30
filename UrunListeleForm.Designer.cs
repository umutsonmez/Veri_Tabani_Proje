namespace VYS_Proje
{
    partial class UrunListeleForm
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
            this.miktarLabel = new System.Windows.Forms.Label();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.varOlanSatisFiyatiTextBox = new System.Windows.Forms.TextBox();
            this.varOlanAlisFiyatiTextBox = new System.Windows.Forms.TextBox();
            this.varOlanMiktarTextBox = new System.Windows.Forms.TextBox();
            this.varOlanUrunAdiTextBox = new System.Windows.Forms.TextBox();
            this.varOlanMarkaTextBox = new System.Windows.Forms.TextBox();
            this.varOlanKategoriTextBox = new System.Windows.Forms.TextBox();
            this.varOlanBarkodTextBox = new System.Windows.Forms.TextBox();
            this.silmeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barkodNoAraTextBox = new System.Windows.Forms.TextBox();
            this.kategoriGuncelleComboBox = new System.Windows.Forms.ComboBox();
            this.markaGuncelleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.markaGuncelleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.Location = new System.Drawing.Point(7, 304);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(0, 17);
            this.miktarLabel.TabIndex = 42;
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(80, 291);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(120, 38);
            this.guncelleButton.TabIndex = 30;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "BarkodNo";
            // 
            // varOlanSatisFiyatiTextBox
            // 
            this.varOlanSatisFiyatiTextBox.Location = new System.Drawing.Point(100, 251);
            this.varOlanSatisFiyatiTextBox.Name = "varOlanSatisFiyatiTextBox";
            this.varOlanSatisFiyatiTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanSatisFiyatiTextBox.TabIndex = 34;
            // 
            // varOlanAlisFiyatiTextBox
            // 
            this.varOlanAlisFiyatiTextBox.Location = new System.Drawing.Point(100, 221);
            this.varOlanAlisFiyatiTextBox.Name = "varOlanAlisFiyatiTextBox";
            this.varOlanAlisFiyatiTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanAlisFiyatiTextBox.TabIndex = 33;
            // 
            // varOlanMiktarTextBox
            // 
            this.varOlanMiktarTextBox.Location = new System.Drawing.Point(100, 191);
            this.varOlanMiktarTextBox.Name = "varOlanMiktarTextBox";
            this.varOlanMiktarTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanMiktarTextBox.TabIndex = 32;
            // 
            // varOlanUrunAdiTextBox
            // 
            this.varOlanUrunAdiTextBox.Location = new System.Drawing.Point(100, 161);
            this.varOlanUrunAdiTextBox.Name = "varOlanUrunAdiTextBox";
            this.varOlanUrunAdiTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanUrunAdiTextBox.TabIndex = 31;
            // 
            // varOlanMarkaTextBox
            // 
            this.varOlanMarkaTextBox.Location = new System.Drawing.Point(100, 131);
            this.varOlanMarkaTextBox.Name = "varOlanMarkaTextBox";
            this.varOlanMarkaTextBox.ReadOnly = true;
            this.varOlanMarkaTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanMarkaTextBox.TabIndex = 29;
            // 
            // varOlanKategoriTextBox
            // 
            this.varOlanKategoriTextBox.Location = new System.Drawing.Point(100, 101);
            this.varOlanKategoriTextBox.Name = "varOlanKategoriTextBox";
            this.varOlanKategoriTextBox.ReadOnly = true;
            this.varOlanKategoriTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanKategoriTextBox.TabIndex = 28;
            // 
            // varOlanBarkodTextBox
            // 
            this.varOlanBarkodTextBox.Location = new System.Drawing.Point(100, 71);
            this.varOlanBarkodTextBox.Name = "varOlanBarkodTextBox";
            this.varOlanBarkodTextBox.Size = new System.Drawing.Size(100, 22);
            this.varOlanBarkodTextBox.TabIndex = 27;
            this.varOlanBarkodTextBox.TextChanged += new System.EventHandler(this.varOlanBarkodTextBox_TextChanged);
            // 
            // silmeButton
            // 
            this.silmeButton.Location = new System.Drawing.Point(739, 71);
            this.silmeButton.Name = "silmeButton";
            this.silmeButton.Size = new System.Drawing.Size(97, 49);
            this.silmeButton.TabIndex = 43;
            this.silmeButton.Text = "Sil";
            this.silmeButton.UseVisualStyleBackColor = true;
            this.silmeButton.Click += new System.EventHandler(this.silmeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "BarkodNo ya göre ara";
            // 
            // barkodNoAraTextBox
            // 
            this.barkodNoAraTextBox.Location = new System.Drawing.Point(518, 37);
            this.barkodNoAraTextBox.Name = "barkodNoAraTextBox";
            this.barkodNoAraTextBox.Size = new System.Drawing.Size(143, 22);
            this.barkodNoAraTextBox.TabIndex = 45;
            this.barkodNoAraTextBox.TextChanged += new System.EventHandler(this.barkodNoAraTextBox_TextChanged);
            // 
            // kategoriGuncelleComboBox
            // 
            this.kategoriGuncelleComboBox.FormattingEnabled = true;
            this.kategoriGuncelleComboBox.Location = new System.Drawing.Point(409, 362);
            this.kategoriGuncelleComboBox.Name = "kategoriGuncelleComboBox";
            this.kategoriGuncelleComboBox.Size = new System.Drawing.Size(121, 24);
            this.kategoriGuncelleComboBox.TabIndex = 46;
            this.kategoriGuncelleComboBox.SelectedIndexChanged += new System.EventHandler(this.kategoriGuncelleComboBox_SelectedIndexChanged);
            // 
            // markaGuncelleComboBox
            // 
            this.markaGuncelleComboBox.FormattingEnabled = true;
            this.markaGuncelleComboBox.Location = new System.Drawing.Point(409, 392);
            this.markaGuncelleComboBox.Name = "markaGuncelleComboBox";
            this.markaGuncelleComboBox.Size = new System.Drawing.Size(121, 24);
            this.markaGuncelleComboBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Kategori";
            // 
            // markaGuncelleButton
            // 
            this.markaGuncelleButton.Location = new System.Drawing.Point(550, 365);
            this.markaGuncelleButton.Name = "markaGuncelleButton";
            this.markaGuncelleButton.Size = new System.Drawing.Size(120, 48);
            this.markaGuncelleButton.TabIndex = 50;
            this.markaGuncelleButton.Text = "Marka Güncelle";
            this.markaGuncelleButton.UseVisualStyleBackColor = true;
            this.markaGuncelleButton.Click += new System.EventHandler(this.markaGuncelleButton_Click);
            // 
            // UrunListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.markaGuncelleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markaGuncelleComboBox);
            this.Controls.Add(this.kategoriGuncelleComboBox);
            this.Controls.Add(this.barkodNoAraTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silmeButton);
            this.Controls.Add(this.miktarLabel);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.varOlanSatisFiyatiTextBox);
            this.Controls.Add(this.varOlanAlisFiyatiTextBox);
            this.Controls.Add(this.varOlanMiktarTextBox);
            this.Controls.Add(this.varOlanUrunAdiTextBox);
            this.Controls.Add(this.varOlanMarkaTextBox);
            this.Controls.Add(this.varOlanKategoriTextBox);
            this.Controls.Add(this.varOlanBarkodTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunListeleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Listeleme";
            this.Load += new System.EventHandler(this.UrunListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label miktarLabel;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox varOlanSatisFiyatiTextBox;
        private System.Windows.Forms.TextBox varOlanAlisFiyatiTextBox;
        private System.Windows.Forms.TextBox varOlanMiktarTextBox;
        private System.Windows.Forms.TextBox varOlanUrunAdiTextBox;
        private System.Windows.Forms.TextBox varOlanMarkaTextBox;
        private System.Windows.Forms.TextBox varOlanKategoriTextBox;
        private System.Windows.Forms.TextBox varOlanBarkodTextBox;
        private System.Windows.Forms.Button silmeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkodNoAraTextBox;
        private System.Windows.Forms.ComboBox kategoriGuncelleComboBox;
        private System.Windows.Forms.ComboBox markaGuncelleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button markaGuncelleButton;
    }
}