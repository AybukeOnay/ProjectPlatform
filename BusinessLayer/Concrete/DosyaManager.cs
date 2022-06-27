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
    public class DosyaManager : IDosyaService
    {
        IDosyaDal _dosyaDal;

        public DosyaManager(IDosyaDal dosyaDal)
        {
            _dosyaDal = dosyaDal;
        }

        public List<Dosya> DosyaLookUpGetirProjeBL(int vrb_id)
        {
            return _dosyaDal.DosyaLookUpGetirProje(vrb_id);
        }

        public void TEkleBL(Dosya cls_t)
        {
            throw new NotImplementedException();
        }

        public Dosya TFiltrelemeyeGoreGetirBL(Expression<Func<Dosya, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(Dosya cls_t)
        {
            throw new NotImplementedException();
        }

        public Dosya TIDIleGetirBL(int vrb_id)
        {
            return _dosyaDal.IDIleGetir(vrb_id);
        }

        public List<Dosya> TListeleBL()
        {
            return _dosyaDal.Listele();
        }

        public void TSilBL(Dosya cls_t)
        {
            _dosyaDal.Sil(cls_t);
        }
    }
}
