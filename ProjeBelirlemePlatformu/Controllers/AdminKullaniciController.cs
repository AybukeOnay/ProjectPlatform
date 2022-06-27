using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class AdminKullaniciController : Controller
    {
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciRepository());
        Context context = new Context();

        public IActionResult KullaniciListele()
        {
            var kullaniciDeger = kullaniciManager.TListeleBL();
            return View(kullaniciDeger);
        }

        [HttpGet]
        public IActionResult KullaniciEkle()
        {
            List<SelectListItem> degerler = (from x in context.Kullanicilar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Mail,
                                                 Value = x.KullaniciID.ToString()
                                             }).ToList();

            ViewBag.v1 = degerler;
            var kullaniciDeger = kullaniciManager.TListeleBL();
            return View();
        }

        [HttpPost]
        public IActionResult KullaniciEkle(Kullanici cls_kullanici)
        {
            kullaniciManager.TEkleBL(cls_kullanici);
            return RedirectToAction("KullaniciListele");
        }

        public IActionResult KullaniciSil(int id)
        {
            var kullaniciDeger = kullaniciManager.TIDIleGetirBL(id);
            kullaniciManager.TSilBL(kullaniciDeger);
            return RedirectToAction("KullaniciListele");
        }
    }
}
