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
    public class OgretimElemaniCalismaAlaniController : Controller
    {
        OgretimElemaniCalismaAlaniManager calismaAlani = new OgretimElemaniCalismaAlaniManager(new EfOgretimElemaniCalismaAlaniRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult OgretimElemaniIleCalismaAlaniListele()
        {
            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = c.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();           
            var calismaAlaniDeger = calismaAlani.OgretimElemaninaGoreListeleBL(ogretimElemaniId);

            return View(calismaAlaniDeger);
        }
        [HttpGet]
        public IActionResult OgretimElemaniCalismaAlaniEkle()
        {
            List<SelectListItem> degerler = (from x in c.CalismaAlanlari.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CalismaAlaniTanim,
                                                 Value = x.CalismaAlaniID.ToString()
                                             }).ToList();

            ViewBag.v1 = degerler;
            return View();
        }

        [HttpPost]
        public IActionResult OgretimElemaniCalismaAlaniEkle(OgretimElemaniCalismaAlani cls_ogretimElemaniCalismaAlani)
        {
            var ogretimElemaniMail = User.Identity.Name;
            var ogretimElemaniId = c.OgretimElemanlari.Where(x => x.OgretimElemaniMail == ogretimElemaniMail).Select(y => y.OgretimElemaniID).FirstOrDefault();
            cls_ogretimElemaniCalismaAlani.OgretimElemaniID = ogretimElemaniId;
            calismaAlani.TEkleBL(cls_ogretimElemaniCalismaAlani);
            return RedirectToAction("OgretimElemaniIleCalismaAlaniListele");
        }

        public IActionResult OgretimElemaniCalismaAlaniSil(int id)
        {

            var calismaAlaniDeger = calismaAlani.TIDIleGetirBL(id);
            calismaAlani.TSilBL(calismaAlaniDeger);
            return RedirectToAction("OgretimElemaniIleCalismaAlaniListele");
        }
    }
}
