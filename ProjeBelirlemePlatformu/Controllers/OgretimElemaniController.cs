using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjeBelirlemePlatformu.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class OgretimElemaniController : Controller
    {
        OgretimElemaniManager om = new OgretimElemaniManager(new EfOgretimElemaniRepository());
        Context c = new Context();

        public PartialViewResult OgretimElemaniMenuPartial()
        {
            return PartialView();
        }
        public PartialViewResult OgretimElemaniAltMenuPartial()
        {
            return PartialView();
        }

        public IActionResult OgretimElemaniAnasayfa()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OgretimElemaniProfil()
        {         
            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = c.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();
            var ogretimElemaniDeger = om.TIDIleGetirBL(ogretimElemaniId);

            return View(ogretimElemaniDeger);
        }
        [HttpPost]
        public IActionResult OgretimElemaniProfil(OgretimElemani cls_ogretimElemani)
        {
            //OgretimElemaniKurallar kurallar = new OgretimElemaniKurallar();
            //ValidationResult sonuc = kurallar.Validate(cls_ogretimElemani);
            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = c.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();
            cls_ogretimElemani.OgretimElemaniID = ogretimElemaniId;
            om.TGuncelleBL(cls_ogretimElemani);
            return RedirectToAction("OgretimElemaniAnasayfa", "OgretimElemani");
            
            //if (sonuc.IsValid)
            //{
            //    cls_ogretimElemani.OgretimElemaniID = ogretimElemaniId; 
            //    om.TGuncelleBL(cls_ogretimElemani);
            //    return RedirectToAction("OgretimElemaniAnasayfa", "OgretimElemani");
            //}
            //else
            //{
            //    foreach (var item in sonuc.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return RedirectToAction("OgretimElemaniAnasayfa");
        }
        [HttpGet]
        public IActionResult OgretimElemaniOzgecmis()
        {
            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = c.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();
            var ogretimElemaniDeger = om.TIDIleGetirBL(ogretimElemaniId);
            return View(ogretimElemaniDeger);
        }
        [HttpPost]
        public IActionResult OgretimElemaniOzgecmis(OgretimElemani cls_ogretimElemani)
        {
            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = c.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();
            cls_ogretimElemani.OgretimElemaniID = ogretimElemaniId;
            om.TGuncelleBL(cls_ogretimElemani);
            return RedirectToAction("OgretimElemaniAnasayfa");
        }

        [HttpGet]
        public IActionResult OgretimElemaniResimEkleme()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgretimElemaniResimEkleme(ProfilResmiEkleme cls_profilResmiEkleme)
        {
            OgretimElemani o = new OgretimElemani();
            if (cls_profilResmiEkleme.OgretimElemaniResim != null)
            {
                var uzanti = Path.GetExtension(cls_profilResmiEkleme.OgretimElemaniResim.FileName);
                var yeniResimIsim = Guid.NewGuid() + uzanti;
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/OgretimElemaniResimDosyalari/", yeniResimIsim);
                var dosyaAkis = new FileStream(konum, FileMode.Create);
                cls_profilResmiEkleme.OgretimElemaniResim.CopyTo(dosyaAkis);
                o.OgretimElemaniResim = yeniResimIsim;
            }
            o.OgretimElemaniMail = cls_profilResmiEkleme.OgretimElemaniMail;
            o.OgretimElemaniAd = cls_profilResmiEkleme.OgretimElemaniAd;
            o.OgretimElemaniSoyad = cls_profilResmiEkleme.OgretimElemaniSoyad;
            o.OgretimElemaniSifre = cls_profilResmiEkleme.OgretimElemaniSifre;
            o.OgretimElemaniUnvan = cls_profilResmiEkleme.OgretimElemaniUnvan;
            o.OgretimElemaniOzgecmis = cls_profilResmiEkleme.OgretimElemaniOzgecmis;
            om.TEkleBL(o);
            return RedirectToAction("OgretimElemaniProfil");
        }
    }
}
