using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class OgretimElemaniProjeController : Controller
    {
        ProjeManager projeManager = new ProjeManager(new EfProjeRepository());
        Context context = new Context();

        public IActionResult OgretimElemaniProjeListele()
        {

            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = context.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();
            var OgretimElemaniProjeDeger = projeManager.ProjeLookUpGetirOgretimElemaniBL(ogretimElemaniId);

            return View(OgretimElemaniProjeDeger);
      
        }
        
        public IActionResult OgretimElemaniTumProjeleriListele()
        {
            var values = projeManager.ProjeLookUpGetirBL();
            return View(values);
        }
    }
}
