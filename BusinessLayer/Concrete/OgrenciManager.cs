using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }

        public void TEkleBL(Ogrenci cls_t)
        {
            _ogrenciDal.Ekle(cls_t);
        }

        public Ogrenci TFiltrelemeyeGoreGetirBL(Expression<Func<Ogrenci, bool>> filter = null)
        {
            return _ogrenciDal.FiltrelemeyeGoreGetir(filter);
        }

        public void TGuncelleBL(Ogrenci cls_t)
        {
            _ogrenciDal.Guncelle(cls_t);
        }

        public Ogrenci TIDIleGetirBL(int vrb_id)
        {
            return _ogrenciDal.IDIleGetir(vrb_id);
        }

        public List<Ogrenci> TListeleBL()
        {
            return _ogrenciDal.Listele();
        }

        public void TSilBL(Ogrenci cls_t)
        {
            _ogrenciDal.Sil(cls_t);
        }
    }
}
