using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class AdminOgrenciController : Controller
    {
        OgrenciManager om = new OgrenciManager(new EfOgrenciRepository());

        public IActionResult Index()
        {
            var ogrenciDeger = om.TListeleBL();
            return View(ogrenciDeger);
        }
    }
}
