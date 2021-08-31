
namespace Hastane_yönetim_randevu_sistemi
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.buttonhastagirisi = new System.Windows.Forms.Button();
            this.buttondoktorgirisi = new System.Windows.Forms.Button();
            this.buttonsekretergirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonhastagirisi
            // 
            this.buttonhastagirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonhastagirisi.BackgroundImage")));
            this.buttonhastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonhastagirisi.Location = new System.Drawing.Point(74, 222);
            this.buttonhastagirisi.Name = "buttonhastagirisi";
            this.buttonhastagirisi.Size = new System.Drawing.Size(181, 120);
            this.buttonhastagirisi.TabIndex = 0;
            this.buttonhastagirisi.UseVisualStyleBackColor = true;
            this.buttonhastagirisi.Click += new System.EventHandler(this.buttonhastagirisi_Click);
            // 
            // buttondoktorgirisi
            // 
            this.buttondoktorgirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondoktorgirisi.BackgroundImage")));
            this.buttondoktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondoktorgirisi.Location = new System.Drawing.Point(297, 222);
            this.buttondoktorgirisi.Name = "buttondoktorgirisi";
            this.buttondoktorgirisi.Size = new System.Drawing.Size(181, 120);
            this.buttondoktorgirisi.TabIndex = 1;
            this.buttondoktorgirisi.UseVisualStyleBackColor = true;
            this.buttondoktorgirisi.Click += new System.EventHandler(this.buttondoktorgirisi_Click);
            // 
            // buttonsekretergirisi
            // 
            this.buttonsekretergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsekretergirisi.BackgroundImage")));
            this.buttonsekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonsekretergirisi.Location = new System.Drawing.Point(520, 222);
            this.buttonsekretergirisi.Name = "buttonsekretergirisi";
            this.buttonsekretergirisi.Size = new System.Drawing.Size(181, 120);
            this.buttonsekretergirisi.TabIndex = 2;
            this.buttonsekretergirisi.UseVisualStyleBackColor = true;
            this.buttonsekretergirisi.Click += new System.EventHandler(this.buttonsekretergirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "STATE HOSPİTAL";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(767, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsekretergirisi);
            this.Controls.Add(this.buttondoktorgirisi);
            this.Controls.Add(this.buttonhastagirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "State Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonhastagirisi;
        private System.Windows.Forms.Button buttondoktorgirisi;
        private System.Windows.Forms.Button buttonsekretergirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

