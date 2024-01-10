namespace otomasyon
{
    partial class talepedilenişler
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
            this.eklebuton = new System.Windows.Forms.Button();
            this.listelebuton = new System.Windows.Forms.Button();
            this.geributon = new System.Windows.Forms.Button();
            this.btnen = new System.Windows.Forms.Button();
            this.btntr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eklebuton
            // 
            this.eklebuton.BackColor = System.Drawing.SystemColors.Info;
            this.eklebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebuton.Location = new System.Drawing.Point(20, 60);
            this.eklebuton.Margin = new System.Windows.Forms.Padding(2);
            this.eklebuton.Name = "eklebuton";
            this.eklebuton.Size = new System.Drawing.Size(64, 57);
            this.eklebuton.TabIndex = 3;
            this.eklebuton.Text = "Ekleme Sayfası";
            this.eklebuton.UseVisualStyleBackColor = false;
            this.eklebuton.Click += new System.EventHandler(this.eklebuton_Click);
            // 
            // listelebuton
            // 
            this.listelebuton.BackColor = System.Drawing.SystemColors.Info;
            this.listelebuton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listelebuton.Location = new System.Drawing.Point(20, 142);
            this.listelebuton.Margin = new System.Windows.Forms.Padding(2);
            this.listelebuton.Name = "listelebuton";
            this.listelebuton.Size = new System.Drawing.Size(104, 86);
            this.listelebuton.TabIndex = 6;
            this.listelebuton.Text = "Listeleme Sayfası";
            this.listelebuton.UseVisualStyleBackColor = false;
            this.listelebuton.Click += new System.EventHandler(this.listelebuton_Click);
            // 
            // geributon
            // 
            this.geributon.BackColor = System.Drawing.Color.Gainsboro;
            this.geributon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geributon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geributon.Location = new System.Drawing.Point(20, 12);
            this.geributon.Name = "geributon";
            this.geributon.Size = new System.Drawing.Size(75, 23);
            this.geributon.TabIndex = 15;
            this.geributon.Text = "Geri";
            this.geributon.UseVisualStyleBackColor = false;
            this.geributon.Click += new System.EventHandler(this.geributon_Click);
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(627, 348);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 17;
            this.btnen.Text = "EN";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btntr
            // 
            this.btntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntr.Location = new System.Drawing.Point(583, 348);
            this.btntr.Name = "btntr";
            this.btntr.Size = new System.Drawing.Size(38, 23);
            this.btntr.TabIndex = 16;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // talepedilenişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.geributon);
            this.Controls.Add(this.listelebuton);
            this.Controls.Add(this.eklebuton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "talepedilenişler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "talepedilenişler";
            this.Load += new System.EventHandler(this.talepedilenişler_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.talepedilenişler_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button eklebuton;
        private System.Windows.Forms.Button listelebuton;
        private System.Windows.Forms.Button geributon;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}