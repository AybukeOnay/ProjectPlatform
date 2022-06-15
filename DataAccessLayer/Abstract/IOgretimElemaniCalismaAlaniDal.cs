using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IOgretimElemaniCalismaAlaniDal: IGenericDal<OgretimElemaniCalismaAlani>
    {
        List<OgretimElemaniCalismaAlani> OgretimElemaninaGoreCalismaAlaniListeleme(int vrb_id);
    }
}
