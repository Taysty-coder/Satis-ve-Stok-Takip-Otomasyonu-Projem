using System;
using System.Windows.Forms;

namespace Proje_Odevim.Presentation_Layer
{
    partial class UrunForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblurunkategori = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltl = new System.Windows.Forms.Label();
            this.lblKayit = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.urunstokMiktari = new System.Windows.Forms.Label();
            this.lblurunfiyat = new System.Windows.Forms.Label();
            this.lblurunAdı = new System.Windows.Forms.Label();
            this.lblurunId = new System.Windows.Forms.Label();
            this.txtstokMiktari = new System.Windows.Forms.TextBox();
            this.txturunalisfiyati = new System.Windows.Forms.TextBox();
            this.txturunminStok = new System.Windows.Forms.TextBox();
            this.txturunsatisfiyati = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txturunId = new System.Windows.Forms.TextBox();
            this.dtgridwurun = new System.Windows.Forms.DataGridView();
            this.btnUrunara = new System.Windows.Forms.Button();
            this.txtidno = new System.Windows.Forms.TextBox();
            this.grpurunAra = new System.Windows.Forms.GroupBox();
            this.txturunisimara = new System.Windows.Forms.TextBox();
            this.lblurunisim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnurunEkle = new System.Windows.Forms.Button();
            this.btnguncellenemeyen = new System.Windows.Forms.Button();
            this.btnurunsilmeislemi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridwurun)).BeginInit();
            this.grpurunAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblurunkategori);
            this.groupBox1.Controls.Add(this.cmbkategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltl);
            this.groupBox1.Controls.Add(this.lblKayit);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.urunstokMiktari);
            this.groupBox1.Controls.Add(this.lblurunfiyat);
            this.groupBox1.Controls.Add(this.lblurunAdı);
            this.groupBox1.Controls.Add(this.lblurunId);
            this.groupBox1.Controls.Add(this.txtstokMiktari);
            this.groupBox1.Controls.Add(this.txturunalisfiyati);
            this.groupBox1.Controls.Add(this.txturunminStok);
            this.groupBox1.Controls.Add(this.txturunsatisfiyati);
            this.groupBox1.Controls.Add(this.txtadi);
            this.groupBox1.Controls.Add(this.txturunId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alış Fiyatı";
            // 
            // lblurunkategori
            // 
            this.lblurunkategori.AutoSize = true;
            this.lblurunkategori.Location = new System.Drawing.Point(100, 184);
            this.lblurunkategori.Name = "lblurunkategori";
            this.lblurunkategori.Size = new System.Drawing.Size(85, 25);
            this.lblurunkategori.TabIndex = 6;
            this.lblurunkategori.Text = "Kategori";
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Items.AddRange(new object[] {
            "Elektronik ",
            "Giyim",
            "Yiyecek ve içecek",
            "Temizlik",
            "Kozmetik",
            "Kırtasiye"});
            this.cmbkategori.Location = new System.Drawing.Point(224, 176);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(154, 33);
            this.cmbkategori.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TL";
            // 
            // lbltl
            // 
            this.lbltl.AutoSize = true;
            this.lbltl.Location = new System.Drawing.Point(384, 303);
            this.lbltl.Name = "lbltl";
            this.lbltl.Size = new System.Drawing.Size(36, 25);
            this.lbltl.TabIndex = 4;
            this.lbltl.Text = "TL";
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Location = new System.Drawing.Point(88, 519);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(110, 25);
            this.lblKayit.TabIndex = 3;
            this.lblKayit.Text = "Kayıt Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(224, 514);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mininum Stok";
            // 
            // urunstokMiktari
            // 
            this.urunstokMiktari.AutoSize = true;
            this.urunstokMiktari.Location = new System.Drawing.Point(81, 384);
            this.urunstokMiktari.Name = "urunstokMiktari";
            this.urunstokMiktari.Size = new System.Drawing.Size(114, 25);
            this.urunstokMiktari.TabIndex = 1;
            this.urunstokMiktari.Text = "Stok Miktarı";
            // 
            // lblurunfiyat
            // 
            this.lblurunfiyat.AutoSize = true;
            this.lblurunfiyat.Location = new System.Drawing.Point(88, 315);
            this.lblurunfiyat.Name = "lblurunfiyat";
            this.lblurunfiyat.Size = new System.Drawing.Size(107, 25);
            this.lblurunfiyat.TabIndex = 1;
            this.lblurunfiyat.Text = "Satış Fiyatı";
            // 
            // lblurunAdı
            // 
            this.lblurunAdı.AutoSize = true;
            this.lblurunAdı.Location = new System.Drawing.Point(97, 113);
            this.lblurunAdı.Name = "lblurunAdı";
            this.lblurunAdı.Size = new System.Drawing.Size(88, 25);
            this.lblurunAdı.TabIndex = 1;
            this.lblurunAdı.Text = "Ürün Adı";
            // 
            // lblurunId
            // 
            this.lblurunId.AutoSize = true;
            this.lblurunId.Location = new System.Drawing.Point(104, 46);
            this.lblurunId.Name = "lblurunId";
            this.lblurunId.Size = new System.Drawing.Size(78, 25);
            this.lblurunId.TabIndex = 1;
            this.lblurunId.Text = "Ürün ID";
            // 
            // txtstokMiktari
            // 
            this.txtstokMiktari.Location = new System.Drawing.Point(224, 384);
            this.txtstokMiktari.Name = "txtstokMiktari";
            this.txtstokMiktari.Size = new System.Drawing.Size(154, 30);
            this.txtstokMiktari.TabIndex = 0;
            // 
            // txturunalisfiyati
            // 
            this.txturunalisfiyati.Location = new System.Drawing.Point(224, 246);
            this.txturunalisfiyati.Name = "txturunalisfiyati";
            this.txturunalisfiyati.Size = new System.Drawing.Size(154, 30);
            this.txturunalisfiyati.TabIndex = 0;
            // 
            // txturunminStok
            // 
            this.txturunminStok.Location = new System.Drawing.Point(224, 445);
            this.txturunminStok.Name = "txturunminStok";
            this.txturunminStok.Size = new System.Drawing.Size(154, 30);
            this.txturunminStok.TabIndex = 0;
            // 
            // txturunsatisfiyati
            // 
            this.txturunsatisfiyati.Location = new System.Drawing.Point(224, 315);
            this.txturunsatisfiyati.Name = "txturunsatisfiyati";
            this.txturunsatisfiyati.Size = new System.Drawing.Size(154, 30);
            this.txturunsatisfiyati.TabIndex = 0;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(224, 108);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(154, 30);
            this.txtadi.TabIndex = 0;
            // 
            // txturunId
            // 
            this.txturunId.Location = new System.Drawing.Point(224, 41);
            this.txturunId.Name = "txturunId";
            this.txturunId.Size = new System.Drawing.Size(154, 30);
            this.txturunId.TabIndex = 0;
            // 
            // dtgridwurun
            // 
            this.dtgridwurun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridwurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridwurun.Location = new System.Drawing.Point(607, 266);
            this.dtgridwurun.Name = "dtgridwurun";
            this.dtgridwurun.RowHeadersWidth = 62;
            this.dtgridwurun.RowTemplate.Height = 28;
            this.dtgridwurun.Size = new System.Drawing.Size(880, 388);
            this.dtgridwurun.TabIndex = 1;
            this.dtgridwurun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridwurun_CellClick_1);
            // 
            // btnUrunara
            // 
            this.btnUrunara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunara.Location = new System.Drawing.Point(27, 69);
            this.btnUrunara.Name = "btnUrunara";
            this.btnUrunara.Size = new System.Drawing.Size(183, 90);
            this.btnUrunara.TabIndex = 2;
            this.btnUrunara.Text = "Ürün Ara";
            this.btnUrunara.UseVisualStyleBackColor = true;
            this.btnUrunara.Click += new System.EventHandler(this.btnUrunara_Click);
            // 
            // txtidno
            // 
            this.txtidno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidno.Location = new System.Drawing.Point(239, 119);
            this.txtidno.Name = "txtidno";
            this.txtidno.Size = new System.Drawing.Size(154, 30);
            this.txtidno.TabIndex = 3;
            // 
            // grpurunAra
            // 
            this.grpurunAra.Controls.Add(this.txturunisimara);
            this.grpurunAra.Controls.Add(this.lblurunisim);
            this.grpurunAra.Controls.Add(this.label1);
            this.grpurunAra.Controls.Add(this.btnUrunara);
            this.grpurunAra.Controls.Add(this.txtidno);
            this.grpurunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpurunAra.Location = new System.Drawing.Point(757, 48);
            this.grpurunAra.Name = "grpurunAra";
            this.grpurunAra.Size = new System.Drawing.Size(666, 199);
            this.grpurunAra.TabIndex = 4;
            this.grpurunAra.TabStop = false;
            this.grpurunAra.Text = "Ürün Ara";
            // 
            // txturunisimara
            // 
            this.txturunisimara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturunisimara.Location = new System.Drawing.Point(448, 119);
            this.txturunisimara.Name = "txturunisimara";
            this.txturunisimara.Size = new System.Drawing.Size(167, 30);
            this.txturunisimara.TabIndex = 6;
            this.txturunisimara.TextChanged += new System.EventHandler(this.txturunisimara_TextChanged);
            // 
            // lblurunisim
            // 
            this.lblurunisim.AutoSize = true;
            this.lblurunisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurunisim.Location = new System.Drawing.Point(481, 69);
            this.lblurunisim.Name = "lblurunisim";
            this.lblurunisim.Size = new System.Drawing.Size(88, 25);
            this.lblurunisim.TabIndex = 5;
            this.lblurunisim.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID No";
            // 
            // btnurunEkle
            // 
            this.btnurunEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnurunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunEkle.Location = new System.Drawing.Point(263, 704);
            this.btnurunEkle.Name = "btnurunEkle";
            this.btnurunEkle.Size = new System.Drawing.Size(247, 95);
            this.btnurunEkle.TabIndex = 5;
            this.btnurunEkle.Text = "Ürün Ekle";
            this.btnurunEkle.UseVisualStyleBackColor = false;
            this.btnurunEkle.Click += new System.EventHandler(this.btnurunEkle_Click);
            // 
            // btnguncellenemeyen
            // 
            this.btnguncellenemeyen.BackColor = System.Drawing.Color.DarkOrange;
            this.btnguncellenemeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncellenemeyen.Location = new System.Drawing.Point(602, 704);
            this.btnguncellenemeyen.Name = "btnguncellenemeyen";
            this.btnguncellenemeyen.Size = new System.Drawing.Size(247, 95);
            this.btnguncellenemeyen.TabIndex = 5;
            this.btnguncellenemeyen.Text = "Ürün Güncelle";
            this.btnguncellenemeyen.UseVisualStyleBackColor = false;
            this.btnguncellenemeyen.Click += new System.EventHandler(this.Guncelleme_Islemi);
            // 
            // btnurunsilmeislemi
            // 
            this.btnurunsilmeislemi.BackColor = System.Drawing.Color.Crimson;
            this.btnurunsilmeislemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunsilmeislemi.Location = new System.Drawing.Point(960, 704);
            this.btnurunsilmeislemi.Name = "btnurunsilmeislemi";
            this.btnurunsilmeislemi.Size = new System.Drawing.Size(247, 95);
            this.btnurunsilmeislemi.TabIndex = 5;
            this.btnurunsilmeislemi.Text = "Ürün Sil";
            this.btnurunsilmeislemi.UseVisualStyleBackColor = false;
            this.btnurunsilmeislemi.Click += new System.EventHandler(this.Silme_Islemi);
            // 
            // UrunForm
            // 
            this.ClientSize = new System.Drawing.Size(1499, 870);
            this.Controls.Add(this.btnurunsilmeislemi);
            this.Controls.Add(this.btnguncellenemeyen);
            this.Controls.Add(this.btnurunEkle);
            this.Controls.Add(this.grpurunAra);
            this.Controls.Add(this.dtgridwurun);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UrunForm";
            this.Text = "Ürün Yönetim Paneli";
            this.Load += new System.EventHandler(this.UrunForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridwurun)).EndInit();
            this.grpurunAra.ResumeLayout(false);
            this.grpurunAra.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label lblurunAdi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMinStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblminStok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtstokMiktari;
        private System.Windows.Forms.TextBox txturunminStok;
        private System.Windows.Forms.TextBox txturunsatisfiyati;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txturunId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label urunstokMiktari;
        private System.Windows.Forms.Label lblurunfiyat;
        private System.Windows.Forms.Label lblurunAdı;
        private System.Windows.Forms.Label lblurunId;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtgridwurun;
        private System.Windows.Forms.Button btnUrunara;
        private System.Windows.Forms.TextBox txtidno;
        private System.Windows.Forms.GroupBox grpurunAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnurunEkle;
        private System.Windows.Forms.Button btnurunGuncelle;
        private System.Windows.Forms.Button btnurunSil;
        private System.Windows.Forms.Label lbltl;
        private Button btnguncellenemeyen;
        private Button btnurunsilmeislemi;
        private TextBox txturunisimara;
        private Label lblurunisim;
        private Label lblurunkategori;
        private ComboBox cmbkategori;
        private Label label3;
        private Label label2;
        private TextBox txturunalisfiyati;
    }
}