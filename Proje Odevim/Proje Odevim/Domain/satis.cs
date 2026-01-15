using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.Domain
{
    public class satis
    {

        private int id;
        private int musteriId;
        private int urunId;
        private int miktar;
        private double birimFiyat;
        private double toplamFiyat;
        private DateTime satisTarihi;


        public satis() { }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        public int Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        public double BirimFiyat
        {
            get { return birimFiyat; }
            set { birimFiyat = value; }
        }

        public double ToplamFiyat
        {
            get { return toplamFiyat; }
            set { toplamFiyat = value; }
        }

        public DateTime SatisTarihi
        {
            get { return satisTarihi; }
            set { satisTarihi = value; }
        }
    }

}
