using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Ekle(T cls_t);
        void Sil(T cls_t);
        void Guncelle(T cls_t);
        List<T> Listele();
        T IDIleGetir(int vrb_id);
        List<T> Listele(Expression<Func<T, bool>> filter);
        T FiltrelemeyeGoreGetir(Expression<Func<T, bool>> filter = null);
    }
}
