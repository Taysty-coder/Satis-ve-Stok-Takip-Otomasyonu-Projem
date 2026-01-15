using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.DAL
{
    internal class kullaniciDAO
    {
        string baglantiyol ="Server = 172.21.54.253; Database=26_132430028; User ID = 26_132430028; Password=İnif123.;";

        public string GirisKontrol(string ad, string sifre)
        {
            string rol = ""; 
            using (MySqlConnection baglan = new MySqlConnection(baglantiyol))
            {
               
                string sorgu = $"SELECT rol FROM kullanicilar WHERE kullanici_adi='{ad}' AND sifre='{sifre}'";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);

                baglan.Open();
                object sonuc = komut.ExecuteScalar(); 

                if (sonuc != null)
                {
                    rol = sonuc.ToString();
                }
            }
            return rol;
        }
    }
}
