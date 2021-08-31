
namespace Hastane_yönetim_randevu_sistemi
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.comboBoxbrans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxtc = new System.Windows.Forms.MaskedTextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttongüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş:";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(96, 24);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(207, 36);
            this.textBoxad.TabIndex = 1;
            // 
            // comboBoxbrans
            // 
            this.comboBoxbrans.FormattingEnabled = true;
            this.comboBoxbrans.Location = new System.Drawing.Point(96, 142);
            this.comboBoxbrans.Name = "comboBoxbrans";
            this.comboBoxbrans.Size = new System.Drawing.Size(207, 37);
            this.comboBoxbrans.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Soyad:";
            // 
            // maskedTextBoxtc
            // 
            this.maskedTextBoxtc.Location = new System.Drawing.Point(96, 202);
            this.maskedTextBoxtc.Mask = "00000000000";
            this.maskedTextBoxtc.Name = "maskedTextBoxtc";
            this.maskedTextBoxtc.Size = new System.Drawing.Size(207, 36);
            this.maskedTextBoxtc.TabIndex = 4;
            this.maskedTextBoxtc.ValidatingType = typeof(int);
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(96, 83);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(207, 36);
            this.textBoxsoyad.TabIndex = 2;
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(96, 261);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(207, 36);
            this.textBoxsifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 383);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonekle.Location = new System.Drawing.Point(85, 303);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(113, 49);
            this.buttonekle.TabIndex = 9;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.Red;
            this.buttonsil.Location = new System.Drawing.Point(204, 303);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(113, 49);
            this.buttonsil.TabIndex = 10;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.Color.BlueViolet;
            this.buttongüncelle.Location = new System.Drawing.Point(96, 358);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(207, 49);
            this.buttongüncelle.TabIndex = 11;
            this.buttongüncelle.Text = "Güncelle";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1067, 420);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.maskedTextBoxtc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxbrans);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.ComboBox comboBoxbrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtc;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttongüncelle;
    }
}