using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.DAL
{
    internal class musteriDAO
    {
        string baglantiyol = "Server = 172.21.54.253; Database=26_132430028; User ID = 26_132430028; Password=İnif123.;";
        public List<Proje_Odevim.Domain.musteri> Listele()
        {
            List<Proje_Odevim.Domain.musteri> liste = new List<Proje_Odevim.Domain.musteri>();

            using (MySqlConnection baglan = new MySqlConnection(baglantiyol))
            {
                string sorgu = "SELECT * FROM musteriler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();

                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    // Her satır için yeni bir müşteri nesnesi oluşturup içini dolduruyoruz
                    Proje_Odevim.Domain.musteri m = new Proje_Odevim.Domain.musteri();
                    m.Id = int.Parse(oku["id"].ToString());
                    m.Ad = oku["ad"].ToString();
                    m.Soyad = oku["soyad"].ToString();
                    m.Telefon = oku["telefon"].ToString();
                    m.Tur = oku["tur"].ToString();
                    
                    liste.Add(m); 
                }
            }
            return liste; 
        }

        public void Ekle(Proje_Odevim.Domain.musteri m)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiyol))
            {
               
                string sorgu = $"INSERT INTO musteriler (ad, soyad, telefon, tur) VALUES ('{m.Ad}', '{m.Soyad}', '{m.Telefon}', '{m.Tur}')";

                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();

            }
        }

        public void Guncelle(Proje_Odevim.Domain.musteri m)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiyol))
            {
                string sorgu = $"UPDATE musteriler SET ad='{m.Ad}', soyad='{m.Soyad}', telefon='{m.Telefon}', tur='{m.Tur}' WHERE id={m.Id}";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }

        // SİLME METODU
        public void Sil(int id)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiyol))
            {
                string sorgu = $"DELETE FROM musteriler WHERE id={id}";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();
            }
        }

    }
}
