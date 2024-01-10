namespace otomasyon
{
    partial class çalışanlistele
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtkullanıcıadıara = new System.Windows.Forms.TextBox();
            this.silbuton = new System.Windows.Forms.Button();
            this.güncellebuton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbktipi = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmeslek = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaaş = new System.Windows.Forms.TextBox();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.txtkullanıcıadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ad-Soyad :";
            // 
            // txtkullanıcıadıara
            // 
            this.txtkullanıcıadıara.Location = new System.Drawing.Point(498, 18);
            this.txtkullanıcıadıara.Name = "txtkullanıcıadıara";
            this.txtkullanıcıadıara.Size = new System.Drawing.Size(100, 20);
            this.txtkullanıcıadıara.TabIndex = 17;
            this.txtkullanıcıadıara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // silbuton
            // 
            this.silbuton.BackColor = System.Drawing.Color.Crimson;
            this.silbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbuton.Location = new System.Drawing.Point(24, 381);
            this.silbuton.Margin = new System.Windows.Forms.Padding(2);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(80, 52);
            this.silbuton.TabIndex = 16;
            this.silbuton.Text = "Sil";
            this.silbuton.UseVisualStyleBackColor = false;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // güncellebuton
            // 
            this.güncellebuton.BackColor = System.Drawing.Color.Orange;
            this.güncellebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellebuton.Location = new System.Drawing.Point(118, 381);
            this.güncellebuton.Margin = new System.Windows.Forms.Padding(2);
            this.güncellebuton.Name = "güncellebuton";
            this.güncellebuton.Size = new System.Drawing.Size(84, 52);
            this.güncellebuton.TabIndex = 15;
            this.güncellebuton.Text = "Güncelle";
            this.güncellebuton.UseVisualStyleBackColor = false;
            this.güncellebuton.Click += new System.EventHandler(this.güncellebuton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 304);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbktipi);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbmeslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmaaş);
            this.groupBox1.Controls.Add(this.txtşifre);
            this.groupBox1.Controls.Add(this.txtkullanıcıadı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 312);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgileri";
            // 
            // cmbktipi
            // 
            this.cmbktipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbktipi.FormattingEnabled = true;
            this.cmbktipi.Location = new System.Drawing.Point(92, 189);
            this.cmbktipi.Name = "cmbktipi";
            this.cmbktipi.Size = new System.Drawing.Size(84, 21);
            this.cmbktipi.TabIndex = 17;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(84, 20);
            this.txtid.TabIndex = 16;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(94, 73);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(84, 20);
            this.txtadsoyad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ad-Soyad :";
            // 
            // cmbmeslek
            // 
            this.cmbmeslek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmeslek.FormattingEnabled = true;
            this.cmbmeslek.Location = new System.Drawing.Point(94, 228);
            this.cmbmeslek.Name = "cmbmeslek";
            this.cmbmeslek.Size = new System.Drawing.Size(84, 21);
            this.cmbmeslek.TabIndex = 14;
            this.cmbmeslek.TextChanged += new System.EventHandler(this.cmbmeslek_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Meslek :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maaş :";
            // 
            // txtmaaş
            // 
            this.txtmaaş.Location = new System.Drawing.Point(94, 270);
            this.txtmaaş.Name = "txtmaaş";
            this.txtmaaş.Size = new System.Drawing.Size(84, 20);
            this.txtmaaş.TabIndex = 7;
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(94, 154);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(84, 20);
            this.txtşifre.TabIndex = 4;
            // 
            // txtkullanıcıadı
            // 
            this.txtkullanıcıadı.Location = new System.Drawing.Point(94, 110);
            this.txtkullanıcıadı.Name = "txtkullanıcıadı";
            this.txtkullanıcıadı.Size = new System.Drawing.Size(84, 20);
            this.txtkullanıcıadı.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Tipi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(744, 415);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 21;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btntr
            // 
            this.btntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntr.Location = new System.Drawing.Point(700, 415);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 20;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // çalışanlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtkullanıcıadıara);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.güncellebuton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "çalışanlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "çalışanlistele";
            this.Load += new System.EventHandler(this.çalışanlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkullanıcıadıara;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.Button güncellebuton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaaş;
        private System.Windows.Forms.TextBox txtşifre;
        private System.Windows.Forms.TextBox txtkullanıcıadı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbmeslek;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbktipi;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}