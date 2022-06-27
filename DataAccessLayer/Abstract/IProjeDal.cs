using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProjeDal: IGenericDal<Proje>
    {
        List<Proje> ProjeLookUpGetir();
        List<Proje> ProjeLookUpGetirOgrenci(int vrb_id);
        List<Proje> ProjeLookUpGetirOgretimElemani(int vrb_id);
        
    }
}
