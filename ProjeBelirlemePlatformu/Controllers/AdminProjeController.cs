using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class AdminProjeController : Controller
    {
        ProjeManager pm = new ProjeManager(new EfProjeRepository());

        public IActionResult Index()
        {
            var projeDeger = pm.ProjeLookUpGetirBL();           
            return View(projeDeger);            
        }

        [HttpGet]
        public IActionResult AdminProjeGoruntule(int id)
        {            
            var values = pm.TIDIleGetirBL(id);
            return View(values);
        }
    }
}
