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
    public partial class satisekrani : Form
    {
        musteriService mServis = new musteriService();
        public satisekrani()
        {
            InitializeComponent();
        }
        urunService urunIslemleri = new urunService();
        musteriDAO musteriIslemleri = new musteriDAO();
        satisService satisIslemleri = new satisService();


        private void satisekrani_Load(object sender, EventArgs e)
        {
            MusteriListele();
            try
            {
                
                cmburunsatissecimi.DataSource = urunIslemleri.Listele();
                cmburunsatissecimi.DisplayMember = "Ad"; // Kullanıcı ürün ismini görsün
                cmburunsatissecimi.ValueMember = "Id";   // Biz arka planda Id'yi tutalım
                cmburunsatissecimi.SelectedIndex = -1;   // İlk açılışta bir şey seçili gelmesin

                // 2. MÜŞTERİLERİ COMBOBOX'A ÇEKELİM (Senin ekranında grid var ama combo istedin)
                cmbmusteriSecimi.DataSource = musteriIslemleri.Listele();
                cmbmusteriSecimi.DisplayMember = "Ad"; // Müşteri adını göster
                cmbmusteriSecimi.ValueMember = "Id";   // Müşteri ID'sini tut
                cmbmusteriSecimi.SelectedIndex = -1;
                dtgridwurunsatis.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
            
        }

        private void cmburunsatissecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmburunsatissecimi.SelectedItem == null) return;
          
            Proje_Odevim.Domain.urun secilenUrun = (Proje_Odevim.Domain.urun)cmburunsatissecimi.SelectedItem;
            txturunsatismiktar.Text = secilenUrun.SatisFiyati.ToString("0.00");
            txturunsatisstok.Text = secilenUrun.StokMiktari.ToString();
            txtbirimfiyat.Text = secilenUrun.SatisFiyati.ToString();
            txturunsatismiktar.Text = "1";

            ToplamHesapla();
        }
        private void ToplamHesapla()
        {

            if (txturunsatismiktar.Text != "" && txtbirimfiyat.Text != "")
            {

                double birimFiyat = double.Parse(txtbirimfiyat.Text);
                int miktar = (int)double.Parse(txturunsatismiktar.Text);

                double toplam = birimFiyat * miktar;
                lbluruntoplamfiyat.Text = toplam.ToString("0.00") + " TL";
            }
        }

        private void txturunsatismiktar_TextChanged(object sender, EventArgs e)
        {
            if (txturunsatismiktar.Text != "")
            {
                ToplamHesapla();
            }    

        }

        private void btnsepeteekle_Click(object sender, EventArgs e)
        {
           
            if (txturunsatismiktar.Text == "")
            {
                MessageBox.Show("Lütfen miktar giriniz!");
                return;
            }


            int girilenMiktar = int.Parse(txturunsatismiktar.Text);
            int mevcutStok = int.Parse(txturunsatisstok.Text);
            double birimFiyat = Convert.ToDouble(txtbirimfiyat.Text);
            string suAnkiZaman = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
          
            if (girilenMiktar > mevcutStok)
            {
                MessageBox.Show("Stokta yeterli ürün yok! Mevcut Stok: " + mevcutStok);
                return;
            }

           
            double toplamFiyat = girilenMiktar * birimFiyat;

            // 5. SEPETE (DataGridView) SATIR EKLEME
            // Sütun sırasına göre verileri ekliyoruz
            dtgridwsepet.Rows.Add(
            cmburunsatissecimi.SelectedValue,   // Ürün ID
            cmburunsatissecimi.Text,            // Ürün Adı
            txturunsatismiktar.Text,       // Miktar
            txtbirimfiyat.Text,            // Birim Fiyat (YENİ EKLEDİĞİN KUTU)
            lbluruntoplamfiyat.Text,       // Toplam Fiyat
            dateTimesatıs.Value);        // Satış Tarihi
                                          


            // 6. TEMİZLİK: Ekranı bir sonraki ürün için hazırla
            txturunsatismiktar.Clear();
            lbluruntoplamfiyat.Text = "0.00 TL";
        }

        private void txturunsatisionayla_Click(object sender, EventArgs e)
        {
            if (cmbmusteriSecimi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz!");
                return;
            }

            if (dtgridwsepet.Rows.Count == 0)
            {
                MessageBox.Show("Sepette ürün bulunmamaktadır!");
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dtgridwsepet.Rows)
                {
                 
                    if (row.Cells[0].Value == null) continue;

                    
                    Proje_Odevim.Domain.satis yeniSatis = new Proje_Odevim.Domain.satis();

                    yeniSatis.MusteriId = Convert.ToInt32(cmbmusteriSecimi.SelectedValue);
                    yeniSatis.UrunId = Convert.ToInt32(row.Cells[0].Value);      
                    yeniSatis.Miktar = Convert.ToInt32(row.Cells[2].Value);
                    string birimFiyatStr = row.Cells[3].Value.ToString().Replace(" TL", "");
                    string toplamFiyatStr = row.Cells[4].Value.ToString().Replace(" TL", "");
                    yeniSatis.SatisTarihi = Convert.ToDateTime(row.Cells[5].Value);
                    
                    string sonuc = satisIslemleri.SatisGerceklestir(yeniSatis);

                    if (sonuc.Contains("Yetersiz Stok"))
                    {
                        MessageBox.Show(sonuc);
                        return;
                    }
                }
                MessageBox.Show("Satış işlemi başarıyla tamamlandı, stoklar güncellendi.");
                cmburunsatissecimi.DataSource = urunIslemleri.Listele();
                dtgridwsepet.Rows.Clear(); 
                lbluruntoplamfiyat.Text = "0.00 TL";
                txturunsatisstok.Text = "";
                cmburunsatissecimi.DataSource = urunIslemleri.Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış sırasında teknik bir hata oluştu: " + ex.Message);
            }
        }

        private void btnsepetitemizle_Click(object sender, EventArgs e)
        {
       
            DialogResult sonuc = MessageBox.Show("Sepetteki tüm ürünleri silmek istediğinize emin misiniz?",
                                                "Sepeti Temizle",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
             
                dtgridwsepet.Rows.Clear();              
                lbluruntoplamfiyat.Text = "0.00 TL";

                MessageBox.Show("Sepet başarıyla temizlendi.");
            }
        }
        public void MusteriListele()
        {
            var musteriler = mServis.MusterileriGetir();

         
            dtgridwurunsatis.DataSource = null;
            dtgridwurunsatis.DataSource = musteriler;
            

            cmbmusteriSecimi.DataSource = musteriler;
            cmbmusteriSecimi.DisplayMember = "Ad"; 
            cmbmusteriSecimi.ValueMember = "Id";   
        }

        private void dtgridwurunsatis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                // Tabloda tıklanan satırdaki Müşteri ID'sini alıyoruz
                int secilenId = Convert.ToInt32(dtgridwurunsatis.Rows[e.RowIndex].Cells["Id"].Value);

                // Yukarıdaki ComboBox'ta o ID'li müşteriyi otomatik seçtiriyoruz
                cmbmusteriSecimi.SelectedValue = secilenId;
            }
        }
    }
}
