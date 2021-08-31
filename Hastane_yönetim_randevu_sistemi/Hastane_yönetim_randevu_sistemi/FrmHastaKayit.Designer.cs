
namespace Hastane_yönetim_randevu_sistemi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.maskedTextBoxtc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxtel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxcinsiyet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(171, 36);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(209, 36);
            this.textBoxad.TabIndex = 1;
            // 
            // maskedTextBoxtc
            // 
            this.maskedTextBoxtc.Location = new System.Drawing.Point(171, 166);
            this.maskedTextBoxtc.Mask = "00000000000";
            this.maskedTextBoxtc.Name = "maskedTextBoxtc";
            this.maskedTextBoxtc.Size = new System.Drawing.Size(209, 36);
            this.maskedTextBoxtc.TabIndex = 3;
            this.maskedTextBoxtc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "TC Kimlik No:";
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(171, 296);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(209, 36);
            this.textBoxsifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre:";
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(171, 101);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(209, 36);
            this.textBoxsoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(73, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cinsiyet:";
            // 
            // maskedTextBoxtel
            // 
            this.maskedTextBoxtel.Location = new System.Drawing.Point(171, 231);
            this.maskedTextBoxtel.Mask = "(999) 000-0000";
            this.maskedTextBoxtel.Name = "maskedTextBoxtel";
            this.maskedTextBoxtel.Size = new System.Drawing.Size(209, 36);
            this.maskedTextBoxtel.TabIndex = 4;
            // 
            // comboBoxcinsiyet
            // 
            this.comboBoxcinsiyet.FormattingEnabled = true;
            this.comboBoxcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxcinsiyet.Location = new System.Drawing.Point(171, 361);
            this.comboBoxcinsiyet.Name = "comboBoxcinsiyet";
            this.comboBoxcinsiyet.Size = new System.Drawing.Size(209, 37);
            this.comboBoxcinsiyet.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(186, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kayıt Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(463, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxcinsiyet);
            this.Controls.Add(this.maskedTextBoxtel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.maskedTextBoxtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtel;
        private System.Windows.Forms.ComboBox comboBoxcinsiyet;
        private System.Windows.Forms.Button button1;
    }
}