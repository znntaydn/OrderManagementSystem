namespace EntityFrameworkPrj
{
    partial class SiparisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSiparisNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.comboBoxMusteriID = new System.Windows.Forms.ComboBox();
            this.comboBoxUrunID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1368, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sipariş No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(186, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(147, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(167, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(191, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adet:";
            // 
            // textBoxSiparisNo
            // 
            this.textBoxSiparisNo.Enabled = false;
            this.textBoxSiparisNo.Location = new System.Drawing.Point(318, 440);
            this.textBoxSiparisNo.Name = "textBoxSiparisNo";
            this.textBoxSiparisNo.Size = new System.Drawing.Size(200, 22);
            this.textBoxSiparisNo.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 470);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(318, 565);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(200, 22);
            this.textBoxAdet.TabIndex = 8;
            // 
            // comboBoxMusteriID
            // 
            this.comboBoxMusteriID.FormattingEnabled = true;
            this.comboBoxMusteriID.Location = new System.Drawing.Point(318, 500);
            this.comboBoxMusteriID.Name = "comboBoxMusteriID";
            this.comboBoxMusteriID.Size = new System.Drawing.Size(402, 24);
            this.comboBoxMusteriID.TabIndex = 9;
            // 
            // comboBoxUrunID
            // 
            this.comboBoxUrunID.FormattingEnabled = true;
            this.comboBoxUrunID.Location = new System.Drawing.Point(318, 533);
            this.comboBoxUrunID.Name = "comboBoxUrunID";
            this.comboBoxUrunID.Size = new System.Drawing.Size(402, 24);
            this.comboBoxUrunID.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(816, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(816, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(816, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(816, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 28);
            this.button4.TabIndex = 14;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1490, 665);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxUrunID);
            this.Controls.Add(this.comboBoxMusteriID);
            this.Controls.Add(this.textBoxAdet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxSiparisNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparisForm";
            this.Text = "SİPARİŞLER";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSiparisNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.ComboBox comboBoxMusteriID;
        private System.Windows.Forms.ComboBox comboBoxUrunID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}