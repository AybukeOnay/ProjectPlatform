using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfOgretimElemaniCalismaAlaniRepository : GenericRepository<OgretimElemaniCalismaAlani>, IOgretimElemaniCalismaAlaniDal
    {        
        List<OgretimElemaniCalismaAlani> IOgretimElemaniCalismaAlaniDal.OgretimElemaninaGoreCalismaAlaniListeleme(int vrb_id)
        {
            using (var c = new Context())
            {
                return c.OgretimElemaniCalismaAlanlari.Include(x => x.CalismaAlani).Where(x => x.OgretimElemaniID == vrb_id).ToList();
            }
        }
    }
}
