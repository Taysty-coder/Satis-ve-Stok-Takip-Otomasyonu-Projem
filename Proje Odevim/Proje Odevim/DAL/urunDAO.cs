using MySql.Data.MySqlClient;
using Proje_Odevim.Domain;
using Proje_Odevim.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.DAL
{
    public class urunDAO
    {

        string yol = "Server=172.21.54.253; Database=26_132430028; User ID=26_132430028; Password=İnif123.;";

        
        public void Ekle(urun u)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {

                string sorgu = $"INSERT INTO urunler (ad, stok_miktari, alis_fiyati, satis_fiyati, min_stok, kayit_tarihi, kategori) VALUES ('{u.Ad}', {u.StokMiktari}, {u.AlisFiyati.ToString().Replace(',', '.')}," +
                               $" {u.SatisFiyati.ToString().Replace(',', '.')}, {u.MinStok}, '{u.KayitTarihi.ToString("yyyy-MM-dd HH:mm:ss")}', '{u.Kategori}')";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }

        
        public List<urun> Listele()
        {
            List<urun> liste = new List<urun>();

            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "SELECT * FROM urunler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    urun u = new urun();
                    u.Id = int.Parse(oku["id"].ToString());
                    u.Ad = oku["ad"].ToString();
                    u.StokMiktari = int.Parse(oku["stok_miktari"].ToString());

                    // Fiyat bitti, artık bunlar var:
                    u.AlisFiyati = double.Parse(oku["alis_fiyati"].ToString());
                    u.SatisFiyati = double.Parse(oku["satis_fiyati"].ToString());

                    u.MinStok = int.Parse(oku["min_stok"].ToString());
                    u.Kategori = oku["kategori"].ToString();
                    u.KayitTarihi = DateTime.Parse(oku["kayit_tarihi"].ToString());
                    liste.Add(u);
                }
            }
            return liste;
        }
        public void Guncelle(Proje_Odevim.Domain.urun u)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {

                string sorgu = $"UPDATE urunler SET ad='{u.Ad}', kategori='{u.Kategori}', stok_miktari={u.StokMiktari}, alis_fiyati={u.AlisFiyati.ToString().Replace(',', '.')}, satis_fiyati={u.SatisFiyati.ToString().Replace(',', '.')}, min_stok={u.MinStok} WHERE id={u.Id}";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }
        public void Sil(int id)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = $"DELETE FROM urunler WHERE id={id}";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }
        public List<urun> IdYeGoreAra(int id)
        {
            List<urun> liste = new List<urun>();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "SELECT * FROM urunler WHERE id=" + id;
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    urun u = new urun();
                    u.Id = int.Parse(oku["id"].ToString());
                    u.Ad = oku["ad"].ToString();
                    u.StokMiktari = int.Parse(oku["stok_miktari"].ToString());

                   
                    u.AlisFiyati = double.Parse(oku["alis_fiyati"].ToString());
                    u.SatisFiyati = double.Parse(oku["satis_fiyati"].ToString());

                    u.MinStok = int.Parse(oku["min_stok"].ToString());
                    u.Kategori = oku["kategori"].ToString();
                    u.KayitTarihi = DateTime.Parse(oku["kayit_tarihi"].ToString());
                    liste.Add(u);
                }
            }
            return liste;
        }
        public void urunGuncelle(urun u)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                // 115. satır burası kanka, 'fiyat' kelimelerini sildik ve yeni isimleri yazdık:
                string sorgu = $"UPDATE urunler SET ad='{u.Ad}', kategori='{u.Kategori}', stok_miktari={u.StokMiktari}, " +
                               $"alis_fiyati={u.AlisFiyati.ToString().Replace(',', '.')}, " + // alis_fiyati yaptık
                               $"satis_fiyati={u.SatisFiyati.ToString().Replace(',', '.')}, " + // satis_fiyati yaptık
                               $"min_stok={u.MinStok}, " +
                               $"kayit_tarihi='{u.KayitTarihi.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                               $"WHERE id={u.Id}";

                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }

        public void urunSil(int id)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol)) 
            {
                string sorgu = "DELETE FROM urunler WHERE id=" + id; 
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery(); // Komutu çalıştır
            }
        }
        public List<urun> AdGoreAra(string ad)
        {
            List<urun> liste = new List<urun>();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = "SELECT * FROM urunler WHERE ad LIKE '%" + ad + "%'";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    urun u = new urun();
                    u.Id = int.Parse(oku["id"].ToString());
                    u.Ad = oku["ad"].ToString();
                    u.StokMiktari = int.Parse(oku["stok_miktari"].ToString());
                    u.AlisFiyati = double.Parse(oku["alis_fiyati"].ToString());
                    u.SatisFiyati = double.Parse(oku["satis_fiyati"].ToString());
                    u.MinStok = int.Parse(oku["min_stok"].ToString());
                    u.Kategori = oku["kategori"].ToString();
                    u.KayitTarihi = DateTime.Parse(oku["kayit_tarihi"].ToString());
                    u.Kategori = oku["kategori"].ToString();
                    liste.Add(u);
                }
            }
            return liste;
        }
    }    
}
