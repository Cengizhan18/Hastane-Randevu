
namespace Hastane_yönetim_randevu_sistemi
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(176, 87);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(209, 36);
            this.textBoxsoyad.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(78, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Soyad:";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(176, 36);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(209, 36);
            this.textBoxad.TabIndex = 34;
            // 
            // maskedTextBoxtc
            // 
            this.maskedTextBoxtc.Location = new System.Drawing.Point(176, 138);
            this.maskedTextBoxtc.Mask = "00000000000";
            this.maskedTextBoxtc.Name = "maskedTextBoxtc";
            this.maskedTextBoxtc.Size = new System.Drawing.Size(209, 36);
            this.maskedTextBoxtc.TabIndex = 33;
            this.maskedTextBoxtc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Şifre:";
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(176, 241);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(209, 36);
            this.textBoxsifre.TabIndex = 37;
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(176, 189);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(209, 37);
            this.comboBoxbrans.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Branş:";
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttongüncelle.Location = new System.Drawing.Point(176, 293);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(209, 49);
            this.buttongüncelle.TabIndex = 41;
            this.buttongüncelle.Text = "Güncelle";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AcceptButton = this.buttongüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(427, 362);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxbrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.maskedTextBoxtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttongüncelle;
    }
}