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
    public class CalismaAlaniManager : ICalismaAlaniService
    {
        ICalismaAlaniDal _calismaAlaniDal;       

        public CalismaAlaniManager(ICalismaAlaniDal calismaAlaniDal)
        {
            _calismaAlaniDal = calismaAlaniDal;
        }
       
        public void TEkleBL(CalismaAlani cls_t)
        {
            _calismaAlaniDal.Ekle(cls_t);
        }

        public CalismaAlani TFiltrelemeyeGoreGetirBL(Expression<Func<CalismaAlani, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(CalismaAlani cls_t)
        {
            _calismaAlaniDal.Guncelle(cls_t);
        }

        public CalismaAlani TIDIleGetirBL(int vrb_id)
        {
            return _calismaAlaniDal.IDIleGetir(vrb_id);
        }

        public List<CalismaAlani> TListeleBL()
        {
            return _calismaAlaniDal.Listele();
        }

        public void TSilBL(CalismaAlani cls_t)
        {
            _calismaAlaniDal.Sil(cls_t);
        }
    }
}
