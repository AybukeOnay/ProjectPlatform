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
    public class MesajManager : IMesajService
    {
        IMesajDal _mesajDal;

        public MesajManager(IMesajDal mesajDal)
        {
            _mesajDal = mesajDal;
        }

        //public List<Mesaj> OgretimElemaninaGelenMesajlariListele(int alici)
        //{
        //    return _mesajDal.Listele(x => x.AliciID == vrb_mail);
        //}

        public void TEkleBL(Mesaj cls_t)
        {
            _mesajDal.Ekle(cls_t);
        }

        public Mesaj TFiltrelemeyeGoreGetirBL(Expression<Func<Mesaj, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(Mesaj cls_t)
        {
            _mesajDal.Guncelle(cls_t);
        }

        public Mesaj TIDIleGetirBL(int vrb_id)
        {
           return  _mesajDal.IDIleGetir(vrb_id);
        }

        public List<Mesaj> TListeleBL()
        {
            return _mesajDal.Listele();
        }

        public void TSilBL(Mesaj cls_t)
        {
            _mesajDal.Sil(cls_t);
        }
    }
}
