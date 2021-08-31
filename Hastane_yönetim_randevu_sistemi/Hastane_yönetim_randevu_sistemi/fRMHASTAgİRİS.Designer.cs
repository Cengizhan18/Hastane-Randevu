
namespace Hastane_yönetim_randevu_sistemi
{
    partial class fRMHASTAgİRİS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRMHASTAgİRİS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.linkLabelüyeol = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(189, 94);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(209, 36);
            this.maskedTextBoxTC.TabIndex = 3;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(189, 136);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(209, 36);
            this.textBoxsifre.TabIndex = 4;
            this.textBoxsifre.UseSystemPasswordChar = true;
            // 
            // linkLabelüyeol
            // 
            this.linkLabelüyeol.AutoSize = true;
            this.linkLabelüyeol.Location = new System.Drawing.Point(418, 143);
            this.linkLabelüyeol.Name = "linkLabelüyeol";
            this.linkLabelüyeol.Size = new System.Drawing.Size(90, 29);
            this.linkLabelüyeol.TabIndex = 5;
            this.linkLabelüyeol.TabStop = true;
            this.linkLabelüyeol.Text = "Üye Ol";
            this.linkLabelüyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelüyeol_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fRMHASTAgİRİS
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(557, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelüyeol);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "fRMHASTAgİRİS";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.LinkLabel linkLabelüyeol;
        private System.Windows.Forms.Button button1;
    }
}