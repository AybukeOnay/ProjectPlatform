using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();

        public void Ekle(T cls_t)
        {
            c.Add(cls_t);
            c.SaveChanges();
        }

        public T FiltrelemeyeGoreGetir(Expression<Func<T, bool>> filter = null)
        {
            if (filter==null)
            {
                return c.Set<T>().FirstOrDefault();
            }
            else
            {
                return c.Set<T>().FirstOrDefault(filter);
            }
        }

        public void Guncelle(T cls_t)
        {
            c.Update(cls_t);
            c.SaveChanges();
        }

        public T IDIleGetir(int vrb_id)
        {
            return c.Set<T>().Find(vrb_id);
        }

        public List<T> Listele()
        {
            return c.Set<T>().ToList();
        }

        public List<T> Listele(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Sil(T cls_t)
        {
            c.Remove(cls_t);
            c.SaveChanges();
        }
    }
}
