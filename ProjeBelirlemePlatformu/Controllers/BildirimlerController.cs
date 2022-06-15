using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class BildirimlerController : Controller
    {
        BildirimManager bm = new BildirimManager(new EfBildirimRepository());

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BildirimleriListele()
        {
            var bildirimDeger = bm.TListeleBL();
            return View(bildirimDeger);
        }

    }
}
