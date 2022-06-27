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
    public class EfDosyaRepository : GenericRepository<Dosya>, IDosyaDal
    {
        public List<Dosya> DosyaLookUpGetirProje(int id)
        {
            using (var c = new Context())
            {
                return c.Dosyalar.Include(x => x.Proje).Where(x => x.ProjeID == id).ToList();
            }
        }
    }
}
