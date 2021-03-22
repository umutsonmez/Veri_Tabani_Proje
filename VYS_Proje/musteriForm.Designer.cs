namespace VYS_Proje
{
    partial class musteriEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.adsoyadTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.adresTestBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.EkleMusteriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(192, 61);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(100, 22);
            this.tcTextBox.TabIndex = 5;
            // 
            // adsoyadTextBox
            // 
            this.adsoyadTextBox.Location = new System.Drawing.Point(192, 94);
            this.adsoyadTextBox.Name = "adsoyadTextBox";
            this.adsoyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.adsoyadTextBox.TabIndex = 6;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(192, 127);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 22);
            this.telTextBox.TabIndex = 7;
            // 
            // adresTestBox
            // 
            this.adresTestBox.Location = new System.Drawing.Point(192, 160);
            this.adresTestBox.Name = "adresTestBox";
            this.adresTestBox.Size = new System.Drawing.Size(100, 22);
            this.adresTestBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(192, 193);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // EkleMusteriButton
            // 
            this.EkleMusteriButton.Location = new System.Drawing.Point(217, 245);
            this.EkleMusteriButton.Name = "EkleMusteriButton";
            this.EkleMusteriButton.Size = new System.Drawing.Size(75, 23);
            this.EkleMusteriButton.TabIndex = 10;
            this.EkleMusteriButton.Text = "Ekle";
            this.EkleMusteriButton.UseVisualStyleBackColor = true;
            this.EkleMusteriButton.Click += new System.EventHandler(this.EkleMusteriButton_Click);
            // 
            // musteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(367, 319);
            this.Controls.Add(this.EkleMusteriButton);
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
            this.Name = "musteriEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşteriEkle";
            this.Load += new System.EventHandler(this.musteriEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.TextBox adsoyadTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox adresTestBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button EkleMusteriButton;
    }
}