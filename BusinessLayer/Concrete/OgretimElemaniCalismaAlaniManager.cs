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
    public class OgretimElemaniCalismaAlaniManager : IOgretimElemaniCalismaAlaniService
    {
        IOgretimElemaniCalismaAlaniDal _ogretimElemaniCalismaAlaniDal;

        public OgretimElemaniCalismaAlaniManager(IOgretimElemaniCalismaAlaniDal ogretimElemaniCalismaAlaniDal)
        {
            _ogretimElemaniCalismaAlaniDal = ogretimElemaniCalismaAlaniDal;
        }

        public List<OgretimElemaniCalismaAlani> OgretimElemaninaGoreListeleBL(int vrb_id)
        {
           return _ogretimElemaniCalismaAlaniDal.OgretimElemaninaGoreCalismaAlaniListeleme(vrb_id);
        }

        public void TEkleBL(OgretimElemaniCalismaAlani cls_t)
        {
            _ogretimElemaniCalismaAlaniDal.Ekle(cls_t);
        }

        public OgretimElemaniCalismaAlani TFiltrelemeyeGoreGetirBL(Expression<Func<OgretimElemaniCalismaAlani, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(OgretimElemaniCalismaAlani cls_t)
        {
            throw new NotImplementedException();
        }

        public OgretimElemaniCalismaAlani TIDIleGetirBL(int vrb_id)
        {
           return _ogretimElemaniCalismaAlaniDal.IDIleGetir(vrb_id);
        }

        public List<OgretimElemaniCalismaAlani> TListeleBL()
        {
            return _ogretimElemaniCalismaAlaniDal.Listele();
        }

        public void TSilBL(OgretimElemaniCalismaAlani cls_t)
        {
            _ogretimElemaniCalismaAlaniDal.Sil(cls_t);
        }
    }
}
