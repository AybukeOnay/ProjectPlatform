using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOgretimElemaniCalismaAlaniService:IGenericService<OgretimElemaniCalismaAlani>
    {                 
        List<OgretimElemaniCalismaAlani> OgretimElemaninaGoreListeleBL(int vrb_id);
    }
}
