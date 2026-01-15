using Proje_Odevim.DAL;
using Proje_Odevim.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Odevim.Service
{
    internal class musteriService
    {
        Proje_Odevim.DAL.musteriDAO veriMerkezi = new Proje_Odevim.DAL.musteriDAO();
        Proje_Odevim.DAL.musteriDAO dal = new Proje_Odevim.DAL.musteriDAO();
        public void Kaydet(Proje_Odevim.Domain.musteri m)
        {
            
            veriMerkezi.Ekle(m);
        }
        public List<Proje_Odevim.Domain.musteri> MusteriListesiGetir()
        {
            return dal.Listele();
        }
        public void Guncelle(Proje_Odevim.Domain.musteri m) { dal.Guncelle(m); }
        public void Sil(int id) 
        { 
            dal.Sil(id);
        }
        public List<musteri> MusterileriGetir()
        {
            musteriDAO mDao = new musteriDAO();
            return mDao.Listele();
        }

    }
}
