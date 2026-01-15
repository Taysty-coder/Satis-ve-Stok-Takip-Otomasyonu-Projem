using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.Domain
{
    public class musteri
    {
       
        int id;
        string ad;
        string soyad;
        string telefon;
        string tur;

        
        public musteri() { }

        
        public musteri(string ad, string soyad, string telefon, string tur)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
            this.tur = tur;
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
        public string Soyad 
        { 
            get { return soyad; } 
            set { soyad = value; } 
        }
        public string Telefon
        
        {   
            get { return telefon; } 
            set { telefon = value; } 
        }
        public string Tur 
        {  
            get { return tur; } 
            set { tur = value; } 
        }

       
        public override string ToString()
        {
            return this.ad + " " + this.soyad;
            
        }

    }
}
