using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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

        public PartialViewResult OgrenciMenuPartial()
        {
            return PartialView();
        }

        public PartialViewResult OgrenciAltMenuPartial()
        {
            return PartialView();
        }

        [HttpGet]        
        public IActionResult OgrenciProfilListele()
        {
            var ogrenciProfilDeger = ogrenciManager.TIDIleGetirBL(1);
            return View(ogrenciProfilDeger);
        }

        [HttpPost]
        public IActionResult OgrenciProfilListele(Ogrenci cls_ogrenci)
        {
            OgrenciProfilKurallar ogrenciProfilKurallar = new OgrenciProfilKurallar();
            ValidationResult sonuc = ogrenciProfilKurallar.Validate(cls_ogrenci);
            if (sonuc.IsValid)
            {
                cls_ogrenci.OgrenciID = 1;
                ogrenciManager.TGuncelleBL(cls_ogrenci);
                return RedirectToAction("OgrenciProfilListele", "Ogrenci");
            }
            else
            {
                foreach (var item in sonuc.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }            
            return View();
        }

        public IActionResult OgrenciHesapAyarlari()
        {
            var ogrenciHesapDeger = ogrenciManager.TIDIleGetirBL(1);
            return View(ogrenciHesapDeger);            
        }
    }
}
