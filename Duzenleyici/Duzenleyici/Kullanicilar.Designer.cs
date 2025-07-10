namespace Duzenleyici
{
    partial class Kullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanicilar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpara = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txtara = new System.Windows.Forms.TextBox();
            this.lblara = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxkulstatu = new System.Windows.Forms.ComboBox();
            this.lblkulstatu = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txtkulsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkuladi = new System.Windows.Forms.TextBox();
            this.lblkuladi = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grpara.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpara
            // 
            this.grpara.Controls.Add(this.btn_ara);
            this.grpara.Controls.Add(this.txtara);
            this.grpara.Controls.Add(this.lblara);
            this.grpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpara.ForeColor = System.Drawing.Color.White;
            this.grpara.Location = new System.Drawing.Point(16, 75);
            this.grpara.Margin = new System.Windows.Forms.Padding(2);
            this.grpara.Name = "grpara";
            this.grpara.Padding = new System.Windows.Forms.Padding(2);
            this.grpara.Size = new System.Drawing.Size(437, 96);
            this.grpara.TabIndex = 0;
            this.grpara.TabStop = false;
            this.grpara.Text = "Kullanıcı Ara";
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
            this.lblara.Location = new System.Drawing.Point(13, 45);
            this.lblara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblara.Name = "lblara";
            this.lblara.Size = new System.Drawing.Size(111, 18);
            this.lblara.TabIndex = 0;
            this.lblara.Text = "Kullanıcı Ara :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxkulstatu);
            this.groupBox1.Controls.Add(this.lblkulstatu);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.txtkulsifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtkuladi);
            this.groupBox1.Controls.Add(this.lblkuladi);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(437, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // cmbxkulstatu
            // 
            this.cmbxkulstatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbxkulstatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxkulstatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxkulstatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxkulstatu.FormattingEnabled = true;
            this.cmbxkulstatu.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbxkulstatu.Location = new System.Drawing.Point(171, 52);
            this.cmbxkulstatu.Name = "cmbxkulstatu";
            this.cmbxkulstatu.Size = new System.Drawing.Size(210, 24);
            this.cmbxkulstatu.TabIndex = 10;
            // 
            // lblkulstatu
            // 
            this.lblkulstatu.AutoSize = true;
            this.lblkulstatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkulstatu.Location = new System.Drawing.Point(14, 52);
            this.lblkulstatu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkulstatu.Name = "lblkulstatu";
            this.lblkulstatu.Size = new System.Drawing.Size(143, 18);
            this.lblkulstatu.TabIndex = 9;
            this.lblkulstatu.Text = "Kullanıcı Statüsü :";
            // 
            // btn_sil
            // 
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.Location = new System.Drawing.Point(171, 223);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(97, 72);
            this.btn_sil.TabIndex = 8;
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
            this.btn_guncelle.Location = new System.Drawing.Point(334, 223);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(97, 72);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txtkulsifre
            // 
            this.txtkulsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtkulsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkulsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkulsifre.Location = new System.Drawing.Point(170, 158);
            this.txtkulsifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtkulsifre.Name = "txtkulsifre";
            this.txtkulsifre.Size = new System.Drawing.Size(210, 27);
            this.txtkulsifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // txtkuladi
            // 
            this.txtkuladi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtkuladi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkuladi.Location = new System.Drawing.Point(170, 103);
            this.txtkuladi.Margin = new System.Windows.Forms.Padding(2);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(210, 27);
            this.txtkuladi.TabIndex = 3;
            // 
            // lblkuladi
            // 
            this.lblkuladi.AutoSize = true;
            this.lblkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkuladi.Location = new System.Drawing.Point(41, 107);
            this.lblkuladi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkuladi.Name = "lblkuladi";
            this.lblkuladi.Size = new System.Drawing.Size(109, 18);
            this.lblkuladi.TabIndex = 2;
            this.lblkuladi.Text = "Kullanıcı Adı :";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.Image")));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kaydet.Location = new System.Drawing.Point(16, 223);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(97, 72);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(480, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(441, 442);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Listesi";
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
            this.button2.Location = new System.Drawing.Point(4, 399);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Seçimleri Sıfırla";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
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
            this.dataGridView1.Size = new System.Drawing.Size(432, 375);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(254, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aramayı Sıfırla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(976, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpara);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Kullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            this.grpara.ResumeLayout(false);
            this.grpara.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpara;
        private System.Windows.Forms.Label lblara;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkulsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkuladi;
        private System.Windows.Forms.Label lblkuladi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblkulstatu;
        private System.Windows.Forms.ComboBox cmbxkulstatu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}