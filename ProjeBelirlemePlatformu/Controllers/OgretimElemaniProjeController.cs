using BusinessLayer.Concrete;
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

        public IActionResult OgretimElemaniProjeListele()
        {
            var OgretimElemaniProjeDeger = projeManager.ProjeLookUpGetirBL();
            return View(OgretimElemaniProjeDeger);
            
           
        }
    }
}
