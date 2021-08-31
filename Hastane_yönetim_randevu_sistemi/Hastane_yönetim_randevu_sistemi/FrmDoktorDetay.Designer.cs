
namespace Hastane_yönetim_randevu_sistemi
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttoncıkıs = new System.Windows.Forms.Button();
            this.buttonduyuru = new System.Windows.Forms.Button();
            this.buttonbilgidüzen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(140, 108);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(108, 29);
            this.labelAdSoyad.TabIndex = 3;
            this.labelAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(140, 69);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(167, 29);
            this.labelTc.TabIndex = 1;
            this.labelTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxsikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextBoxsikayet
            // 
            this.richTextBoxsikayet.Location = new System.Drawing.Point(6, 35);
            this.richTextBoxsikayet.Name = "richTextBoxsikayet";
            this.richTextBoxsikayet.Size = new System.Drawing.Size(397, 196);
            this.richTextBoxsikayet.TabIndex = 5;
            this.richTextBoxsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(440, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 571);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 536);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttoncıkıs);
            this.groupBox4.Controls.Add(this.buttonduyuru);
            this.groupBox4.Controls.Add(this.buttonbilgidüzen);
            this.groupBox4.Location = new System.Drawing.Point(12, 428);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 155);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // buttoncıkıs
            // 
            this.buttoncıkıs.Location = new System.Drawing.Point(9, 97);
            this.buttoncıkıs.Name = "buttoncıkıs";
            this.buttoncıkıs.Size = new System.Drawing.Size(394, 41);
            this.buttoncıkıs.TabIndex = 2;
            this.buttoncıkıs.Text = "Çıkış";
            this.buttoncıkıs.UseVisualStyleBackColor = true;
            this.buttoncıkıs.Click += new System.EventHandler(this.buttoncıkıs_Click);
            // 
            // buttonduyuru
            // 
            this.buttonduyuru.Location = new System.Drawing.Point(209, 35);
            this.buttonduyuru.Name = "buttonduyuru";
            this.buttonduyuru.Size = new System.Drawing.Size(194, 41);
            this.buttonduyuru.TabIndex = 1;
            this.buttonduyuru.Text = "Duyurular";
            this.buttonduyuru.UseVisualStyleBackColor = true;
            this.buttonduyuru.Click += new System.EventHandler(this.buttonduyuru_Click);
            // 
            // buttonbilgidüzen
            // 
            this.buttonbilgidüzen.Location = new System.Drawing.Point(6, 35);
            this.buttonbilgidüzen.Name = "buttonbilgidüzen";
            this.buttonbilgidüzen.Size = new System.Drawing.Size(194, 41);
            this.buttonbilgidüzen.TabIndex = 0;
            this.buttonbilgidüzen.Text = "Bilgi Düzenle";
            this.buttonbilgidüzen.UseVisualStyleBackColor = true;
            this.buttonbilgidüzen.Click += new System.EventHandler(this.buttonbilgidüzen_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1161, 606);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBoxsikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttoncıkıs;
        private System.Windows.Forms.Button buttonduyuru;
        private System.Windows.Forms.Button buttonbilgidüzen;
    }
}