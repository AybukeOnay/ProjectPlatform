using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class OgrenciController : Controller
    {
        OgrenciManager ogrenciManager = new OgrenciManager(new EfOgrenciRepository());
        Context context = new Context();


        public PartialViewResult OgrenciMenuPartial()
        {
            return PartialView();
        }

        public PartialViewResult OgrenciAltMenuPartial()
        {
            return PartialView();
        }

        public IActionResult Anasayfa()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OgrenciProfilListele()
        {

            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            var ogrenciProfilDeger = ogrenciManager.TIDIleGetirBL(ogrenciId);

            return View(ogrenciProfilDeger);
        }

        [HttpPost]
        public IActionResult OgrenciProfilListele(Ogrenci cls_ogrenci)
        {
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            cls_ogrenci.OgrenciID = ogrenciId;
            ogrenciManager.TGuncelleBL(cls_ogrenci);
            return RedirectToAction("Anasayfa", "Ogrenci");

            //OgrenciProfilKurallar ogrenciProfilKurallar = new OgrenciProfilKurallar();
            //ValidationResult sonuc = ogrenciProfilKurallar.Validate(cls_ogrenci);
            ////if (sonuc.IsValid)
            //{
            //    var ogrenciMail = User.Identity.Name;
            //    var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            //    cls_ogrenci.OgrenciID = ogrenciId;
            //    ogrenciManager.TGuncelleBL(cls_ogrenci);
            //    return RedirectToAction("OgrenciProfilListele", "Ogrenci");
            //}
            //else
            //{
            //    foreach (var item in sonuc.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
           
        }

        [HttpGet]
        public IActionResult OgrenciHesapAyarlari()
        {
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            var ogrenciHesapDeger = ogrenciManager.TIDIleGetirBL(ogrenciId);

            return View(ogrenciHesapDeger);
        }

        [HttpPost]
        public IActionResult OgrenciHesapAyarlari(Ogrenci cls_ogrenci)
        {
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            cls_ogrenci.OgrenciID = ogrenciId;
            ogrenciManager.TGuncelleBL(cls_ogrenci);

            return RedirectToAction("Anasayfa");
        }

       
    }
}
