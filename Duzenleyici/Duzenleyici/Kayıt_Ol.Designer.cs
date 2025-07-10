namespace Duzenleyici
{
    partial class Kayıt_Ol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt_Ol));
            this.lblkuladi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblkulstatusu = new System.Windows.Forms.Label();
            this.txtkuladi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.cmbxkulstatu = new System.Windows.Forms.ComboBox();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblkuladi
            // 
            this.lblkuladi.AutoSize = true;
            this.lblkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkuladi.Location = new System.Drawing.Point(67, 93);
            this.lblkuladi.Name = "lblkuladi";
            this.lblkuladi.Size = new System.Drawing.Size(126, 20);
            this.lblkuladi.TabIndex = 1;
            this.lblkuladi.Text = "Kullanıcı Adı :";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(132, 139);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(61, 20);
            this.lblsifre.TabIndex = 2;
            this.lblsifre.Text = "Şifre :";
            // 
            // lblkulstatusu
            // 
            this.lblkulstatusu.AutoSize = true;
            this.lblkulstatusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkulstatusu.Location = new System.Drawing.Point(30, 47);
            this.lblkulstatusu.Name = "lblkulstatusu";
            this.lblkulstatusu.Size = new System.Drawing.Size(163, 20);
            this.lblkulstatusu.TabIndex = 3;
            this.lblkulstatusu.Text = "Kullanıcı Statüsü :";
            // 
            // txtkuladi
            // 
            this.txtkuladi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtkuladi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkuladi.Location = new System.Drawing.Point(212, 94);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(186, 23);
            this.txtkuladi.TabIndex = 4;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(212, 140);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(186, 23);
            this.txtsifre.TabIndex = 5;
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
            this.cmbxkulstatu.Location = new System.Drawing.Point(212, 49);
            this.cmbxkulstatu.Name = "cmbxkulstatu";
            this.cmbxkulstatu.Size = new System.Drawing.Size(186, 24);
            this.cmbxkulstatu.TabIndex = 6;
            // 
            // btnkayıt
            // 
            this.btnkayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnkayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayıt.Image = ((System.Drawing.Image)(resources.GetObject("btnkayıt.Image")));
            this.btnkayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkayıt.Location = new System.Drawing.Point(285, 185);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(113, 48);
            this.btnkayıt.TabIndex = 7;
            this.btnkayıt.Text = "KAYIT";
            this.btnkayıt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkayıt.UseVisualStyleBackColor = false;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // Kayıt_Ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(480, 281);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.cmbxkulstatu);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkuladi);
            this.Controls.Add(this.lblkulstatusu);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkuladi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayıt_Ol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt_Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkuladi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblkulstatusu;
        private System.Windows.Forms.TextBox txtkuladi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.ComboBox cmbxkulstatu;
        private System.Windows.Forms.Button btnkayıt;
    }
}