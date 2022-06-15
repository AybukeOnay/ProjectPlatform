using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class AdminOgretimElemaniController : Controller
    {
        OgretimElemaniManager ogretimElemani = new OgretimElemaniManager(new EfOgretimElemaniRepository());

        public IActionResult Index()
        {
            var ogretimElemaniDeger = ogretimElemani.TListeleBL();
            return View(ogretimElemaniDeger);
        }
    }
}
