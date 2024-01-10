namespace otomasyon
{
    partial class alınanişler
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
            this.label7 = new System.Windows.Forms.Label();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.geributon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbtemizlikçi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtm2fiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbaşlangıçfiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttoplamfiyat = new System.Windows.Forms.TextBox();
            this.cmbtemizliktürü = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 370);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TC :";
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(494, 34);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(100, 20);
            this.txttcara.TabIndex = 11;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // geributon
            // 
            this.geributon.BackColor = System.Drawing.Color.Gainsboro;
            this.geributon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geributon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geributon.Location = new System.Drawing.Point(12, 12);
            this.geributon.Name = "geributon";
            this.geributon.Size = new System.Drawing.Size(75, 23);
            this.geributon.TabIndex = 17;
            this.geributon.Text = "Geri";
            this.geributon.UseVisualStyleBackColor = false;
            this.geributon.Click += new System.EventHandler(this.geributon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(570, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "İş Tamamlandı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbtemizlikçi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtm2fiyat);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbaşlangıçfiyat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txttoplamfiyat);
            this.groupBox2.Controls.Add(this.cmbtemizliktürü);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtm2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 305);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İş Bilgileri";
            // 
            // cmbtemizlikçi
            // 
            this.cmbtemizlikçi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtemizlikçi.FormattingEnabled = true;
            this.cmbtemizlikçi.Location = new System.Drawing.Point(100, 267);
            this.cmbtemizlikçi.Name = "cmbtemizlikçi";
            this.cmbtemizlikçi.Size = new System.Drawing.Size(84, 21);
            this.cmbtemizlikçi.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Temizlikçi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "m2 Fiyatı :";
            // 
            // txtm2fiyat
            // 
            this.txtm2fiyat.Location = new System.Drawing.Point(100, 150);
            this.txtm2fiyat.Name = "txtm2fiyat";
            this.txtm2fiyat.Size = new System.Drawing.Size(84, 20);
            this.txtm2fiyat.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Başlangıç Fiyatı :";
            // 
            // txtbaşlangıçfiyat
            // 
            this.txtbaşlangıçfiyat.Location = new System.Drawing.Point(100, 112);
            this.txtbaşlangıçfiyat.Name = "txtbaşlangıçfiyat";
            this.txtbaşlangıçfiyat.Size = new System.Drawing.Size(84, 20);
            this.txtbaşlangıçfiyat.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyat :";
            // 
            // txttoplamfiyat
            // 
            this.txttoplamfiyat.Location = new System.Drawing.Point(100, 188);
            this.txttoplamfiyat.Name = "txttoplamfiyat";
            this.txttoplamfiyat.Size = new System.Drawing.Size(84, 20);
            this.txttoplamfiyat.TabIndex = 9;
            // 
            // cmbtemizliktürü
            // 
            this.cmbtemizliktürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtemizliktürü.FormattingEnabled = true;
            this.cmbtemizliktürü.Location = new System.Drawing.Point(100, 75);
            this.cmbtemizliktürü.Name = "cmbtemizliktürü";
            this.cmbtemizliktürü.Size = new System.Drawing.Size(84, 21);
            this.cmbtemizliktürü.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(101, 217);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(84, 44);
            this.txtAdres.TabIndex = 5;
            // 
            // txtm2
            // 
            this.txtm2.Location = new System.Drawing.Point(100, 32);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(84, 20);
            this.txtm2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Temizlik Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ev m2\'si :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 97);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(84, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(100, 58);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(84, 20);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(98, 22);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(84, 20);
            this.txttc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad-Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(750, 496);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 22;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btntr
            // 
            this.btntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntr.Location = new System.Drawing.Point(706, 496);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 21;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // alınanişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geributon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "alınanişler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alınanişler";
            this.Load += new System.EventHandler(this.alınanişler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Button geributon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbtemizlikçi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtm2fiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbaşlangıçfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttoplamfiyat;
        private System.Windows.Forms.ComboBox cmbtemizliktürü;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}