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
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public void TEkleBL(Kullanici cls_t)
        {
            _kullaniciDal.Ekle(cls_t);
        }

        public Kullanici TFiltrelemeyeGoreGetirBL(Expression<Func<Kullanici, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(Kullanici cls_t)
        {
            _kullaniciDal.Guncelle(cls_t);
        }

        public Kullanici TIDIleGetirBL(int vrb_id)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> TListeleBL()
        {
            return _kullaniciDal.Listele();
        }

        public void TSilBL(Kullanici cls_t)
        {
            throw new NotImplementedException();
        }
    }
}
