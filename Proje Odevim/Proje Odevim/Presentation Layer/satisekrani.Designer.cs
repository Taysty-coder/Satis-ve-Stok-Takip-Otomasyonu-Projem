namespace Proje_Odevim.Presentation_Layer
{
    partial class satisekrani
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
            this.dtgridwurunsatis = new System.Windows.Forms.DataGridView();
            this.grmusterisec = new System.Windows.Forms.GroupBox();
            this.lblmüsteri = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbmusteriSecimi = new System.Windows.Forms.ComboBox();
            this.txturunsatisstok = new System.Windows.Forms.TextBox();
            this.txturunsatismiktar = new System.Windows.Forms.TextBox();
            this.cmburunsatissecimi = new System.Windows.Forms.ComboBox();
            this.dtgridwsepet = new System.Windows.Forms.DataGridView();
            this.Ürün_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblurunsatis = new System.Windows.Forms.Label();
            this.lblurunmiktar = new System.Windows.Forms.Label();
            this.lblurunstok = new System.Windows.Forms.Label();
            this.dateTimesatıs = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltexttoplamfiyat = new System.Windows.Forms.Label();
            this.lbluruntoplamfiyat = new System.Windows.Forms.Label();
            this.btnsepeteekle = new System.Windows.Forms.Button();
            this.txturunsatisionayla = new System.Windows.Forms.Button();
            this.txtbirimfiyat = new System.Windows.Forms.TextBox();
            this.lblsatisbirimfiyat = new System.Windows.Forms.Label();
            this.btnsepetitemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridwurunsatis)).BeginInit();
            this.grmusterisec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridwsepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridwurunsatis
            // 
            this.dtgridwurunsatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgridwurunsatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridwurunsatis.Location = new System.Drawing.Point(9, 134);
            this.dtgridwurunsatis.Name = "dtgridwurunsatis";
            this.dtgridwurunsatis.RowHeadersVisible = false;
            this.dtgridwurunsatis.RowHeadersWidth = 62;
            this.dtgridwurunsatis.RowTemplate.Height = 28;
            this.dtgridwurunsatis.Size = new System.Drawing.Size(443, 216);
            this.dtgridwurunsatis.TabIndex = 2;
            this.dtgridwurunsatis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridwurunsatis_CellClick);
            // 
            // grmusterisec
            // 
            this.grmusterisec.Controls.Add(this.lblmüsteri);
            this.grmusterisec.Controls.Add(this.textBox2);
            this.grmusterisec.Controls.Add(this.dtgridwurunsatis);
            this.grmusterisec.Controls.Add(this.cmbmusteriSecimi);
            this.grmusterisec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grmusterisec.Location = new System.Drawing.Point(12, 12);
            this.grmusterisec.Name = "grmusterisec";
            this.grmusterisec.Size = new System.Drawing.Size(462, 356);
            this.grmusterisec.TabIndex = 3;
            this.grmusterisec.TabStop = false;
            this.grmusterisec.Text = "Müşteri Seçimi";
            // 
            // lblmüsteri
            // 
            this.lblmüsteri.AutoSize = true;
            this.lblmüsteri.Location = new System.Drawing.Point(200, 50);
            this.lblmüsteri.Name = "lblmüsteri";
            this.lblmüsteri.Size = new System.Drawing.Size(83, 25);
            this.lblmüsteri.TabIndex = 6;
            this.lblmüsteri.Text = "Müşteri";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(817, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 28);
            this.textBox2.TabIndex = 5;
            // 
            // cmbmusteriSecimi
            // 
            this.cmbmusteriSecimi.FormattingEnabled = true;
            this.cmbmusteriSecimi.Location = new System.Drawing.Point(142, 78);
            this.cmbmusteriSecimi.Name = "cmbmusteriSecimi";
            this.cmbmusteriSecimi.Size = new System.Drawing.Size(194, 33);
            this.cmbmusteriSecimi.TabIndex = 6;
            // 
            // txturunsatisstok
            // 
            this.txturunsatisstok.Enabled = false;
            this.txturunsatisstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturunsatisstok.Location = new System.Drawing.Point(1130, 121);
            this.txturunsatisstok.Name = "txturunsatisstok";
            this.txturunsatisstok.Size = new System.Drawing.Size(194, 30);
            this.txturunsatisstok.TabIndex = 5;
            // 
            // txturunsatismiktar
            // 
            this.txturunsatismiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturunsatismiktar.Location = new System.Drawing.Point(909, 121);
            this.txturunsatismiktar.Name = "txturunsatismiktar";
            this.txturunsatismiktar.Size = new System.Drawing.Size(194, 30);
            this.txturunsatismiktar.TabIndex = 5;
            this.txturunsatismiktar.TextChanged += new System.EventHandler(this.txturunsatismiktar_TextChanged);
            // 
            // cmburunsatissecimi
            // 
            this.cmburunsatissecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmburunsatissecimi.FormattingEnabled = true;
            this.cmburunsatissecimi.Location = new System.Drawing.Point(490, 121);
            this.cmburunsatissecimi.Name = "cmburunsatissecimi";
            this.cmburunsatissecimi.Size = new System.Drawing.Size(194, 33);
            this.cmburunsatissecimi.TabIndex = 6;
            this.cmburunsatissecimi.SelectedIndexChanged += new System.EventHandler(this.cmburunsatissecimi_SelectedIndexChanged);
            // 
            // dtgridwsepet
            // 
            this.dtgridwsepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridwsepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ürün_ID,
            this.Urun_Adi,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgridwsepet.GridColor = System.Drawing.Color.DimGray;
            this.dtgridwsepet.Location = new System.Drawing.Point(12, 451);
            this.dtgridwsepet.Name = "dtgridwsepet";
            this.dtgridwsepet.RowHeadersWidth = 62;
            this.dtgridwsepet.RowTemplate.Height = 28;
            this.dtgridwsepet.Size = new System.Drawing.Size(1326, 307);
            this.dtgridwsepet.TabIndex = 7;
            // 
            // Ürün_ID
            // 
            this.Ürün_ID.HeaderText = "Ürün ID";
            this.Ürün_ID.MinimumWidth = 8;
            this.Ürün_ID.Name = "Ürün_ID";
            this.Ürün_ID.Width = 150;
            // 
            // Urun_Adi
            // 
            this.Urun_Adi.HeaderText = "Ürün Adı";
            this.Urun_Adi.MinimumWidth = 8;
            this.Urun_Adi.Name = "Urun_Adi";
            this.Urun_Adi.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Miktar";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Birim Fiyat";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Toplam Fiyat";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kayıt Tarihi";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "SEPET";
            // 
            // lblurunsatis
            // 
            this.lblurunsatis.AutoSize = true;
            this.lblurunsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurunsatis.Location = new System.Drawing.Point(520, 62);
            this.lblurunsatis.Name = "lblurunsatis";
            this.lblurunsatis.Size = new System.Drawing.Size(118, 25);
            this.lblurunsatis.TabIndex = 6;
            this.lblurunsatis.Text = "Ürün Seçimi";
            // 
            // lblurunmiktar
            // 
            this.lblurunmiktar.AutoSize = true;
            this.lblurunmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurunmiktar.Location = new System.Drawing.Point(969, 62);
            this.lblurunmiktar.Name = "lblurunmiktar";
            this.lblurunmiktar.Size = new System.Drawing.Size(65, 25);
            this.lblurunmiktar.TabIndex = 6;
            this.lblurunmiktar.Text = "Miktar";
            // 
            // lblurunstok
            // 
            this.lblurunstok.AutoSize = true;
            this.lblurunstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurunstok.Location = new System.Drawing.Point(1192, 62);
            this.lblurunstok.Name = "lblurunstok";
            this.lblurunstok.Size = new System.Drawing.Size(52, 25);
            this.lblurunstok.TabIndex = 6;
            this.lblurunstok.Text = "Stok";
            // 
            // dateTimesatıs
            // 
            this.dateTimesatıs.Location = new System.Drawing.Point(1138, 419);
            this.dateTimesatıs.Name = "dateTimesatıs";
            this.dateTimesatıs.Size = new System.Drawing.Size(200, 26);
            this.dateTimesatıs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1022, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Satış Tarihi";
            // 
            // lbltexttoplamfiyat
            // 
            this.lbltexttoplamfiyat.AutoSize = true;
            this.lbltexttoplamfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexttoplamfiyat.Location = new System.Drawing.Point(1039, 217);
            this.lbltexttoplamfiyat.Name = "lbltexttoplamfiyat";
            this.lbltexttoplamfiyat.Size = new System.Drawing.Size(205, 29);
            this.lbltexttoplamfiyat.TabIndex = 10;
            this.lbltexttoplamfiyat.Text = "TOPLAM FİYAT:";
            // 
            // lbluruntoplamfiyat
            // 
            this.lbluruntoplamfiyat.AutoSize = true;
            this.lbluruntoplamfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluruntoplamfiyat.Location = new System.Drawing.Point(1099, 294);
            this.lbluruntoplamfiyat.Name = "lbluruntoplamfiyat";
            this.lbluruntoplamfiyat.Size = new System.Drawing.Size(100, 29);
            this.lbluruntoplamfiyat.TabIndex = 11;
            this.lbluruntoplamfiyat.Text = "0.00 TL";
            // 
            // btnsepeteekle
            // 
            this.btnsepeteekle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsepeteekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsepeteekle.Location = new System.Drawing.Point(490, 217);
            this.btnsepeteekle.Name = "btnsepeteekle";
            this.btnsepeteekle.Size = new System.Drawing.Size(162, 122);
            this.btnsepeteekle.TabIndex = 12;
            this.btnsepeteekle.Text = "Sepete Ekle";
            this.btnsepeteekle.UseVisualStyleBackColor = false;
            this.btnsepeteekle.Click += new System.EventHandler(this.btnsepeteekle_Click);
            // 
            // txturunsatisionayla
            // 
            this.txturunsatisionayla.BackColor = System.Drawing.Color.ForestGreen;
            this.txturunsatisionayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturunsatisionayla.Location = new System.Drawing.Point(829, 217);
            this.txturunsatisionayla.Name = "txturunsatisionayla";
            this.txturunsatisionayla.Size = new System.Drawing.Size(161, 122);
            this.txturunsatisionayla.TabIndex = 12;
            this.txturunsatisionayla.Text = "Satışı Onayla";
            this.txturunsatisionayla.UseVisualStyleBackColor = false;
            this.txturunsatisionayla.Click += new System.EventHandler(this.txturunsatisionayla_Click);
            // 
            // txtbirimfiyat
            // 
            this.txtbirimfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbirimfiyat.Location = new System.Drawing.Point(703, 121);
            this.txtbirimfiyat.Name = "txtbirimfiyat";
            this.txtbirimfiyat.Size = new System.Drawing.Size(194, 30);
            this.txtbirimfiyat.TabIndex = 5;
            this.txtbirimfiyat.TextChanged += new System.EventHandler(this.txturunsatismiktar_TextChanged);
            // 
            // lblsatisbirimfiyat
            // 
            this.lblsatisbirimfiyat.AutoSize = true;
            this.lblsatisbirimfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsatisbirimfiyat.Location = new System.Drawing.Point(744, 62);
            this.lblsatisbirimfiyat.Name = "lblsatisbirimfiyat";
            this.lblsatisbirimfiyat.Size = new System.Drawing.Size(102, 25);
            this.lblsatisbirimfiyat.TabIndex = 6;
            this.lblsatisbirimfiyat.Text = "Birim Fiyat";
            // 
            // btnsepetitemizle
            // 
            this.btnsepetitemizle.BackColor = System.Drawing.Color.Crimson;
            this.btnsepetitemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsepetitemizle.Location = new System.Drawing.Point(663, 217);
            this.btnsepetitemizle.Name = "btnsepetitemizle";
            this.btnsepetitemizle.Size = new System.Drawing.Size(156, 122);
            this.btnsepetitemizle.TabIndex = 12;
            this.btnsepetitemizle.Text = "Sepeti Temizle";
            this.btnsepetitemizle.UseVisualStyleBackColor = false;
            this.btnsepetitemizle.Click += new System.EventHandler(this.btnsepetitemizle_Click);
            // 
            // satisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 769);
            this.Controls.Add(this.txturunsatisionayla);
            this.Controls.Add(this.btnsepetitemizle);
            this.Controls.Add(this.btnsepeteekle);
            this.Controls.Add(this.lbluruntoplamfiyat);
            this.Controls.Add(this.lbltexttoplamfiyat);
            this.Controls.Add(this.dateTimesatıs);
            this.Controls.Add(this.lblurunstok);
            this.Controls.Add(this.lblsatisbirimfiyat);
            this.Controls.Add(this.lblurunmiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblurunsatis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgridwsepet);
            this.Controls.Add(this.cmburunsatissecimi);
            this.Controls.Add(this.grmusterisec);
            this.Controls.Add(this.txtbirimfiyat);
            this.Controls.Add(this.txturunsatismiktar);
            this.Controls.Add(this.txturunsatisstok);
            this.Name = "satisekrani";
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.satisekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridwurunsatis)).EndInit();
            this.grmusterisec.ResumeLayout(false);
            this.grmusterisec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridwsepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridwurunsatis;
        private System.Windows.Forms.GroupBox grmusterisec;
        private System.Windows.Forms.Label lblmüsteri;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txturunsatisstok;
        private System.Windows.Forms.TextBox txturunsatismiktar;
        private System.Windows.Forms.ComboBox cmburunsatissecimi;
        private System.Windows.Forms.DataGridView dtgridwsepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblurunsatis;
        private System.Windows.Forms.Label lblurunmiktar;
        private System.Windows.Forms.Label lblurunstok;
        private System.Windows.Forms.DateTimePicker dateTimesatıs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltexttoplamfiyat;
        private System.Windows.Forms.Label lbluruntoplamfiyat;
        private System.Windows.Forms.Button btnsepeteekle;
        private System.Windows.Forms.Button txturunsatisionayla;
        private System.Windows.Forms.ComboBox cmbmusteriSecimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ürün_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtbirimfiyat;
        private System.Windows.Forms.Label lblsatisbirimfiyat;
        private System.Windows.Forms.Button btnsepetitemizle;
    }
}