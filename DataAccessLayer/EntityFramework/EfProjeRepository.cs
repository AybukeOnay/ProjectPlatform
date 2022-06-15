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
    public class EfProjeRepository : GenericRepository<Proje>, IProjeDal
    {
        public List<Proje> ProjeLookUpGetir()
        {
            using (var c = new Context())
            {
                return c.Projeler.Include(x => x.CalismaAlani).Include(x=>x.Ogrenci).Include(x=>x.OgretimElemani).ToList();
            }
        }      
    }
}
