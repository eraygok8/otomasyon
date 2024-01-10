namespace otomasyon
{
    partial class stokpersonel
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
            this.geributon = new System.Windows.Forms.Button();
            this.txtürünadıara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geributon
            // 
            this.geributon.BackColor = System.Drawing.Color.Gainsboro;
            this.geributon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geributon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geributon.Location = new System.Drawing.Point(12, 12);
            this.geributon.Name = "geributon";
            this.geributon.Size = new System.Drawing.Size(75, 23);
            this.geributon.TabIndex = 18;
            this.geributon.Text = "Geri";
            this.geributon.UseVisualStyleBackColor = false;
            this.geributon.Click += new System.EventHandler(this.geributon_Click);
            // 
            // txtürünadıara
            // 
            this.txtürünadıara.Location = new System.Drawing.Point(556, 30);
            this.txtürünadıara.Name = "txtürünadıara";
            this.txtürünadıara.Size = new System.Drawing.Size(84, 20);
            this.txtürünadıara.TabIndex = 26;
            this.txtürünadıara.TextChanged += new System.EventHandler(this.txtürünadıara_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ürün Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 346);
            this.dataGridView1.TabIndex = 24;
            // 
            // stokpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtürünadıara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geributon);
            this.Name = "stokpersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stokpersonel";
            this.Load += new System.EventHandler(this.stokpersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geributon;
        private System.Windows.Forms.TextBox txtürünadıara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}