namespace otomasyon
{
    partial class demirbaşekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdemirbaşadeti = new System.Windows.Forms.TextBox();
            this.txtdemirbaşadı = new System.Windows.Forms.TextBox();
            this.eklebuton = new System.Windows.Forms.Button();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdemirbaşadeti);
            this.groupBox1.Controls.Add(this.txtdemirbaşadı);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demirbaş Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Demirbaş Adeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Demirbaş Adı :";
            // 
            // txtdemirbaşadeti
            // 
            this.txtdemirbaşadeti.Location = new System.Drawing.Point(94, 87);
            this.txtdemirbaşadeti.Name = "txtdemirbaşadeti";
            this.txtdemirbaşadeti.Size = new System.Drawing.Size(100, 20);
            this.txtdemirbaşadeti.TabIndex = 1;
            // 
            // txtdemirbaşadı
            // 
            this.txtdemirbaşadı.Location = new System.Drawing.Point(94, 41);
            this.txtdemirbaşadı.Name = "txtdemirbaşadı";
            this.txtdemirbaşadı.Size = new System.Drawing.Size(100, 20);
            this.txtdemirbaşadı.TabIndex = 0;
            // 
            // eklebuton
            // 
            this.eklebuton.BackColor = System.Drawing.Color.LimeGreen;
            this.eklebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebuton.Location = new System.Drawing.Point(247, 121);
            this.eklebuton.Margin = new System.Windows.Forms.Padding(2);
            this.eklebuton.Name = "eklebuton";
            this.eklebuton.Size = new System.Drawing.Size(82, 52);
            this.eklebuton.TabIndex = 18;
            this.eklebuton.Text = "Ekle";
            this.eklebuton.UseVisualStyleBackColor = false;
            this.eklebuton.Click += new System.EventHandler(this.eklebuton_Click);
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(321, 293);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 20;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btntr
            // 
            this.btntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntr.Location = new System.Drawing.Point(277, 293);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 19;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // demirbaşekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(371, 328);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.eklebuton);
            this.Controls.Add(this.groupBox1);
            this.Name = "demirbaşekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "demirbaşekle";
            this.Load += new System.EventHandler(this.demirbaşekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdemirbaşadeti;
        private System.Windows.Forms.TextBox txtdemirbaşadı;
        private System.Windows.Forms.Button eklebuton;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}