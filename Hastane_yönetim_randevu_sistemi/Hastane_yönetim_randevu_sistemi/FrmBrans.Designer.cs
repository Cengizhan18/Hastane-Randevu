
namespace Hastane_yönetim_randevu_sistemi
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.BackColor = System.Drawing.Color.BlueViolet;
            this.buttongüncelle.Location = new System.Drawing.Point(137, 186);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(207, 49);
            this.buttongüncelle.TabIndex = 25;
            this.buttongüncelle.Text = "Güncelle";
            this.buttongüncelle.UseVisualStyleBackColor = false;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.Red;
            this.buttonsil.Location = new System.Drawing.Point(245, 131);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(113, 49);
            this.buttonsil.TabIndex = 24;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonekle
            // 
            this.buttonekle.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonekle.Location = new System.Drawing.Point(126, 131);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(113, 49);
            this.buttonekle.TabIndex = 23;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = false;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 211);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(137, 84);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(207, 36);
            this.textBoxad.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Branş Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Branş Id:";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(137, 24);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(207, 36);
            this.textBoxid.TabIndex = 13;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_TextChanged);
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(874, 254);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "FrmBrans";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttongüncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxid;
    }
}