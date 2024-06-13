namespace EntityFrameworkPrj
{
    partial class MusteriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSehir = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxMusteriID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonListele = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1349, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxSehir
            // 
            this.textBoxSehir.Location = new System.Drawing.Point(226, 591);
            this.textBoxSehir.Name = "textBoxSehir";
            this.textBoxSehir.Size = new System.Drawing.Size(127, 22);
            this.textBoxSehir.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(226, 562);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(127, 22);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(226, 533);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(127, 22);
            this.textBoxAd.TabIndex = 3;
            // 
            // textBoxMusteriID
            // 
            this.textBoxMusteriID.Enabled = false;
            this.textBoxMusteriID.Location = new System.Drawing.Point(226, 504);
            this.textBoxMusteriID.Name = "textBoxMusteriID";
            this.textBoxMusteriID.Size = new System.Drawing.Size(127, 22);
            this.textBoxMusteriID.TabIndex = 4;
            this.textBoxMusteriID.TextChanged += new System.EventHandler(this.textBoxMusteriID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(162, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ad:";
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(510, 502);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(96, 24);
            this.buttonListele.TabIndex = 9;
            this.buttonListele.Text = "Tüm Liste";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1496, 657);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMusteriID);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxSehir);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriForm";
            this.Text = "MÜŞTERİLER";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSehir;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxMusteriID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}