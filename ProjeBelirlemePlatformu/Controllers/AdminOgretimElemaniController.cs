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
    public class AdminOgretimElemaniController : Controller
    {
        OgretimElemaniManager ogretimElemani = new OgretimElemaniManager(new EfOgretimElemaniRepository());

        public IActionResult Index()
        {
            var ogretimElemaniDeger = ogretimElemani.TListeleBL();
            return View(ogretimElemaniDeger);
        }

        [HttpGet]
        public IActionResult AdminOgretimElemaniEkle()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult AdminOgretimElemaniEkle(OgretimElemani cls_ogretimElemani)
        {
            ogretimElemani.TEkleBL(cls_ogretimElemani);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AdminOgretimElemaniGuncelle(int id)
        {
            var values = ogretimElemani.TIDIleGetirBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult AdminOgretimElemaniGuncelle(OgretimElemani cls_ogretimElemani)
        {
            ogretimElemani.TGuncelleBL(cls_ogretimElemani);
            return RedirectToAction("Index");
        }
    }
}
