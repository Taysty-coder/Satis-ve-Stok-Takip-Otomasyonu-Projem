using MySql.Data.MySqlClient;
using Proje_Odevim.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.DAL
{
    public class satisDAO
    {
        string yol = "Server=172.21.54.253; Database=26_132430028; User ID=26_132430028; Password=İnif123.;";

        public void SatisEkle(satis s)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                // Sütun isimleri DB ile tam uyumlu hale getirildi
                string sorgu = "INSERT INTO satislar (musteri_id, urun_id, miktar, toplam_tutar, tarih) " +
                               "VALUES (@musteri, @urun, @miktar, @toplam, @tarih)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@musteri", s.MusteriId);
                komut.Parameters.AddWithValue("@urun", s.UrunId);
                komut.Parameters.AddWithValue("@miktar", s.Miktar);
                komut.Parameters.AddWithValue("@toplam", s.ToplamFiyat);
                komut.Parameters.AddWithValue("@tarih", s.SatisTarihi);

                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }

        public void StoktanDus(int urunId, int satilanMiktar)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "UPDATE urunler SET stok_miktari = stok_miktari - @miktar WHERE id = @id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@miktar", satilanMiktar);
                komut.Parameters.AddWithValue("@id", urunId);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }

        public double ToplamKarHesapla()
        {
            double toplamKar = 0;
            urunDAO uDao = new urunDAO();

            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "SELECT * FROM satislar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                MySqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    // DBNull kontrolü eklenerek çökme engellendi
                    if (okuyucu["urun_id"] == DBNull.Value || okuyucu["miktar"] == DBNull.Value || okuyucu["toplam_tutar"] == DBNull.Value) continue;

                    int urunId = Convert.ToInt32(okuyucu["urun_id"]);
                    int miktar = Convert.ToInt32(okuyucu["miktar"]);
                    // 'birim_fiyat' sütunu yoktu, 'toplam_tutar' üzerinden hesaplama yapıyoruz
                    double satisTutari = Convert.ToDouble(okuyucu["toplam_tutar"]);

                    var urunBilgisi = uDao.IdYeGoreAra(urunId);
                    if (urunBilgisi.Count > 0)
                    {
                        double alisFiyati = urunBilgisi[0].AlisFiyati;
                        double maliyet = alisFiyati * miktar;
                        toplamKar += (satisTutari - maliyet);
                    }
                }
            }
            return toplamKar;
        }

        public List<satis> SatislariGetir()
        {
            List<satis> liste = new List<satis>();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "SELECT * FROM satislar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    satis s = new satis();
                    s.MusteriId = Convert.ToInt32(oku["musteri_id"]);
                    s.UrunId = Convert.ToInt32(oku["urun_id"]);
                    s.Miktar = Convert.ToInt32(oku["miktar"]);

                    // DÜZELTME: toplam_fiyat değil, şemadaki gibi toplam_tutar
                    s.ToplamFiyat = Convert.ToDouble(oku["toplam_tutar"]);

                    // DÜZELTME: satis_tarihi değil, şemadaki gibi tarih
                    s.SatisTarihi = Convert.ToDateTime(oku["tarih"]);

                    liste.Add(s);
                }
            }
            return liste;
        }

        public List<encoksatilan> EnCokSatilanlariHesapla()
        {
            List<encoksatilan> raporListesi = new List<encoksatilan>();
            urunDAO uDao = new urunDAO();

            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "SELECT urun_id, SUM(miktar) as Toplam FROM satislar GROUP BY urun_id ORDER BY Toplam DESC";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    encoksatilan rapor = new encoksatilan();
                    int urunId = Convert.ToInt32(oku["urun_id"]);
                    rapor.ToplamMiktar = Convert.ToInt32(oku["Toplam"]);

                    var urunBilgisi = uDao.IdYeGoreAra(urunId);
                    if (urunBilgisi.Count > 0) { rapor.UrunAdi = urunBilgisi[0].Ad; }

                    raporListesi.Add(rapor);
                }
            }
            return raporListesi;
        }

        public double ToplamCiroGetir()
        {
            double toplam = 0;
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                // Şemadaki isim: toplam_tutar
                string sorgu = "SELECT SUM(toplam_tutar) FROM satislar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);

                baglan.Open();
                object sonuc = komut.ExecuteScalar(); // Sorgu sonucunu buraya alır

                if (sonuc != DBNull.Value && sonuc != null)
                {
                    toplam = Convert.ToDouble(sonuc);
                }
            }
            return toplam;
        }
    }
}