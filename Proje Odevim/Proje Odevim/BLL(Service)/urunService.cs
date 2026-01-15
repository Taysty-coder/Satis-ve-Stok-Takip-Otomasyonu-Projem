using Proje_Odevim.DAL;
using Proje_Odevim.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odevim.Service
{
    public class urunService
    {
        urunDAO dal = new urunDAO();
        public void Ekle(urun u) { dal.Ekle(u); }
        public List<urun> Listele() { return dal.Listele(); }
        public void Guncelle(urun u) { dal.urunGuncelle(u); }
        public void Sil(int id) { dal.urunSil(id); }
        public List<urun> IdYeGoreAra(int id) { return dal.IdYeGoreAra(id); }
        public List<urun> AdGoreAra(string ad) { return dal.AdGoreAra(ad); }

    }
}

