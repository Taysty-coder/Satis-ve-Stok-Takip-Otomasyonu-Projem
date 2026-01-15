using Proje_Odevim.DAL;
using Proje_Odevim.Service;
using System;
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
    public partial class RaporlamaEkrani : Form
    {
        public RaporlamaEkrani()
        {
            InitializeComponent();
        }

        // 1. Grid Renklendirme: Sütun kontrolü eklenerek çökme hatası engellendi
        private void dgvRapor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Sadece stok raporunda bu sütunlar olduğu için diğer raporlarda hata vermemesi için kontrol şart
            if (!dgvRapor.Columns.Contains("StokMiktari") || !dgvRapor.Columns.Contains("MinStok"))
            {
                return;
            }

            foreach (DataGridViewRow row in dgvRapor.Rows)
            {
                if (row.Cells["StokMiktari"].Value != null && row.Cells["MinStok"].Value != null)
                {
                    int mevcutStok = Convert.ToInt32(row.Cells["StokMiktari"].Value);
                    int kritikLimit = Convert.ToInt32(row.Cells["MinStok"].Value);

                    if (mevcutStok <= kritikLimit)
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
        }

        // 2. Kâr/Zarar Raporu: Mimari uyum için Service üzerinden çağrıldı
        private void btnkarzarar_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = null;
            try
            {
                satisService sServis = new satisService();
                double netKar = sServis.ToplamKarHesapla();

                var karRaporu = new List<object>
                {
                    new { Rapor = "Net Finansal Durum", Tutar = netKar.ToString("C2"), Durum = netKar >= 0 ? "KÂR" : "ZARAR" }
                };
                dgvRapor.DataSource = karRaporu;

                dgvRapor.Columns[0].HeaderText = "Rapor Türü";
                dgvRapor.Columns[1].HeaderText = "Hesaplanan Tutar";
                dgvRapor.Columns[2].HeaderText = "Mali Durum";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama hatası (DBNull veya Bağlantı): " + ex.Message);
            }
        }

        // 3. Toplam Ciro Raporu
        private void btntoplamciro_Click(object sender, EventArgs e)
        {
            try
            {
                satisService satisIslemleri = new satisService();
                double ciro = satisIslemleri.ToplamCiroHesapla();

                var ciroRaporu = new List<object>
                {
                    new { RaporAdi = "Toplam Satış Cirosu", Tutar = ciro.ToString("C2"), Tarih = DateTime.Now.ToShortDateString() }
                };

                dgvRapor.DataSource = null;
                dgvRapor.DataSource = ciroRaporu;

                dgvRapor.Columns[0].HeaderText = "Rapor Tanımı";
                dgvRapor.Columns[1].HeaderText = "Toplam Tutar";
                dgvRapor.Columns[2].HeaderText = "Hesaplanma Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ciro bilgisi çekilemedi: " + ex.Message);
            }
        }

        // 4. En Çok Satılan Ürünler: DAO yerine Service kullanıldı
        private void btnencoksatilanurun_Click(object sender, EventArgs e)
        {
            try
            {
                satisService sServis = new satisService();
                dgvRapor.DataSource = null;

                var liste = sServis.EnCokSatilanlariHesapla();
                dgvRapor.DataSource = liste;

                if (dgvRapor.Columns.Count > 0)
                {
                    dgvRapor.Columns[0].HeaderText = "Ürün Adı";
                    dgvRapor.Columns[1].HeaderText = "Toplam Satış Adedi";
                }
                MessageBox.Show("Ürünler satış performansına göre sıralandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor yükleme hatası: " + ex.Message);
            }
        }

        // 5. Kritik Stok Raporu
        private void btnurunstokraporu_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = null;
            try
            {
                urunService uServis = new urunService();
                dgvRapor.DataSource = uServis.Listele();

                MessageBox.Show("Ürün listesi yüklendi. Kritik seviyedeki ürünler otomatik olarak kırmızı işaretlendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok verileri alınamadı: " + ex.Message);
            }
        }

        private void RaporlamaEkrani_Load(object sender, EventArgs e)
        {
            // Form açıldığında varsayılan bir işlem yapılacaksa buraya eklenebilir.
        }
    }
}