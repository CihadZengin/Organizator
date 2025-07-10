namespace Duzenleyici
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblkuladi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtkuladi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.Btngiris = new System.Windows.Forms.Button();
            this.llblkayit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblkuladi
            // 
            this.lblkuladi.AutoSize = true;
            this.lblkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkuladi.Location = new System.Drawing.Point(27, 64);
            this.lblkuladi.Name = "lblkuladi";
            this.lblkuladi.Size = new System.Drawing.Size(126, 20);
            this.lblkuladi.TabIndex = 0;
            this.lblkuladi.Text = "Kullanıcı Adı :";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(92, 126);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(61, 20);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre :";
            // 
            // txtkuladi
            // 
            this.txtkuladi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtkuladi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkuladi.Location = new System.Drawing.Point(176, 64);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(186, 27);
            this.txtkuladi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(176, 123);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(186, 27);
            this.txtsifre.TabIndex = 3;
            this.txtsifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsifre_KeyDown);
            // 
            // Btngiris
            // 
            this.Btngiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngiris.Image = ((System.Drawing.Image)(resources.GetObject("Btngiris.Image")));
            this.Btngiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btngiris.Location = new System.Drawing.Point(249, 167);
            this.Btngiris.Name = "Btngiris";
            this.Btngiris.Size = new System.Drawing.Size(113, 48);
            this.Btngiris.TabIndex = 4;
            this.Btngiris.Text = "GİRİŞ";
            this.Btngiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btngiris.UseVisualStyleBackColor = false;
            this.Btngiris.Click += new System.EventHandler(this.Btngiris_Click);
            // 
            // llblkayit
            // 
            this.llblkayit.AutoSize = true;
            this.llblkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llblkayit.Location = new System.Drawing.Point(28, 230);
            this.llblkayit.Name = "llblkayit";
            this.llblkayit.Size = new System.Drawing.Size(57, 17);
            this.llblkayit.TabIndex = 5;
            this.llblkayit.TabStop = true;
            this.llblkayit.Text = "Kayıt Ol";
            this.llblkayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblkayit_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(412, 266);
            this.Controls.Add(this.llblkayit);
            this.Controls.Add(this.Btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkuladi);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkuladi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkuladi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button Btngiris;
        private System.Windows.Forms.TextBox txtkuladi;
        private System.Windows.Forms.LinkLabel llblkayit;
    }
}

