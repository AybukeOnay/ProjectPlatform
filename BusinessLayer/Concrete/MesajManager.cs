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

        public List<Mesaj> OgretimElemaninaGelenMesajlariListele(string vrb_mail)
        {
            return _mesajDal.Listele(x => x.AliciMail == vrb_mail);
        }

        public void TEkleBL(Mesaj cls_t)
        {
            throw new NotImplementedException();
        }

        public Mesaj TFiltrelemeyeGoreGetirBL(Expression<Func<Mesaj, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(Mesaj cls_t)
        {
            throw new NotImplementedException();
        }

        public Mesaj TIDIleGetirBL(int vrb_id)
        {
            throw new NotImplementedException();
        }

        public List<Mesaj> TListeleBL()
        {
            throw new NotImplementedException();
        }

        public void TSilBL(Mesaj cls_t)
        {
            throw new NotImplementedException();
        }
    }
}
