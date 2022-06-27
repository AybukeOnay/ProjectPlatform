using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
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
        Context context = new Context();

        public IActionResult Index()
        {

            var ogrenciDeger = om.TListeleBL();            
            return View(ogrenciDeger);
        }

        [HttpGet]
        public IActionResult AdminOgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminOgrenciEkle(Ogrenci cls_ogrenci)
        {
            om.TEkleBL(cls_ogrenci);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AdminOgrenciGuncelle(int id)
        {
            var values = om.TIDIleGetirBL(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult AdminOgrenciGuncelle(Ogrenci cls_ogrenci)
        {
            //cls_ogrenci.OgrenciCinsiyet = "K";
            //cls_ogrenci.OgrenciDogumTarihi = DateTime.Now;
            //cls_ogrenci.OgrenciDurum = true;
            //cls_ogrenci.OgrenciResim = null;
            
            om.TGuncelleBL(cls_ogrenci);
            return RedirectToAction("Index");
        }
    }
}
