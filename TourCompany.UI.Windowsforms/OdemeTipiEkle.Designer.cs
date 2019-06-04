namespace TourCompany.UI.Windowsforms
{
    partial class OdemeTipiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeTipiEkle));
            this.txtPayUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayUpdate = new System.Windows.Forms.Button();
            this.btnTypeSave = new System.Windows.Forms.Button();
            this.txtOdemeTipi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvOdemeTipi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeTipi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPayUpdate
            // 
            this.txtPayUpdate.Location = new System.Drawing.Point(412, 186);
            this.txtPayUpdate.Name = "txtPayUpdate";
            this.txtPayUpdate.Size = new System.Drawing.Size(137, 20);
            this.txtPayUpdate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ödeme Tipini Güncelle : ";
            // 
            // btnPayUpdate
            // 
            this.btnPayUpdate.Location = new System.Drawing.Point(412, 226);
            this.btnPayUpdate.Name = "btnPayUpdate";
            this.btnPayUpdate.Size = new System.Drawing.Size(137, 38);
            this.btnPayUpdate.TabIndex = 13;
            this.btnPayUpdate.Text = "Ödeme Tipini Güncelle";
            this.btnPayUpdate.UseVisualStyleBackColor = true;
            this.btnPayUpdate.Click += new System.EventHandler(this.btnPayUpdate_Click);
            // 
            // btnTypeSave
            // 
            this.btnTypeSave.Location = new System.Drawing.Point(412, 117);
            this.btnTypeSave.Name = "btnTypeSave";
            this.btnTypeSave.Size = new System.Drawing.Size(137, 38);
            this.btnTypeSave.TabIndex = 12;
            this.btnTypeSave.Text = "Ödeme Tipini Kaydet";
            this.btnTypeSave.UseVisualStyleBackColor = true;
            this.btnTypeSave.Click += new System.EventHandler(this.btnTypeSave_Click);
            // 
            // txtOdemeTipi
            // 
            this.txtOdemeTipi.Location = new System.Drawing.Point(412, 89);
            this.txtOdemeTipi.Name = "txtOdemeTipi";
            this.txtOdemeTipi.Size = new System.Drawing.Size(137, 20);
            this.txtOdemeTipi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ödeme Tİpi Ekle  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dgvOdemeTipi
            // 
            this.dgvOdemeTipi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeTipi.Location = new System.Drawing.Point(12, 12);
            this.dgvOdemeTipi.MultiSelect = false;
            this.dgvOdemeTipi.Name = "dgvOdemeTipi";
            this.dgvOdemeTipi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdemeTipi.Size = new System.Drawing.Size(245, 331);
            this.dgvOdemeTipi.TabIndex = 8;
            this.dgvOdemeTipi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdemeTipi_CellClick);
            // 
            // OdemeTipiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 376);
            this.Controls.Add(this.txtPayUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayUpdate);
            this.Controls.Add(this.btnTypeSave);
            this.Controls.Add(this.txtOdemeTipi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvOdemeTipi);
            this.Name = "OdemeTipiEkle";
            this.Text = "Ödeme Tipi Ekleme/Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.OdemeTipiEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeTipi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPayUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPayUpdate;
        private System.Windows.Forms.Button btnTypeSave;
        private System.Windows.Forms.TextBox txtOdemeTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvOdemeTipi;
    }
}

