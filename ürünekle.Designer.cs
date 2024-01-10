namespace otomasyon
{
    partial class ürünekle
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
            this.cmbürüntürü = new System.Windows.Forms.ComboBox();
            this.txtürünadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtürünadeti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eklebuton = new System.Windows.Forms.Button();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbürüntürü);
            this.groupBox1.Controls.Add(this.txtürünadı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtürünadeti);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // cmbürüntürü
            // 
            this.cmbürüntürü.FormattingEnabled = true;
            this.cmbürüntürü.Location = new System.Drawing.Point(102, 110);
            this.cmbürüntürü.Name = "cmbürüntürü";
            this.cmbürüntürü.Size = new System.Drawing.Size(84, 21);
            this.cmbürüntürü.TabIndex = 5;
            // 
            // txtürünadı
            // 
            this.txtürünadı.Location = new System.Drawing.Point(102, 24);
            this.txtürünadı.Name = "txtürünadı";
            this.txtürünadı.Size = new System.Drawing.Size(84, 20);
            this.txtürünadı.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Türü :";
            // 
            // txtürünadeti
            // 
            this.txtürünadeti.Location = new System.Drawing.Point(102, 70);
            this.txtürünadeti.Name = "txtürünadeti";
            this.txtürünadeti.Size = new System.Drawing.Size(84, 20);
            this.txtürünadeti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // eklebuton
            // 
            this.eklebuton.BackColor = System.Drawing.Color.LimeGreen;
            this.eklebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebuton.Location = new System.Drawing.Point(234, 121);
            this.eklebuton.Margin = new System.Windows.Forms.Padding(2);
            this.eklebuton.Name = "eklebuton";
            this.eklebuton.Size = new System.Drawing.Size(82, 52);
            this.eklebuton.TabIndex = 17;
            this.eklebuton.Text = "Ekle";
            this.eklebuton.UseVisualStyleBackColor = false;
            this.eklebuton.Click += new System.EventHandler(this.eklebuton_Click);
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(278, 249);
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
            this.btntr.Location = new System.Drawing.Point(234, 249);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 19;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // ürünekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eklebuton);
            this.Name = "ürünekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ürünekle";
            this.Load += new System.EventHandler(this.ürünekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtürünadı;
        private System.Windows.Forms.TextBox txtürünadeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eklebuton;
        private System.Windows.Forms.ComboBox cmbürüntürü;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}