
namespace CsFormsEB102_Ana.OgrenciIsleri
{
    partial class frmOgrenciGiris
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
            this.scOgr = new System.Windows.Forms.SplitContainer();
            this.mTxtOgrNo = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtBolum = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtOgrno = new System.Windows.Forms.TextBox();
            this.txtTcno = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKayıt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scOgr)).BeginInit();
            this.scOgr.Panel1.SuspendLayout();
            this.scOgr.Panel2.SuspendLayout();
            this.scOgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // scOgr
            // 
            this.scOgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOgr.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scOgr.Location = new System.Drawing.Point(0, 0);
            this.scOgr.Name = "scOgr";
            this.scOgr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scOgr.Panel1
            // 
            this.scOgr.Panel1.Controls.Add(this.btnKayıt);
            this.scOgr.Panel1.Controls.Add(this.mTxtOgrNo);
            this.scOgr.Panel1.Controls.Add(this.mTxtTc);
            this.scOgr.Panel1.Controls.Add(this.btnTemizle);
            this.scOgr.Panel1.Controls.Add(this.txtBolum);
            this.scOgr.Panel1.Controls.Add(this.txtSehir);
            this.scOgr.Panel1.Controls.Add(this.txtOgrno);
            this.scOgr.Panel1.Controls.Add(this.txtTcno);
            this.scOgr.Panel1.Controls.Add(this.txtSoyad);
            this.scOgr.Panel1.Controls.Add(this.txtAd);
            this.scOgr.Panel1.Controls.Add(this.label4);
            this.scOgr.Panel1.Controls.Add(this.label3);
            this.scOgr.Panel1.Controls.Add(this.label6);
            this.scOgr.Panel1.Controls.Add(this.label2);
            this.scOgr.Panel1.Controls.Add(this.label5);
            this.scOgr.Panel1.Controls.Add(this.label1);
            // 
            // scOgr.Panel2
            // 
            this.scOgr.Panel2.Controls.Add(this.Liste);
            this.scOgr.Size = new System.Drawing.Size(800, 450);
            this.scOgr.SplitterDistance = 266;
            this.scOgr.TabIndex = 0;
            // 
            // mTxtOgrNo
            // 
            this.mTxtOgrNo.Location = new System.Drawing.Point(261, 109);
            this.mTxtOgrNo.Mask = "0000999999";
            this.mTxtOgrNo.Name = "mTxtOgrNo";
            this.mTxtOgrNo.Size = new System.Drawing.Size(85, 20);
            this.mTxtOgrNo.TabIndex = 5;
            // 
            // mTxtTc
            // 
            this.mTxtTc.Location = new System.Drawing.Point(261, 83);
            this.mTxtTc.Mask = "00000000000";
            this.mTxtTc.Name = "mTxtTc";
            this.mTxtTc.Size = new System.Drawing.Size(85, 20);
            this.mTxtTc.TabIndex = 5;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(77, 208);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtBolum
            // 
            this.txtBolum.FormattingEnabled = true;
            this.txtBolum.Location = new System.Drawing.Point(517, 57);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(121, 21);
            this.txtBolum.TabIndex = 3;
            // 
            // txtSehir
            // 
            this.txtSehir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSehir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(517, 29);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(121, 21);
            this.txtSehir.TabIndex = 3;
            // 
            // txtOgrno
            // 
            this.txtOgrno.Location = new System.Drawing.Point(120, 109);
            this.txtOgrno.Name = "txtOgrno";
            this.txtOgrno.Size = new System.Drawing.Size(135, 20);
            this.txtOgrno.TabIndex = 2;
            // 
            // txtTcno
            // 
            this.txtTcno.Location = new System.Drawing.Point(120, 83);
            this.txtTcno.Name = "txtTcno";
            this.txtTcno.Size = new System.Drawing.Size(135, 20);
            this.txtTcno.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(135, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 20);
            this.txtAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ogr No :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tc NO :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(400, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bolum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(400, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sehir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Soyad,
            this.TcNo,
            this.OgrNo,
            this.Sehir,
            this.Bolum});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(800, 180);
            this.Liste.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            // 
            // TcNo
            // 
            this.TcNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TcNo.HeaderText = "TcNo";
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 59;
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrNo.HeaderText = "OgrNo";
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Width = 63;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.Name = "Sehir";
            // 
            // Bolum
            // 
            this.Bolum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bolum.HeaderText = "Bolum";
            this.Bolum.Name = "Bolum";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(686, 220);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnKayıt.TabIndex = 6;
            this.btnKayıt.Text = "Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // frmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scOgr);
            this.Name = "frmOgrenciGiris";
            this.Text = "frmOgrenciGiris";
            this.Load += new System.EventHandler(this.frmOgrenciGiris_Load);
            this.scOgr.Panel1.ResumeLayout(false);
            this.scOgr.Panel1.PerformLayout();
            this.scOgr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOgr)).EndInit();
            this.scOgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scOgr;
        private System.Windows.Forms.TextBox txtOgrno;
        private System.Windows.Forms.TextBox txtTcno;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox txtBolum;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MaskedTextBox mTxtTc;
        private System.Windows.Forms.MaskedTextBox mTxtOgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum;
        private System.Windows.Forms.Button btnKayıt;
    }
}