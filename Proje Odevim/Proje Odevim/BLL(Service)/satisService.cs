using Proje_Odevim.DAL;
using Proje_Odevim.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.Service
{
    public class satisService
    {
        
        satisDAO sDao = new satisDAO();
        urunDAO uDao = new urunDAO(); 

        public string SatisGerceklestir(satis s)
        {
            try
            {
                satisDAO sDao = new satisDAO();
                urunDAO uDao = new urunDAO();

             
                var urunListesi = uDao.IdYeGoreAra(s.UrunId);
                if (urunListesi.Count == 0) return "Ürün bulunamadı!";

                urun guncelUrun = urunListesi[0];

                if (guncelUrun.StokMiktari < s.Miktar)
                {
                    return $"Yetersiz Stok! Mevcut Stok: {guncelUrun.StokMiktari}";
                }

                // 2. SATIŞI KAYDET (Hatalı olan 'Ekle' satırını sildik, doğrusunu yazdık)
                sDao.SatisEkle(s);

                // 3. STOKTAN DÜŞ
                sDao.StoktanDus(s.UrunId, s.Miktar);

                // 4. KRİTİK STOK KONTROLÜ (YBS mantığı: Yöneticiyi uyar)
                if ((guncelUrun.StokMiktari - s.Miktar) <= guncelUrun.MinStok)
                {
                    return "Satış başarılı! DİKKAT: Ürün kritik stok seviyesine düştü!";
                }

                return "Satış başarıyla tamamlandı.";
            }
            catch (Exception ex)
            {
                return "Hata oluştu: " + ex.Message;
            }
        }
        public double ToplamCiroHesapla()
        {
            return sDao.ToplamCiroGetir();
        }
        public double ToplamKarHesapla()
        {
            
            return sDao.ToplamKarHesapla();
        }
       
        public List<encoksatilan> EnCokSatilanlariHesapla()
        {
         
            return sDao.EnCokSatilanlariHesapla();
        }
    }
}
