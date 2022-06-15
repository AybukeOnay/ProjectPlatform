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
    public class BildirimManager : IBildirimService
    {
        IBildirimDal _bildirimDal;

        public BildirimManager(IBildirimDal bildirimDal)
        {
            _bildirimDal = bildirimDal;
        }

        public void TEkleBL(Bildirim cls_t)
        {
            throw new NotImplementedException();
        }

        public Bildirim TFiltrelemeyeGoreGetirBL(Expression<Func<Bildirim, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void TGuncelleBL(Bildirim cls_t)
        {
            throw new NotImplementedException();
        }

        public Bildirim TIDIleGetirBL(int vrb_id)
        {
            throw new NotImplementedException();
        }

        public List<Bildirim> TListeleBL()
        {
            return _bildirimDal.Listele();
        }

        public void TSilBL(Bildirim cls_t)
        {
            throw new NotImplementedException();
        }
    }
}
