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
    public class OgretimElemaniManager : IOgretimElemaniService
    {
        IOgretimElemaniDal _ogretimElemaniDal;

        public OgretimElemaniManager(IOgretimElemaniDal ogretimElemaniDal)
        {
            _ogretimElemaniDal = ogretimElemaniDal;
        }

        public void TEkleBL(OgretimElemani cls_t)
        {
            _ogretimElemaniDal.Ekle(cls_t);
        }

        public OgretimElemani TFiltrelemeyeGoreGetirBL(Expression<Func<OgretimElemani, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(OgretimElemani cls_t)
        {
            _ogretimElemaniDal.Guncelle(cls_t);
        }

        public OgretimElemani TIDIleGetirBL(int vrb_id)
        {
            return _ogretimElemaniDal.IDIleGetir(vrb_id);
        }

        public List<OgretimElemani> TListeleBL()
        {
            return _ogretimElemaniDal.Listele();
        }

        public void TSilBL(OgretimElemani cls_t)
        {
            _ogretimElemaniDal.Sil(cls_t);
        }
    }
}
