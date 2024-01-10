namespace otomasyon
{
    partial class ürünlistele
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
            this.cmbürüntürü = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtürünadı = new System.Windows.Forms.TextBox();
            this.txtürünadeti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.silbuton = new System.Windows.Forms.Button();
            this.güncellebuton = new System.Windows.Forms.Button();
            this.txtürünadıara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(236, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbürüntürü);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtürünadı);
            this.groupBox1.Controls.Add(this.txtürünadeti);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // cmbürüntürü
            // 
            this.cmbürüntürü.FormattingEnabled = true;
            this.cmbürüntürü.Location = new System.Drawing.Point(102, 165);
            this.cmbürüntürü.Name = "cmbürüntürü";
            this.cmbürüntürü.Size = new System.Drawing.Size(84, 21);
            this.cmbürüntürü.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Türü :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(84, 20);
            this.txtid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID :";
            // 
            // txtürünadı
            // 
            this.txtürünadı.Location = new System.Drawing.Point(102, 79);
            this.txtürünadı.Name = "txtürünadı";
            this.txtürünadı.Size = new System.Drawing.Size(84, 20);
            this.txtürünadı.TabIndex = 4;
            // 
            // txtürünadeti
            // 
            this.txtürünadeti.Location = new System.Drawing.Point(102, 125);
            this.txtürünadeti.Name = "txtürünadeti";
            this.txtürünadeti.Size = new System.Drawing.Size(84, 20);
            this.txtürünadeti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // silbuton
            // 
            this.silbuton.BackColor = System.Drawing.Color.Crimson;
            this.silbuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbuton.Location = new System.Drawing.Point(12, 311);
            this.silbuton.Margin = new System.Windows.Forms.Padding(2);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(80, 52);
            this.silbuton.TabIndex = 21;
            this.silbuton.Text = "Sil";
            this.silbuton.UseVisualStyleBackColor = false;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click_1);
            // 
            // güncellebuton
            // 
            this.güncellebuton.BackColor = System.Drawing.Color.Orange;
            this.güncellebuton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellebuton.Location = new System.Drawing.Point(106, 311);
            this.güncellebuton.Margin = new System.Windows.Forms.Padding(2);
            this.güncellebuton.Name = "güncellebuton";
            this.güncellebuton.Size = new System.Drawing.Size(84, 52);
            this.güncellebuton.TabIndex = 20;
            this.güncellebuton.Text = "Güncelle";
            this.güncellebuton.UseVisualStyleBackColor = false;
            this.güncellebuton.Click += new System.EventHandler(this.güncellebuton_Click_1);
            // 
            // txtürünadıara
            // 
            this.txtürünadıara.Location = new System.Drawing.Point(515, 20);
            this.txtürünadıara.Name = "txtürünadıara";
            this.txtürünadıara.Size = new System.Drawing.Size(84, 20);
            this.txtürünadıara.TabIndex = 23;
            this.txtürünadıara.TextChanged += new System.EventHandler(this.txtürünadıara_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ürün Adı :";
            // 
            // btnen
            // 
            this.btnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnen.Location = new System.Drawing.Point(750, 415);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(38, 23);
            this.btnen.TabIndex = 25;
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
            this.btntr.TabIndex = 24;
            this.btntr.Text = "TR";
            this.btntr.UseVisualStyleBackColor = true;
            this.btntr.Click += new System.EventHandler(this.btntr_Click);
            // 
            // ürünlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::otomasyon.Properties.Resources.temizlik;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btntr);
            this.Controls.Add(this.txtürünadıara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.güncellebuton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ürünlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ürünlistele";
            this.Load += new System.EventHandler(this.ürünlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtürünadı;
        private System.Windows.Forms.TextBox txtürünadeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.Button güncellebuton;
        private System.Windows.Forms.TextBox txtürünadıara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbürüntürü;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btntr;
    }
}