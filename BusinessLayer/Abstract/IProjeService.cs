using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjeService:IGenericService<Proje>
    {
        List<Proje> ProjeLookUpGetirBL();
        List<Proje> TSartliListeleBL(Expression<Func<Proje, bool>> filter);
        List<Proje> ProjeLookUpGetirOgrenciBL(int vrb_id);
        List<Proje> ProjeLookUpGetirOgretimElemaniBL(int vrb_id);
    }
}
