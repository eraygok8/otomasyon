namespace otomasyon
{
    partial class çalışanlar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.geributon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblençokçalışan = new System.Windows.Forms.Label();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekleme Sayfası";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listeleme Sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // geributon
            // 
            this.geributon.BackColor = System.Drawing.Color.Gainsboro;
            this.geributon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geributon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geributon.Location = new System.Drawing.Point(12, 26);
            this.geributon.Name = "geributon";
            this.geributon.Size = new System.Drawing.Size(75, 23);
            this.geributon.TabIndex = 16;
            this.geributon.Text = "Geri";
            this.geributon.UseVisualStyleBackColor = false;
            this.geributon.Click += new System.EventHandler(this.geributon_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "Personel İş Bilgileri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblençokçalışan
            // 
            this.lblençokçalışan.AutoSize = true;
            this.lblençokçalışan.Location = new System.Drawing.Point(257, 309);
            this.lblençokçalışan.Name = "lblençokçalışan";
            this.lblençokçalışan.Size = new System.Drawing.Size(0, 13);
            this.lblençokçalışan.TabIndex = 18;
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(750, 415);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 20;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            // 
            // btntr
            // 
            this.btntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntr.Location = new System.Drawing.Point(706, 415);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 19;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            // 
            // çalışanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.lblençokçalışan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.geributon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "çalışanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "çalışanlar";
            this.Load += new System.EventHandler(this.çalışanlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button geributon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblençokçalışan;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}