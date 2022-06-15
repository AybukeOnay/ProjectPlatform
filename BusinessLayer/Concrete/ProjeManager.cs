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
    public class ProjeManager : IProjeService
    {
        IProjeDal _projeDal;

        public ProjeManager(IProjeDal projeDal)
        {
            _projeDal = projeDal;
        }

        public List<Proje> ProjeLookUpGetirBL()
        {
            return _projeDal.ProjeLookUpGetir();
        }

        public void TEkleBL(Proje cls_t)
        {
            _projeDal.Ekle(cls_t);
        }

        public Proje TFiltrelemeyeGoreGetirBL(Expression<Func<Proje, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(Proje cls_t)
        {
            _projeDal.Guncelle(cls_t);
        }

        public Proje TIDIleGetirBL(int vrb_id)
        {
            throw new NotImplementedException();
        }

        public List<Proje> TListeleBL()
        {
            return _projeDal.Listele();
        }

        public void TSilBL(Proje cls_t)
        {
            _projeDal.Sil(cls_t);
        }
    }
}
