namespace ProlabOdev
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
            this.TxtEnlem = new System.Windows.Forms.TextBox();
            this.TxtBoylam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRakim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmbİller = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGidilecekRakim = new System.Windows.Forms.TextBox();
            this.CmbGidilecekIl = new System.Windows.Forms.ComboBox();
            this.TxtGidilecekEnlem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtGidilecekBoylam = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblKomşu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtRakimFark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtYolcu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtFark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PctTR = new System.Windows.Forms.PictureBox();
            this.BtnAsama2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctTR)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEnlem
            // 
            this.TxtEnlem.Location = new System.Drawing.Point(7, 106);
            this.TxtEnlem.Name = "TxtEnlem";
            this.TxtEnlem.ReadOnly = true;
            this.TxtEnlem.Size = new System.Drawing.Size(100, 22);
            this.TxtEnlem.TabIndex = 0;
            // 
            // TxtBoylam
            // 
            this.TxtBoylam.Location = new System.Drawing.Point(113, 106);
            this.TxtBoylam.Name = "TxtBoylam";
            this.TxtBoylam.ReadOnly = true;
            this.TxtBoylam.Size = new System.Drawing.Size(100, 22);
            this.TxtBoylam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enlem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boylam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtRakim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Cmbİller);
            this.groupBox1.Controls.Add(this.TxtEnlem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBoylam);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rakım";
            // 
            // TxtRakim
            // 
            this.TxtRakim.Location = new System.Drawing.Point(219, 106);
            this.TxtRakim.Name = "TxtRakim";
            this.TxtRakim.ReadOnly = true;
            this.TxtRakim.Size = new System.Drawing.Size(100, 22);
            this.TxtRakim.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "İller";
            // 
            // Cmbİller
            // 
            this.Cmbİller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbİller.FormattingEnabled = true;
            this.Cmbİller.Location = new System.Drawing.Point(7, 49);
            this.Cmbİller.Name = "Cmbİller";
            this.Cmbİller.Size = new System.Drawing.Size(312, 24);
            this.Cmbİller.TabIndex = 4;
            this.Cmbİller.SelectedIndexChanged += new System.EventHandler(this.Cmbİller_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtGidilecekRakim);
            this.groupBox2.Controls.Add(this.CmbGidilecekIl);
            this.groupBox2.Controls.Add(this.TxtGidilecekEnlem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtGidilecekBoylam);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 143);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gidilecek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rakım";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "İller";
            // 
            // TxtGidilecekRakim
            // 
            this.TxtGidilecekRakim.Location = new System.Drawing.Point(219, 106);
            this.TxtGidilecekRakim.Name = "TxtGidilecekRakim";
            this.TxtGidilecekRakim.ReadOnly = true;
            this.TxtGidilecekRakim.Size = new System.Drawing.Size(100, 22);
            this.TxtGidilecekRakim.TabIndex = 8;
            // 
            // CmbGidilecekIl
            // 
            this.CmbGidilecekIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGidilecekIl.FormattingEnabled = true;
            this.CmbGidilecekIl.Location = new System.Drawing.Point(7, 49);
            this.CmbGidilecekIl.Name = "CmbGidilecekIl";
            this.CmbGidilecekIl.Size = new System.Drawing.Size(312, 24);
            this.CmbGidilecekIl.TabIndex = 4;
            this.CmbGidilecekIl.SelectedIndexChanged += new System.EventHandler(this.CmbGidilecekIl_SelectedIndexChanged);
            // 
            // TxtGidilecekEnlem
            // 
            this.TxtGidilecekEnlem.Location = new System.Drawing.Point(7, 106);
            this.TxtGidilecekEnlem.Name = "TxtGidilecekEnlem";
            this.TxtGidilecekEnlem.ReadOnly = true;
            this.TxtGidilecekEnlem.Size = new System.Drawing.Size(100, 22);
            this.TxtGidilecekEnlem.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Boylam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Enlem";
            // 
            // TxtGidilecekBoylam
            // 
            this.TxtGidilecekBoylam.Location = new System.Drawing.Point(113, 106);
            this.TxtGidilecekBoylam.Name = "TxtGidilecekBoylam";
            this.TxtGidilecekBoylam.ReadOnly = true;
            this.TxtGidilecekBoylam.Size = new System.Drawing.Size(100, 22);
            this.TxtGidilecekBoylam.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.LblKomşu);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TxtRakimFark);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtYolcu);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtFark);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 74);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // LblKomşu
            // 
            this.LblKomşu.AutoSize = true;
            this.LblKomşu.Location = new System.Drawing.Point(365, 35);
            this.LblKomşu.Name = "LblKomşu";
            this.LblKomşu.Size = new System.Drawing.Size(12, 17);
            this.LblKomşu.TabIndex = 10;
            this.LblKomşu.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(459, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Komşu İller";
            // 
            // TxtRakimFark
            // 
            this.TxtRakimFark.Location = new System.Drawing.Point(219, 35);
            this.TxtRakimFark.Name = "TxtRakimFark";
            this.TxtRakimFark.Size = new System.Drawing.Size(100, 22);
            this.TxtRakimFark.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Rakım Farkı (M)";
            // 
            // TxtYolcu
            // 
            this.TxtYolcu.Location = new System.Drawing.Point(113, 35);
            this.TxtYolcu.Name = "TxtYolcu";
            this.TxtYolcu.Size = new System.Drawing.Size(100, 22);
            this.TxtYolcu.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Yolcu Sayısı";
            // 
            // TxtFark
            // 
            this.TxtFark.Location = new System.Drawing.Point(7, 35);
            this.TxtFark.Name = "TxtFark";
            this.TxtFark.Size = new System.Drawing.Size(100, 22);
            this.TxtFark.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fark (KM)";
            // 
            // PctTR
            // 
            this.PctTR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PctTR.Location = new System.Drawing.Point(12, 241);
            this.PctTR.Name = "PctTR";
            this.PctTR.Size = new System.Drawing.Size(694, 257);
            this.PctTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctTR.TabIndex = 8;
            this.PctTR.TabStop = false;
            // 
            // BtnAsama2
            // 
            this.BtnAsama2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAsama2.Location = new System.Drawing.Point(631, 507);
            this.BtnAsama2.Name = "BtnAsama2";
            this.BtnAsama2.Size = new System.Drawing.Size(75, 23);
            this.BtnAsama2.TabIndex = 9;
            this.BtnAsama2.Text = "Aşama 2";
            this.BtnAsama2.UseVisualStyleBackColor = true;
            this.BtnAsama2.Click += new System.EventHandler(this.BtnAsama2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 539);
            this.Controls.Add(this.BtnAsama2);
            this.Controls.Add(this.PctTR);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zeplin Yol Hesap Vs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctTR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEnlem;
        private System.Windows.Forms.TextBox TxtBoylam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmbİller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbGidilecekIl;
        private System.Windows.Forms.TextBox TxtGidilecekEnlem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtGidilecekBoylam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtRakim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtGidilecekRakim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtYolcu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtFark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtRakimFark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox PctTR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblKomşu;
        private System.Windows.Forms.Button BtnAsama2;
    }
}

