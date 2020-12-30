namespace VYS_Proje
{
    partial class musteriListelemeForm
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
            this.guncelleButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adresTestBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.adsoyadTextBox = new System.Windows.Forms.TextBox();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tcAraTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(135, 285);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(100, 43);
            this.guncelleButton.TabIndex = 21;
            this.guncelleButton.Text = "Guncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(135, 238);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 20;
            // 
            // adresTestBox
            // 
            this.adresTestBox.Location = new System.Drawing.Point(135, 205);
            this.adresTestBox.Name = "adresTestBox";
            this.adresTestBox.Size = new System.Drawing.Size(100, 22);
            this.adresTestBox.TabIndex = 19;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(135, 172);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 22);
            this.telTextBox.TabIndex = 18;
            // 
            // adsoyadTextBox
            // 
            this.adsoyadTextBox.Location = new System.Drawing.Point(135, 139);
            this.adsoyadTextBox.Name = "adsoyadTextBox";
            this.adsoyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.adsoyadTextBox.TabIndex = 17;
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(135, 106);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(100, 22);
            this.tcTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC";
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(1014, 104);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(97, 55);
            this.silButton.TabIndex = 22;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tc Ara";
            // 
            // tcAraTextBox
            // 
            this.tcAraTextBox.Location = new System.Drawing.Point(550, 54);
            this.tcAraTextBox.Name = "tcAraTextBox";
            this.tcAraTextBox.Size = new System.Drawing.Size(141, 22);
            this.tcAraTextBox.TabIndex = 24;
            this.tcAraTextBox.TextChanged += new System.EventHandler(this.tcAraTextBox_TextChanged);
            // 
            // musteriListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.tcAraTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.adresTestBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.adsoyadTextBox);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "musteriListelemeForm";
            this.Text = "Müşteri Listeleme";
            this.Load += new System.EventHandler(this.musteriListelemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox adresTestBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox adsoyadTextBox;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcAraTextBox;
    }
}