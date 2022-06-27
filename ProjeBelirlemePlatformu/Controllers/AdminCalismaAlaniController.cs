using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class AdminCalismaAlaniController : Controller
    {
        CalismaAlaniManager cm = new CalismaAlaniManager(new EfCalismaAlaniRepository());
       
        public IActionResult Index()
        {
            var values = cm.TListeleBL();
            return View(values);
        }

        [HttpGet]
        public IActionResult CalismaAlaniEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalismaAlaniEkle(CalismaAlani cls_calismaAlani)
        {
            cm.TEkleBL(cls_calismaAlani);
            return RedirectToAction("Index");
        }

        public IActionResult CalismaAlaniSil(int id)
        {
            var values=cm.TIDIleGetirBL(id);
            cm.TSilBL(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CalismaAlaniGuncelle(int id)
        {
            var calismaAlaniDeger = cm.TIDIleGetirBL(id);
            return View(calismaAlaniDeger);
        }

        [HttpPost]
        public IActionResult CalismaAlaniGuncelle(CalismaAlani cls_calismaAlani)
        {
            cm.TGuncelleBL(cls_calismaAlani);
            return RedirectToAction("Index");
        }
    }
}
