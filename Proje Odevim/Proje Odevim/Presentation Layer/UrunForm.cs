using Proje_Odevim.Domain;
using Proje_Odevim.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odevim.Presentation_Layer
{
    public partial class UrunForm : Form
    {
        urunService urunIslemleri = new urunService();
        public UrunForm()
        {
            InitializeComponent();
        }
        
        void Listele()
        {
            Proje_Odevim.Service.urunService servis = new Proje_Odevim.Service.urunService();
            try
            {
                dtgridwurun.DataSource = null;
                dtgridwurun.DataSource = urunIslemleri.Listele();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Listeleme Hatası: " + ex.Message);
            }
        }

        // FORM AÇILINCA LİSTE GELSİN
        private void UrunForm_Load(object sender, EventArgs e)
        {
              
            txturunId.Enabled = false; 
            Listele();
            txturunId.ReadOnly = true;
        }

        // KAYDET BUTONU
        private void btnurunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (urunIslemleri == null) urunIslemleri = new urunService();

                Proje_Odevim.Domain.urun yeniUrun = new Proje_Odevim.Domain.urun();
                yeniUrun.Ad = txtadi.Text;
                yeniUrun.StokMiktari = int.Parse(txtstokMiktari.Text);
                yeniUrun.AlisFiyati = double.Parse(txturunalisfiyati.Text.Replace('.', ','));
                yeniUrun.SatisFiyati = double.Parse(txturunsatisfiyati.Text.Replace('.', ','));
                yeniUrun.MinStok = int.Parse(txturunminStok.Text);
                yeniUrun.KayitTarihi = dateTimePicker1.Value;
                yeniUrun.Kategori = cmbkategori.Text;

                urunIslemleri.Ekle(yeniUrun);

                MessageBox.Show("Ürün ve Kayıt Tarihi veritabanına kaydedildi!");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: " + ex.ToString());
            }
        }
        
        void Temizle()
        {
            txtAd.Clear();
            txtStok.Clear();
            txtFiyat.Clear();
            txtMinStok.Clear();
        }
        

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunId.Text = dtgridwurun.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dtgridwurun.CurrentRow.Cells[1].Value.ToString();
            txtStok.Text = dtgridwurun.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dtgridwurun.CurrentRow.Cells[3].Value.ToString();
            txtMinStok.Text = dtgridwurun.CurrentRow.Cells[4].Value.ToString();
        }

        private void dtgridwurun_DataBindingCompelete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dtgridwurun.Rows)
            {
                
                int stok = Convert.ToInt32(row.Cells["StokMiktari"].Value);
                int minStok = Convert.ToInt32(row.Cells["MinStok"].Value);

                if (stok <= minStok)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White; 
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; 
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

            }
        }
        private void txtidno_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txturunId.Text))
            {
                try
                {
                    int arananId = int.Parse(txturunId.Text);
                   
                    dtgridwurun.DataSource = urunIslemleri.IdYeGoreAra(arananId);
                }
                catch
                {
                    
                }
            }
            else
            {
                Listele(); 
            }
        }

        private void dtgridwurun_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dtgridwurun.Rows[e.RowIndex];

                
                txturunId.Text = row.Cells["Id"].Value?.ToString();
                txtadi.Text = row.Cells["Ad"].Value?.ToString();
                txtstokMiktari.Text = row.Cells["StokMiktari"].Value?.ToString();
                txturunalisfiyati.Text = row.Cells["AlisFiyati"].Value?.ToString();
                txturunsatisfiyati.Text = row.Cells["SatisFiyati"].Value?.ToString();
                txturunminStok.Text = row.Cells["MinStok"].Value?.ToString();
                cmbkategori.Text = row.Cells["Kategori"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hücre seçilirken hata oluştu: " + ex.Message);
            }
        }
        private void Guncelleme_Islemi(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbkategori.Text))
                {
                    MessageBox.Show("Lütfen güncellenecek ürün için bir kategori seçin!");
                    return;
                }
                Proje_Odevim.Domain.urun gUrun = new Proje_Odevim.Domain.urun();
                gUrun.Id = int.Parse(txturunId.Text);
                gUrun.Ad = txtadi.Text;
                gUrun.StokMiktari = int.Parse(txtstokMiktari.Text);
                gUrun.AlisFiyati = double.Parse(txturunalisfiyati.Text);
                gUrun.SatisFiyati = double.Parse(txturunsatisfiyati.Text);
                gUrun.Kategori = cmbkategori.Text;
                gUrun.MinStok = int.Parse(txturunminStok.Text);
                gUrun.KayitTarihi = dateTimePicker1.Value;
                gUrun.Kategori = cmbkategori.Text;

                urunIslemleri.Guncelle(gUrun);
                MessageBox.Show("Ürün başarıyla güncellendi!");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teknik Hata: " + ex.Message);
            }

        }
        private void Silme_Islemi(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txturunId.Text);
                if (MessageBox.Show("Silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    urunIslemleri.Sil(id);
                    MessageBox.Show("Ürün silindi.");
                    Listele();
                }
            }
            catch { MessageBox.Show("Silinecek ürünü seçin!"); }
        }

        private void btnUrunara_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txturunisimara.Text))
                {
                    string arananAd = txturunisimara.Text;
                    dtgridwurun.DataSource = urunIslemleri.AdGoreAra(txturunisimara.Text);
                }
                if (!string.IsNullOrEmpty(txtidno.Text))
                {
                    int arananId = int.Parse(txtidno.Text);
                    dtgridwurun.DataSource = urunIslemleri.IdYeGoreAra(arananId);
                }
                else
                {
                   
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: Lütfen geçerli bir sayısal ID girin! " + ex.Message);
            }
        }

        private void txturunisimara_TextChanged(object sender, EventArgs e)
        {
            dtgridwurun.DataSource = urunIslemleri.AdGoreAra(txturunisimara.Text);
        }

        
    }
    
}
