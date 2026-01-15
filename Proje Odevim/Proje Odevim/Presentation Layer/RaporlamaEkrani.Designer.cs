namespace Proje_Odevim.Presentation_Layer
{
    partial class RaporlamaEkrani
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
            this.btnkarzarar = new System.Windows.Forms.Button();
            this.btntoplamciro = new System.Windows.Forms.Button();
            this.btnencoksatilanurun = new System.Windows.Forms.Button();
            this.btnurunstokraporu = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkarzarar
            // 
            this.btnkarzarar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnkarzarar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkarzarar.Location = new System.Drawing.Point(414, 95);
            this.btnkarzarar.Name = "btnkarzarar";
            this.btnkarzarar.Size = new System.Drawing.Size(231, 132);
            this.btnkarzarar.TabIndex = 0;
            this.btnkarzarar.Text = "Kar/Zarar";
            this.btnkarzarar.UseVisualStyleBackColor = false;
            this.btnkarzarar.Click += new System.EventHandler(this.btnkarzarar_Click);
            // 
            // btntoplamciro
            // 
            this.btntoplamciro.BackColor = System.Drawing.Color.ForestGreen;
            this.btntoplamciro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoplamciro.Location = new System.Drawing.Point(90, 104);
            this.btntoplamciro.Name = "btntoplamciro";
            this.btntoplamciro.Size = new System.Drawing.Size(236, 123);
            this.btntoplamciro.TabIndex = 0;
            this.btntoplamciro.Text = "Toplam Ciro";
            this.btntoplamciro.UseVisualStyleBackColor = false;
            this.btntoplamciro.Click += new System.EventHandler(this.btntoplamciro_Click);
            // 
            // btnencoksatilanurun
            // 
            this.btnencoksatilanurun.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnencoksatilanurun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencoksatilanurun.Location = new System.Drawing.Point(726, 95);
            this.btnencoksatilanurun.Name = "btnencoksatilanurun";
            this.btnencoksatilanurun.Size = new System.Drawing.Size(231, 132);
            this.btnencoksatilanurun.TabIndex = 0;
            this.btnencoksatilanurun.Text = "En Çok Satılan Ürünler";
            this.btnencoksatilanurun.UseVisualStyleBackColor = false;
            this.btnencoksatilanurun.Click += new System.EventHandler(this.btnencoksatilanurun_Click);
            // 
            // btnurunstokraporu
            // 
            this.btnurunstokraporu.BackColor = System.Drawing.Color.Crimson;
            this.btnurunstokraporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurunstokraporu.Location = new System.Drawing.Point(1045, 95);
            this.btnurunstokraporu.Name = "btnurunstokraporu";
            this.btnurunstokraporu.Size = new System.Drawing.Size(231, 132);
            this.btnurunstokraporu.TabIndex = 0;
            this.btnurunstokraporu.Text = "Kritik Stok Raporu";
            this.btnurunstokraporu.UseVisualStyleBackColor = false;
            this.btnurunstokraporu.Click += new System.EventHandler(this.btnurunstokraporu_Click);
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Location = new System.Drawing.Point(35, 351);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidth = 62;
            this.dgvRapor.RowTemplate.Height = 28;
            this.dgvRapor.Size = new System.Drawing.Size(1316, 395);
            this.dgvRapor.TabIndex = 1;
            this.dgvRapor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRapor_DataBindingComplete);
            // 
            // RaporlamaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 779);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.btnurunstokraporu);
            this.Controls.Add(this.btnencoksatilanurun);
            this.Controls.Add(this.btntoplamciro);
            this.Controls.Add(this.btnkarzarar);
            this.Name = "RaporlamaEkrani";
            this.Text = "RaporlamaEkrani";
            this.Load += new System.EventHandler(this.RaporlamaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkarzarar;
        private System.Windows.Forms.Button btntoplamciro;
        private System.Windows.Forms.Button btnencoksatilanurun;
        private System.Windows.Forms.Button btnurunstokraporu;
        private System.Windows.Forms.DataGridView dgvRapor;
    }
}