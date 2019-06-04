namespace TourCompany.UI.Windowsforms
{
    partial class GezilecekYerEkle
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
            this.dgvGezilecekYerler = new System.Windows.Forms.DataGridView();
            this.txtYerAdi = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGezilecekYerler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGezilecekYerler
            // 
            this.dgvGezilecekYerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGezilecekYerler.Location = new System.Drawing.Point(12, 20);
            this.dgvGezilecekYerler.Name = "dgvGezilecekYerler";
            this.dgvGezilecekYerler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGezilecekYerler.Size = new System.Drawing.Size(276, 332);
            this.dgvGezilecekYerler.TabIndex = 0;
            this.dgvGezilecekYerler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGezilecekYerler_CellClick);
            // 
            // txtYerAdi
            // 
            this.txtYerAdi.Location = new System.Drawing.Point(328, 36);
            this.txtYerAdi.Name = "txtYerAdi";
            this.txtYerAdi.Size = new System.Drawing.Size(221, 20);
            this.txtYerAdi.TabIndex = 1;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(328, 94);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(221, 20);
            this.txtUcret.TabIndex = 2;
            this.txtUcret.Leave += new System.EventHandler(this.txtUcret_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yer Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ücret (TL):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dolar:";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(328, 150);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.ReadOnly = true;
            this.txtDolar.Size = new System.Drawing.Size(221, 20);
            this.txtDolar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Euro:";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(328, 206);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.ReadOnly = true;
            this.txtEuro.Size = new System.Drawing.Size(221, 20);
            this.txtEuro.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(347, 251);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(178, 27);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(347, 287);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(178, 27);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(347, 325);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(178, 27);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // GezilecekYerEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 364);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtYerAdi);
            this.Controls.Add(this.dgvGezilecekYerler);
            this.Name = "GezilecekYerEkle";
            this.Text = "Gezilecek Yer Ekleme/Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.GezilecekYerEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGezilecekYerler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGezilecekYerler;
        private System.Windows.Forms.TextBox txtYerAdi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}