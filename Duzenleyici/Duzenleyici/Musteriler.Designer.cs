namespace Duzenleyici
{
    partial class Musteriler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpara = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.lblara = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmtel = new System.Windows.Forms.MaskedTextBox();
            this.txtmadres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txtmadi = new System.Windows.Forms.TextBox();
            this.lblmadi = new System.Windows.Forms.Label();
            this.lblmtel = new System.Windows.Forms.Label();
            this.lblmsoyad = new System.Windows.Forms.Label();
            this.txtmsoyad = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpara.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(480, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(441, 550);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 479);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 502);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Seçimleri Sıfırla";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(253, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aramayı Sıfırla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpara
            // 
            this.grpara.Controls.Add(this.btn_ara);
            this.grpara.Controls.Add(this.txtara);
            this.grpara.Controls.Add(this.lblara);
            this.grpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpara.ForeColor = System.Drawing.Color.White;
            this.grpara.Location = new System.Drawing.Point(16, 20);
            this.grpara.Margin = new System.Windows.Forms.Padding(2);
            this.grpara.Name = "grpara";
            this.grpara.Padding = new System.Windows.Forms.Padding(2);
            this.grpara.Size = new System.Drawing.Size(437, 96);
            this.grpara.TabIndex = 17;
            this.grpara.TabStop = false;
            this.grpara.Text = "Müşteri Ara";
            // 
            // btn_ara
            // 
            this.btn_ara.FlatAppearance.BorderSize = 0;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ara.Image = ((System.Drawing.Image)(resources.GetObject("btn_ara.Image")));
            this.btn_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ara.Location = new System.Drawing.Point(334, 19);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(83, 72);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "ARA";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txtara
            // 
            this.txtara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(122, 41);
            this.txtara.Margin = new System.Windows.Forms.Padding(2);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(209, 27);
            this.txtara.TabIndex = 1;
            // 
            // lblara
            // 
            this.lblara.AutoSize = true;
            this.lblara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblara.Location = new System.Drawing.Point(28, 45);
            this.lblara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblara.Name = "lblara";
            this.lblara.Size = new System.Drawing.Size(104, 18);
            this.lblara.TabIndex = 0;
            this.lblara.Text = "Müşteri Ara :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmtel);
            this.groupBox1.Controls.Add(this.txtmadres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.txtmadi);
            this.groupBox1.Controls.Add(this.lblmadi);
            this.groupBox1.Controls.Add(this.lblmtel);
            this.groupBox1.Controls.Add(this.lblmsoyad);
            this.groupBox1.Controls.Add(this.txtmsoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 449);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtmtel
            // 
            this.txtmtel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmtel.Location = new System.Drawing.Point(165, 151);
            this.txtmtel.Margin = new System.Windows.Forms.Padding(2);
            this.txtmtel.Mask = "(999) 000-0000";
            this.txtmtel.Name = "txtmtel";
            this.txtmtel.Size = new System.Drawing.Size(210, 27);
            this.txtmtel.TabIndex = 17;
            // 
            // txtmadres
            // 
            this.txtmadres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmadres.Location = new System.Drawing.Point(74, 197);
            this.txtmadres.Margin = new System.Windows.Forms.Padding(2);
            this.txtmadres.Name = "txtmadres";
            this.txtmadres.Size = new System.Drawing.Size(302, 145);
            this.txtmadres.TabIndex = 16;
            this.txtmadres.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adres :";
            // 
            // btn_sil
            // 
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.Location = new System.Drawing.Point(165, 359);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(97, 72);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guncelle.Location = new System.Drawing.Point(321, 359);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(97, 72);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kaydet.Location = new System.Drawing.Point(4, 359);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(97, 72);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txtmadi
            // 
            this.txtmadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmadi.Location = new System.Drawing.Point(165, 46);
            this.txtmadi.Margin = new System.Windows.Forms.Padding(2);
            this.txtmadi.Name = "txtmadi";
            this.txtmadi.Size = new System.Drawing.Size(210, 27);
            this.txtmadi.TabIndex = 7;
            // 
            // lblmadi
            // 
            this.lblmadi.AutoSize = true;
            this.lblmadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmadi.Location = new System.Drawing.Point(52, 50);
            this.lblmadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmadi.Name = "lblmadi";
            this.lblmadi.Size = new System.Drawing.Size(102, 18);
            this.lblmadi.TabIndex = 6;
            this.lblmadi.Text = "Müşteri Adı :";
            // 
            // lblmtel
            // 
            this.lblmtel.AutoSize = true;
            this.lblmtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmtel.Location = new System.Drawing.Point(11, 151);
            this.lblmtel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmtel.Name = "lblmtel";
            this.lblmtel.Size = new System.Drawing.Size(151, 18);
            this.lblmtel.TabIndex = 10;
            this.lblmtel.Text = "Telefon Numarası :";
            // 
            // lblmsoyad
            // 
            this.lblmsoyad.AutoSize = true;
            this.lblmsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmsoyad.Location = new System.Drawing.Point(28, 102);
            this.lblmsoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmsoyad.Name = "lblmsoyad";
            this.lblmsoyad.Size = new System.Drawing.Size(130, 18);
            this.lblmsoyad.TabIndex = 8;
            this.lblmsoyad.Text = "Müşteri Soyadı :";
            // 
            // txtmsoyad
            // 
            this.txtmsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtmsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmsoyad.Location = new System.Drawing.Point(165, 98);
            this.txtmsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtmsoyad.Name = "txtmsoyad";
            this.txtmsoyad.Size = new System.Drawing.Size(210, 27);
            this.txtmsoyad.TabIndex = 9;
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(976, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpara);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpara.ResumeLayout(false);
            this.grpara.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Label lblara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txtmadi;
        private System.Windows.Forms.Label lblmadi;
        private System.Windows.Forms.Label lblmtel;
        private System.Windows.Forms.Label lblmsoyad;
        private System.Windows.Forms.TextBox txtmsoyad;
        private System.Windows.Forms.MaskedTextBox txtmtel;
        private System.Windows.Forms.RichTextBox txtmadres;
        private System.Windows.Forms.Label label1;
    }
}