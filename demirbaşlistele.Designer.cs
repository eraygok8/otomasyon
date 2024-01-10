namespace otomasyon
{
    partial class demirbaşlistele
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdemirbaşadeti = new System.Windows.Forms.TextBox();
            this.txtdemirbaşadı = new System.Windows.Forms.TextBox();
            this.silbuton = new System.Windows.Forms.Button();
            this.güncellebuton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdemirbaşadıara = new System.Windows.Forms.TextBox();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdemirbaşadeti);
            this.groupBox1.Controls.Add(this.txtdemirbaşadı);
            this.groupBox1.Location = new System.Drawing.Point(26, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demirbaş Bilgileri";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Demirbaş Adeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Demirbaş Adı :";
            // 
            // txtdemirbaşadeti
            // 
            this.txtdemirbaşadeti.Location = new System.Drawing.Point(94, 123);
            this.txtdemirbaşadeti.Name = "txtdemirbaşadeti";
            this.txtdemirbaşadeti.Size = new System.Drawing.Size(100, 20);
            this.txtdemirbaşadeti.TabIndex = 1;
            // 
            // txtdemirbaşadı
            // 
            this.txtdemirbaşadı.Location = new System.Drawing.Point(94, 77);
            this.txtdemirbaşadı.Name = "txtdemirbaşadı";
            this.txtdemirbaşadı.Size = new System.Drawing.Size(100, 20);
            this.txtdemirbaşadı.TabIndex = 0;
            // 
            // silbuton
            // 
            this.silbuton.BackColor = System.Drawing.Color.Crimson;
            this.silbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbuton.Location = new System.Drawing.Point(33, 281);
            this.silbuton.Margin = new System.Windows.Forms.Padding(2);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(80, 52);
            this.silbuton.TabIndex = 10;
            this.silbuton.Text = "Sil";
            this.silbuton.UseVisualStyleBackColor = false;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // güncellebuton
            // 
            this.güncellebuton.BackColor = System.Drawing.Color.Orange;
            this.güncellebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellebuton.Location = new System.Drawing.Point(127, 281);
            this.güncellebuton.Margin = new System.Windows.Forms.Padding(2);
            this.güncellebuton.Name = "güncellebuton";
            this.güncellebuton.Size = new System.Drawing.Size(84, 52);
            this.güncellebuton.TabIndex = 9;
            this.güncellebuton.Text = "Güncelle";
            this.güncellebuton.UseVisualStyleBackColor = false;
            this.güncellebuton.Click += new System.EventHandler(this.güncellebuton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Demirbaş Adı :";
            // 
            // txtdemirbaşadıara
            // 
            this.txtdemirbaşadıara.Location = new System.Drawing.Point(482, 41);
            this.txtdemirbaşadıara.Name = "txtdemirbaşadıara";
            this.txtdemirbaşadıara.Size = new System.Drawing.Size(100, 20);
            this.txtdemirbaşadıara.TabIndex = 11;
            this.txtdemirbaşadıara.TextChanged += new System.EventHandler(this.txtdemirbaşadıara_TextChanged);
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(750, 415);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 14;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btntr
            // 
            this.btntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntr.Location = new System.Drawing.Point(706, 415);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 13;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // demirbaşlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdemirbaşadıara);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.güncellebuton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "demirbaşlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "demirbaşlistele";
            this.Load += new System.EventHandler(this.demirbaşlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdemirbaşadeti;
        private System.Windows.Forms.TextBox txtdemirbaşadı;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.Button güncellebuton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdemirbaşadıara;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}