using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.Domain
{
    public class urun
    {
        int id;
        string ad;
        int stokMiktari;  
        double fiyat;    
        int minStok;      

        public urun() { }
  
        public urun(string ad, int stokMiktari, double fiyat, int minStok)
        {
            this.ad = ad;
            this.stokMiktari = stokMiktari;
            this.fiyat = fiyat;
            this.minStok = minStok;
        }

        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Ad 
        {   
            get { return ad; }
            set { ad = value; }
        }
        public int StokMiktari 
        {
            get { return stokMiktari; }
            set { stokMiktari = value; } 
        }
        public double AlisFiyati { get; set; }
        public double SatisFiyati { get; set; }
        
        public int MinStok 
        { 
            get { return minStok; } 
            set { minStok = value; } 
        }
        public string Kategori { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
